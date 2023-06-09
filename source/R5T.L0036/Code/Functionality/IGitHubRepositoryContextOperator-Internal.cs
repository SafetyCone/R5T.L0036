using System;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0184;

using R5T.L0036.T000;


namespace R5T.L0036.Internal
{
    [FunctionalityMarker]
    public partial interface IGitHubRepositoryContextOperator : IFunctionalityMarker
    {
        public async Task Check_RepositoryExists(
            T000.N001.IGitHubRepositoryContext context,
            Action<T000.N001.IGitHubRepositoryContext, bool> outputConsumer)
        {
            var exists = await Instances.GitHubOperator.RepositoryExists(
                context.OwnerName.Value,
                context.RepositoryName.Value);

            outputConsumer(context, exists);
        }

        public async Task Clone_Repository(
            T000.N001.IGitHubRepositoryContext context,
            Action<T000.N001.IGitHubRepositoryContext, string> outputConsumer)
        {
            var localDirectoryPath = await Instances.GitOperator.Clone_NonIdempotent(
                context.RepositoryName.Value,
                context.OwnerName.Value);

            Instances.ActionOperator.Run(
                outputConsumer,
                context,
                localDirectoryPath);
        }

        public async Task Clone_Repository(
            T000.N001.IGitHubRepositoryContext context,
            Action<string> outputConsumer)
        {
            var localDirectoryPath = await Instances.GitOperator.Clone_NonIdempotent(
                context.RepositoryName.Value,
                context.OwnerName.Value);

            outputConsumer(localDirectoryPath);
        }

        public async Task Create_RemoteRepository(
            T000.N001.IGitHubRepositoryContext context,
            IRepositoryDescription description)
        {
            var repositorySpecification = new F0041.GitHubRepositorySpecification
            {
                Description = description.Value,
                InitializeWithReadMe = true,
                License = F0041.GitHubRepositoryLicense.MIT,
                Name = context.RepositoryName.Value,
                Organization = context.OwnerName.Value,
                Visibility = F0041.GitHubRepositoryVisibility.Public,
            };

            await Instances.GitHubOperator.CreateRepository(
                repositorySpecification);
        }

        public async Task Create_RemoteRepository(
            T000.N001.IGitHubRepositoryContext context,
            IRepositoryDescription description,
            bool isPrivate)
        {
            var visibility = Instances.GitHubRepositoryVisibilityOperator.Get_GitHubRepositoryVisibility(isPrivate);

            var repositorySpecification = new F0041.GitHubRepositorySpecification
            {
                Description = description.Value,
                InitializeWithReadMe = true,
                License = F0041.GitHubRepositoryLicense.MIT,
                Name = context.RepositoryName.Value,
                Organization = context.OwnerName.Value,
                Visibility = visibility
            };

            await Instances.GitHubOperator.CreateRepository(
                repositorySpecification);
        }

        /// <inheritdoc cref="F0041.IGitHubOperator.DeleteRepository(string, string)"/>
        public async Task Delete_Repository(T000.N001.IGitHubRepositoryContext context)
        {
            await Instances.GitHubOperator.DeleteRepository(
                context.OwnerName.Value,
                context.RepositoryName.Value);
        }

        public async Task Verify_RepositoryDoesNotExist(IGitHubRepositoryContext context)
        {
            var exists = await Instances.GitHubOperator.RepositoryExists(
                context.GitHubRepositoryUrl.Value);

            if(exists)
            {
                throw new Exception($"{context.GitHubRepositoryUrl}: Repository already exists.");
            }
        }

        public async Task Verify_RepositoryDoesNotExist(T000.N001.IGitHubRepositoryContext context)
        {
            var exists = await Instances.GitHubOperator.RepositoryExists(
                context.OwnerName.Value,
                context.RepositoryName.Value);

            if (exists)
            {
                throw new Exception($"{context.OwnerName.Value}/{context.RepositoryName.Value}: GitHub repository already exists.");
            }
        }
    }
}

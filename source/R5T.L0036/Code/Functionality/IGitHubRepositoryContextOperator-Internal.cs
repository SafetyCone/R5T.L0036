using System;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0184;


namespace R5T.L0036.Internal
{
    [FunctionalityMarker]
    public partial interface IGitHubRepositoryContextOperator : IFunctionalityMarker
    {
        public async Task Check_RepositoryExists(
            N001.IGitHubRepositoryContext context,
            Action<N001.IGitHubRepositoryContext, bool> outputConsumer)
        {
            var exists = await Instances.GitHubOperator.RepositoryExists(
                context.OwnerName.Value,
                context.RepositoryName.Value);

            outputConsumer(context, exists);
        }

        public async Task Clone_Repository_ProvideContext(
            N001.IGitHubRepositoryContext context,
            Action<N001.IGitHubRepositoryContext, string> outputConsumer)
        {
            var localDirectoryPath = await Instances.GitOperator.Clone_NonIdempotent(
                context.RepositoryName.Value,
                context.OwnerName.Value);

            outputConsumer(context, localDirectoryPath);
        }

        public async Task Clone_Repository(
            N001.IGitHubRepositoryContext context,
            Action<string> outputConsumer)
        {
            var localDirectoryPath = await Instances.GitOperator.Clone_NonIdempotent(
                context.RepositoryName.Value,
                context.OwnerName.Value);

            outputConsumer(localDirectoryPath);
        }

        public async Task Create_RemoteRepository(
            N001.IGitHubRepositoryContext context,
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

            var exists = await Instances.GitHubOperator.CreateRepository(
                repositorySpecification);
        }

        /// <inheritdoc cref="F0041.IGitHubOperator.DeleteRepository(string, string)"/>
        public async Task Delete_Repository(N001.IGitHubRepositoryContext context)
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

        public async Task Verify_RepositoryDoesNotExist(N001.IGitHubRepositoryContext context)
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

using System;
using System.Threading.Tasks;

using R5T.T0131;
using R5T.T0184;

using R5T.L0036.T000;


namespace R5T.L0036
{
    [ValuesMarker]
    public partial interface IGitHubRepositoryContextOperations : IValuesMarker
    {
        public Func<T000.N001.IGitHubRepositoryContext, Task> Check_RepositoryExists(
            Action<T000.N001.IGitHubRepositoryContext, bool> outputConsumer)
        {
            return context => Instances.GitHubRepositoryContextOperator_Internal.Check_RepositoryExists(
                context,
                outputConsumer);
        }
        
        public Func<T000.N001.IGitHubRepositoryContext, Task> Clone_Repository(
            Action<T000.N001.IGitHubRepositoryContext, string> outputConsumer = default)
        {
            return context => Instances.GitHubRepositoryContextOperator_Internal.Clone_Repository(
                context,
                outputConsumer);
        }

        public Func<T000.N001.IGitHubRepositoryContext, Task> Clone_Repository(
            Action<string> outputConsumer = default)
        {
            return context => Instances.GitHubRepositoryContextOperator_Internal.Clone_Repository(
                context,
                outputConsumer);
        }

        public Func<T000.N001.IGitHubRepositoryContext, Task> Create_RemoteRepository(
            IRepositoryDescription repositoryDescription)
        {
            return context => Instances.GitHubRepositoryContextOperator_Internal.Create_RemoteRepository(
                    context,
                    repositoryDescription);
        }

        /// <inheritdoc cref="Internal.IGitHubRepositoryContextOperator.Delete_Repository(T000.N001.IGitHubRepositoryContext)"/>
        public Func<T000.N001.IGitHubRepositoryContext, Task> Delete_Repository =>
            context => Instances.GitHubRepositoryContextOperator_Internal.Delete_Repository(context);

        public Task Verify_RepositoryDoesNotExist(IGitHubRepositoryContext context)
        {
            return Instances.GitHubRepositoryContextOperator_Internal.Verify_RepositoryDoesNotExist(context);
        }

        public Task Verify_RepositoryDoesNotExist(T000.N001.IGitHubRepositoryContext context)
        {
            return Instances.GitHubRepositoryContextOperator_Internal.Verify_RepositoryDoesNotExist(context);
        }
    }
}

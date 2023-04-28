using System;
using System.Threading.Tasks;

using R5T.T0131;
using R5T.T0184;


namespace R5T.L0036
{
    [ValuesMarker]
    public partial interface IGitHubRepositoryContextOperations : IValuesMarker
    {
        public Func<Action<N001.IGitHubRepositoryContext, bool>, Func<N001.IGitHubRepositoryContext, Task>> Check_RepositoryExists =>
            outputConsumer =>
                context => Instances.GitHubRepositoryContextOperator_Internal.Check_RepositoryExists(
                    context,
                    outputConsumer);

        public Func<Action<N001.IGitHubRepositoryContext, string>, Func<N001.IGitHubRepositoryContext, Task>> Clone_Repository_ProvideContext =>
            outputConsumer =>
                context => Instances.GitHubRepositoryContextOperator_Internal.Clone_Repository_ProvideContext(
                    context,
                    outputConsumer);

        public Func<Action<string>, Func<N001.IGitHubRepositoryContext, Task>> Clone_Repository =>
            outputConsumer =>
                context => Instances.GitHubRepositoryContextOperator_Internal.Clone_Repository(
                    context,
                    outputConsumer);

        public Func<IRepositoryDescription, Func<N001.IGitHubRepositoryContext, Task>> Create_RemoteRepository =>
            description =>
                context => Instances.GitHubRepositoryContextOperator_Internal.Create_RemoteRepository(
                    context,
                    description);

        /// <inheritdoc cref="Internal.IGitHubRepositoryContextOperator.Delete_Repository(N001.IGitHubRepositoryContext)"/>
        public Func<N001.IGitHubRepositoryContext, Task> Delete_Repository =>
            context => Instances.GitHubRepositoryContextOperator_Internal.Delete_Repository(context);

        public Func<IGitHubRepositoryContext, Task> Verify_RepositoryDoesNotExist =>
            context => Instances.GitHubRepositoryContextOperator_Internal.Verify_RepositoryDoesNotExist(context);

        public Func<N001.IGitHubRepositoryContext, Task> Verify_RepositoryDoesNotExist_N001 =>
            context => Instances.GitHubRepositoryContextOperator_Internal.Verify_RepositoryDoesNotExist(context);
    }
}

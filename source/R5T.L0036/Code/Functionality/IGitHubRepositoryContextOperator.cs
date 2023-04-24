using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.L0036
{
    [FunctionalityMarker]
    public partial interface IGitHubRepositoryContextOperator : IFunctionalityMarker
    {
        public void In_GitHubRepositoryContext(
            IGitHubRepositoryUrl gitHubRepositoryUrl,
            IEnumerable<Action<IGitHubRepositoryContext>> operations = default)
        {
            Instances.ContextOperator.In_Context(
                Instances.GitHubRepositoryContextConstructors.Default(gitHubRepositoryUrl),
                operations,
                Instances.GitHubRepositoryContextDestructors.Default);
        }

        public Task In_GitHubRepositoryContext(
            IGitHubRepositoryUrl gitHubRepositoryUrl,
            params Func<IGitHubRepositoryContext, Task>[] operations)
        {
            return Instances.ContextOperator.In_Context(
                Instances.GitHubRepositoryContextConstructors.Default(gitHubRepositoryUrl),
                operations,
                Instances.GitHubRepositoryContextDestructors.Default);
        }
    }
}

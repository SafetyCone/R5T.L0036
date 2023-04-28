using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0159;
using R5T.T0186;


namespace R5T.L0036
{
    [FunctionalityMarker]
    public partial interface IGitHubRepositoryContextOperator : IFunctionalityMarker
    {
        public void In_GitHubRepositoryContext(
            IGitHubRepositoryUrl gitHubRepositoryUrl,
            ITextOutput textOutput,
            IEnumerable<Action<IGitHubRepositoryContext>> operations = default)
        {
            Instances.ContextOperator.In_Context(
                Instances.GitHubRepositoryContextConstructors.Default(
                    gitHubRepositoryUrl,
                    textOutput),
                operations,
                Instances.GitHubRepositoryContextDestructors.Default);
        }

        public Task In_GitHubRepositoryContext(
            IGitHubRepositoryUrl gitHubRepositoryUrl,
            ITextOutput textOutput,
            params Func<IGitHubRepositoryContext, Task>[] operations)
        {
            return Instances.ContextOperator.In_Context(
                Instances.GitHubRepositoryContextConstructors.Default(
                    gitHubRepositoryUrl,
                    textOutput),
                operations,
                Instances.GitHubRepositoryContextDestructors.Default);
        }

        public Task In_GitHubRepositoryContext(
            IGitHubRepositoryName repositoryName,
            IGitHubRepositoryOwnerName ownerName,
            ITextOutput textOutput,
            params Func<N001.IGitHubRepositoryContext, Task>[] operations)
        {
            return Instances.ContextOperator.In_Context(
                Instances.GitHubRepositoryContextConstructors.Default_N001(
                    repositoryName,
                    ownerName,
                    textOutput),
                operations,
                Instances.GitHubRepositoryContextDestructors.Default_N001);
        }
    }
}

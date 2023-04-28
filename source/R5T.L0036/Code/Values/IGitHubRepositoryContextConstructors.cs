using System;

using R5T.T0131;
using R5T.T0159;
using R5T.T0186;


namespace R5T.L0036
{
    [ValuesMarker]
    public partial interface IGitHubRepositoryContextConstructors : IValuesMarker
    {
        public Func<IGitHubRepositoryUrl, ITextOutput, Func<IGitHubRepositoryContext>> Default =>
            (gitHubRepositoryUrl, textOutput) =>
                () => GitHubRepositoryContextConstructor.Instance.Default(
                    gitHubRepositoryUrl,
                    textOutput);

        public Func<IGitHubRepositoryName, IGitHubRepositoryOwnerName, ITextOutput, Func<N001.IGitHubRepositoryContext>> Default_N001 =>
            (repositoryName, ownerName, textOutput) =>
                () => GitHubRepositoryContextConstructor.Instance.Default(
                    repositoryName,
                    ownerName,
                    textOutput);
    }
}

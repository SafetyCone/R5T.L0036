using System;

using R5T.T0131;


namespace R5T.L0036
{
    [ValuesMarker]
    public partial interface IGitHubRepositoryContextConstructors : IValuesMarker
    {
        public Func<IGitHubRepositoryUrl, Func<IGitHubRepositoryContext>> Default =>
            gitHubRepositoryUrl =>
                () => GitHubRepositoryContextConstructor.Instance.Default(gitHubRepositoryUrl);
    }
}

using System;

using R5T.T0132;


namespace R5T.L0036
{
    [FunctionalityMarker]
    public partial interface IGitHubRepositoryContextConstructor : IFunctionalityMarker
    {
        public IGitHubRepositoryContext Default(IGitHubRepositoryUrl gitHubRepositoryUrl)
        {
            var output = new GitHubRepositoryContext
            {
                GitHubRepositoryUrl = gitHubRepositoryUrl,
            };

            return output;
        }
    }
}

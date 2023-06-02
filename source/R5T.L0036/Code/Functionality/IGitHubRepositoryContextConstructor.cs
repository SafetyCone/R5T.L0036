using System;

using R5T.T0132;
using R5T.T0159;
using R5T.T0186;
using R5T.T0198;

using R5T.L0036.T000;


namespace R5T.L0036
{
    [FunctionalityMarker]
    public partial interface IGitHubRepositoryContextConstructor : IFunctionalityMarker
    {
        public IGitHubRepositoryContext Default(
            IGitHubRepositoryUrl gitHubRepositoryUrl,
            ITextOutput textOutput)
        {
            var output = new GitHubRepositoryContext
            {
                GitHubRepositoryUrl = gitHubRepositoryUrl,
                TextOutput = textOutput,
            };

            return output;
        }

        public T000.N001.IGitHubRepositoryContext Default(
            IGitHubRepositoryName repositoryName,
            IGitHubRepositoryOwnerName ownerName,
            ITextOutput textOutput)
        {
            var output = new T000.N001.GitHubRepositoryContext
            {
                RepositoryName = repositoryName,
                OwnerName = ownerName,
                TextOutput = textOutput,
            };

            return output;
        }
    }
}

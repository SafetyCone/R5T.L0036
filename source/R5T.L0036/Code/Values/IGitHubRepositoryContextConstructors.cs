using System;

using R5T.T0131;
using R5T.T0159;
using R5T.T0186;
using R5T.T0198;

using R5T.L0036.T000;


namespace R5T.L0036
{
    [ValuesMarker]
    public partial interface IGitHubRepositoryContextConstructors : IValuesMarker
    {
        public Func<IGitHubRepositoryContext> Default(
            IGitHubRepositoryUrl gitHubRepositoryUrl,
            ITextOutput textOutput)
        {
            return () => GitHubRepositoryContextConstructor.Instance.Default(
                gitHubRepositoryUrl,
                textOutput);
        }
         
        public Func<T000.N001.IGitHubRepositoryContext> Default(
            IGitHubRepositoryName repositoryName,
            IGitHubRepositoryOwnerName ownerName,
            ITextOutput textOutput)
        {
            return () => GitHubRepositoryContextConstructor.Instance.Default(
                repositoryName,
                ownerName,
                textOutput);
        }
    }     
}

using System;

using R5T.T0132;


namespace R5T.L0036
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public IGitHubRepositoryUrl ToGitHubRepositoryUrl(string value)
        {
            var output = new GitHubRepositoryUrl(value);
            return output;
        }
    }
}

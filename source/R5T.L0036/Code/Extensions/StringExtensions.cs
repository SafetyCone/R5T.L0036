using System;


namespace R5T.L0036
{
    public static class StringExtensions
    {
        public static IGitHubRepositoryUrl ToGitHubRepositoryUrl(this string value)
        {
            return Instances.StringOperator.ToGitHubRepositoryUrl(value);
        }
    }
}

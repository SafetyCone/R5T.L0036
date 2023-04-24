using System;


namespace R5T.L0036
{
    public class GitHubRepositoryContextOperations : IGitHubRepositoryContextOperations
    {
        #region Infrastructure

        public static IGitHubRepositoryContextOperations Instance { get; } = new GitHubRepositoryContextOperations();


        private GitHubRepositoryContextOperations()
        {
        }

        #endregion
    }
}

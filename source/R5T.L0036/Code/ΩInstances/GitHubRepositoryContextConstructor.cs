using System;


namespace R5T.L0036
{
    public class GitHubRepositoryContextConstructor : IGitHubRepositoryContextConstructor
    {
        #region Infrastructure

        public static IGitHubRepositoryContextConstructor Instance { get; } = new GitHubRepositoryContextConstructor();


        private GitHubRepositoryContextConstructor()
        {
        }

        #endregion
    }
}

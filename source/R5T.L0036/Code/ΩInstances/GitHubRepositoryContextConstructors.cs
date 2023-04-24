using System;


namespace R5T.L0036
{
    public class GitHubRepositoryContextConstructors : IGitHubRepositoryContextConstructors
    {
        #region Infrastructure

        public static IGitHubRepositoryContextConstructors Instance { get; } = new GitHubRepositoryContextConstructors();


        private GitHubRepositoryContextConstructors()
        {
        }

        #endregion
    }
}

using System;


namespace R5T.L0036
{
    public class GitHubRepositoryContextDestructors : IGitHubRepositoryContextDestructors
    {
        #region Infrastructure

        public static IGitHubRepositoryContextDestructors Instance { get; } = new GitHubRepositoryContextDestructors();


        private GitHubRepositoryContextDestructors()
        {
        }

        #endregion
    }
}

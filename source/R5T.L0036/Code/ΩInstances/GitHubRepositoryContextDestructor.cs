using System;


namespace R5T.L0036
{
    public class GitHubRepositoryContextDestructor : IGitHubRepositoryContextDestructor
    {
        #region Infrastructure

        public static IGitHubRepositoryContextDestructor Instance { get; } = new GitHubRepositoryContextDestructor();


        private GitHubRepositoryContextDestructor()
        {
        }

        #endregion
    }
}

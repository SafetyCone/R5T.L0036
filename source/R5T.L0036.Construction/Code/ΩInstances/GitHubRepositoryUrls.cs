using System;


namespace R5T.L0036.Construction
{
    public class GitHubRepositoryUrls : IGitHubRepositoryUrls
    {
        #region Infrastructure

        public static IGitHubRepositoryUrls Instance { get; } = new GitHubRepositoryUrls();


        private GitHubRepositoryUrls()
        {
        }

        #endregion
    }
}

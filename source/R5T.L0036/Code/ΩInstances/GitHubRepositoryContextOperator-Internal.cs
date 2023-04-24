using System;


namespace R5T.L0036.Internal
{
    public class GitHubRepositoryContextOperator : IGitHubRepositoryContextOperator
    {
        #region Infrastructure

        public static IGitHubRepositoryContextOperator Instance { get; } = new GitHubRepositoryContextOperator();


        private GitHubRepositoryContextOperator()
        {
        }

        #endregion
    }
}

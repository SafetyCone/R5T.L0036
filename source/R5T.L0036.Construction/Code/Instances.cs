using System;


namespace R5T.L0036.Construction
{
    public static class Instances
    {
        public static IGitHubRepositoryContextOperator GitHubRepositoryContextOperator => L0036.GitHubRepositoryContextOperator.Instance;
        public static IGitHubRepositoryContextOperations GitHubRepositoryContextOperations => L0036.GitHubRepositoryContextOperations.Instance;
        public static IGitHubRepositoryUrls GitHubRepositoryUrls => Construction.GitHubRepositoryUrls.Instance;
    }
}
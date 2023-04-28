using System;


namespace R5T.L0036
{
    public static class Instances
    {
        public static F0000.IActionOperations ActionOperations => F0000.ActionOperations.Instance;
        public static L0031.IContextOperator ContextOperator => L0031.ContextOperator.Instance;
        public static F0041.IGitHubOperator GitHubOperator => F0041.GitHubOperator.Instance;
        public static IGitHubRepositoryContextConstructors GitHubRepositoryContextConstructors => L0036.GitHubRepositoryContextConstructors.Instance;
        public static IGitHubRepositoryContextDestructors GitHubRepositoryContextDestructors => L0036.GitHubRepositoryContextDestructors.Instance;
        public static IGitHubRepositoryContextOperator GitHubRepositoryContextOperator => L0036.GitHubRepositoryContextOperator.Instance;
        public static Internal.IGitHubRepositoryContextOperator GitHubRepositoryContextOperator_Internal => Internal.GitHubRepositoryContextOperator.Instance;
        public static F0041.IGitOperator GitOperator => F0041.GitOperator.Instance;
        public static IStringOperator StringOperator => L0036.StringOperator.Instance;
    }
}
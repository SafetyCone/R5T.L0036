using System;

using R5T.T0137;
using R5T.T0159;
using R5T.T0186;


namespace R5T.L0036.T000.N001
{
    /// <summary>
    /// Repository and owner name based GitHub repository context.
    /// </summary>
    [ContextImplementationMarker]
    public class GitHubRepositoryContext : IContextImplementationMarker,
        IGitHubRepositoryContext
    {
        public IGitHubRepositoryName RepositoryName { get; set; }
        public IGitHubRepositoryOwnerName OwnerName { get; set; }

        public ITextOutput TextOutput { get; set; }
    }
}

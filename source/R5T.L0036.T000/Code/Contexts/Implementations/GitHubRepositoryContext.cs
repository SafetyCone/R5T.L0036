using System;

using R5T.T0137;
using R5T.T0159;
using R5T.T0198;


namespace R5T.L0036.T000
{
    /// <summary>
    /// URL-based GitHub repository context.
    /// </summary>
    [ContextImplementationMarker]
    public class GitHubRepositoryContext : IContextImplementationMarker,
        IGitHubRepositoryContext
    {
        public IGitHubRepositoryUrl GitHubRepositoryUrl { get; set; }

        public ITextOutput TextOutput { get; set; }

        IRemoteRepositoryUrl IRemoteRepositoryContext.RemoteRepositoryUrl => this.GitHubRepositoryUrl;
    }
}

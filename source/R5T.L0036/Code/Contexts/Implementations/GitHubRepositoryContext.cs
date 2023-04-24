using System;

using R5T.T0137;


namespace R5T.L0036
{
    [ContextImplementationMarker]
    public class GitHubRepositoryContext : IContextImplementationMarker,
        IGitHubRepositoryContext
    {
        IRemoteRepositoryUrl IRemoteRepositoryContext.RemoteRepositoryUrl => this.GitHubRepositoryUrl;

        public IGitHubRepositoryUrl GitHubRepositoryUrl { get; set; }
    }
}

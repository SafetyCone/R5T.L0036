using System;

using R5T.T0137;


namespace R5T.L0036
{
    /// <summary>
    /// URL-based.
    /// </summary>
    [ContextDefinitionMarker]
    public interface IGitHubRepositoryContext : IContextDefinitionMarker,
        IRemoteRepositoryContext
    {
        public IGitHubRepositoryUrl GitHubRepositoryUrl { get; }
    }
}

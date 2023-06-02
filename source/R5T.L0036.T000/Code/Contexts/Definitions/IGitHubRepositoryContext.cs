using System;

using R5T.T0137;
using R5T.T0198;


namespace R5T.L0036.T000
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

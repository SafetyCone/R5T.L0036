using System;

using R5T.F0124;
using R5T.T0178;


namespace R5T.L0036
{
    /// <summary>
    /// Represents a URL for a GitHub repository.
    /// </summary>
    [StrongTypeMarker]
    public interface IGitHubRepositoryUrl : IStrongTypeMarker,
        IRemoteRepositoryUrl
    {
    }
}

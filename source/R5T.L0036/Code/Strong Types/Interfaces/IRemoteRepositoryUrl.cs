using System;

using R5T.F0124;
using R5T.T0178;


namespace R5T.L0036
{
    /// <summary>
    /// Represents a URL for a remote repository.
    /// </summary>
    [StrongTypeMarker]
    public interface IRemoteRepositoryUrl : IStrongTypeMarker,
        IUrl
    {
    }
}

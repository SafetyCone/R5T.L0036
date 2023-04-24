using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0036
{
    /// <inheritdoc cref="IRemoteRepositoryUrl"/>
    [StrongTypeImplementationMarker]
    public class RemoteRepositoryUrl : TypedBase<string>, IStrongTypeMarker,
        IRemoteRepositoryUrl
    {
        public RemoteRepositoryUrl(string value)
            : base(value)
        {
        }
    }
}

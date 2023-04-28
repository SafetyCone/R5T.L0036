using System;

using R5T.T0137;
using R5T.T0159;


namespace R5T.L0036
{
    [ContextImplementationMarker]
    public class RemoteRepositoryContext : IContextImplementationMarker,
        IRemoteRepositoryContext
    {
        public IRemoteRepositoryUrl RemoteRepositoryUrl { get; }
        public ITextOutput TextOutput { get; }
    }
}

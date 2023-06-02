using System;

using R5T.T0137;
using R5T.T0159;
using R5T.T0198;


namespace R5T.L0036.T000
{
    [ContextImplementationMarker]
    public class RemoteRepositoryContext : IContextImplementationMarker,
        IRemoteRepositoryContext
    {
        public IRemoteRepositoryUrl RemoteRepositoryUrl { get; }
        public ITextOutput TextOutput { get; }
    }
}

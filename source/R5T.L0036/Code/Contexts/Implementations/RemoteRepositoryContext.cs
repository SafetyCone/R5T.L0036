using System;

using R5T.T0137;


namespace R5T.L0036
{
    [ContextImplementationMarker]
    public class ProjectFileContext : IContextImplementationMarker,
        IRemoteRepositoryContext
    {
        public IRemoteRepositoryUrl RemoteRepositoryUrl { get; set; }
    }
}

using System;

using R5T.T0137;


namespace R5T.L0036
{
    [ContextDefinitionMarker]
    public interface IRemoteRepositoryContext : IContextDefinitionMarker
    {
        public IRemoteRepositoryUrl RemoteRepositoryUrl { get; }
    }
}

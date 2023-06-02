using System;

using R5T.T0137;
using R5T.T0159;
using R5T.T0198;


namespace R5T.L0036.T000
{
    [ContextDefinitionMarker]
    public interface IRemoteRepositoryContext : IContextDefinitionMarker
    {
        public IRemoteRepositoryUrl RemoteRepositoryUrl { get; }

        public ITextOutput TextOutput { get; }
    }
}

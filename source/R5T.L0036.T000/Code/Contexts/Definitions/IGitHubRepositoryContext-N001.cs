using System;

using R5T.T0137;
using R5T.T0159;
using R5T.T0186;


namespace R5T.L0036.T000.N001
{
    /// <summary>
    /// Repository name and owner name based.
    /// </summary>
    [ContextDefinitionMarker]
    public interface IGitHubRepositoryContext : IContextDefinitionMarker
    {
        public IGitHubRepositoryName RepositoryName { get; }
        public IGitHubRepositoryOwnerName OwnerName { get; }

        public ITextOutput TextOutput { get; }
    }
}

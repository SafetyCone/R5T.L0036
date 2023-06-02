using System;

using R5T.T0131;

using R5T.L0036.T000;


namespace R5T.L0036
{
    [ValuesMarker]
    public partial interface IGitHubRepositoryContextDestructors : IValuesMarker
    {
        public void Default(IGitHubRepositoryContext gitHubRepositoryContext) => Instances.ActionOperations.DoNothing_Synchronous(gitHubRepositoryContext);

        public void Default(T000.N001.IGitHubRepositoryContext gitHubRepositoryContext) => Instances.ActionOperations.DoNothing_Synchronous(gitHubRepositoryContext);
    }
}

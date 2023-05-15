using System;

using R5T.T0131;


namespace R5T.L0036
{
    [ValuesMarker]
    public partial interface IGitHubRepositoryContextDestructors : IValuesMarker
    {
        public Action<IGitHubRepositoryContext> Default => 
            context => Instances.ActionOperations.DoNothing_Synchronous(context);

        public Action<N001.IGitHubRepositoryContext> Default_N001 =>
            context => Instances.ActionOperations.DoNothing_Synchronous(context);
    }
}

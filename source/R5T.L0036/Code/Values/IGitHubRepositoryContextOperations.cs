using System;
using System.Threading.Tasks;

using R5T.T0131;


namespace R5T.L0036
{
    [ValuesMarker]
    public partial interface IGitHubRepositoryContextOperations : IValuesMarker
    {
        public Func<IGitHubRepositoryContext, Task> Verify_RepositoryDoesNotExist =>
            context => Instances.GitHubRepositoryContextOperator_Internal.Verify_RepositoryDoesNotExist(context);
    }
}

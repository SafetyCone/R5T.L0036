using System;
using System.Threading.Tasks;

using R5T.T0141;


namespace R5T.L0036.Construction
{
    [ExperimentsMarker]
    public partial interface IExperiments : IExperimentsMarker
    {
        public async Task TestRepositoryExists()
        {
            /// Inputs.
            var gitHubRepositoryUrl =
                Instances.GitHubRepositoryUrls.Exists
                ;


            /// Run.
            await Instances.GitHubRepositoryContextOperator.In_GitHubRepositoryContext(
                gitHubRepositoryUrl,
                Instances.GitHubRepositoryContextOperations.Verify_RepositoryDoesNotExist);
        }
    }
}

using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.L0036.Internal
{
    [FunctionalityMarker]
    public partial interface IGitHubRepositoryContextOperator : IFunctionalityMarker
    {
        public async Task Verify_RepositoryDoesNotExist(
            IGitHubRepositoryContext context)
        {
            var exists = await Instances.GitHubOperator.RepositoryExists(
                context.GitHubRepositoryUrl.Value);

            if(exists)
            {
                throw new Exception($"{context.GitHubRepositoryUrl}: Repository already exists.");
            }
        }
    }
}

using System;

using R5T.T0131;


namespace R5T.L0036.Construction
{
    [ValuesMarker]
    public partial interface IGitHubRepositoryUrls : IValuesMarker
    {
        public IGitHubRepositoryUrl R5T_L0036 => "https://github.com/SafetyCone/R5T.L0036".ToGitHubRepositoryUrl();

        public IGitHubRepositoryUrl Exists => this.R5T_L0036;
        public IGitHubRepositoryUrl DoesNotExist => "https://github.com/SafetyCone/DoesNotExist".ToGitHubRepositoryUrl();
    }
}

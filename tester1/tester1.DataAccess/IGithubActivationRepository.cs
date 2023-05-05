namespace Tester1.Service
{
    using Tester1.DTO;
    using Tester1.Repository;

    public interface IGithubActivationRepository
    {
        Task<GithubActivationModel> GetGithubActivationModelAsync(int id);
        Task<int> InsertGithubActivationModelAsync(GithubActivationModel model);
        Task<int> UpdateGithubActivationModelAsync(GithubActivationModel model);
        Task<int> DeleteGithubActivationModelAsync(int id);
    }
}
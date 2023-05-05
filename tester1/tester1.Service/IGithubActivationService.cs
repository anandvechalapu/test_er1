using Tester1.DataAccess;
using Tester1.DTO;

namespace Tester1.Service
{
    public interface IGithubActivationService
    {
        Task<GithubActivationModel> GetGithubActivationModelAsync(int id);
        Task<int> InsertGithubActivationModelAsync(GithubActivationModel model);
        Task<int> UpdateGithubActivationModelAsync(GithubActivationModel model);
        Task<int> DeleteGithubActivationModelAsync(int id);
    }
}
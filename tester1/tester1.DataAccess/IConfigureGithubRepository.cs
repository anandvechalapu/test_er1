using Tester1.DTO;

namespace Tester1.Service
{
    public interface IConfigureGithubRepository
    {
        Task<List<ConfigureGithubModel>> GetAllAsync();
        Task<ConfigureGithubModel> GetByIdAsync(int id);
        Task<ConfigureGithubModel> CreateAsync(ConfigureGithubModel model);
        Task<bool> UpdateAsync(ConfigureGithubModel model);
        Task<bool> DeleteAsync(int id);
    }
}
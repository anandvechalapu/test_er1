namespace Tester1.Service
{
    using Tester1.DTO;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public interface IConfigureGithubService
    {
         Task<List<ConfigureGithubModel>> GetAllAsync();
         Task<ConfigureGithubModel> GetByIdAsync(int id);
         Task<ConfigureGithubModel> CreateAsync(ConfigureGithubModel model);
         Task<bool> UpdateAsync(ConfigureGithubModel model);
         Task<bool> DeleteAsync(int id);
    }
}
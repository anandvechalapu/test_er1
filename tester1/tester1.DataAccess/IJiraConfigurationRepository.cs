namespace Tester1.Service
{
    using Tester1.DTO;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public interface IJiraConfigurationRepository
    {
        Task<JiraConfigurationModel> GetAsync(int id);
        Task<IEnumerable<JiraConfigurationModel>> GetAllAsync();
        Task<JiraConfigurationModel> CreateAsync(JiraConfigurationModel model);
        Task<JiraConfigurationModel> UpdateAsync(JiraConfigurationModel model);
        Task DeleteAsync(int id);
    }
}
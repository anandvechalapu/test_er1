namespace Tester1.Service
{
    using Tester1.DataAccess;
    using Tester1.DTO;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ConfigureGithubService : IConfigureGithubService
    {
        private readonly IConfigureGithubRepository _configureGithubRepository;
        public ConfigureGithubService(IConfigureGithubRepository configureGithubRepository)
        {
            _configureGithubRepository = configureGithubRepository;
        }

        public async Task<List<ConfigureGithubModel>> GetAllAsync()
        {
            return await _configureGithubRepository.GetAllAsync();
        }

        public async Task<ConfigureGithubModel> GetByIdAsync(int id)
        {
            return await _configureGithubRepository.GetByIdAsync(id);
        }

        public async Task<ConfigureGithubModel> CreateAsync(ConfigureGithubModel model)
        {
            return await _configureGithubRepository.CreateAsync(model);
        }

        public async Task<bool> UpdateAsync(ConfigureGithubModel model)
        {
            return await _configureGithubRepository.UpdateAsync(model);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _configureGithubRepository.DeleteAsync(id);
        }
    }
}
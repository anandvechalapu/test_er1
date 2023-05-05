using Tester1.DataAccess;
using Tester1.DTO;

namespace Tester1.Service
{
    public class GithubActivationService : IGithubActivationService
    {
        private IGithubActivationRepository _githubActivationRepository;
        public GithubActivationService(IGithubActivationRepository githubActivationRepository)
        {
            _githubActivationRepository = githubActivationRepository;
        }

        public async Task<GithubActivationModel> GetGithubActivationModelAsync(int id)
        {
            var model = await _githubActivationRepository.GetGithubActivationModelAsync(id);
            return model;
        }

        public async Task<int> InsertGithubActivationModelAsync(GithubActivationModel model)
        {
            var result = await _githubActivationRepository.InsertGithubActivationModelAsync(model);
            return result;
        }

        public async Task<int> UpdateGithubActivationModelAsync(GithubActivationModel model)
        {
            var result = await _githubActivationRepository.UpdateGithubActivationModelAsync(model);
            return result;
        }

        public async Task<int> DeleteGithubActivationModelAsync(int id)
        {
            var result = await _githubActivationRepository.DeleteGithubActivationModelAsync(id);
            return result;
        }
    }
}
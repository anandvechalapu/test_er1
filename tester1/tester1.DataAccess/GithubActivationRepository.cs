namespace Tester1.Repository
{
    using Tester1.DTO;
    public class GithubActivationRepository : IGithubActivationRepository
    {
        public async Task<GithubActivationModel> GetGithubActivationModelAsync(int id)
        {
            var model = await Task.Run(() =>
            {
                //TODO: Add DB connection logic here
                return new GithubActivationModel { Id = id };
            });
            return model;
        }
        public async Task<int> InsertGithubActivationModelAsync(GithubActivationModel model)
        {
            var result = await Task.Run(() =>
            {
                //TODO: Add DB connection logic here
                return 1;
            });
            return result;
        }
        public async Task<int> UpdateGithubActivationModelAsync(GithubActivationModel model)
        {
            var result = await Task.Run(() =>
            {
                //TODO: Add DB connection logic here
                return 1;
            });
            return result;
        }
        public async Task<int> DeleteGithubActivationModelAsync(int id)
        {
            var result = await Task.Run(() =>
            {
                //TODO: Add DB connection logic here
                return 1;
            });
            return result;
        }
    }
}
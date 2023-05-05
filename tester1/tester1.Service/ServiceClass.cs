using System.Threading.Tasks;

namespace tester1.Service
{
    public class ServiceClass : IServiceClass
    {
        private readonly ITester1DataAccess _tester1DataAccess;

        public ServiceClass(ITester1DataAccess tester1DataAccess)
        {
            _tester1DataAccess = tester1DataAccess;
        }

        public async Task<bool> ValidateUserStoryContentAsync(UserStoryDTO userStory)
        {
            return await _tester1DataAccess.ValidateUserStoryContentAsync(userStory);
        }
    }
}
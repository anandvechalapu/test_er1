using System.Threading.Tasks;
using tester1.DTO;

namespace tester1.Service
{
    public interface IServiceClass
    {
        Task<bool> ValidateUserStoryContentAsync(UserStoryDTO userStory);
    }
}
namespace tester1.DTO
{
    public class UserStoryDTO
    {
        public string Content { get; set; }
    }
}

namespace tester1.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserStoryController : ControllerBase
    {
        private readonly IServiceClass _serviceClass;

        public UserStoryController(IServiceClass serviceClass)
        {
            _serviceClass = serviceClass;
        }

        [HttpPost]
        public async Task<IActionResult> ValidateUserStoryContentAsync([FromBody] UserStoryDTO userStory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _serviceClass.ValidateUserStoryContentAsync(userStory);

            if (result)
            {
                return Ok("User Story validation was successful.");
            }
            else
            {
                return BadRequest("User Story validation failed.");
            }
        }
    }
}
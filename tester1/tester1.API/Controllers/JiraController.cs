using System.Threading.Tasks;
using tester1.DTO;
using tester1.Service;
using Microsoft.AspNetCore.Mvc;

namespace tester1.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class JiraController : ControllerBase
    {
        private readonly IJiraService _jiraService;

        public JiraController(IJiraService jiraService)
        {
            _jiraService = jiraService;
        }

        [HttpPost]
        public async Task<ActionResult> ConfigureJira(JiraConfigurationDTO jiraConfigurationDTO)
        {
            var result = await _jiraService.ConfigureJira(jiraConfigurationDTO);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
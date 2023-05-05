namespace Tester1.API
{
    [ApiController]
    [Route("[controller]")]
    public class SignUpController : ControllerBase
    {
        private readonly SignUpService _signUpService;

        public SignUpController(SignUpService signUpService)
        {
            _signUpService = signUpService;
        }

        // GET api/SignUp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SignUpModel>> GetSignUpAsync(int id)
        {
            var result = await _signUpService.GetSignUpAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // POST api/SignUp
        [HttpPost]
        public async Task<ActionResult<SignUpModel>> CreateSignUpAsync(SignUpModel signUp)
        {
            var result = await _signUpService.CreateSignUpAsync(signUp);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        // PUT api/SignUp/5
        [HttpPut("{id}")]
        public async Task<ActionResult<SignUpModel>> UpdateSignUpAsync(int id, SignUpModel signUp)
        {
            if (id != signUp.Id)
            {
                return BadRequest();
            }
            var result = await _signUpService.UpdateSignUpAsync(signUp);
            if (result == false)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // DELETE api/SignUp/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SignUpModel>> DeleteSignUpAsync(int id)
        {
            var result = await _signUpService.DeleteSignUpAsync(id);
            if (result == false)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
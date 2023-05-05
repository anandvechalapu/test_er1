namespace Tester1.Service
{
    public class SignUpService : ISignUpService
    {
        private readonly ISignUpRepository _signUpRepository;

        public SignUpService(ISignUpRepository signUpRepository)
        {
            _signUpRepository = signUpRepository;
        }

        public async Task<SignUpModel> GetSignUpAsync(int id)
        {
            return await _signUpRepository.GetSignUpAsync(id);
        }

        public async Task<int> CreateSignUpAsync(SignUpModel signUp)
        {
            return await _signUpRepository.CreateSignUpAsync(signUp);
        }

        public async Task<bool> UpdateSignUpAsync(SignUpModel signUp)
        {
            return await _signUpRepository.UpdateSignUpAsync(signUp);
        }

        public async Task<bool> DeleteSignUpAsync(int id)
        {
            return await _signUpRepository.DeleteSignUpAsync(id);
        }
    }
}
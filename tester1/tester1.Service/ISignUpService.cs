using Tester1.DTO;

namespace Tester1.Service
{
    public interface ISignUpService
    {
        Task<SignUpModel> GetSignUpAsync(int id);

        Task<int> CreateSignUpAsync(SignUpModel signUp);

        Task<bool> UpdateSignUpAsync(SignUpModel signUp);

        Task<bool> DeleteSignUpAsync(int id);
    }
}
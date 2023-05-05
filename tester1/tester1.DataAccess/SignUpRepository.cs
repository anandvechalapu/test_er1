using Tester1.DTO;

namespace Tester1
{
    public class SignUpRepository: ISignUpRepository
    {
        public async Task<SignUpModel> GetSignUpAsync(int id)
        {
            // Get sign up details from database
            return await Task.Run(() =>
            {
                SignUpModel signUp = new SignUpModel
                {
                    Id = id,
                    UserName = "tester1",
                    Password = "123456",
                    Email = "tester1@example.com",
                    Phone = "1234567890"
                };
                return signUp;
            });
        }

        public async Task<int> CreateSignUpAsync(SignUpModel signUp)
        {
            // Create sign up in database
            return await Task.Run(() =>
            {
                return signUp.Id;
            });
        }

        public async Task<bool> UpdateSignUpAsync(SignUpModel signUp)
        {
            // Update sign up in database
            return await Task.Run(() =>
            {
                return true;
            });
        }

        public async Task<bool> DeleteSignUpAsync(int id)
        {
            // Delete sign up from database
            return await Task.Run(() =>
            {
                return true;
            });
        }
    }
}
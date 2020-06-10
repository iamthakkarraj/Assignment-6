using Testing.BLL.Interface;
using Testing.DAL.Interface;
using Testing.DAL.Repository;
using Testing.BLL.ViewModels;
using Testing.DAL.Database;

namespace Testing.BLL.Service {

    public class AuthenticationService : IAuthenticationService {

        private readonly IAuthenticationRepository _AuthenticationRepository;

        public AuthenticationService() {
            _AuthenticationRepository = new AuthenticationRepository();
        }

        public bool VerifyUser(LoginModel login) {
            login.Password = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(login.Password));
            return _AuthenticationRepository
                    .VerifyUser(ModelMapperService
                    .Map<LoginModel,Login>(login));
        }

        public bool AddUser(SignUpModel login) {
            login.Password = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(login.Password));
            return _AuthenticationRepository
                    .AddUser(ModelMapperService
                    .Map<SignUpModel, Login>(login));
        }

    }

}
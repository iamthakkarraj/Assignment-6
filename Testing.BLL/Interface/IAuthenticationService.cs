using Testing.BLL.ViewModels;

namespace Testing.BLL.Interface {

    public interface IAuthenticationService {

        bool VerifyUser(LoginModel login);

        bool AddUser(SignUpModel login);

    }

}
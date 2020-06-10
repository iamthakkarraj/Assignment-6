using Testing.DAL.Database;

namespace Testing.DAL.Interface {    

    public interface IAuthenticationRepository {        

        bool VerifyUser(Login login);

        bool AddUser(Login login);

    }

}
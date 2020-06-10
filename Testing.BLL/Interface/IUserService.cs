using System.Collections.Generic;
using Testing.BLL.ViewModels;

namespace Testing.BLL.Interface {

    public interface IUserService {

        List<UserModel> GetUsers();
        UserModel GetUser(int id);
        bool AddUser(UserModel user);
        bool UpdateUser(UserModel user);
        bool DeleteUser(int id);

    }

}
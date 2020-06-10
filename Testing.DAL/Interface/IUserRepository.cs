using System.Collections.Generic;
using Testing.DAL.Database;

namespace Testing.DAL.Interface {

    public interface IUserRepository {

        List<User> GetUsers();
        User GetUser(int id);
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int id);

    }

}
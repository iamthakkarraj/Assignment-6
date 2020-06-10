using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.BLL.ViewModels;
using Testing.BLL.Interface;
using Testing.DAL.Interface;
using Testing.DAL.Repository;
using Testing.DAL.Database;

namespace Testing.BLL.Service {

   public class UserService : IUserService {

        IUserRepository _UserRepository;

        public UserService() {
            _UserRepository = new UserRespository();
        }        

        public bool AddUser(UserModel user) {
            return _UserRepository
                    .AddUser(ModelMapperService
                        .Map<UserModel,User>(user));
        }

        public bool DeleteUser(int id) {
            return _UserRepository.DeleteUser(id);
        }

        public UserModel GetUser(int id) {
            return ModelMapperService
                        .Map<User, UserModel>(
                        _UserRepository.GetUser(id));
        }

        public List<UserModel> GetUsers() {
            
            List<UserModel> destination = new List<UserModel>();

            foreach(User user in _UserRepository.GetUsers()) {
                destination.Add(ModelMapperService.Map<User, UserModel>(user));
            }

            return destination;

        }

        public bool UpdateUser(UserModel user) {
            return _UserRepository
                    .UpdateUser(ModelMapperService
                        .Map<UserModel, User>(user));
        }

    }

}
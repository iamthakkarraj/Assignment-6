using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.BLL.ViewModels;

namespace Testing.UI.Tests.Data {

    public static class DataProvider {
        
        public static List<UserModel> PositiveUserData = new List<UserModel>() {
            new UserModel() {
                UserId = 1,
                Name = "Bob Ross",
                Email = "IAmPainter@gmail.com",
                Gender = true,
                Phone = "9726080715",
                Birthdate = DateTime.Now
            },
            new UserModel() {
                UserId = 2,
                Name = "Hitler",
                Email = "FXXKJEWS@gmail.com",
                Gender = true,
                Phone = "9726080715",
                Birthdate = DateTime.Now
            },
            new UserModel() {
                UserId = 3,
                Name = "Slavoj Zizek",
                Email = "AndSoONAndSoOn@gmail.com",
                Gender = true,
                Phone = "9726080715",
                Birthdate = DateTime.Now
            }
        };

        public static List<UserModel> NegativeUserData = new List<UserModel>() {
            new UserModel() {
                Name = "Bob Ross",
                Email = "IAmPainter",
                Gender = true,
                Phone = "9726080715",
                Birthdate = DateTime.Now
            },
            new UserModel() {
                Name = "Hitler",
                Email = "FXXKJEWS",
                Gender = true,
                Phone = "9726080715",
                Birthdate = DateTime.Now
            },
            new UserModel() {
                Name = "Slavoj Zizek",
                Email = "AndSoONAndSoOn",
                Gender = true,
                Phone = "9726080715",
                Birthdate = DateTime.Now
            }
        };

        public static List<LoginModel> PositiveLoginData = new List<LoginModel>() {
            new LoginModel() {
                Username = "iamthakkarraj@gmail.com",
                Password = "GA(()fxaud3"
            },
            new LoginModel() {
                Username = "admin@admin.com",
                Password = "GA(()fxaud3"
            },
        };

        public static List<LoginModel> NegativeLoginData = new List<LoginModel>() {
            new LoginModel() {
                Username = "iamthakkarraj",
                Password = "GA(()fxaud3"
            },
            new LoginModel() {
                Username = "admin",
                Password = "GA(()fxaud3"
            },
        };

        public static List<SignUpModel> PositiveSinUpData = new List<SignUpModel>() {
            new SignUpModel() {
                Username = "iamthakkarraj@gmail.com",
                Password = "GA(()fxaud3",
                ConfirmPassword = "GA(()fxaud3"
            },
            new SignUpModel() {
                Username = "admin@admin.com",
                Password = "GA(()fxaud3",
                ConfirmPassword = "GA(()fxaud3"
            },
        };

        public static List<SignUpModel> NegativeSignUpData = new List<SignUpModel>() {
            new SignUpModel() {
                Username = "iamthakkarraj",
                Password = "GA(()fxaud3",
                ConfirmPassword = "GA(()fx"
            },
            new SignUpModel() {
                Username = "admin",
                Password = "GA(()fxaud3",
                ConfirmPassword = "()fxaud3"
            },
        };

    }

}
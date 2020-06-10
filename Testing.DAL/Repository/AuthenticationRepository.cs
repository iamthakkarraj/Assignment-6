using Testing.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.DAL.Interface;
using System.Data.SqlClient;
using System.Data;

namespace Testing.DAL.Repository {

    public class AuthenticationRepository : IAuthenticationRepository {

        private readonly TestingAssignmentEntities DBContext;

        public AuthenticationRepository() {
            DBContext = new TestingAssignmentEntities();
        }

        public bool VerifyUser(Login login) {
            string connectionString = @"data source=RAZZMATAZZ\SQLEXPRESS;initial catalog=TestingAssignment;integrated security=True";
            try {
                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Username = @name and password = @password", connection);
                    cmd.Parameters.AddWithValue("@name", login.Username);
                    cmd.Parameters.AddWithValue("@password", login.Password);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable datatbl = new DataTable();
                    sda.Fill(datatbl);

                    if (datatbl.Rows.Count > 0) {
                        connection.Close();
                        return true;
                    } else {
                        connection.Close();
                        return false;
                    }

                }
            } catch {
                return false;
            }
        }

        public bool AddUser(Login loing) {
            try {
                DBContext.Logins.Add(loing);
                DBContext.SaveChanges();
                return true;
            } catch {
                return false;
            }
        }

    }

}
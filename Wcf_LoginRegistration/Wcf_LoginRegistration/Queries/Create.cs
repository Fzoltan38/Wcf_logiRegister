using MySqlConnector;
using Payment_wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf_LoginRegistration.Queries
{
    public class Create
    {
        Connect c = new Connect();
        public int addUser(User user)
        {
            try
            {
                string qry = "INSERT INTO `users`(`uname`, `email`, `pwd`, `fullname`, `reg_time`) VALUES (@uname, @email, @pwd, @fullname, @reg)";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = c.connection;

                cmd.Parameters.AddWithValue("@uname", user.uname);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@pwd", user.pwd);
                cmd.Parameters.AddWithValue("@fullname", user.fullname);
                cmd.Parameters.AddWithValue("@reg", DateTime.Now);
            
                cmd.CommandText = qry;

                return cmd.ExecuteNonQuery();

            }
            catch
            {
                return 0;
            }
           
        }
    }
}
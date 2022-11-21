using MySqlConnector;
using Payment_wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf_LoginRegistration.Queries
{
    public class Update
    {
        Connect c = new Connect();

        public int modifyUser(User user)
        {
            Connect c = new Connect();
            try
            {
                string qry = "UPDATE `users` SET `uname`= @uname,`email`= @email,`pwd`= @pwd,`fullname`= @fullname,`active`= @active,`rank`= @rank,`ban`= @ban WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = c.connection;

                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.Parameters.AddWithValue("@uname", user.uname);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@pwd", user.pwd);
                cmd.Parameters.AddWithValue("@fullname", user.fullname);
                cmd.Parameters.AddWithValue("@active", user.active);
                cmd.Parameters.AddWithValue("@rank", user.rank);
                cmd.Parameters.AddWithValue("@ban", user.ban);

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
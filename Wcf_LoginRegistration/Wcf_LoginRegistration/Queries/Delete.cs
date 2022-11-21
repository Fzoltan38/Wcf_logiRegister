using MySqlConnector;
using Payment_wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf_LoginRegistration.Queries
{
    public class Delete
    {
        public int delUser(string id)
        {
            Connect c = new Connect();
            try
            {
                string qry = "DELETE FROM `users` WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = c.connection;

                cmd.Parameters.AddWithValue("@id", id);

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
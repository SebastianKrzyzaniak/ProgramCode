using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;

namespace Session
{
    public class Broker
    {
        SqlConnection conn;
        SqlConnectionStringBuilder connStringBuilder;

        void ConnectTo()
        {//Data Source=DESKTOP-IGOETAR\SQLEXPRESS;Initial Catalog=BazaMojeTesty;Integrated Security=True
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = @"DESKTOP-IGOETAR\SQLEXPRESS";
            connStringBuilder.InitialCatalog = "BazaMojeTesty";
            connStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStringBuilder.ToString());
        }

        public Broker()
        {
            ConnectTo();
        }

        public void Insert(Person p)
        {
            try
            {
                string cmdText = "INSERT INTO dbo.Persons(FirstName, LastName) VALUES(@FirstName, @LastName)";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.AddWithValue("@FirstName", p.FirstName);
                cmd.Parameters.AddWithValue("@LastName", p.LastName);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn!=null)
                {
                    conn.Close();
                }
            }
        }
    }
}

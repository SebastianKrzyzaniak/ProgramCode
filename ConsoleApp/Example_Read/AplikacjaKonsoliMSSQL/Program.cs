using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AplikacjaKonsoliMSSQL
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection conn = new SqlConnection("Server=DESKTOP-IGOETAR\\SQLEXPRESS;Database=BazaPoradnik; Integrated Security=True;");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[uczen]", conn);
            SqlDataReader reader = cmd.ExecuteReader();

    

            while(reader.Read())
            {
                Console.WriteLine("{0}, {1}, \t {2}", reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
            }
            reader.Close();
            conn.Close();
            Console.ReadLine();
        }
    }
}

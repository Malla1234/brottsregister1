using System.Data;
using System.Data.SqlClient;

namespace brottsregister1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-9U8J83ML; Initial Catalog=Brottsregister;Integrated Security=true");

            SqlDataAdapter sqlDat = new SqlDataAdapter("Select * From Brott", sqlcon);

            DataTable dtTbl= new DataTable();

            sqlDat.Fill(dtTbl);

            foreach (DataRow dr in dtTbl.Rows)
            {
                Console.WriteLine(dr["BrottsNamn"]);
                Console.WriteLine();
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlinhansu.Model
{
    public class KiemTraKetNoi
    {
        public bool Kiemtra()
        {
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(System.IO.File.ReadAllText("connectionString.txt"));
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlinhansu.Model
{
    public class ConnectSQL
    {
        protected static SqlConnection connection = null;

        protected void OpenConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(System.IO.File.ReadAllText("ConnectionString.txt"));
                try
                {
                    connection.Open();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("có lỗi kết nối đến cơ sở dữ liệu. Vui lòng khởi động lại ứng dụng.\n" + ex.Message);
                    Application.Exit();

                }
            }
        }


    }
}

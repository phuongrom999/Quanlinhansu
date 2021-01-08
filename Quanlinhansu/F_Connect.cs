using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlinhansu
{
    public partial class F_Connect : Form
    {
        public F_Connect()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void F_Connect_Load(object sender, EventArgs e)
        {
            lblmessage.Text = "Kết nối đến CSDL thất bại.\n vui lòng thiết lập lại thông số kết nối CBCSDL";
            cbauthentication.Items.Add("Windows Authentication");
            cbauthentication.Items.Add("SQL Server Authentication");
            cbauthentication.SelectedIndex = 0;

        }

        private void F_Connect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EnableSqlAuthenticationMode(bool b)
        {
            lblusername.Enabled = b;
            lblpassword.Enabled = b;
            txtusername.Enabled = b;
            txtpassword.Enabled = b;
        }

        private void cbauthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbauthentication.SelectedIndex == 0)
            {
                EnableSqlAuthenticationMode(false);
            }
            else
            {
                EnableSqlAuthenticationMode(true);
            }
        }

        private void txtservername_TextChanged(object sender, EventArgs e)
        {
            if (txtservername.Text == "")
            {
                btnlaydsdatabase.Enabled = false;

            }
            else
            {
                btnlaydsdatabase.Enabled = true;
            }
        }

        private void btnlaydsdatabase_Click(object sender, EventArgs e)
        {
            String ConnectionString;

            if (cbauthentication.SelectedIndex == 0)
            {
                ConnectionString = @"Data Source=" + txtservername.Text.Trim() + ";Initial Catalog=master;Integrated Security=True";

            }
            else
            {
                ConnectionString = @"Data Source=" + txtservername.Text.Trim() + ";Initial Catalog=master;User ID=" + txtusername.Text.Trim() + ";Password=" + txtpassword.Text.Trim();
            }
                SqlConnection connection = new SqlConnection(ConnectionString);
                try
                {
                    connection.Open();

                    SqlDataAdapter da = new SqlDataAdapter("Select name FROM sys.databases WHERE name NOT IN('master','model','msdb','tempdb')", connection);

                    DataTable table = new DataTable();
                    da.Fill(table);
                    da.Dispose();
                    connection.Close();
                    cbchoncsdl.DataSource = table;
                    cbchoncsdl.DisplayMember = "name";
                    cbchoncsdl.ValueMember = "name";

                    lblchoncsdl.Enabled = true;
                    cbchoncsdl.Enabled = true;

                    btnlaydsdatabase.Enabled = false;
                    btnkncsdl.Enabled = true;

                    lblservername.Enabled = false;
                    txtservername.Enabled = false;

                    cbauthentication.Enabled = false;

                    EnableSqlAuthenticationMode(false);
                }
                catch (Exception ex)
                {

                    btnkncsdl.Enabled = false;
                    MessageBox.Show(ex.Message);
                }
            
        }

        private void btnkncsdl_Click(object sender, EventArgs e)
        {
            if(cbchoncsdl.SelectedValue==null)
            {
                MessageBox.Show("vui lòng chọn 1 cơ sở dữ liệu");
                return;
            }

            string connectionString;
            if (cbauthentication.SelectedIndex == 0)
            {
                connectionString = @"Data Source=" + txtservername.Text.Trim() + ";Initial Catalog=" + cbchoncsdl.SelectedValue.ToString() + ";Integrated Security=True";
            }
            else
            {
                connectionString = @"Data Source=" + txtservername.Text.Trim() + ";Initial Catalog=" + cbchoncsdl.SelectedValue.ToString() + ";User ID=" + txtusername.Text.Trim() + ";Password=" + txtpassword.Text.Trim();
            }
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("sp_kiem_tra_ket_noi", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    bool flag = (bool)cmd.ExecuteScalar();

                    cmd.Dispose();
                    connection.Close();

                    if(flag)
                    {
                        System.IO.File.WriteAllText("connectionString.txt", connectionString);
                        this.Hide();
                        new F_Main().Show();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn đúng cơ sở dữ liệu. Mặc định là qlns");

                    }
                }
                catch
                {

                    connection.Close();
                    MessageBox.Show("Vui lòng chọn đúng cơ sở dữ liệu. Mặc định là qlns");
                    return;
                }
            
        }
    }
}

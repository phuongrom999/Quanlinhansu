using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlinhansu
{
    public partial class F_Start : Form
    {
        public F_Start()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void F_Start_Load(object sender, EventArgs e)
        {
            
            lblMessage.Text = "...Đang mở ứng dụng";
            Thread th = new Thread(new ThreadStart(ThreadFuntion))
            {
                IsBackground = true
            };
            th.Start();
        }
        
        private void OpenMainForm()
        {
            Thread.Sleep(1500);
            if(this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    new F_Main().Show();
                    this.Visible = false;
                });
            }
            else
            {
                new F_Main().Show();
                this.Visible = false;
            }
        }

        private void TestConnectDatabase()
        {
            Quanlinhansu.Model.KiemTraKetNoi test = new Quanlinhansu.Model.KiemTraKetNoi();
            if(!test.Kiemtra())
            {
                this.Visible = false;
                new F_Connect().Show();
            }
            else
            {
                lblMessage.Text = "...Kết nối thành công. Đang mở ứng dụng";

                Thread th = new Thread(new ThreadStart(OpenMainForm))
                {
                    IsBackground = true
                };
                th.Start();
            }
        }

        private void ThreadFuntion()
        {
            Thread.Sleep(2000);
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    lblMessage.Text = "...Đang kiểm tra kết nối";
                });
            }
            else
                lblMessage.Text = "...Đang kiểm tra kết nối đến CSDL";

            Thread.Sleep(1500);
            if(this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
               {
                   TestConnectDatabase();
               });
            }
        }
    }
}

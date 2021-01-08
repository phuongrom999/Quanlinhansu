namespace Quanlinhansu
{
    partial class F_Connect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblservername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblchoncsdl = new System.Windows.Forms.Label();
            this.txtservername = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cbauthentication = new System.Windows.Forms.ComboBox();
            this.cbchoncsdl = new System.Windows.Forms.ComboBox();
            this.btnlaydsdatabase = new System.Windows.Forms.Button();
            this.btnkncsdl = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.lblmessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblservername
            // 
            this.lblservername.AutoSize = true;
            this.lblservername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservername.Location = new System.Drawing.Point(12, 58);
            this.lblservername.Name = "lblservername";
            this.lblservername.Size = new System.Drawing.Size(101, 20);
            this.lblservername.TabIndex = 0;
            this.lblservername.Text = "Server Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Authentication";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(12, 149);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(89, 20);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "User Name";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(12, 200);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(78, 20);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Password";
            // 
            // lblchoncsdl
            // 
            this.lblchoncsdl.AutoSize = true;
            this.lblchoncsdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchoncsdl.Location = new System.Drawing.Point(12, 297);
            this.lblchoncsdl.Name = "lblchoncsdl";
            this.lblchoncsdl.Size = new System.Drawing.Size(94, 20);
            this.lblchoncsdl.TabIndex = 4;
            this.lblchoncsdl.Text = "Chọn CSDL";
            // 
            // txtservername
            // 
            this.txtservername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtservername.Location = new System.Drawing.Point(178, 56);
            this.txtservername.Name = "txtservername";
            this.txtservername.Size = new System.Drawing.Size(251, 22);
            this.txtservername.TabIndex = 5;
            this.txtservername.TextChanged += new System.EventHandler(this.txtservername_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(178, 147);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(251, 22);
            this.txtusername.TabIndex = 6;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(178, 198);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(251, 22);
            this.txtpassword.TabIndex = 7;
            // 
            // cbauthentication
            // 
            this.cbauthentication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbauthentication.FormattingEnabled = true;
            this.cbauthentication.Location = new System.Drawing.Point(178, 101);
            this.cbauthentication.Name = "cbauthentication";
            this.cbauthentication.Size = new System.Drawing.Size(251, 24);
            this.cbauthentication.TabIndex = 8;
            this.cbauthentication.SelectedIndexChanged += new System.EventHandler(this.cbauthentication_SelectedIndexChanged);
            // 
            // cbchoncsdl
            // 
            this.cbchoncsdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbchoncsdl.FormattingEnabled = true;
            this.cbchoncsdl.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cbchoncsdl.Location = new System.Drawing.Point(178, 293);
            this.cbchoncsdl.Name = "cbchoncsdl";
            this.cbchoncsdl.Size = new System.Drawing.Size(251, 24);
            this.cbchoncsdl.TabIndex = 9;
            // 
            // btnlaydsdatabase
            // 
            this.btnlaydsdatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlaydsdatabase.Location = new System.Drawing.Point(206, 239);
            this.btnlaydsdatabase.Name = "btnlaydsdatabase";
            this.btnlaydsdatabase.Size = new System.Drawing.Size(223, 23);
            this.btnlaydsdatabase.TabIndex = 10;
            this.btnlaydsdatabase.Text = "Lấy danh sách Database";
            this.btnlaydsdatabase.UseVisualStyleBackColor = true;
            this.btnlaydsdatabase.Click += new System.EventHandler(this.btnlaydsdatabase_Click);
            // 
            // btnkncsdl
            // 
            this.btnkncsdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkncsdl.Location = new System.Drawing.Point(187, 320);
            this.btnkncsdl.Name = "btnkncsdl";
            this.btnkncsdl.Size = new System.Drawing.Size(110, 23);
            this.btnkncsdl.TabIndex = 11;
            this.btnkncsdl.Text = "Kết nối CSDL";
            this.btnkncsdl.UseVisualStyleBackColor = true;
            this.btnkncsdl.Click += new System.EventHandler(this.btnkncsdl_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(328, 320);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(110, 23);
            this.btnhuy.TabIndex = 12;
            this.btnhuy.Text = "Huỷ";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(203, 9);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 13);
            this.lblmessage.TabIndex = 13;
            // 
            // F_Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 401);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnkncsdl);
            this.Controls.Add(this.btnlaydsdatabase);
            this.Controls.Add(this.cbchoncsdl);
            this.Controls.Add(this.cbauthentication);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtservername);
            this.Controls.Add(this.lblchoncsdl);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblservername);
            this.Name = "F_Connect";
            this.Text = "Chọn CSDL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_Connect_FormClosing);
            this.Load += new System.EventHandler(this.F_Connect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblservername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblchoncsdl;
        private System.Windows.Forms.TextBox txtservername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ComboBox cbauthentication;
        private System.Windows.Forms.ComboBox cbchoncsdl;
        private System.Windows.Forms.Button btnlaydsdatabase;
        private System.Windows.Forms.Button btnkncsdl;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Label lblmessage;
    }
}
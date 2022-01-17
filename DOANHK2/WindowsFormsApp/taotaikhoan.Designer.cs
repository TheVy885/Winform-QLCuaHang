namespace WindowsFormsApp
{
    partial class taotaikhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_taouser = new System.Windows.Forms.TextBox();
            this.txt_taopassword = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LoginID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_loginID = new System.Windows.Forms.TextBox();
            this.btn_themtk = new System.Windows.Forms.Button();
            this.btn_xoatk = new System.Windows.Forms.Button();
            this.btn_suatk = new System.Windows.Forms.Button();
            this.btn_xoathongtintk = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_mahoa = new System.Windows.Forms.Button();
            this.txt_passdamahoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_giaimapassword = new System.Windows.Forms.TextBox();
            this.btn_giaima = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // txt_taouser
            // 
            this.txt_taouser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taouser.Location = new System.Drawing.Point(174, 254);
            this.txt_taouser.Name = "txt_taouser";
            this.txt_taouser.Size = new System.Drawing.Size(313, 29);
            this.txt_taouser.TabIndex = 2;
            // 
            // txt_taopassword
            // 
            this.txt_taopassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taopassword.Location = new System.Drawing.Point(174, 307);
            this.txt_taopassword.Name = "txt_taopassword";
            this.txt_taopassword.Size = new System.Drawing.Size(313, 29);
            this.txt_taopassword.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoginID,
            this.Username,
            this.Password});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(35, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 146);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // LoginID
            // 
            this.LoginID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoginID.DataPropertyName = "LoginID";
            this.LoginID.HeaderText = "LoginID";
            this.LoginID.Name = "LoginID";
            this.LoginID.Width = 69;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Username.DataPropertyName = "username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.Width = 80;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Password.DataPropertyName = "password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.Width = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "LoginID : ";
            // 
            // txt_loginID
            // 
            this.txt_loginID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginID.Location = new System.Drawing.Point(174, 205);
            this.txt_loginID.Name = "txt_loginID";
            this.txt_loginID.Size = new System.Drawing.Size(313, 29);
            this.txt_loginID.TabIndex = 6;
            // 
            // btn_themtk
            // 
            this.btn_themtk.BackColor = System.Drawing.SystemColors.Control;
            this.btn_themtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themtk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_themtk.Location = new System.Drawing.Point(502, 205);
            this.btn_themtk.Name = "btn_themtk";
            this.btn_themtk.Size = new System.Drawing.Size(131, 36);
            this.btn_themtk.TabIndex = 7;
            this.btn_themtk.Text = "Tạo tài khoản";
            this.btn_themtk.UseVisualStyleBackColor = false;
            this.btn_themtk.Click += new System.EventHandler(this.btn_themtk_Click);
            // 
            // btn_xoatk
            // 
            this.btn_xoatk.BackColor = System.Drawing.SystemColors.Control;
            this.btn_xoatk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoatk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoatk.Location = new System.Drawing.Point(639, 205);
            this.btn_xoatk.Name = "btn_xoatk";
            this.btn_xoatk.Size = new System.Drawing.Size(131, 36);
            this.btn_xoatk.TabIndex = 8;
            this.btn_xoatk.Text = "Xóa Tài Khoản";
            this.btn_xoatk.UseVisualStyleBackColor = false;
            this.btn_xoatk.Click += new System.EventHandler(this.btn_xoatk_Click);
            // 
            // btn_suatk
            // 
            this.btn_suatk.BackColor = System.Drawing.SystemColors.Control;
            this.btn_suatk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suatk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_suatk.Location = new System.Drawing.Point(502, 250);
            this.btn_suatk.Name = "btn_suatk";
            this.btn_suatk.Size = new System.Drawing.Size(131, 33);
            this.btn_suatk.TabIndex = 9;
            this.btn_suatk.Text = "Sửa Tài Khoản";
            this.btn_suatk.UseVisualStyleBackColor = false;
            this.btn_suatk.Click += new System.EventHandler(this.btn_suatk_Click);
            // 
            // btn_xoathongtintk
            // 
            this.btn_xoathongtintk.BackColor = System.Drawing.SystemColors.Control;
            this.btn_xoathongtintk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoathongtintk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoathongtintk.Location = new System.Drawing.Point(639, 250);
            this.btn_xoathongtintk.Name = "btn_xoathongtintk";
            this.btn_xoathongtintk.Size = new System.Drawing.Size(131, 33);
            this.btn_xoathongtintk.TabIndex = 10;
            this.btn_xoathongtintk.Text = "Clear";
            this.btn_xoathongtintk.UseVisualStyleBackColor = false;
            this.btn_xoathongtintk.Click += new System.EventHandler(this.btn_xoathongtintk_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_thoat.Location = new System.Drawing.Point(502, 301);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(268, 31);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_mahoa
            // 
            this.btn_mahoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mahoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_mahoa.Location = new System.Drawing.Point(776, 208);
            this.btn_mahoa.Name = "btn_mahoa";
            this.btn_mahoa.Size = new System.Drawing.Size(151, 31);
            this.btn_mahoa.TabIndex = 12;
            this.btn_mahoa.Text = "Mã hóa mật khẩu";
            this.btn_mahoa.UseVisualStyleBackColor = true;
            this.btn_mahoa.Click += new System.EventHandler(this.btn_mahoa_Click);
            // 
            // txt_passdamahoa
            // 
            this.txt_passdamahoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passdamahoa.Location = new System.Drawing.Point(308, 357);
            this.txt_passdamahoa.Name = "txt_passdamahoa";
            this.txt_passdamahoa.Size = new System.Drawing.Size(205, 29);
            this.txt_passdamahoa.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password sau khi mã hóa : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password sau khi giải mã hóa:";
            // 
            // txt_giaimapassword
            // 
            this.txt_giaimapassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaimapassword.Location = new System.Drawing.Point(308, 425);
            this.txt_giaimapassword.Name = "txt_giaimapassword";
            this.txt_giaimapassword.Size = new System.Drawing.Size(205, 31);
            this.txt_giaimapassword.TabIndex = 16;
            // 
            // btn_giaima
            // 
            this.btn_giaima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giaima.Location = new System.Drawing.Point(776, 254);
            this.btn_giaima.Name = "btn_giaima";
            this.btn_giaima.Size = new System.Drawing.Size(151, 29);
            this.btn_giaima.TabIndex = 17;
            this.btn_giaima.Text = "Giải mã mật khẩu";
            this.btn_giaima.UseVisualStyleBackColor = true;
            this.btn_giaima.Click += new System.EventHandler(this.btn_giaima_Click);
            // 
            // taotaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(943, 475);
            this.Controls.Add(this.btn_giaima);
            this.Controls.Add(this.txt_giaimapassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_passdamahoa);
            this.Controls.Add(this.btn_mahoa);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoathongtintk);
            this.Controls.Add(this.btn_suatk);
            this.Controls.Add(this.btn_xoatk);
            this.Controls.Add(this.btn_themtk);
            this.Controls.Add(this.txt_loginID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_taopassword);
            this.Controls.Add(this.txt_taouser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "taotaikhoan";
            this.Text = "Truy Xuất Tài Khoản ";
            this.Load += new System.EventHandler(this.taotaikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_taouser;
        private System.Windows.Forms.TextBox txt_taopassword;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_loginID;
        private System.Windows.Forms.Button btn_themtk;
        private System.Windows.Forms.Button btn_xoatk;
        private System.Windows.Forms.Button btn_suatk;
        private System.Windows.Forms.Button btn_xoathongtintk;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_mahoa;
        private System.Windows.Forms.TextBox txt_passdamahoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_giaimapassword;
        private System.Windows.Forms.Button btn_giaima;
    }
}
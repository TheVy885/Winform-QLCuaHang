using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace WindowsFormsApp
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source =DESKTOP-U0R07KQ\SQLEXPRESS ; Initial Catalog =QLCH1; Integrated Security=True");//duong dan toi sv cua csdl
            string query = " select * from Login Where username='" + txt_user.Text.Trim() + "'and password='" + Encrypt(txt_password.Text).Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Form1 objform1 = new Form1();
                this.Hide();
                objform1.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại username và password!");
            }
        }

        static string Encrypt(string value) //encrypt với MD5
        {
            using (MD5CryptoServiceProvider mds = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = mds.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            khachhang khachhang1 = new khachhang();
            this.Hide();
            khachhang1.Show();
        }
    }
}

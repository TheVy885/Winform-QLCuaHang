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
    public partial class taotaikhoan : Form
    {
        public taotaikhoan()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source =DESKTOP-U0R07KQ\SQLEXPRESS ; Initial Catalog =QLCH1; Integrated Security=True"; //duong dan toi sv cua csdl
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table2 = new DataTable();

        void LoadUser()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Login ";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            dataGridView1.DataSource = table2;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_loginID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_taouser.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_taopassword.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void taotaikhoan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadUser();
        }

        private void btn_themtk_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Insert into Login values ('" + txt_loginID.Text + "','" + txt_taouser.Text + "','" + Encrypt(txt_taopassword.Text) + "')";
                command.ExecuteNonQuery();
                LoadUser();
                MessageBox.Show("Đã tạo tài khoản thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại LoginID !", "Cảnh Báo!");
            }
        }

        private void btn_xoatk_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Login where LoginID='" + txt_loginID.Text + "'";
            command.ExecuteNonQuery();
            LoadUser();
            MessageBox.Show("Đã xóa tài khoản thành công!", "Thông báo");
        }

        private void btn_suatk_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Login set LoginID='" + txt_loginID.Text + "',username='" + txt_taouser.Text + "',password='" + txt_taopassword.Text + "'Where LoginID='" + txt_loginID.Text + "'";
            command.ExecuteNonQuery();
            LoadUser();
            MessageBox.Show("Đã sửa tài khoản thành công!", "Thông báo");
        }

        private void btn_xoathongtintk_Click(object sender, EventArgs e)
        {
            txt_loginID.Text = "";
            txt_taouser.Text = "";
            txt_taopassword.Text = "";
            txt_giaimapassword.Text = "";
            txt_passdamahoa.Text = "";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            var DR = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Cảnh Báo", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
        }
        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider mds = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();

                byte[] data = mds.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }



        private void btn_mahoa_Click(object sender, EventArgs e)
        {
            /*if(string.IsNullOrEmpty(txt_taopassword.Text))
            {
                MessageBox.Show("Vui lòng điền Password!", "Cảnh báo!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            txt_passdamahoa.Text = Encrypt(txt_taopassword.Text);
            */
            byte[] data = UTF8Encoding.UTF8.GetBytes(txt_taopassword.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txt_passdamahoa.Text = Convert.ToBase64String(results, 0, results.Length);



                }
            }
        }

         string hash = "abc";
        private void btn_giaima_Click(object sender, EventArgs e)
        {
            byte[] data = Convert.FromBase64String(txt_passdamahoa.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txt_giaimapassword.Text = UTF8Encoding.UTF8.GetString(results);
                }

            }

        }

    }
}

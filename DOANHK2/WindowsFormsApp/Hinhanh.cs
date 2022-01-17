using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace WindowsFormsApp
{
    public partial class Hinhanh : Form
    {
        string filename;
        List<MyPic> list;

        public Hinhanh()
        {
            InitializeComponent();
        }

        Image ConvertBinaryToImage(byte[] data)
        {
            using(MemoryStream ms=new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null)
            {
                pictureBox1.Image = ConvertBinaryToImage(list[listView1.FocusedItem.Index].Data);
                lblFileName.Text = listView1.FocusedItem.SubItems[0].Text;
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg ", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    lblFileName.Text = filename;
                    pictureBox1.Image = Image.FromFile(filename);

                }
            }
        }
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms =new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            using(SaveImageEntities db= new SaveImageEntities())
            {
                MyPic pic = new MyPic() { FileName = filename, Data = ConvertImageToBinary(pictureBox1.Image) };
                db.MyPics.Add(pic);
                await db.SaveChangesAsync();
                MessageBox.Show("Lưu thành công!", "Thông báo !",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            
        }



        private void btn_load_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using(SaveImageEntities db= new SaveImageEntities())
            {
                list = db.MyPics.ToList();
                foreach(MyPic  pic in list)
                    {
                    ListViewItem item = new ListViewItem(filename);
                    listView1.Items.Add(item);

                }
            }
        }



        private void btn_exit_Click(object sender, EventArgs e)
        {
            var DR = MessageBox.Show("Bạn có muốn thoát khỏi mục hình ảnh sản phẩm?", "Cảnh Báo", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
        }
    }
}

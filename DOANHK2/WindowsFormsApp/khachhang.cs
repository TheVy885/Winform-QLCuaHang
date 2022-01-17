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

namespace WindowsFormsApp
{
    public partial class khachhang : Form
    {
        public khachhang()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source =DESKTOP-U0R07KQ\SQLEXPRESS ; Initial Catalog =QLCH1; Integrated Security=True"; //duong dan toi sv cua csdl
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable(); //thongtin ve hanghoa
        DataTable table1 = new DataTable(); //thong tin ve hoa don

        void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select *from HangHoa";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        void LoadHoaDon()
        {
            command = connection.CreateCommand();
            command.CommandText = "select *from HDChiTietDatHang";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dataGridView2.DataSource = table1;

        }

        private void khachhang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
            LoadHoaDon();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_mshh.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_tenhang.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_khoiluong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_donvi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_gia.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt_tongsoluong.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }

        

        

        private void btn_taomoihh_Click(object sender, EventArgs e)
        {
            txt_mshh.Text = "";
            txt_tenhang.Text = "";
            txt_khoiluong.Text = "";
            txt_donvi.Text = "";
            txt_gia.Text = "";
            txt_tongsoluong.Text = "";
            dateTimePicker1.Text = "";
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        

        private void btn_timhh_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HangHoa where TenHang like '%" + txt_tenhang.Text + "%'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x;
            x = dataGridView2.CurrentRow.Index;
            txt_msdh.Text = dataGridView2.Rows[x].Cells[0].Value.ToString();
            txt_hotenkhachhang.Text = dataGridView2.Rows[x].Cells[1].Value.ToString();
            txt_diachi.Text = dataGridView2.Rows[x].Cells[2].Value.ToString();
            txt_sodienthoai.Text = dataGridView2.Rows[x].Cells[3].Value.ToString();
            txt_mshhdh.Text = dataGridView2.Rows[x].Cells[4].Value.ToString();
            txt_tenhangdh.Text = dataGridView2.Rows[x].Cells[5].Value.ToString();
            txt_soluong.Text = dataGridView2.Rows[x].Cells[6].Value.ToString();
            txt_giadh.Text = dataGridView2.Rows[x].Cells[7].Value.ToString();
            txt_thanhtien.Text = dataGridView2.Rows[x].Cells[8].Value.ToString();
            dateTimePicker2.Text = dataGridView2.Rows[x].Cells[9].Value.ToString();
        }

        private void btn_themhd_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Insert into HDChiTietDatHang values ('" + txt_msdh.Text + "','" + txt_hotenkhachhang.Text + "','" + txt_diachi.Text + "','" + txt_sodienthoai.Text + "','" + txt_mshhdh.Text + "','" + txt_tenhangdh.Text + "','" + txt_soluong.Text + "','" + txt_giadh.Text + "','" + txt_thanhtien.Text + "','" + dateTimePicker2.Value.ToString() + "')";
                command.ExecuteNonQuery();
                LoadHoaDon();
                MessageBox.Show("Đã thêm hóa đơn thành công!", "Thông báo");

                string tongsl = txt_tongsoluong.Text;
                int tongsoluong;
                bool isParsable = Int32.TryParse(tongsl, out tongsoluong);

                string soluong = txt_soluong.Text;
                int sl;
                bool isParsable1 = Int32.TryParse(soluong, out sl);

                int slconlai = 0;
                slconlai = tongsoluong - sl;
                txt_tongsoluong.Text = slconlai.ToString();
                command = connection.CreateCommand();
                command.CommandText = "update HangHoa set MSHH='" + txt_mshh.Text + "',TenHang='" + txt_tenhang.Text + "',KhoiLuong='" + txt_khoiluong.Text + "',DonVi='" + txt_donvi.Text + "',Gia='" + txt_gia.Text + "',TongSoLuong='" + txt_tongsoluong.Text + "',NgayNhapKho='" + dateTimePicker1.Value.ToString() + "'Where MSHH='" + txt_mshh.Text + "'";
                command.ExecuteNonQuery();
                LoadData();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại mã số hàng hóa !", "Cảnh Báo!");
            }
        }

        private void btn_xoahd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from HDChiTietDatHang where MSDH='" + txt_msdh.Text + "'";
            command.ExecuteNonQuery();
            LoadHoaDon();
            MessageBox.Show("Đã xóa hóa đơn thành công!", "Thông báo");
        }

        private void btn_suahd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update HDChiTietDatHang set MSDH='" + txt_msdh.Text + "',HoTenKhachHang='" + txt_hotenkhachhang.Text + "',DiaChi='" + txt_diachi.Text + "',SoDienThoai='" + txt_sodienthoai.Text + "',MSHH='" + txt_mshhdh.Text + "',TenHang='" + txt_tenhangdh.Text + "',SoLuong='" + txt_soluong.Text + "',Gia='" + txt_giadh.Text + "',ThanhTien='" + txt_thanhtien.Text + "',NgayDatHang='" + dateTimePicker2.Value.ToString() + "'Where MSDH='" + txt_msdh.Text + "'";
            command.ExecuteNonQuery();
            LoadHoaDon();
            MessageBox.Show("Đã sửa hóa đơn thành công!", "Thông báo");
        }

        private void btn_khoitao_Click(object sender, EventArgs e)
        {
            txt_msdh.Text = "";
            txt_hotenkhachhang.Text = "";
            txt_diachi.Text = "";
            txt_sodienthoai.Text = "";
            txt_mshhdh.Text = "";
            txt_tenhangdh.Text = "";
            txt_soluong.Text = "";
            txt_giadh.Text = "";
            txt_thanhtien.Text = "";
            dateTimePicker2.Text = "";
        }

        private void btn_capnhathd_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void btn_timkhach_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HDChiTietDatHang where HoTenKhachHang like '%" + txt_hotenkhachhang.Text + "%'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void btn_timhd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HDChiTietDatHang where MSDH= '" + txt_msdh.Text + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void btn_laythongtin_Click(object sender, EventArgs e)
        {
            txt_mshhdh.Text = txt_mshh.Text;
            txt_tenhangdh.Text = txt_tenhang.Text;
            txt_giadh.Text = txt_gia.Text;
        }

        private void btn_ttkm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quý Khách Khi Mua Một Số Lượng Nhất Định Cùng Một Sản Phẩm Sẽ Được Ưu Đãi \n " +
                "Mua 10 Sản Phẩm Cùng Loại Giảm 5% Giá Mỗi Sản Phẩm \n " +
                "Mua 20 Sản PHẩm Cùng Loại Giảm 10% Giá Mỗi Sản Phẩm \n " +
                "Sau Khi Nhập Số Lượng Sản Phẩm Cần Mua Vui Lòng Nhấn Nút Áp Dụng Khuyến Mãi Để Đươc Mức Giá Ưu Đãi!", "Chương Trình Khuyến Mãi!");
        }

        private void btn_apdungkm_Click(object sender, EventArgs e)
        {
            string soluong = txt_soluong.Text;
            int sl;
            bool isParsable = Int32.TryParse(soluong, out sl);

            string gia = txt_giadh.Text;
            int giadh;
            bool isParsable1 = Int32.TryParse(gia, out giadh);

            if (sl >= 10 && sl < 20)
            {
                giadh = giadh - (giadh * 5) / 100;
            }

            if (sl >= 20)
            {
                giadh = giadh - (giadh * 10) / 100;
            }

            txt_giadh.Text = giadh.ToString();

            MessageBox.Show("Khuyến Mãi Chỉ Được Áp Dụng 1 Lần Cho Mỗi Hóa Đơn!\n Nếu Thay Đổi Số Lượng Thì Cần Nhập Lại Giá Ban Đầu Của Sản Phẩm!", "Chú Ý!");
        }

        private void btn_thanhtien_Click(object sender, EventArgs e)
        {
            string soluong = txt_soluong.Text;
            int sl;

            bool isParsable = Int32.TryParse(soluong, out sl);

            string gia = txt_giadh.Text;
            int giadh;
            bool isParsable1 = Int32.TryParse(gia, out giadh);

            int giatien = sl * giadh;

            txt_thanhtien.Text = giatien.ToString();
        }

        private void btn_kiemtrahh_Click(object sender, EventArgs e)
        {
            string tongsl = txt_tongsoluong.Text;
            int tongsoluong;
            bool isParsable = Int32.TryParse(tongsl, out tongsoluong);

            txt_tsl.Text = tongsoluong.ToString();

            string soluong = txt_soluong.Text;
            int sl;
            bool isParsable1 = Int32.TryParse(soluong, out sl);

            txt_sl.Text = sl.ToString();
            

            if (tongsoluong < sl)
            {
                MessageBox.Show("Không Còn Đủ Số Lượng Hàng Hóa Quý Khách Yêu Cầu\n Vui Lòng Kiểm Tra Lại!", "Chú Ý!");
                
                

            }
            else
            {
                MessageBox.Show("Có đủ số lượng quý khách yêu cầu!", "Thông báo");
            }

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            var DR = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Cảnh Báo", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_hinhanh_Click(object sender, EventArgs e)
        {
            this.Hide();
            HinhanhSP hinhanhsp = new HinhanhSP();
            hinhanhsp.Show();
        }
    }
}

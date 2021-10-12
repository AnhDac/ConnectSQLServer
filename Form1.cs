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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        string strConnectionString = "Data Source=DESKTOP-7OU0031\\SQLEXPRESS;"
        + "Initial Catalog=PHONGTRO;"
        + "Integrated Security=True";
        // Đối tượng kết nối
        SqlConnection conn = null;

        SqlDataAdapter daPhongTro = null;
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtPhongTro = null;
        void LoadData(string nametable)
        {
            try
            {
                // Khởi động connection
                conn = new SqlConnection(strConnectionString);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                // Vận chuyển dữ liệu vào DataTable dtThanhPho
                daPhongTro = new SqlDataAdapter(
                    "SELECT * FROM "+ nametable, conn);
                dtPhongTro = new DataTable();
                dtPhongTro.Clear();
                daPhongTro.Fill(dtPhongTro);

                dgvPhongTro.DataSource = dtPhongTro;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table. Lỗi rồi!!!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvPhongTro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhongTro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            LoadData("NhanVien");
            
        }

        private void btnShowNV_Click(object sender, EventArgs e)
        {
            LoadData("NhanVien");

        }

        private void btnShowPhongTro_Click(object sender, EventArgs e)
        {
            LoadData("Phong");
        }
    }
}

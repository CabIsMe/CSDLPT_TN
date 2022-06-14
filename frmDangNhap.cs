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

namespace TNCSDLPT
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
       
        private void layDSPM(string cmd)
        {
            DataTable dt =new  DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
        }

        public frmDangNhap()
        {
            InitializeComponent();
        }
        private int KETNOI_CSDL_GOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu gốc");
                return 0;
            }
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KETNOI_CSDL_GOC() == 0) { return; }
            layDSPM("select * from V_DS_PHANMANH");
            cmbCoSo.SelectedIndex = 1;
            cmbCoSo.SelectedIndex = 0;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text.Trim() == "" || textBoxPass.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật khẩu không được để trống \n", "", MessageBoxButtons.OK);
                return;
            }
            if (cbGiangVien.Checked == true)
            {
                Program.mlogin = textBoxUser.Text; Program.password = textBoxPass.Text;
                if (Program.KetNoi() == 0) return;
                Program.mCoSo = cmbCoSo.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                string strLenh = "EXEC SP_DANGNHAP_GV '" + Program.mlogin + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn đăng nhập không có quyền đăng nhập dữ liệu\n Bạn xem lại username, password", "");
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                
                Program.myReader.Close();
            }
            else if(cbSinhVien.Checked==true)
            {
                Program.mlogin = "sinhvien"; Program.password = "123";
                if (Program.KetNoi() == 0) return;
                Program.mCoSo = cmbCoSo.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                Program.svLogin = textBoxUser.Text.Trim();
                Program.svPass = textBoxPass.Text.Trim();
                string strLenh = "EXEC SP_DANGNHAP_SV '" + textBoxUser.Text.Trim() + "',"+"'"+ textBoxPass.Text.Trim()+"'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return; 
                Program.myReader.Read();
                if (Program.myReader.IsDBNull(0))
                {
                    MessageBox.Show("Sai mật khẩu hoặc mã sinh viên");
                    return;
                }
                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn đăng nhập không có quyền đăng nhập dữ liệu\n Bạn xem lại username, password", "");
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
            }
            else
            {
                MessageBox.Show("Chưa chọn đối tượng đăng nhập Giảng viên/Sinh viên");
                return;
            }
            MessageBox.Show("Ket noi thanh cong");
            Program.conn.Close();
            Program.frmChinh.HienThiMenu();
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbCoSo.SelectedValue.ToString();

            }
            catch
            {

            }
        }

        private void cbGiangVien_CheckedChanged(object sender, EventArgs e)
        {
            
            cbSinhVien.Checked = !cbGiangVien.Checked;
        }

        private void cbSinhVien_CheckedChanged(object sender, EventArgs e)
        {
           
            cbGiangVien.Checked= !cbSinhVien.Checked;
        }
    }
}

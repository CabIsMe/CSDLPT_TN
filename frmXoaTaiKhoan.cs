using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNCSDLPT
{
    public partial class frmXoaTaiKhoan : Form
    {
        public frmXoaTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmXoaTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Program.myReader = Program.ExecSqlDataReader("EXEC Xoa_Login '" + tbLoginName.Text.ToString().Trim() + "','" + tbMaGv.Text.ToString().Trim() + "'");
                    Program.myReader.Close();
                    MessageBox.Show("XÓA TÀI KHOẢN THÀNH CÔNG");
                }
                catch
                {
                    MessageBox.Show("Lỗi không thể xóa tài khoản!");
                    return;
                }
            }
            else
            {
                return;
            }
            
        }
    }
}

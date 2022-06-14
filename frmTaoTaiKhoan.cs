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
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "TRUONG")
            {
                cmbRole.SelectedText = "TRUONG";
                cmbRole.Enabled = false;
            }
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.mGroup == "COSO")
                {
                    Program.myReader = Program.ExecSqlDataReader("EXEC SP_TAOLOGIN '" + tbLoginName.Text.ToString().Trim() + "','" + tbPassword.Text.ToString().Trim() + "','" + tbMaGV.Text.ToString().Trim() + "','" + cmbRole.Text + "'");
                    Program.myReader.Close();
                    MessageBox.Show("TẠO TÀI KHOẢN THÀNH CÔNG");
                }
                else
                {
                    Program.myReader = Program.ExecSqlDataReader("EXEC SP_TAOLOGIN '" + tbLoginName.Text.ToString().Trim() + "','" + tbPassword.Text.ToString().Trim() + "','" + tbMaGV.Text.ToString().Trim() + "','TRUONG'");
                    Program.myReader.Close();
                    MessageBox.Show("TẠO TÀI KHOẢN THÀNH CÔNG");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi tạo tài khoản \n" + ex.Message);
                
                return;
            }
        }
    }
}

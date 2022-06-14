using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace TNCSDLPT
{
    public partial class Xfrm_InKetQuaThi : Form
    {
        public Xfrm_InKetQuaThi()
        {
            InitializeComponent();
        }
        private void LayDSMonHoc()
        {          
            cmbMaMh.DataSource = Program.ExecSqlDataTable("SELECT DISTINCT MAMH FROM BANGDIEM");
            cmbMaMh.DisplayMember = "MAMH";
            cmbMaMh.ValueMember = "MAMH";
        }
        private void Xfrm_InKetQuaThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.tN_CSDLPTDataSet.V_DS_PHANMANH);
            cmbCoSo.SelectedIndex = Program.mCoSo;
            cmbCoSo.DataSource = Program.bds_dspm;
            LayDSMonHoc();
            if (Program.mGroup == "TRUONG")
                cmbCoSo.Enabled = true;
            else
                cmbCoSo.Enabled = false;
        }

        private void buttonInKetQua_Click(object sender, EventArgs e)
        {

            try
            {
                Xrpt_InKetQuaThi rpt = new Xrpt_InKetQuaThi(tbMaSv.Text.ToString().Trim(), cmbMaMh.Text.ToString().Trim(), Int16.Parse(cmbLan.Text.ToString().Trim()));
                Program.myReader = Program.ExecSqlDataReader("exec SP_THONGTIN_BANGKETQUA '" + tbMaSv.Text.ToString().Trim() + "','" + cmbMaMh.Text.ToString().Trim() + "','" + Int16.Parse(cmbLan.Text.ToString().Trim()) + "'");
                Program.myReader.Read();
                rpt.xrLabelLop.Text = Program.myReader.GetString(0);
                rpt.xrLabelHoTen.Text = Program.myReader.GetString(1);
                rpt.xrLabelMonThi.Text = Program.myReader.GetString(2);
                rpt.xrLabelNgayThi.Text = Program.myReader.GetDateTime(3).ToShortDateString();
                rpt.xrLabelLan.Text = Program.myReader.GetInt16(4).ToString();
                rpt.xrTableCellSTT.Text = Int16.Parse(rpt.xrTableCellSTT.Text).ToString();
                rpt.xrLabelNguoiTaoForm.Text = Program.mHoten;
                Program.myReader.Close();
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n"+"Kiểm tra lại mã số sinh viên, mã môn học hoặc lần thi!");
                Program.myReader.Close();
                return;
            }


        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") // ktra xem co so lieu k
                return;
            Program.servername = cmbCoSo.SelectedValue.ToString();
            if (cmbCoSo.SelectedIndex != Program.mCoSo)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
            }
            
        }
    }
}

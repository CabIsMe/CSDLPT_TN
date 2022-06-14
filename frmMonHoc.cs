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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }


        int pos = 0;
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            
                dS.EnforceConstraints = false; // bắt buộc kiểm tra ràng buộc= false
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);

            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

            //maCS =((DataRowView)bdsMH)

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoSo;
            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                btnGhiMH.Enabled = btnHieuChinhMH.Enabled = btnPhucHoiMH.Enabled = btnThemMH.Enabled =btnXoaMH.Enabled= false;
            }
            if (Program.mGroup == "GV")
            {
                cmbCoSo.Enabled = false;
                btnGhiMH.Enabled = btnHieuChinhMH.Enabled = btnPhucHoiMH.Enabled = btnThemMH.Enabled = btnXoaMH.Enabled = false;
            }
            if(Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
                btnGhiMH.Enabled = btnHieuChinhMH.Enabled = btnPhucHoiMH.Enabled = btnThemMH.Enabled = btnXoaMH.Enabled = true;
            }
            
            
        }

        private void barDockControlTop_Click(object sender, EventArgs e)
        {

        }



        private void btnThemMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pos = bdsMH.Position;
            groupBox1.Enabled = true;
            bdsMH.AddNew();

            btnThemMH.Enabled = btnHieuChinhMH.Enabled = btnXoaMH.Enabled = btnReloadMH.Enabled = btnThoatMH.Enabled = false;
            btnGhiMH.Enabled= btnPhucHoiMH.Enabled = true;
            gcMonHoc.Enabled = false;
        }

        private void btnPhucHoiMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMH.CancelEdit();
            if (btnThemMH.Enabled == false) bdsMH.Position = pos;
            gcMonHoc.Enabled = true;
            groupBox1.Enabled = false;
            btnThemMH.Enabled = btnHieuChinhMH.Enabled = btnXoaMH.Enabled = btnReloadMH.Enabled = btnThoatMH.Enabled = true;
            btnGhiMH.Enabled = btnPhucHoiMH.Enabled = false;
        }

        private void btnHieuChinhMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pos = bdsMH.Position;
            groupBox1.Enabled = true;
            btnThemMH.Enabled = btnHieuChinhMH.Enabled = btnXoaMH.Enabled = btnReloadMH.Enabled = btnThoatMH.Enabled = false;
            btnGhiMH.Enabled = btnPhucHoiMH.Enabled = true;
            gcMonHoc.Enabled = false;
        }

        private void btnReloadMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoaMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBD.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã tồn tại bộ đề môn này", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có giáo viên đăng ký môn này", "", MessageBoxButtons.OK);
                return;

            }
            if (bdsBANGDIEM.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã tồn tại bảng điểm môn này", "", MessageBoxButtons.OK);
                return;
            }
            string MaMH="";
            if(MessageBox.Show("Bạn có thật sự muốn xóa môn học này ?? ","Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    MaMH = (string)(((DataRowView)bdsMH[bdsMH.Position])["MAMH"].ToString());
                    bdsMH.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    bdsMH.Position = bdsMH.Find("MAMH",MaMH);
                }
            }
            if (bdsMH.Count == 0) btnXoaMH.Enabled = false;
        }

        private void btnGhiMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống!", "", MessageBoxButtons.OK);
                tbMaMH.Focus();
                return;
            }
            if (tbTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được để trống!", "", MessageBoxButtons.OK);
                tbTenMH.Focus();
                return;
            }
            string cmd = "EXEC sp_checkMonHocExist '" + tbMaMH.Text.Trim() + "'";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null)
            {
                MessageBox.Show("Exec SP null", "", MessageBoxButtons.OK);
                return;
            }
            Program.myReader.Read();
            String exist = Program.myReader.GetString(0);
            Program.myReader.Close();
            if (exist == "1")
            {
                MessageBox.Show("Mã môn học bị trùng! \n", "", MessageBoxButtons.OK);
                return;
            }
            try
            {
                bdsMH.EndEdit();
                bdsMH.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.dS.MONHOC);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ghi Môn học. \n"+ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcMonHoc.Enabled = true;
            btnThemMH.Enabled = btnHieuChinhMH.Enabled = btnXoaMH.Enabled = btnReloadMH.Enabled = btnThoatMH.Enabled = true;
            btnGhiMH.Enabled = btnPhucHoiMH.Enabled = false;
        }
        
        private void btnThoatMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                return;
            }


        }
    }
}

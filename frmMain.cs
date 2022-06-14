using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TNCSDLPT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
                    
        }
        private void login_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
                Frm_MonHoc.Enabled = true;
            }
        }
        private void logOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form fm in this.MdiChildren)
            {
                fm.Dispose();
            }
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            ID.Text = "ID";
            HOTEN.Text = "HOTEN";
            NHOM.Text = "NHOM";
            Program.mlogin = "";
            Program.password = "";
            Program.mGroup = "";
            Program.username = "";
            Program.mHoten = "";
            f.Show();

        }

        public void HienThiMenu()
        {
            ID.Text = "ID: " + Program.username;
            HOTEN.Text = "Tên: " + Program.mHoten;
            NHOM.Text = "Nhóm: " + Program.mGroup;
        }
        

        private void frmMain_Load(object sender, EventArgs e)
        {
                  
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void MonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "")
            {
                MessageBox.Show("Bạn chưa đăng nhập!");
                return;
            }
            if (Program.mGroup == "SV")
            {
                MessageBox.Show("Sinh viên không được cấp quyền này!");
            }
            else
            {
                Form frm = this.CheckExists(typeof(frmMonHoc));
                Form frmDN = this.CheckExists(typeof(frmDangNhap));
                if (frmDN != null) frmDN.Close();
                if (frm != null)
                {
                    return;
                }
                else
                {
                    frmMonHoc f = new frmMonHoc();
                    f.MdiParent = this;
                    HienThiMenu();
                    f.Show();
                }
            }
        }
        public void closeForm()
        {
            Form frmMH = this.CheckExists(typeof(frmMonHoc));
            if (frmMH != null) frmMH.Close();
        }

        private void Thi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "")
            {
                MessageBox.Show("Bạn chưa đăng nhập!");
                return;
            }
            Form frm = this.CheckExists(typeof(frmThi));
            Form frmDN = this.CheckExists(typeof(frmDangNhap));
            if (frmDN != null) frmDN.Close();
            if (frm != null)
            {
                return;
            }
            else
            {
                frmThi f = new frmThi();
                f.MdiParent = this;
                HienThiMenu();
                f.Show();
            }
        }

        private void InKetQua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "")
            {
                MessageBox.Show("Bạn chưa đăng nhập!");
                return;
            }
            if (Program.mGroup == "SV")
            {
                MessageBox.Show("Sinh viên không được cấp quyền này!");
            }
            else
            {
                Form frm = this.CheckExists(typeof(Xfrm_InKetQuaThi));
                Form frmDN = this.CheckExists(typeof(frmDangNhap));
                if (frmDN != null) frmDN.Close();
                if (frm != null)
                {
                    return;
                }
                else
                {
                    Xfrm_InKetQuaThi f = new Xfrm_InKetQuaThi();
                    f.MdiParent = this;
                    HienThiMenu();
                    f.Show();
                }
            }
        }

        private void Register_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "")
            {
                MessageBox.Show("Bạn chưa đăng nhập!");
                return;
            }
            if (Program.mGroup == "SV")
            {
                MessageBox.Show("Sinh viên không được cấp quyền này!");
            }
            else
            {
                Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
                Form frmDN = this.CheckExists(typeof(frmDangNhap));
                if (frmDN != null) frmDN.Close();
                if (frm != null)
                {
                    return;
                }
                else
                {
                    frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                    f.MdiParent = this;
                    HienThiMenu();
                    f.Show();
                }
            }
        }

        private void XoaTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "")
            {
                MessageBox.Show("Bạn chưa đăng nhập!");
                return;
            }
            if (Program.mGroup != "COSO")
            {
                MessageBox.Show("Quyền này chỉ dành cho nhóm Cơ sở!");
                return;
            }
            else
            {
                Form frm = this.CheckExists(typeof(frmXoaTaiKhoan));
                Form frmDN = this.CheckExists(typeof(frmDangNhap));
                if (frmDN != null) frmDN.Close();
                if (frm != null)
                {
                    return;
                }
                else
                {
                    frmXoaTaiKhoan f = new frmXoaTaiKhoan();
                    f.MdiParent = this;
                    HienThiMenu();
                    f.Show();
                }
            }
        }
    }
}

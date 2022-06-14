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
    public partial class frmThi : Form
    {
        //List<string> MyList_LuuDapAn = new List<string>();
        int phut = 0;
        int giay = 60;
        int cauSo = 0;
        int SoCauHoi = 0;
        DataTable dt = new DataTable();
        public frmThi()
        {
            InitializeComponent();
        }


        private void LayDSMT(string cmd)
        {
            if (Program.KetNoi() == 0)
            {
                return;
            }
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            Program.conn.Close();
            cmbMonHoc.DataSource = dt;       
            cmbMonHoc.DisplayMember = "TENMH";
            cmbMonHoc.ValueMember = "MAMH";
            
            //cmbLan.Enabled = true;
        }
        private void LayDSNgayThi(string cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            Program.conn.Close();
            cmbNgayThi.DataSource = dt;
            cmbNgayThi.DisplayMember = "NGAYTHI";
            cmbNgayThi.ValueMember = "NGAYTHI";
            
        }
        private void LayDSLanThi(string cmd)
        {
            try
            {
                DataTable dt = new DataTable();
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
                da.Fill(dt);
                Program.conn.Close();
                cmbLan.DataSource = dt;
                cmbLan.DisplayMember = "LAN";
                cmbLan.ValueMember = "LAN";
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
                    
            }
        }

        private void ShowDapAn()
        {
            lvDapAn.Columns.Add("Câu số", 100);
            lvDapAn.Columns.Add("Đáp án", 100);
            DataTable dt = Program.ExecSqlDataTable("select * from BAITHI where MaBD='" + Program.svLogin.Trim() + cmbMonHoc.SelectedValue.ToString().Trim() + cmbLan.SelectedValue.ToString().Trim() + "'");
            for(int i=0;i< dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem((i+1).ToString());
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                item.SubItems.Add(dr[8].ToString());                
                item.SubItems.Add(subitem);
                lvDapAn.Items.Add(item);
            }
            
        }
        private void frmThi_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "SV")
            {
                lbHoTen.Text = Program.mHoten;
                string cmd = "EXEC SP_THONGTIN_SINHVIEN" + "'" + Program.svLogin + "', '" + Program.svPass + "'";
                Program.myReader = Program.ExecSqlDataReader(cmd);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                lbMaLop.Text = Program.myReader.GetString(0);
                lbTenLop.Text = Program.myReader.GetString(1);
                LayDSMT("select DISTINCT MAMH, TENMH from f_CHECKMONTHI('"+ lbMaLop.Text.Trim() + "')");
                LayDSNgayThi("select CONVERT(VARCHAR,NGAYTHI,103) as NGAYTHI FROM f_CHECKMONTHI('" + lbMaLop.Text.Trim() + "') where MAMH= '" + cmbMonHoc.SelectedValue.ToString() + "'");
                LayDSLanThi("select DISTINCT LAN FROM f_CHECKMONTHI('" + lbMaLop.Text.Trim() + "')");
                

                Program.myReader.Close();
                
            }
            if (Program.mGroup == "GV")
            {
                lbHoTen.Text = Program.mHoten;
                LayDSMT("select Distinct MAMH from GIAOVIEN_DANGKY");
                LayDSNgayThi("select Distinct NGAYTHI from GIAOVIEN_DANGKY where MAMH= '"+cmbMonHoc.SelectedValue.ToString().Trim()+"'");
                LayDSLanThi("select Distinct LAN from GIAOVIEN_DANGKY where MAMH='" + cmbMonHoc.SelectedValue.ToString().Trim() + "'");
                lbMaLop.Text = "TH04";
            }
            timer1.Interval = 1000;
            
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonHoc.SelectedIndex != -1)
            {
               
                LayDSNgayThi("select CONVERT(VARCHAR,NGAYTHI,103) as NGAYTHI FROM f_CHECKMONTHI('" + lbMaLop.Text.Trim() + "') where MAMH= '" + cmbMonHoc.SelectedValue.ToString() + "'");
            }
        }
        private void cmbNgayThi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbNgayThi.SelectedIndex != -1)
            {
                LayDSLanThi("select LAN FROM f_CHECKMONTHI('" + lbMaLop.Text.Trim() + "') where MAMH" + "='" + cmbMonHoc.SelectedValue.ToString().Trim() + "' and CONVERT(VARCHAR,NGAYTHI,103)='" + cmbNgayThi.Text + "'");
            }
        }
        private void cmbNgayThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbLan.Enabled = true;
            //LayDSLanThi("select LAN FROM f_CHECKMONTHI('" + lbMaLop.Text.Trim() + "') where MAMH" + "='" + cmbMonHoc.SelectedValue.ToString().Trim() + "' and CONVERT(VARCHAR,NGAYTHI,103)='" + cmbNgayThi.Text + "'");
        }
        private void LayThoiGianThi() {
            Program.myReader = Program.ExecSqlDataReader("select THOIGIAN FROM f_CHECKMONTHI('" + lbMaLop.Text.Trim() + "') where MAMH" + "='" + cmbMonHoc.SelectedValue.ToString().Trim() + "' and LAN='" + cmbLan.SelectedValue.ToString() + "'");
            if (Program.myReader == null) return;
            Program.myReader.Read();        
            phut=Program.myReader.GetInt16(0)-1;
            Program.myReader.Close();
        }
        private void batDauThi_Click(object sender, EventArgs e)
        {
            //buttonBatDau.Enabled = false; 
            
            string cmd = "";
            string cmdTable = "";
            if (Program.mGroup == "SV")
            {
                try
                {
                    Program.myReader = Program.ExecSqlDataReader("EXEC SP_KTLANTHI '" + Program.svLogin + "','" + cmbMonHoc.SelectedValue.ToString().Trim() + "','" + cmbLan.SelectedValue + "'");
                    Program.myReader.Close();
                }
                catch (Exception ex)
                {

                    return;
                }
                cmd = "exec SP_LAYBAITHI '" + lbMaLop.Text.Trim() + "','" + Program.svLogin + "','" + cmbMonHoc.SelectedValue.ToString().Trim() + "'," + cmbLan.SelectedValue ;             
                cmdTable = "select * from BAITHI where MaBD='" + Program.svLogin.Trim() + cmbMonHoc.SelectedValue.ToString().Trim() + cmbLan.SelectedValue.ToString().Trim() + "'";
                
            }
            if (Program.mGroup == "GV")
            {
                cmd = "exec SP_THI_THU '" + lbMaLop.Text.Trim() + "','" + Program.mlogin + "','" + cmbMonHoc.SelectedValue.ToString().Trim() + "'," + cmbLan.SelectedValue ;
                cmdTable = "select * from BAITHI where MaBD='" + Program.mlogin.Trim() + cmbMonHoc.SelectedValue.ToString().Trim() + cmbLan.SelectedValue.ToString().Trim() + "'";
                
            }
            if (Program.KetNoi() == 0) return;
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null) return;
            
            Program.myReader.Close();
            panelLamBaiThi.Enabled = true;          
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmdTable, Program.conn);
            da.Fill(dt);
            Program.conn.Close();
            
            lbNoiDung.Text = dt.Rows[0]["NoiDung"].ToString();
            lbCauHoi.Text = "Câu " + (cauSo + 1).ToString();
            lbDapAnA.Text = dt.Rows[0]["A"].ToString();
            lbDapAnB.Text = dt.Rows[0]["B"].ToString();
            lbDapAnC.Text = dt.Rows[0]["C"].ToString();
            lbDapAnD.Text = dt.Rows[0]["D"].ToString();
            DapAnDaChon(KtraDapAn());
            LayThoiGianThi();
            timer1.Start();
            ShowDapAn();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (cauSo != dt.Rows.Count-1)
            {
                buttonNext.Enabled = true;
                buttonBack.Enabled = true;
                cauSo++;
                lbNoiDung.Text = dt.Rows[cauSo]["NoiDung"].ToString();
                lbCauHoi.Text ="Câu "+ (cauSo+1).ToString();
                lbDapAnA.Text = dt.Rows[cauSo]["A"].ToString();
                lbDapAnB.Text = dt.Rows[cauSo]["B"].ToString();
                lbDapAnC.Text = dt.Rows[cauSo]["C"].ToString();
                lbDapAnD.Text = dt.Rows[cauSo]["D"].ToString();
                DapAnDaChon(KtraDapAn());
                lvDapAn.Clear();
                ShowDapAn();


            }
            else
            {
                buttonNext.Enabled = false;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (cauSo != 0)
            {
                buttonBack.Enabled = true;
                buttonNext.Enabled = true;
                cauSo--;
                lbNoiDung.Text = dt.Rows[cauSo]["NoiDung"].ToString();
                lbCauHoi.Text = "Câu " + (cauSo+1).ToString();
                lbDapAnA.Text = dt.Rows[cauSo]["A"].ToString();
                lbDapAnB.Text = dt.Rows[cauSo]["B"].ToString();
                lbDapAnC.Text = dt.Rows[cauSo]["C"].ToString();
                lbDapAnD.Text = dt.Rows[cauSo]["D"].ToString();
                DapAnDaChon(KtraDapAn());
                lvDapAn.Clear();
                ShowDapAn();
            }
            else
            {
                buttonBack.Enabled = false;
            }
        }
        private string KtraDapAn()
        {
            string dA = "";
            string cmd = "select DaChon from BAITHI where CauHoi='" + dt.Rows[cauSo]["CauHoi"].ToString() + "'";
            if (Program.KetNoi() != 0)
            {
                Program.myReader = Program.ExecSqlDataReader(cmd);

                Program.myReader.Read();
                if (Program.myReader.IsDBNull(0))
                {
                    dA = "X";
                }
                else dA = Program.myReader.GetString(0);
                Program.myReader.Close();                
            }
            return dA;
        }
        private void DapAnDaChon(String dapAn)
        {
            if (dapAn=="A")
            {
                rB_A.Checked = true;
            }
            else if (dapAn == "B")
            {
                rB_B.Checked = true;
            }
            else if (dapAn == "C")
            {
                rB_C.Checked = true;
            }
            else if(dapAn== "D")
            {
                rB_D.Checked = true;
            }
            else
            {
                rB_A.Checked = rB_B.Checked = rB_C.Checked = rB_D.Checked = false;
            }
        }


        private void rB_A_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_A.Checked == true)
            {
                
                string cmdUpdate = "Update BAITHI set DaChon='A' where CauHoi='"+ dt.Rows[cauSo]["CauHoi"].ToString()+"'";
                if (Program.ExecSqlNonQuery(cmdUpdate) != 0) return;
                
            }
        }

        private void rB_B_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_B.Checked == true)
            {
                
                string cmdUpdate = "Update BAITHI set DaChon='B' where CauHoi='" + dt.Rows[cauSo]["CauHoi"].ToString() + "'";
                if (Program.ExecSqlNonQuery(cmdUpdate) != 0) return;
                
            }
        }

        private void rB_C_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_C.Checked == true)
            {
                
                string cmdUpdate = "Update BAITHI set DaChon='C' where CauHoi='" + dt.Rows[cauSo]["CauHoi"].ToString() + "'";
                if (Program.ExecSqlNonQuery(cmdUpdate) != 0) return;
                
            }
        }

        private void rB_D_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_D.Checked == true)
            {
                
                string cmdUpdate = "Update BAITHI set DaChon='D' where CauHoi='" + dt.Rows[cauSo]["CauHoi"].ToString() + "'";
                if (Program.ExecSqlNonQuery(cmdUpdate) != 0) return;
                
            }
        }
        private void ChamDiem() {
            Program.myReader = Program.ExecSqlDataReader("EXEC SP_CHAMDIEM '"+Program.svLogin+"','"+ cmbMonHoc.SelectedValue.ToString().Trim().ToString().Trim()+"','"+cmbLan.SelectedValue.ToString().Trim()+"'");
            if (Program.myReader == null) return;
            try
            {
                Program.myReader.Read();
                MessageBox.Show("ĐIỂM CỦA BẠN LÀ: "+Program.myReader.GetDouble(0).ToString());
                Program.myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chấm điểm!",""+ ex.Message);
                Program.myReader.Close();
            }
            

        }
        private void ChamDiemThu()
        {
            Program.myReader = Program.ExecSqlDataReader("select count(CauHoi) from BAITHI where MaBD='" + Program.mlogin.ToString().Trim() + cmbMonHoc.SelectedValue.ToString().Trim().ToString().Trim() + cmbLan.SelectedValue.ToString().Trim() + "'");
            Program.myReader.Read();
            SoCauHoi = Program.myReader.GetInt32(0);
            Program.myReader.Close();

            Program.myReader = Program.ExecSqlDataReader("SELECT COUNT(*) FROM BAITHI WHERE MaBD='" + Program.mlogin.Trim() + cmbMonHoc.SelectedValue.ToString().Trim().ToString().Trim() + cmbLan.SelectedValue.ToString().Trim() + "' AND DapAn=DaChon");
            Program.myReader.Read();
            int dapAnDung = Program.myReader.GetInt32(0);
            double diem = 10 * ((double)dapAnDung / (double)SoCauHoi);
            diem = Math.Round(diem, 1);
            MessageBox.Show("ĐIỂM CỦA BẠN LÀ: " + diem.ToString());
            Program.myReader.Close();
        }
        private void buttonNopBai_Click(object sender, EventArgs e)
        {
            if (Program.mGroup == "SV")
            {
                DialogResult dr;
                dr = MessageBox.Show("Bạn có muốn nộp bài ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ChamDiem();
                    timer1.Stop();
                    this.Dispose();
                }
                else
                {
                    return;
                }
            }
            if (Program.mGroup == "GV")
            {
                ChamDiemThu();
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //int i = 10;
            giay--;           
            if (giay == 0) {
                phut--;
                giay = 60;
            }
            lbTime.Text = phut.ToString()+" : "+giay.ToString();
            if (phut == 0) {
                timer1.Stop();
                panelLamBaiThi.Enabled = false;
            }
        }

        private void lvDapAn_Click(object sender, EventArgs e)
        {
            if (lvDapAn.SelectedItems.Count > 0)
            {
                cauSo = lvDapAn.FocusedItem.Index;
                lbNoiDung.Text = dt.Rows[cauSo]["NoiDung"].ToString();
                lbCauHoi.Text = "Câu " + (cauSo+1).ToString();
                lbDapAnA.Text = dt.Rows[cauSo]["A"].ToString();
                lbDapAnB.Text = dt.Rows[cauSo]["B"].ToString();
                lbDapAnC.Text = dt.Rows[cauSo]["C"].ToString();
                lbDapAnD.Text = dt.Rows[cauSo]["D"].ToString();
                DapAnDaChon(KtraDapAn());
                lvDapAn.Clear();
                ShowDapAn();
            }
            
            
        }
    }
}

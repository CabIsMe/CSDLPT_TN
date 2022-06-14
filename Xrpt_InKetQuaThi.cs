using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TNCSDLPT
{
    public partial class Xrpt_InKetQuaThi : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_InKetQuaThi(string maSV, string maMH, Int16 lan)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maSV;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = maMH;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lan;
            this.sqlDataSource1.Fill();
        }
    }
}

namespace TNCSDLPT
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.login = new DevExpress.XtraBars.BarButtonItem();
            this.Register = new DevExpress.XtraBars.BarButtonItem();
            this.logOut = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.Frm_MonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.printPreviewStaticItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.printPreviewStaticItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
            this.Frm_Thi = new DevExpress.XtraBars.BarButtonItem();
            this.Frm_InKetQua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageHT = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ID = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.tN_CSDLPTDataSet1 = new TNCSDLPT.TN_CSDLPTDataSet();
            this.fieldListDockPanel1 = new DevExpress.XtraReports.UserDesigner.FieldListDockPanel();
            this.fieldListDockPanel1_Container = new DevExpress.XtraReports.UserDesigner.DesignControlContainer();
            this.reportExplorerDockPanel1 = new DevExpress.XtraReports.UserDesigner.ReportExplorerDockPanel();
            this.reportExplorerDockPanel1_Container = new DevExpress.XtraReports.UserDesigner.DesignControlContainer();
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.panelContainer2 = new DevExpress.XtraBars.Docking.DockPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet1)).BeginInit();
            this.fieldListDockPanel1.SuspendLayout();
            this.reportExplorerDockPanel1.SuspendLayout();
            this.panelContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AutoHideEmptyItems = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.login,
            this.Register,
            this.logOut,
            this.barButtonGroup1,
            this.barButtonItem2,
            this.Frm_MonHoc,
            this.printPreviewStaticItem1,
            this.barStaticItem2,
            this.barButtonItem1,
            this.printPreviewStaticItem2,
            this.Frm_Thi,
            this.Frm_InKetQua,
            this.barButtonItem3});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 134;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageHT});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1,
            this.repositoryItemZoomTrackBar1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1119, 179);
            this.ribbonControl1.TransparentEditors = true;
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // login
            // 
            this.login.Caption = "Đăng Nhập";
            this.login.Glyph = ((System.Drawing.Image)(resources.GetObject("login.Glyph")));
            this.login.Id = 1;
            this.login.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("login.LargeGlyph")));
            this.login.Name = "login";
            this.login.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.login_ItemClick);
            // 
            // Register
            // 
            this.Register.Caption = "Tạo tài khoản";
            this.Register.Id = 2;
            this.Register.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Register.LargeGlyph")));
            this.Register.Name = "Register";
            this.Register.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Register_ItemClick);
            // 
            // logOut
            // 
            this.logOut.Caption = "Đăng xuất";
            this.logOut.Id = 3;
            this.logOut.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("logOut.LargeGlyph")));
            this.logOut.Name = "logOut";
            this.logOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.logOut_ItemClick);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 5;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // Frm_MonHoc
            // 
            this.Frm_MonHoc.Caption = "MÔN HỌC";
            this.Frm_MonHoc.Glyph = ((System.Drawing.Image)(resources.GetObject("Frm_MonHoc.Glyph")));
            this.Frm_MonHoc.Id = 7;
            this.Frm_MonHoc.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Frm_MonHoc.LargeGlyph")));
            this.Frm_MonHoc.Name = "Frm_MonHoc";
            this.Frm_MonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MonHoc_ItemClick);
            // 
            // printPreviewStaticItem1
            // 
            this.printPreviewStaticItem1.Caption = "Nothing";
            this.printPreviewStaticItem1.Id = 124;
            this.printPreviewStaticItem1.LeftIndent = 1;
            this.printPreviewStaticItem1.Name = "printPreviewStaticItem1";
            this.printPreviewStaticItem1.RightIndent = 1;
            this.printPreviewStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.printPreviewStaticItem1.Type = "PageOfPages";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Id = 125;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barStaticItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 128;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime;
            // 
            // printPreviewStaticItem2
            // 
            this.printPreviewStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.printPreviewStaticItem2.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None;
            this.printPreviewStaticItem2.Caption = "100%";
            this.printPreviewStaticItem2.Id = 129;
            this.printPreviewStaticItem2.Name = "printPreviewStaticItem2";
            this.printPreviewStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            this.printPreviewStaticItem2.Type = "ZoomFactorText";
            // 
            // Frm_Thi
            // 
            this.Frm_Thi.Caption = "THI";
            this.Frm_Thi.Id = 131;
            this.Frm_Thi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Frm_Thi.LargeGlyph")));
            this.Frm_Thi.Name = "Frm_Thi";
            this.Frm_Thi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Thi_ItemClick);
            // 
            // Frm_InKetQua
            // 
            this.Frm_InKetQua.Caption = "IN KẾT QUẢ THI";
            this.Frm_InKetQua.Id = 132;
            this.Frm_InKetQua.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Frm_InKetQua.LargeGlyph")));
            this.Frm_InKetQua.Name = "Frm_InKetQua";
            this.Frm_InKetQua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.InKetQua_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa tài khoản";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 133;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XoaTaiKhoan_ItemClick);
            // 
            // ribbonPageHT
            // 
            this.ribbonPageHT.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPageHT.Name = "ribbonPageHT";
            this.ribbonPageHT.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.login);
            this.ribbonPageGroup1.ItemLinks.Add(this.Register);
            this.ribbonPageGroup1.ItemLinks.Add(this.logOut);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "HỆ THỐNG";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.Frm_MonHoc);
            this.ribbonPageGroup2.ItemLinks.Add(this.Frm_Thi);
            this.ribbonPageGroup2.ItemLinks.Add(this.Frm_InKetQua);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // repositoryItemZoomTrackBar1
            // 
            this.repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemZoomTrackBar1.AllowFocused = false;
            this.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemZoomTrackBar1.Maximum = 180;
            this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            this.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = -1;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 622);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1119, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ID
            // 
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(24, 20);
            this.ID.Text = "ID";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(57, 20);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(55, 20);
            this.NHOM.Text = "NHOM";
            // 
            // tN_CSDLPTDataSet1
            // 
            this.tN_CSDLPTDataSet1.DataSetName = "TN_CSDLPTDataSet";
            this.tN_CSDLPTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldListDockPanel1
            // 
            this.fieldListDockPanel1.Controls.Add(this.fieldListDockPanel1_Container);
            this.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.fieldListDockPanel1.ID = new System.Guid("faf69838-a93f-4114-83e8-d0d09cc5ce95");
            this.fieldListDockPanel1.ImageIndex = 0;
            this.fieldListDockPanel1.Location = new System.Drawing.Point(7, 27);
            this.fieldListDockPanel1.Name = "fieldListDockPanel1";
            this.fieldListDockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.fieldListDockPanel1.Size = new System.Drawing.Size(238, 34);
            this.fieldListDockPanel1.Text = "Field List";
            this.fieldListDockPanel1.XRDesignPanel = null;
            // 
            // fieldListDockPanel1_Container
            // 
            this.fieldListDockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            this.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container";
            this.fieldListDockPanel1_Container.Size = new System.Drawing.Size(238, 34);
            this.fieldListDockPanel1_Container.TabIndex = 0;
            // 
            // reportExplorerDockPanel1
            // 
            this.reportExplorerDockPanel1.Controls.Add(this.reportExplorerDockPanel1_Container);
            this.reportExplorerDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.reportExplorerDockPanel1.ID = new System.Guid("fb3ec6cc-3b9b-4b9c-91cf-cff78c1edbf1");
            this.reportExplorerDockPanel1.ImageIndex = 3;
            this.reportExplorerDockPanel1.Location = new System.Drawing.Point(7, 27);
            this.reportExplorerDockPanel1.Name = "reportExplorerDockPanel1";
            this.reportExplorerDockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.reportExplorerDockPanel1.Size = new System.Drawing.Size(238, 34);
            this.reportExplorerDockPanel1.Text = "Report Explorer";
            this.reportExplorerDockPanel1.XRDesignPanel = null;
            // 
            // reportExplorerDockPanel1_Container
            // 
            this.reportExplorerDockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            this.reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container";
            this.reportExplorerDockPanel1_Container.Size = new System.Drawing.Size(238, 34);
            this.reportExplorerDockPanel1_Container.TabIndex = 0;
            // 
            // panelContainer1
            // 
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.panelContainer1.ID = new System.Guid("8ab9cba3-ec63-40d1-ab22-affbf835c3c1");
            this.panelContainer1.Location = new System.Drawing.Point(0, 0);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(250, 99);
            this.panelContainer1.Size = new System.Drawing.Size(250, 199);
            // 
            // panelContainer2
            // 
            this.panelContainer2.ActiveChild = this.fieldListDockPanel1;
            this.panelContainer2.Controls.Add(this.reportExplorerDockPanel1);
            this.panelContainer2.Controls.Add(this.fieldListDockPanel1);
            this.panelContainer2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.panelContainer2.ID = new System.Guid("96468d6a-eb9b-4a40-b1b0-e2453643c9e3");
            this.panelContainer2.Location = new System.Drawing.Point(0, 0);
            this.panelContainer2.Name = "panelContainer2";
            this.panelContainer2.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer2.Size = new System.Drawing.Size(250, 100);
            this.panelContainer2.Tabbed = true;
            this.panelContainer2.Text = "panelContainer2";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 647);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet1)).EndInit();
            this.fieldListDockPanel1.ResumeLayout(false);
            this.reportExplorerDockPanel1.ResumeLayout(false);
            this.panelContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem login;
        private DevExpress.XtraBars.BarButtonItem Register;
        private DevExpress.XtraBars.BarButtonItem logOut;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ID;
        private System.Windows.Forms.ToolStripStatusLabel HOTEN;
        private System.Windows.Forms.ToolStripStatusLabel NHOM;
        private TN_CSDLPTDataSet tN_CSDLPTDataSet1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem Frm_MonHoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem printPreviewStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem printPreviewStaticItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private DevExpress.XtraBars.BarButtonItem Frm_Thi;
        private DevExpress.XtraReports.UserDesigner.FieldListDockPanel fieldListDockPanel1;
        private DevExpress.XtraReports.UserDesigner.DesignControlContainer fieldListDockPanel1_Container;
        private DevExpress.XtraReports.UserDesigner.ReportExplorerDockPanel reportExplorerDockPanel1;
        private DevExpress.XtraReports.UserDesigner.DesignControlContainer reportExplorerDockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer2;
        private DevExpress.XtraBars.BarButtonItem Frm_InKetQua;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}


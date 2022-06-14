namespace TNCSDLPT
{
    partial class frmMonHoc
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinhMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnReloadMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatMH = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.labelCoSo = new System.Windows.Forms.Label();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dS = new TNCSDLPT.DS();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new TNCSDLPT.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TNCSDLPT.DSTableAdapters.TableAdapterManager();
            this.bANGDIEMTableAdapter = new TNCSDLPT.DSTableAdapters.BANGDIEMTableAdapter();
            this.bODETableAdapter = new TNCSDLPT.DSTableAdapters.BODETableAdapter();
            this.gIAOVIEN_DANGKYTableAdapter = new TNCSDLPT.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.gcMonHoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.bdsBD = new System.Windows.Forms.BindingSource(this.components);
            this.bdsBANGDIEM = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTenMH = new System.Windows.Forms.TextBox();
            this.tbMaMH = new System.Windows.Forms.TextBox();
            tENMHLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBANGDIEM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            tENMHLabel.Location = new System.Drawing.Point(162, 111);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(71, 21);
            tENMHLabel.TabIndex = 6;
            tENMHLabel.Text = "TENMH:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            mAMHLabel.Location = new System.Drawing.Point(169, 48);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(64, 21);
            mAMHLabel.TabIndex = 4;
            mAMHLabel.Text = "MAMH:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemMH,
            this.btnGhiMH,
            this.btnXoaMH,
            this.btnPhucHoiMH,
            this.btnReloadMH,
            this.btnThoatMH,
            this.btnHieuChinhMH,
            this.skinBarSubItem1,
            this.barLargeButtonItem1,
            this.barStaticItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(1186, 219);
            this.bar1.Offset = 810;
            this.bar1.Text = "Tools";
            this.bar1.Visible = false;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinhMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoiMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReloadMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemMH
            // 
            this.btnThemMH.Caption = "Thêm";
            this.btnThemMH.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThemMH.Glyph")));
            this.btnThemMH.Id = 0;
            this.btnThemMH.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThemMH.LargeGlyph")));
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemMH_ItemClick);
            // 
            // btnHieuChinhMH
            // 
            this.btnHieuChinhMH.Caption = "Hiệu chỉnh";
            this.btnHieuChinhMH.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHieuChinhMH.Glyph")));
            this.btnHieuChinhMH.Id = 6;
            this.btnHieuChinhMH.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHieuChinhMH.LargeGlyph")));
            this.btnHieuChinhMH.Name = "btnHieuChinhMH";
            this.btnHieuChinhMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinhMH_ItemClick);
            // 
            // btnGhiMH
            // 
            this.btnGhiMH.Caption = "Ghi";
            this.btnGhiMH.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGhiMH.Glyph")));
            this.btnGhiMH.Id = 1;
            this.btnGhiMH.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGhiMH.LargeGlyph")));
            this.btnGhiMH.Name = "btnGhiMH";
            this.btnGhiMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiMH_ItemClick);
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Caption = "Xóa";
            this.btnXoaMH.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoaMH.Glyph")));
            this.btnXoaMH.Id = 2;
            this.btnXoaMH.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXoaMH.LargeGlyph")));
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaMH_ItemClick);
            // 
            // btnPhucHoiMH
            // 
            this.btnPhucHoiMH.Caption = "Phục hồi";
            this.btnPhucHoiMH.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiMH.Glyph")));
            this.btnPhucHoiMH.Id = 3;
            this.btnPhucHoiMH.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiMH.LargeGlyph")));
            this.btnPhucHoiMH.Name = "btnPhucHoiMH";
            this.btnPhucHoiMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoiMH_ItemClick);
            // 
            // btnReloadMH
            // 
            this.btnReloadMH.Caption = "Reload";
            this.btnReloadMH.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReloadMH.Glyph")));
            this.btnReloadMH.Id = 4;
            this.btnReloadMH.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnReloadMH.LargeGlyph")));
            this.btnReloadMH.Name = "btnReloadMH";
            this.btnReloadMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReloadMH_ItemClick);
            // 
            // btnThoatMH
            // 
            this.btnThoatMH.Caption = "Thoát";
            this.btnThoatMH.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThoatMH.Glyph")));
            this.btnThoatMH.Id = 5;
            this.btnThoatMH.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThoatMH.LargeGlyph")));
            this.btnThoatMH.Name = "btnThoatMH";
            this.btnThoatMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatMH_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 10);
            this.barDockControlTop.Size = new System.Drawing.Size(894, 61);
            this.barDockControlTop.Click += new System.EventHandler(this.barDockControlTop_Click);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 490);
            this.barDockControlBottom.Size = new System.Drawing.Size(894, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 71);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 419);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(894, 71);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 419);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "skinBarSubItem1";
            this.skinBarSubItem1.Id = 7;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Id = 8;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "CƠ SỞ";
            this.barStaticItem1.Id = 9;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // labelCoSo
            // 
            this.labelCoSo.AutoSize = true;
            this.labelCoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoSo.Location = new System.Drawing.Point(110, 9);
            this.labelCoSo.Name = "labelCoSo";
            this.labelCoSo.Size = new System.Drawing.Size(62, 17);
            this.labelCoSo.TabIndex = 10;
            this.labelCoSo.Text = "CƠ SỞ:";
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Items.AddRange(new object[] {
            "Cơ sở 1",
            "Cơ sở 2"});
            this.cmbCoSo.Location = new System.Drawing.Point(178, 6);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(287, 24);
            this.cmbCoSo.TabIndex = 11;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbCoSo);
            this.panelControl1.Controls.Add(this.labelCoSo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 71);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(894, 38);
            this.panelControl1.TabIndex = 22;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.dS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = this.bANGDIEMTableAdapter;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.UpdateOrder = TNCSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bANGDIEMTableAdapter
            // 
            this.bANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // gcMonHoc
            // 
            this.gcMonHoc.DataSource = this.bdsMH;
            this.gcMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMonHoc.Location = new System.Drawing.Point(0, 109);
            this.gcMonHoc.MainView = this.gridView1;
            this.gcMonHoc.MenuManager = this.barManager1;
            this.gcMonHoc.Name = "gcMonHoc";
            this.gcMonHoc.Size = new System.Drawing.Size(894, 220);
            this.gcMonHoc.TabIndex = 22;
            this.gcMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gridView1.GridControl = this.gcMonHoc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "FK_GIAOVIEN_DANGKY_MONHOC1";
            this.bdsGVDK.DataSource = this.bdsMH;
            // 
            // bdsBD
            // 
            this.bdsBD.DataMember = "FK_BODE_MONHOC";
            this.bdsBD.DataSource = this.bdsMH;
            // 
            // bdsBANGDIEM
            // 
            this.bdsBANGDIEM.DataMember = "FK_BANGDIEM_MONHOC";
            this.bdsBANGDIEM.DataSource = this.bdsMH;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(tENMHLabel);
            this.groupBox1.Controls.Add(this.tbTenMH);
            this.groupBox1.Controls.Add(mAMHLabel);
            this.groupBox1.Controls.Add(this.tbMaMH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 161);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbTenMH
            // 
            this.tbTenMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMH, "TENMH", true));
            this.tbTenMH.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbTenMH.Location = new System.Drawing.Point(244, 108);
            this.tbTenMH.Name = "tbTenMH";
            this.tbTenMH.Size = new System.Drawing.Size(268, 28);
            this.tbTenMH.TabIndex = 7;
            // 
            // tbMaMH
            // 
            this.tbMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMH, "MAMH", true));
            this.tbMaMH.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbMaMH.Location = new System.Drawing.Point(244, 45);
            this.tbMaMH.Name = "tbMaMH";
            this.tbMaMH.Size = new System.Drawing.Size(268, 28);
            this.tbMaMH.TabIndex = 5;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 515);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcMonHoc);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMonHoc";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Text = "frmMonHoc";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBANGDIEM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThemMH;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinhMH;
        private DevExpress.XtraBars.BarButtonItem btnGhiMH;
        private DevExpress.XtraBars.BarButtonItem btnXoaMH;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiMH;
        private DevExpress.XtraBars.BarButtonItem btnReloadMH;
        private DevExpress.XtraBars.BarButtonItem btnThoatMH;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label labelCoSo;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsMH;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcMonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private System.Windows.Forms.BindingSource bdsBD;
        private DSTableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
        private System.Windows.Forms.BindingSource bdsBANGDIEM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTenMH;
        private System.Windows.Forms.TextBox tbMaMH;
    }
}
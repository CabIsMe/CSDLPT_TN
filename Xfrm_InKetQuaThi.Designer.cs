namespace TNCSDLPT
{
    partial class Xfrm_InKetQuaThi
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
            System.Windows.Forms.Label mAMHLabel;
            this.tableAdapterManager = new TNCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new TNCSDLPT.DS();
            this.cmbLan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaSv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonInKetQua = new System.Windows.Forms.Button();
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new TNCSDLPT.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tN_CSDLPTDataSet = new TNCSDLPT.TN_CSDLPTDataSet();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new TNCSDLPT.TN_CSDLPTDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager1 = new TNCSDLPT.DSTableAdapters.TableAdapterManager();
            this.cmbMaMh = new System.Windows.Forms.ComboBox();
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TNCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DataSource = this.vDSPHANMANHBindingSource;
            this.cmbCoSo.DisplayMember = "TENCS";
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(373, 56);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(300, 28);
            this.cmbCoSo.TabIndex = 1;
            this.cmbCoSo.ValueMember = "TENSERVER";
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHỌN CƠ SỞ:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbLan
            // 
            this.cmbLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLan.FormattingEnabled = true;
            this.cmbLan.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbLan.Location = new System.Drawing.Point(471, 150);
            this.cmbLan.Name = "cmbLan";
            this.cmbLan.Size = new System.Drawing.Size(121, 28);
            this.cmbLan.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lần:";
            // 
            // tbMaSv
            // 
            this.tbMaSv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaSv.Location = new System.Drawing.Point(785, 150);
            this.tbMaSv.Name = "tbMaSv";
            this.tbMaSv.Size = new System.Drawing.Size(100, 26);
            this.tbMaSv.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(657, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã sinh viên:";
            // 
            // buttonInKetQua
            // 
            this.buttonInKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInKetQua.Location = new System.Drawing.Point(413, 248);
            this.buttonInKetQua.Name = "buttonInKetQua";
            this.buttonInKetQua.Size = new System.Drawing.Size(208, 58);
            this.buttonInKetQua.TabIndex = 8;
            this.buttonInKetQua.Text = "IN BÁO CÁO KẾT QUẢ";
            this.buttonInKetQua.UseVisualStyleBackColor = true;
            this.buttonInKetQua.Click += new System.EventHandler(this.buttonInKetQua_Click);
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "GIAOVIEN_DANGKY";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.dS;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(113, 153);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(106, 20);
            mAMHLabel.TabIndex = 8;
            mAMHLabel.Text = "Mã môn học:";
            // 
            // tN_CSDLPTDataSet
            // 
            this.tN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.tN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.tN_CSDLPTDataSet;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BANGDIEMTableAdapter = null;
            this.tableAdapterManager1.BODETableAdapter = null;
            this.tableAdapterManager1.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager1.MONHOCTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = TNCSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbMaMh
            // 
            this.cmbMaMh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaMh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaMh.FormattingEnabled = true;
            this.cmbMaMh.Location = new System.Drawing.Point(245, 150);
            this.cmbMaMh.Name = "cmbMaMh";
            this.cmbMaMh.Size = new System.Drawing.Size(121, 28);
            this.cmbMaMh.TabIndex = 9;
            // 
            // Xfrm_InKetQuaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 328);
            this.Controls.Add(this.cmbMaMh);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.buttonInKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMaSv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCoSo);
            this.Name = "Xfrm_InKetQuaThi";
            this.Text = "Xfrm_InKetQuaThi";
            this.Load += new System.EventHandler(this.Xfrm_InKetQuaThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.ComboBox cmbLan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaSv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonInKetQua;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private TN_CSDLPTDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cmbMaMh;
    }
}
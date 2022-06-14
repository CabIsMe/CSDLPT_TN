namespace TNCSDLPT
{
    partial class frmThi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBatDau = new System.Windows.Forms.Button();
            this.cmbLan = new System.Windows.Forms.ComboBox();
            this.cmbNgayThi = new System.Windows.Forms.ComboBox();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbTenLop = new System.Windows.Forms.Label();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLamBaiThi = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.buttonNopBai = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.rB_B = new System.Windows.Forms.RadioButton();
            this.rB_C = new System.Windows.Forms.RadioButton();
            this.rB_D = new System.Windows.Forms.RadioButton();
            this.rB_A = new System.Windows.Forms.RadioButton();
            this.lbDapAnB = new System.Windows.Forms.Label();
            this.lbDapAnC = new System.Windows.Forms.Label();
            this.lbDapAnD = new System.Windows.Forms.Label();
            this.lbDapAnA = new System.Windows.Forms.Label();
            this.lbNoiDung = new System.Windows.Forms.Label();
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lvDapAn = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panelLamBaiThi.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBatDau);
            this.panel1.Controls.Add(this.cmbLan);
            this.panel1.Controls.Add(this.cmbNgayThi);
            this.panel1.Controls.Add(this.cmbMonHoc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbHoTen);
            this.panel1.Controls.Add(this.lbTenLop);
            this.panel1.Controls.Add(this.lbMaLop);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 193);
            this.panel1.TabIndex = 0;
            // 
            // buttonBatDau
            // 
            this.buttonBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatDau.Location = new System.Drawing.Point(1030, 68);
            this.buttonBatDau.Name = "buttonBatDau";
            this.buttonBatDau.Size = new System.Drawing.Size(136, 52);
            this.buttonBatDau.TabIndex = 21;
            this.buttonBatDau.Text = "Bắt đầu thi";
            this.buttonBatDau.UseVisualStyleBackColor = true;
            this.buttonBatDau.Click += new System.EventHandler(this.batDauThi_Click);
            // 
            // cmbLan
            // 
            this.cmbLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLan.FormattingEnabled = true;
            this.cmbLan.Location = new System.Drawing.Point(609, 143);
            this.cmbLan.Name = "cmbLan";
            this.cmbLan.Size = new System.Drawing.Size(362, 28);
            this.cmbLan.TabIndex = 20;
            // 
            // cmbNgayThi
            // 
            this.cmbNgayThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNgayThi.FormattingEnabled = true;
            this.cmbNgayThi.Location = new System.Drawing.Point(609, 81);
            this.cmbNgayThi.Name = "cmbNgayThi";
            this.cmbNgayThi.Size = new System.Drawing.Size(362, 28);
            this.cmbNgayThi.TabIndex = 19;
            this.cmbNgayThi.SelectedIndexChanged += new System.EventHandler(this.cmbNgayThi_SelectedIndexChanged_1);
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(609, 25);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(362, 28);
            this.cmbMonHoc.TabIndex = 18;
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(529, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lần:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(529, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày thi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Môn học:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(162, 117);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(53, 20);
            this.lbHoTen.TabIndex = 5;
            this.lbHoTen.Text = "label6";
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLop.Location = new System.Drawing.Point(162, 69);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(53, 20);
            this.lbTenLop.TabIndex = 4;
            this.lbTenLop.Text = "label5";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.Location = new System.Drawing.Point(162, 25);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(53, 20);
            this.lbMaLop.TabIndex = 3;
            this.lbMaLop.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp:";
            // 
            // panelLamBaiThi
            // 
            this.panelLamBaiThi.Controls.Add(this.lvDapAn);
            this.panelLamBaiThi.Controls.Add(this.panel2);
            this.panelLamBaiThi.Controls.Add(this.buttonNopBai);
            this.panelLamBaiThi.Controls.Add(this.buttonNext);
            this.panelLamBaiThi.Controls.Add(this.buttonBack);
            this.panelLamBaiThi.Controls.Add(this.rB_B);
            this.panelLamBaiThi.Controls.Add(this.rB_C);
            this.panelLamBaiThi.Controls.Add(this.rB_D);
            this.panelLamBaiThi.Controls.Add(this.rB_A);
            this.panelLamBaiThi.Controls.Add(this.lbDapAnB);
            this.panelLamBaiThi.Controls.Add(this.lbDapAnC);
            this.panelLamBaiThi.Controls.Add(this.lbDapAnD);
            this.panelLamBaiThi.Controls.Add(this.lbDapAnA);
            this.panelLamBaiThi.Controls.Add(this.lbNoiDung);
            this.panelLamBaiThi.Controls.Add(this.lbCauHoi);
            this.panelLamBaiThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLamBaiThi.Enabled = false;
            this.panelLamBaiThi.Location = new System.Drawing.Point(0, 193);
            this.panelLamBaiThi.Name = "panelLamBaiThi";
            this.panelLamBaiThi.Size = new System.Drawing.Size(1235, 445);
            this.panelLamBaiThi.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.lbTime);
            this.panel2.Location = new System.Drawing.Point(662, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 40);
            this.panel2.TabIndex = 33;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTime.Location = new System.Drawing.Point(20, 10);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(38, 20);
            this.lbTime.TabIndex = 29;
            this.lbTime.Text = "--:--";
            // 
            // buttonNopBai
            // 
            this.buttonNopBai.BackColor = System.Drawing.Color.White;
            this.buttonNopBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNopBai.Location = new System.Drawing.Point(883, 370);
            this.buttonNopBai.Name = "buttonNopBai";
            this.buttonNopBai.Size = new System.Drawing.Size(216, 67);
            this.buttonNopBai.TabIndex = 32;
            this.buttonNopBai.Text = "Nộp bài";
            this.buttonNopBai.UseVisualStyleBackColor = false;
            this.buttonNopBai.Click += new System.EventHandler(this.buttonNopBai_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(372, 383);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(127, 41);
            this.buttonNext.TabIndex = 31;
            this.buttonNext.Text = "NEXT";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(116, 383);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 41);
            this.buttonBack.TabIndex = 30;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // rB_B
            // 
            this.rB_B.AutoSize = true;
            this.rB_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_B.Location = new System.Drawing.Point(103, 181);
            this.rB_B.Name = "rB_B";
            this.rB_B.Size = new System.Drawing.Size(42, 24);
            this.rB_B.TabIndex = 11;
            this.rB_B.TabStop = true;
            this.rB_B.Text = "B";
            this.rB_B.UseVisualStyleBackColor = true;
            this.rB_B.CheckedChanged += new System.EventHandler(this.rB_B_CheckedChanged);
            // 
            // rB_C
            // 
            this.rB_C.AutoSize = true;
            this.rB_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_C.Location = new System.Drawing.Point(103, 239);
            this.rB_C.Name = "rB_C";
            this.rB_C.Size = new System.Drawing.Size(42, 24);
            this.rB_C.TabIndex = 10;
            this.rB_C.TabStop = true;
            this.rB_C.Text = "C";
            this.rB_C.UseVisualStyleBackColor = true;
            this.rB_C.CheckedChanged += new System.EventHandler(this.rB_C_CheckedChanged);
            // 
            // rB_D
            // 
            this.rB_D.AutoSize = true;
            this.rB_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_D.Location = new System.Drawing.Point(103, 293);
            this.rB_D.Name = "rB_D";
            this.rB_D.Size = new System.Drawing.Size(43, 24);
            this.rB_D.TabIndex = 9;
            this.rB_D.TabStop = true;
            this.rB_D.Text = "D";
            this.rB_D.UseVisualStyleBackColor = true;
            this.rB_D.CheckedChanged += new System.EventHandler(this.rB_D_CheckedChanged);
            // 
            // rB_A
            // 
            this.rB_A.AutoSize = true;
            this.rB_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_A.Location = new System.Drawing.Point(103, 126);
            this.rB_A.Name = "rB_A";
            this.rB_A.Size = new System.Drawing.Size(41, 24);
            this.rB_A.TabIndex = 8;
            this.rB_A.TabStop = true;
            this.rB_A.Text = "A";
            this.rB_A.UseVisualStyleBackColor = true;
            this.rB_A.CheckedChanged += new System.EventHandler(this.rB_A_CheckedChanged);
            // 
            // lbDapAnB
            // 
            this.lbDapAnB.AutoSize = true;
            this.lbDapAnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDapAnB.Location = new System.Drawing.Point(149, 181);
            this.lbDapAnB.Name = "lbDapAnB";
            this.lbDapAnB.Size = new System.Drawing.Size(62, 20);
            this.lbDapAnB.TabIndex = 7;
            this.lbDapAnB.Text = "Đáp án";
            // 
            // lbDapAnC
            // 
            this.lbDapAnC.AutoSize = true;
            this.lbDapAnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDapAnC.Location = new System.Drawing.Point(149, 239);
            this.lbDapAnC.Name = "lbDapAnC";
            this.lbDapAnC.Size = new System.Drawing.Size(62, 20);
            this.lbDapAnC.TabIndex = 6;
            this.lbDapAnC.Text = "Đáp án";
            // 
            // lbDapAnD
            // 
            this.lbDapAnD.AutoSize = true;
            this.lbDapAnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDapAnD.Location = new System.Drawing.Point(149, 295);
            this.lbDapAnD.Name = "lbDapAnD";
            this.lbDapAnD.Size = new System.Drawing.Size(62, 20);
            this.lbDapAnD.TabIndex = 5;
            this.lbDapAnD.Text = "Đáp án";
            // 
            // lbDapAnA
            // 
            this.lbDapAnA.AutoSize = true;
            this.lbDapAnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDapAnA.Location = new System.Drawing.Point(149, 128);
            this.lbDapAnA.Name = "lbDapAnA";
            this.lbDapAnA.Size = new System.Drawing.Size(62, 20);
            this.lbDapAnA.TabIndex = 4;
            this.lbDapAnA.Text = "Đáp án";
            // 
            // lbNoiDung
            // 
            this.lbNoiDung.AutoSize = true;
            this.lbNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiDung.Location = new System.Drawing.Point(204, 35);
            this.lbNoiDung.Name = "lbNoiDung";
            this.lbNoiDung.Size = new System.Drawing.Size(75, 20);
            this.lbNoiDung.TabIndex = 3;
            this.lbNoiDung.Text = "Nội dung";
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.AutoSize = true;
            this.lbCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCauHoi.Location = new System.Drawing.Point(104, 36);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(66, 20);
            this.lbCauHoi.TabIndex = 2;
            this.lbCauHoi.Text = "Câu hỏi";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lvDapAn
            // 
            this.lvDapAn.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvDapAn.FullRowSelect = true;
            this.lvDapAn.GridLines = true;
            this.lvDapAn.Location = new System.Drawing.Point(935, 0);
            this.lvDapAn.Name = "lvDapAn";
            this.lvDapAn.Size = new System.Drawing.Size(300, 445);
            this.lvDapAn.TabIndex = 34;
            this.lvDapAn.UseCompatibleStateImageBehavior = false;
            this.lvDapAn.View = System.Windows.Forms.View.Details;
            this.lvDapAn.Click += new System.EventHandler(this.lvDapAn_Click);
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 637);
            this.Controls.Add(this.panelLamBaiThi);
            this.Controls.Add(this.panel1);
            this.Name = "frmThi";
            this.Text = "frmThi";
            this.Load += new System.EventHandler(this.frmThi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLamBaiThi.ResumeLayout(false);
            this.panelLamBaiThi.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbTenLop;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBatDau;
        private System.Windows.Forms.ComboBox cmbLan;
        private System.Windows.Forms.ComboBox cmbNgayThi;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelLamBaiThi;
        private System.Windows.Forms.Label lbDapAnB;
        private System.Windows.Forms.Label lbDapAnC;
        private System.Windows.Forms.Label lbDapAnD;
        private System.Windows.Forms.Label lbDapAnA;
        private System.Windows.Forms.Label lbNoiDung;
        private System.Windows.Forms.Label lbCauHoi;
        private System.Windows.Forms.RadioButton rB_A;
        private System.Windows.Forms.RadioButton rB_B;
        private System.Windows.Forms.RadioButton rB_C;
        private System.Windows.Forms.RadioButton rB_D;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button buttonNopBai;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListView lvDapAn;
    }
}
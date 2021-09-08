namespace TN_CSDLPT_HK3
{
    partial class FormThiThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThiThu));
            this.colDapAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDiem = new System.Windows.Forms.Label();
            this.gvKetQua = new System.Windows.Forms.DataGridView();
            this.ColDaChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.rdbCauHoi = new DevExpress.XtraEditors.RadioGroup();
            this.rdbDapAn = new DevExpress.XtraEditors.RadioGroup();
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNhom = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoCauThi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNgayThi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTrinhDo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMon = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnNopBai = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gvKetQua)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbCauHoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbDapAn.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tbcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // colDapAn
            // 
            this.colDapAn.HeaderText = "Đáp Án";
            this.colDapAn.Name = "colDapAn";
            this.colDapAn.ReadOnly = true;
            // 
            // colCauHoi
            // 
            this.colCauHoi.HeaderText = "Câu";
            this.colCauHoi.Name = "colCauHoi";
            this.colCauHoi.ReadOnly = true;
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(658, 261);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(39, 17);
            this.lblDiem.TabIndex = 2;
            this.lblDiem.Text = "Điểm";
            // 
            // gvKetQua
            // 
            this.gvKetQua.AllowUserToAddRows = false;
            this.gvKetQua.AllowUserToDeleteRows = false;
            this.gvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCauHoi,
            this.ColDaChon,
            this.colDapAn});
            this.gvKetQua.Location = new System.Drawing.Point(74, 32);
            this.gvKetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvKetQua.Name = "gvKetQua";
            this.gvKetQua.ReadOnly = true;
            this.gvKetQua.Size = new System.Drawing.Size(381, 250);
            this.gvKetQua.TabIndex = 1;
            // 
            // ColDaChon
            // 
            this.ColDaChon.HeaderText = "Đã chọn";
            this.ColDaChon.Name = "ColDaChon";
            this.ColDaChon.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1327, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.rdbCauHoi);
            this.groupBox2.Controls.Add(this.rdbDapAn);
            this.groupBox2.Controls.Add(this.lbCauHoi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1321, 364);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblTime.Location = new System.Drawing.Point(1186, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(73, 29);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "00:00";
            // 
            // rdbCauHoi
            // 
            this.rdbCauHoi.Location = new System.Drawing.Point(28, 198);
            this.rdbCauHoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbCauHoi.Name = "rdbCauHoi";
            this.rdbCauHoi.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.rdbCauHoi.Properties.Appearance.Options.UseBackColor = true;
            this.rdbCauHoi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.rdbCauHoi.Size = new System.Drawing.Size(1267, 128);
            this.rdbCauHoi.TabIndex = 7;
            this.rdbCauHoi.SelectedIndexChanged += new System.EventHandler(this.rdbCauHoi_SelectedIndexChanged_1);
            // 
            // rdbDapAn
            // 
            this.rdbDapAn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDapAn.Location = new System.Drawing.Point(28, 91);
            this.rdbDapAn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbDapAn.Name = "rdbDapAn";
            this.rdbDapAn.Properties.Appearance.BackColor = System.Drawing.Color.Wheat;
            this.rdbDapAn.Properties.Appearance.Options.UseBackColor = true;
            this.rdbDapAn.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdbDapAn.Size = new System.Drawing.Size(1267, 86);
            this.rdbDapAn.TabIndex = 6;
            this.rdbDapAn.SelectedIndexChanged += new System.EventHandler(this.rdbDapAn_SelectedIndexChanged_1);
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.AutoSize = true;
            this.lbCauHoi.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbCauHoi.Location = new System.Drawing.Point(33, 24);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(74, 24);
            this.lbCauHoi.TabIndex = 5;
            this.lbCauHoi.Text = "Câu 1 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtNhom);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtLan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSoCauThi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNgayThi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTrinhDo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMon);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtThoiGian);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1321, 187);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(656, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "NHÓM";
            // 
            // txtNhom
            // 
            this.txtNhom.Location = new System.Drawing.Point(723, 101);
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Size = new System.Drawing.Size(189, 23);
            this.txtNhom.TabIndex = 22;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(407, 98);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(189, 23);
            this.txtMaGV.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1145, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "PHÚT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(875, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "THỜI GIAN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "ĐỀ THI TRẮC NGHIỆM MÔN";
            // 
            // txtLan
            // 
            this.txtLan.Location = new System.Drawing.Point(609, 37);
            this.txtLan.Name = "txtLan";
            this.txtLan.Size = new System.Drawing.Size(60, 23);
            this.txtLan.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(564, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "LẦN";
            // 
            // txtSoCauThi
            // 
            this.txtSoCauThi.Location = new System.Drawing.Point(723, 147);
            this.txtSoCauThi.Name = "txtSoCauThi";
            this.txtSoCauThi.Size = new System.Drawing.Size(189, 23);
            this.txtSoCauThi.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(656, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Số Câu :";
            // 
            // txtNgayThi
            // 
            this.txtNgayThi.Location = new System.Drawing.Point(723, 40);
            this.txtNgayThi.Name = "txtNgayThi";
            this.txtNgayThi.Size = new System.Drawing.Size(130, 23);
            this.txtNgayThi.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(675, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "NGÀY";
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Location = new System.Drawing.Point(487, 37);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Size = new System.Drawing.Size(71, 23);
            this.txtTrinhDo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "TRÌNH ĐỘ";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(102, 141);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(189, 23);
            this.txtTenLop.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên Lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(407, 147);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(189, 23);
            this.txtMaLop.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Lớp :";
            // 
            // txtMon
            // 
            this.txtMon.Location = new System.Drawing.Point(206, 37);
            this.txtMon.Name = "txtMon";
            this.txtMon.Size = new System.Drawing.Size(189, 23);
            this.txtMon.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(102, 98);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(189, 23);
            this.txtHoTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giáo Viên";
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Location = new System.Drawing.Point(954, 40);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(175, 23);
            this.txtThoiGian.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ GV";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblDiem);
            this.tabPage2.Controls.Add(this.gvKetQua);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1327, 581);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kết Quả Thi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabPage1);
            this.tbcMain.Controls.Add(this.tabPage2);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 51);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1335, 610);
            this.tbcMain.TabIndex = 15;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNopBai,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNopBai),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnNopBai
            // 
            this.btnNopBai.Caption = "NỘP BÀI";
            this.btnNopBai.Id = 0;
            this.btnNopBai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNopBai.ImageOptions.Image")));
            this.btnNopBai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNopBai.ImageOptions.LargeImage")));
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNopBai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNopBai_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "THOÁT";
            this.btnThoat.Id = 1;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1335, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 661);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1335, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 610);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1335, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 610);
            // 
            // FormThiThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 661);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormThiThu";
            this.Text = "Thi Thử";
            this.Load += new System.EventHandler(this.FormThiThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvKetQua)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbCauHoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbDapAn.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tbcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colDapAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCauHoi;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.DataGridView gvKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDaChon;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTime;
        private DevExpress.XtraEditors.RadioGroup rdbCauHoi;
        private DevExpress.XtraEditors.RadioGroup rdbDapAn;
        private System.Windows.Forms.Label lbCauHoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoCauThi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNgayThi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTrinhDo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMon;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnNopBai;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNhom;
    }
}
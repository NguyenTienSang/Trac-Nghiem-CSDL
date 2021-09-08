namespace TN_CSDLPT_HK3
{
    partial class FormThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnNopBai = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.rdbCauHoi = new DevExpress.XtraEditors.RadioGroup();
            this.rdbDapAn = new DevExpress.XtraEditors.RadioGroup();
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblThoiGianThi = new System.Windows.Forms.Label();
            this.lblThiTracNghiem = new System.Windows.Forms.Label();
            this.lblLanThi = new System.Windows.Forms.Label();
            this.lblSoCauThi = new System.Windows.Forms.Label();
            this.lblNgayThi = new System.Windows.Forms.Label();
            this.lblTrinhDoThi = new System.Windows.Forms.Label();
            this.lblTenLopThi = new System.Windows.Forms.Label();
            this.lblMaLopThi = new System.Windows.Forms.Label();
            this.lblHoTenThi = new System.Windows.Forms.Label();
            this.lblMaSVThi = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSoCauDung = new System.Windows.Forms.Label();
            this.lblKetQuaThi = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblLan = new System.Windows.Forms.Label();
            this.lblSoCau = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblTrinhDo = new System.Windows.Forms.Label();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.gvKetQua = new System.Windows.Forms.DataGridView();
            this.colCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDaChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDapAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbCauHoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbDapAn.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvKetQua)).BeginInit();
            this.SuspendLayout();
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
            this.btnNopBai,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
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
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1362, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 547);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1362, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 496);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1362, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 496);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.rdbCauHoi);
            this.groupBox2.Controls.Add(this.rdbDapAn);
            this.groupBox2.Controls.Add(this.lbCauHoi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1348, 364);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(965, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thời Gian Còn Lại : ";
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
            this.rdbCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbCauHoi.Location = new System.Drawing.Point(48, 146);
            this.rdbCauHoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbCauHoi.Name = "rdbCauHoi";
            this.rdbCauHoi.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.rdbCauHoi.Properties.Appearance.Options.UseBackColor = true;
            this.rdbCauHoi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.rdbCauHoi.Size = new System.Drawing.Size(1262, 115);
            this.rdbCauHoi.TabIndex = 7;
            this.rdbCauHoi.SelectedIndexChanged += new System.EventHandler(this.rdbCauHoi_SelectedIndexChanged);
            // 
            // rdbDapAn
            // 
            this.rdbDapAn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDapAn.Location = new System.Drawing.Point(48, 52);
            this.rdbDapAn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbDapAn.Name = "rdbDapAn";
            this.rdbDapAn.Properties.Appearance.BackColor = System.Drawing.Color.Wheat;
            this.rdbDapAn.Properties.Appearance.Options.UseBackColor = true;
            this.rdbDapAn.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdbDapAn.Size = new System.Drawing.Size(1262, 86);
            this.rdbDapAn.TabIndex = 6;
            this.rdbDapAn.SelectedIndexChanged += new System.EventHandler(this.rdbDapAn_SelectedIndexChanged);
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.AutoSize = true;
            this.lbCauHoi.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbCauHoi.Location = new System.Drawing.Point(21, 24);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(74, 24);
            this.lbCauHoi.TabIndex = 5;
            this.lbCauHoi.Text = "Câu 1 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblThoiGianThi);
            this.groupBox1.Controls.Add(this.lblThiTracNghiem);
            this.groupBox1.Controls.Add(this.lblLanThi);
            this.groupBox1.Controls.Add(this.lblSoCauThi);
            this.groupBox1.Controls.Add(this.lblNgayThi);
            this.groupBox1.Controls.Add(this.lblTrinhDoThi);
            this.groupBox1.Controls.Add(this.lblTenLopThi);
            this.groupBox1.Controls.Add(this.lblMaLopThi);
            this.groupBox1.Controls.Add(this.lblHoTenThi);
            this.groupBox1.Controls.Add(this.lblMaSVThi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1348, 182);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblThoiGianThi
            // 
            this.lblThoiGianThi.AutoSize = true;
            this.lblThoiGianThi.Location = new System.Drawing.Point(720, 82);
            this.lblThoiGianThi.Name = "lblThoiGianThi";
            this.lblThoiGianThi.Size = new System.Drawing.Size(77, 17);
            this.lblThoiGianThi.TabIndex = 19;
            this.lblThoiGianThi.Text = "Thời Gian : ";
            // 
            // lblThiTracNghiem
            // 
            this.lblThiTracNghiem.AutoSize = true;
            this.lblThiTracNghiem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThiTracNghiem.Location = new System.Drawing.Point(414, 30);
            this.lblThiTracNghiem.Name = "lblThiTracNghiem";
            this.lblThiTracNghiem.Size = new System.Drawing.Size(395, 32);
            this.lblThiTracNghiem.TabIndex = 18;
            this.lblThiTracNghiem.Text = "ĐỀ THI TRẮC NGHIỆM MÔN";
            // 
            // lblLanThi
            // 
            this.lblLanThi.AutoSize = true;
            this.lblLanThi.Location = new System.Drawing.Point(409, 79);
            this.lblLanThi.Name = "lblLanThi";
            this.lblLanThi.Size = new System.Drawing.Size(39, 17);
            this.lblLanThi.TabIndex = 16;
            this.lblLanThi.Text = "Lần :";
            // 
            // lblSoCauThi
            // 
            this.lblSoCauThi.AutoSize = true;
            this.lblSoCauThi.Location = new System.Drawing.Point(951, 91);
            this.lblSoCauThi.Name = "lblSoCauThi";
            this.lblSoCauThi.Size = new System.Drawing.Size(61, 17);
            this.lblSoCauThi.TabIndex = 14;
            this.lblSoCauThi.Text = "Số Câu :";
            // 
            // lblNgayThi
            // 
            this.lblNgayThi.AutoSize = true;
            this.lblNgayThi.Location = new System.Drawing.Point(538, 79);
            this.lblNgayThi.Name = "lblNgayThi";
            this.lblNgayThi.Size = new System.Drawing.Size(49, 17);
            this.lblNgayThi.TabIndex = 12;
            this.lblNgayThi.Text = "Ngày :";
            // 
            // lblTrinhDoThi
            // 
            this.lblTrinhDoThi.AutoSize = true;
            this.lblTrinhDoThi.Location = new System.Drawing.Point(255, 79);
            this.lblTrinhDoThi.Name = "lblTrinhDoThi";
            this.lblTrinhDoThi.Size = new System.Drawing.Size(70, 17);
            this.lblTrinhDoThi.TabIndex = 10;
            this.lblTrinhDoThi.Text = "Trình Độ :";
            // 
            // lblTenLopThi
            // 
            this.lblTenLopThi.AutoSize = true;
            this.lblTenLopThi.Location = new System.Drawing.Point(945, 143);
            this.lblTenLopThi.Name = "lblTenLopThi";
            this.lblTenLopThi.Size = new System.Drawing.Size(67, 17);
            this.lblTenLopThi.TabIndex = 8;
            this.lblTenLopThi.Text = "Tên Lớp :";
            // 
            // lblMaLopThi
            // 
            this.lblMaLopThi.AutoSize = true;
            this.lblMaLopThi.Location = new System.Drawing.Point(722, 143);
            this.lblMaLopThi.Name = "lblMaLopThi";
            this.lblMaLopThi.Size = new System.Drawing.Size(61, 17);
            this.lblMaLopThi.TabIndex = 6;
            this.lblMaLopThi.Text = "Mã Lớp :";
            // 
            // lblHoTenThi
            // 
            this.lblHoTenThi.AutoSize = true;
            this.lblHoTenThi.Location = new System.Drawing.Point(171, 143);
            this.lblHoTenThi.Name = "lblHoTenThi";
            this.lblHoTenThi.Size = new System.Drawing.Size(61, 17);
            this.lblHoTenThi.TabIndex = 2;
            this.lblHoTenThi.Text = "Họ Tên :";
            // 
            // lblMaSVThi
            // 
            this.lblMaSVThi.AutoSize = true;
            this.lblMaSVThi.Location = new System.Drawing.Point(443, 143);
            this.lblMaSVThi.Name = "lblMaSVThi";
            this.lblMaSVThi.Size = new System.Drawing.Size(54, 17);
            this.lblMaSVThi.TabIndex = 0;
            this.lblMaSVThi.Text = "Mã SV :";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabPage1);
            this.tbcMain.Controls.Add(this.tabPage2);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 51);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1362, 496);
            this.tbcMain.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1354, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblSoCauDung);
            this.tabPage2.Controls.Add(this.lblKetQuaThi);
            this.tabPage2.Controls.Add(this.lblThoiGian);
            this.tabPage2.Controls.Add(this.lblLan);
            this.tabPage2.Controls.Add(this.lblSoCau);
            this.tabPage2.Controls.Add(this.lblNgay);
            this.tabPage2.Controls.Add(this.lblTrinhDo);
            this.tabPage2.Controls.Add(this.lblTenLop);
            this.tabPage2.Controls.Add(this.lblMaLop);
            this.tabPage2.Controls.Add(this.lblHoTen);
            this.tabPage2.Controls.Add(this.lblMaSV);
            this.tabPage2.Controls.Add(this.lblDiem);
            this.tabPage2.Controls.Add(this.gvKetQua);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1354, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kết Quả Thi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSoCauDung
            // 
            this.lblSoCauDung.AutoSize = true;
            this.lblSoCauDung.Location = new System.Drawing.Point(788, 290);
            this.lblSoCauDung.Name = "lblSoCauDung";
            this.lblSoCauDung.Size = new System.Drawing.Size(99, 17);
            this.lblSoCauDung.TabIndex = 44;
            this.lblSoCauDung.Text = "Số Câu Đúng :";
            // 
            // lblKetQuaThi
            // 
            this.lblKetQuaThi.AutoSize = true;
            this.lblKetQuaThi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQuaThi.Location = new System.Drawing.Point(561, 25);
            this.lblKetQuaThi.Name = "lblKetQuaThi";
            this.lblKetQuaThi.Size = new System.Drawing.Size(199, 32);
            this.lblKetQuaThi.TabIndex = 43;
            this.lblKetQuaThi.Text = "KẾT QUẢ THI";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(891, 98);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(77, 17);
            this.lblThoiGian.TabIndex = 40;
            this.lblThoiGian.Text = "Thời Gian : ";
            // 
            // lblLan
            // 
            this.lblLan.AutoSize = true;
            this.lblLan.Location = new System.Drawing.Point(251, 88);
            this.lblLan.Name = "lblLan";
            this.lblLan.Size = new System.Drawing.Size(39, 17);
            this.lblLan.TabIndex = 37;
            this.lblLan.Text = "Lần :";
            // 
            // lblSoCau
            // 
            this.lblSoCau.AutoSize = true;
            this.lblSoCau.Location = new System.Drawing.Point(1043, 98);
            this.lblSoCau.Name = "lblSoCau";
            this.lblSoCau.Size = new System.Drawing.Size(61, 17);
            this.lblSoCau.TabIndex = 35;
            this.lblSoCau.Text = "Số Câu :";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(564, 88);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(49, 17);
            this.lblNgay.TabIndex = 33;
            this.lblNgay.Text = "Ngày :";
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.AutoSize = true;
            this.lblTrinhDo.Location = new System.Drawing.Point(61, 88);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(61, 17);
            this.lblTrinhDo.TabIndex = 31;
            this.lblTrinhDo.Text = "Trình Độ";
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(1113, 240);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(58, 17);
            this.lblTenLop.TabIndex = 29;
            this.lblTenLop.Text = "Tên Lớp";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(903, 240);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(61, 17);
            this.lblMaLop.TabIndex = 27;
            this.lblMaLop.Text = "Mã Lớp :";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(447, 240);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(52, 17);
            this.lblHoTen.TabIndex = 24;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(679, 240);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(45, 17);
            this.lblMaSV.TabIndex = 22;
            this.lblMaSV.Text = "Mã SV";
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(589, 290);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(117, 17);
            this.lblDiem.TabIndex = 2;
            this.lblDiem.Text = "Số điểm đạt được";
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
            this.gvKetQua.Location = new System.Drawing.Point(64, 178);
            this.gvKetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvKetQua.Name = "gvKetQua";
            this.gvKetQua.ReadOnly = true;
            this.gvKetQua.Size = new System.Drawing.Size(341, 361);
            this.gvKetQua.TabIndex = 1;
            // 
            // colCauHoi
            // 
            this.colCauHoi.HeaderText = "Câu";
            this.colCauHoi.Name = "colCauHoi";
            this.colCauHoi.ReadOnly = true;
            // 
            // ColDaChon
            // 
            this.ColDaChon.HeaderText = "Đã chọn";
            this.ColDaChon.Name = "ColDaChon";
            this.ColDaChon.ReadOnly = true;
            // 
            // colDapAn
            // 
            this.colDapAn.HeaderText = "Đáp Án";
            this.colDapAn.Name = "colDapAn";
            this.colDapAn.ReadOnly = true;
            // 
            // FormThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 567);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormThi";
            this.Text = "Thi";
            this.Load += new System.EventHandler(this.FormThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbCauHoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbDapAn.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvKetQua)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lbCauHoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblThoiGianThi;
        private System.Windows.Forms.Label lblThiTracNghiem;
        private System.Windows.Forms.Label lblLanThi;
        private System.Windows.Forms.Label lblSoCauThi;
        private System.Windows.Forms.Label lblNgayThi;
        private System.Windows.Forms.Label lblTrinhDoThi;
        private System.Windows.Forms.Label lblTenLopThi;
        private System.Windows.Forms.Label lblMaLopThi;
        private System.Windows.Forms.Label lblHoTenThi;
        private System.Windows.Forms.Label lblMaSVThi;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraEditors.RadioGroup rdbCauHoi;
        private DevExpress.XtraEditors.RadioGroup rdbDapAn;
        private DevExpress.XtraBars.BarButtonItem btnNopBai;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.DataGridView gvKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDapAn;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblLan;
        private System.Windows.Forms.Label lblSoCau;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblTrinhDo;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblKetQuaThi;
        private System.Windows.Forms.Label lblSoCauDung;
        private System.Windows.Forms.Label label1;
    }
}
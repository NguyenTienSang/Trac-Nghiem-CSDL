namespace TN_CSDLPT_HK3
{
    partial class FormThaoTacSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThaoTacSV));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnTraCuuDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemKetQua = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MASV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.MALOP = new System.Windows.Forms.ToolStripStatusLabel();
            this.TENLOP = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnTHI,
            this.btnTraCuuDiem,
            this.btnDangXuat,
            this.btnXemKetQua});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1236, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnTHI
            // 
            this.btnTHI.Caption = "THI";
            this.btnTHI.Id = 1;
            this.btnTHI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTHI.ImageOptions.Image")));
            this.btnTHI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTHI.ImageOptions.LargeImage")));
            this.btnTHI.Name = "btnTHI";
            this.btnTHI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHI_ItemClick);
            // 
            // btnTraCuuDiem
            // 
            this.btnTraCuuDiem.Caption = "TRA CỨU ĐIỂM";
            this.btnTraCuuDiem.Id = 2;
            this.btnTraCuuDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuuDiem.ImageOptions.Image")));
            this.btnTraCuuDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTraCuuDiem.ImageOptions.LargeImage")));
            this.btnTraCuuDiem.Name = "btnTraCuuDiem";
            this.btnTraCuuDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTraCuuDiem_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "ĐĂNG XUẤT";
            this.btnDangXuat.Id = 3;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Caption = "Xem Kết Quả";
            this.btnXemKetQua.Id = 4;
            this.btnXemKetQua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemKetQua.ImageOptions.Image")));
            this.btnXemKetQua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXemKetQua.ImageOptions.LargeImage")));
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemKetQua_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thao Tác Sinh Viên";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTHI);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnXemKetQua);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTraCuuDiem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 616);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1236, 30);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MASV,
            this.HOTEN,
            this.NHOM,
            this.MALOP,
            this.TENLOP});
            this.statusStrip1.Location = new System.Drawing.Point(0, 591);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1236, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MASV
            // 
            this.MASV.Name = "MASV";
            this.MASV.Size = new System.Drawing.Size(58, 20);
            this.MASV.Text = "Mã SV :";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(61, 20);
            this.HOTEN.Text = "Họ tên :";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(57, 20);
            this.NHOM.Text = "Nhóm :";
            // 
            // MALOP
            // 
            this.MALOP.Name = "MALOP";
            this.MALOP.Size = new System.Drawing.Size(63, 20);
            this.MALOP.Text = "Mã lớp :";
            // 
            // TENLOP
            // 
            this.TENLOP.Name = "TENLOP";
            this.TENLOP.Size = new System.Drawing.Size(65, 20);
            this.TENLOP.Text = "Tên lớp :";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormThaoTacSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 646);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FormThaoTacSV";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Thao Tác Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnTHI;
        private DevExpress.XtraBars.BarButtonItem btnTraCuuDiem;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MASV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        public System.Windows.Forms.ToolStripStatusLabel MALOP;
        public System.Windows.Forms.ToolStripStatusLabel TENLOP;
        private DevExpress.XtraBars.BarButtonItem btnXemKetQua;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}
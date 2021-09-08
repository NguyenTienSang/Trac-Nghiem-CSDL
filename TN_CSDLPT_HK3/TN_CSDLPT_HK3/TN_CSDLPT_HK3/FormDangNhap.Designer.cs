namespace TN_CSDLPT_HK3
{
    partial class FormDangNhap
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
            System.Windows.Forms.Label tENCOSOLabel;
            this.rdbSV = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.DS_DSPM = new TN_CSDLPT_HK3.DS_DSPM();
            this.bdsDSPM = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new TN_CSDLPT_HK3.DS_DSPMTableAdapters.v_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT_HK3.DS_DSPMTableAdapters.TableAdapterManager();
            this.cmb_TENCOSO = new System.Windows.Forms.ComboBox();
            tENCOSOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPM)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCOSOLabel
            // 
            tENCOSOLabel.AutoSize = true;
            tENCOSOLabel.Location = new System.Drawing.Point(36, 26);
            tENCOSOLabel.Name = "tENCOSOLabel";
            tENCOSOLabel.Size = new System.Drawing.Size(49, 17);
            tENCOSOLabel.TabIndex = 12;
            tENCOSOLabel.Text = "CƠ SỞ";
            // 
            // rdbSV
            // 
            this.rdbSV.AutoSize = true;
            this.rdbSV.Location = new System.Drawing.Point(360, 192);
            this.rdbSV.Name = "rdbSV";
            this.rdbSV.Size = new System.Drawing.Size(92, 21);
            this.rdbSV.TabIndex = 21;
            this.rdbSV.TabStop = true;
            this.rdbSV.Text = "SINH VIÊN";
            this.rdbSV.UseVisualStyleBackColor = true;
            this.rdbSV.CheckedChanged += new System.EventHandler(this.rdbSV_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Blue;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(447, 233);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(284, 57);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.Color.Red;
            this.btnDangnhap.ForeColor = System.Drawing.Color.White;
            this.btnDangnhap.Location = new System.Drawing.Point(132, 233);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(228, 57);
            this.btnDangnhap.TabIndex = 18;
            this.btnDangnhap.Text = "ĐĂNG NHẬP";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(22, 134);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(72, 17);
            this.labelPassword.TabIndex = 17;
            this.labelPassword.Text = "MẬT KHẨU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "TÀI KHOẢN";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(153, 128);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(609, 23);
            this.txtPassword.TabIndex = 15;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(153, 76);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(609, 23);
            this.txtLogin.TabIndex = 14;
            // 
            // DS_DSPM
            // 
            this.DS_DSPM.DataSetName = "DS_DSPM";
            this.DS_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSPM
            // 
            this.bdsDSPM.DataMember = "v_DS_PHANMANH";
            this.bdsDSPM.DataSource = this.DS_DSPM;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT_HK3.DS_DSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmb_TENCOSO
            // 
            this.cmb_TENCOSO.DataSource = this.bdsDSPM;
            this.cmb_TENCOSO.DisplayMember = "TEN_COSO";
            this.cmb_TENCOSO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TENCOSO.FormattingEnabled = true;
            this.cmb_TENCOSO.Location = new System.Drawing.Point(153, 30);
            this.cmb_TENCOSO.Name = "cmb_TENCOSO";
            this.cmb_TENCOSO.Size = new System.Drawing.Size(609, 24);
            this.cmb_TENCOSO.TabIndex = 23;
            this.cmb_TENCOSO.ValueMember = "TEN_SERVER";
            this.cmb_TENCOSO.SelectedIndexChanged += new System.EventHandler(this.cmb_TENCOSO_SelectedIndexChanged);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 326);
            this.Controls.Add(this.cmb_TENCOSO);
            this.Controls.Add(this.rdbSV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(tENCOSOLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDangNhap";
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbSV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private DS_DSPM DS_DSPM;
        private System.Windows.Forms.BindingSource bdsDSPM;
        private DS_DSPMTableAdapters.v_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_DSPMTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmb_TENCOSO;
    }
}


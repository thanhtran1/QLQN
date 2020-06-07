namespace Main
{
    partial class frm_MainClient
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblMaMay = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnDoiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.btnTinNhan = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangXuat = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblTenTK = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.lblthoigiansudung = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(432, 45);
            this.panelControl1.TabIndex = 2;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(179, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 27);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Máy 01";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(26, 244);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(167, 22);
            this.labelControl4.TabIndex = 56;
            this.labelControl4.Text = "Thời gian còn lại: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(9, 187);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(184, 22);
            this.labelControl3.TabIndex = 55;
            this.labelControl3.Text = "Thời gian sử dụng: ";
            // 
            // lblMaMay
            // 
            this.lblMaMay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaMay.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMay.Appearance.Options.UseFont = true;
            this.lblMaMay.Location = new System.Drawing.Point(45, 134);
            this.lblMaMay.Margin = new System.Windows.Forms.Padding(4);
            this.lblMaMay.Name = "lblMaMay";
            this.lblMaMay.Size = new System.Drawing.Size(148, 22);
            this.lblMaMay.TabIndex = 54;
            this.lblMaMay.Text = "Tổng thời gian: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(87, 201);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 53;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.Appearance.Options.UseFont = true;
            this.btnDoiMatKhau.ImageOptions.Image = global::Main.Properties.Resources.modify_key_icon__1_;
            this.btnDoiMatKhau.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(105, 391);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(178, 51);
            this.btnDoiMatKhau.TabIndex = 62;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnTinNhan
            // 
            this.btnTinNhan.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinNhan.Appearance.Options.UseFont = true;
            this.btnTinNhan.ImageOptions.Image = global::Main.Properties.Resources.SMS_Message_icon__1_;
            this.btnTinNhan.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTinNhan.Location = new System.Drawing.Point(10, 289);
            this.btnTinNhan.Name = "btnTinNhan";
            this.btnTinNhan.Size = new System.Drawing.Size(151, 51);
            this.btnTinNhan.TabIndex = 61;
            this.btnTinNhan.Text = "Tin nhắn";
            this.btnTinNhan.Click += new System.EventHandler(this.btnTinNhan_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Appearance.Options.UseFont = true;
            this.btnDangXuat.ImageOptions.Image = global::Main.Properties.Resources.logout_icon;
            this.btnDangXuat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDangXuat.Location = new System.Drawing.Point(232, 289);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(151, 51);
            this.btnDangXuat.TabIndex = 60;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(89, 78);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(104, 22);
            this.labelControl5.TabIndex = 63;
            this.labelControl5.Text = "Tài khoản: ";
            // 
            // lblTenTK
            // 
            this.lblTenTK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTenTK.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTK.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTenTK.Appearance.Options.UseFont = true;
            this.lblTenTK.Appearance.Options.UseForeColor = true;
            this.lblTenTK.Location = new System.Drawing.Point(242, 78);
            this.lblTenTK.Margin = new System.Windows.Forms.Padding(4);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(10, 21);
            this.lblTenTK.TabIndex = 64;
            this.lblTenTK.Text = "1";
            this.lblTenTK.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "label1";
            // 
            // lblthoigiansudung
            // 
            this.lblthoigiansudung.AccessibleDescription = "";
            this.lblthoigiansudung.AutoSize = true;
            this.lblthoigiansudung.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthoigiansudung.Location = new System.Drawing.Point(208, 180);
            this.lblthoigiansudung.Name = "lblthoigiansudung";
            this.lblthoigiansudung.Size = new System.Drawing.Size(0, 29);
            this.lblthoigiansudung.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "label3";
            // 
            // frm_MainClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblthoigiansudung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTenTK);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.btnTinNhan);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblMaMay);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_MainClient";
            this.Text = "THÔNG TIN";
            this.Load += new System.EventHandler(this.MainClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnDoiMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnTinNhan;
        private DevExpress.XtraEditors.SimpleButton btnDangXuat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblMaMay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblTenTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblthoigiansudung;
        private System.Windows.Forms.Label label3;
    }
}


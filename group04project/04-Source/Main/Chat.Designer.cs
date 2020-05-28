namespace Main
{
    partial class frm_chat
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
            this.lvHienThiTinNhan = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapTinNhan = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGui = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapTinNhan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lvHienThiTinNhan
            // 
            this.lvHienThiTinNhan.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHienThiTinNhan.HideSelection = false;
            this.lvHienThiTinNhan.Location = new System.Drawing.Point(110, 61);
            this.lvHienThiTinNhan.Name = "lvHienThiTinNhan";
            this.lvHienThiTinNhan.Size = new System.Drawing.Size(419, 182);
            this.lvHienThiTinNhan.TabIndex = 0;
            this.lvHienThiTinNhan.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hiển thị tin nhắn";
            // 
            // txtNhapTinNhan
            // 
            this.txtNhapTinNhan.Location = new System.Drawing.Point(108, 317);
            this.txtNhapTinNhan.Name = "txtNhapTinNhan";
            this.txtNhapTinNhan.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTinNhan.Properties.Appearance.Options.UseFont = true;
            this.txtNhapTinNhan.Size = new System.Drawing.Size(421, 34);
            this.txtNhapTinNhan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập tin nhắn";
            // 
            // btnGui
            // 
            this.btnGui.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.Appearance.Options.UseFont = true;
            this.btnGui.ImageOptions.Image = global::Main.Properties.Resources.email_send_icon__1_;
            this.btnGui.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnGui.Location = new System.Drawing.Point(543, 310);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(106, 43);
            this.btnGui.TabIndex = 4;
            this.btnGui.Text = "Gửi";
            // 
            // frm_chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 406);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNhapTinNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvHienThiTinNhan);
            this.Name = "frm_chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.frm_chat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapTinNhan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvHienThiTinNhan;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtNhapTinNhan;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnGui;
    }
}
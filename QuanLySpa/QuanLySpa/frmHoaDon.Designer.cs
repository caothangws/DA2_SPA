namespace QuanLySpa
{
    partial class frmHoaDon
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
            this.pnlNhap = new System.Windows.Forms.Panel();
            this.cbxHD = new System.Windows.Forms.ComboBox();
            this.btnChonHD = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pnlNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNhap
            // 
            this.pnlNhap.Controls.Add(this.cbxHD);
            this.pnlNhap.Controls.Add(this.btnChonHD);
            this.pnlNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNhap.Location = new System.Drawing.Point(0, 0);
            this.pnlNhap.Name = "pnlNhap";
            this.pnlNhap.Size = new System.Drawing.Size(1282, 78);
            this.pnlNhap.TabIndex = 84;
            // 
            // cbxHD
            // 
            this.cbxHD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHD.FormattingEnabled = true;
            this.cbxHD.Location = new System.Drawing.Point(12, 26);
            this.cbxHD.Name = "cbxHD";
            this.cbxHD.Size = new System.Drawing.Size(222, 31);
            this.cbxHD.TabIndex = 104;
            // 
            // btnChonHD
            // 
            this.btnChonHD.AutoRoundedCorners = true;
            this.btnChonHD.BorderRadius = 21;
            this.btnChonHD.CheckedState.Parent = this.btnChonHD;
            this.btnChonHD.CustomImages.Parent = this.btnChonHD;
            this.btnChonHD.FillColor = System.Drawing.Color.LightCoral;
            this.btnChonHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonHD.ForeColor = System.Drawing.Color.White;
            this.btnChonHD.HoverState.Parent = this.btnChonHD;
            this.btnChonHD.Location = new System.Drawing.Point(251, 16);
            this.btnChonHD.Name = "btnChonHD";
            this.btnChonHD.ShadowDecoration.Parent = this.btnChonHD;
            this.btnChonHD.Size = new System.Drawing.Size(138, 45);
            this.btnChonHD.TabIndex = 103;
            this.btnChonHD.Text = "Chọn HD";
            this.btnChonHD.Click += new System.EventHandler(this.btnChonHD_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContainer.Location = new System.Drawing.Point(0, 78);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1282, 651);
            this.panelContainer.TabIndex = 85;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1282, 730);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.pnlNhap);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.pnlNhap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlNhap;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button btnChonHD;
        private System.Windows.Forms.ComboBox cbxHD;
    }
}
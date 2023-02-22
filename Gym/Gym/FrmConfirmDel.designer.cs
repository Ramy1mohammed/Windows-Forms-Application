namespace Gym
{
    partial class FrmConfirmDel
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnYes = new SansationRoundButton();
            this.btnNo = new SansationRoundButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHeader.Location = new System.Drawing.Point(87, 42);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(0, 39);
            this.lblHeader.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 60;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Pink;
            this.btnYes.BackColorMouseOver = System.Drawing.Color.Red;
            this.btnYes.BorderColor = System.Drawing.Color.Black;
            this.btnYes.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(452, 20);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(121, 51);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "نعم";
            this.btnYes.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnYes.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Pink;
            this.btnNo.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnNo.BorderColor = System.Drawing.Color.Black;
            this.btnNo.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(262, 20);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(121, 51);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "لـلـ";
            this.btnNo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnYes);
            this.panel1.Controls.Add(this.btnNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 115);
            this.panel1.TabIndex = 3;
            // 
            // FrmConfirmDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(834, 293);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfirmDel";
            this.Opacity = 0D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmConfirmDel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Label lblHeader;
        public SansationRoundButton btnYes;
        public SansationRoundButton btnNo;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
    }
}
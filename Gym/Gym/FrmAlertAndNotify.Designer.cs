namespace Gym
{
    partial class FrmAlertAndNotify
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
            this.pnlHead = new System.Windows.Forms.Panel();
            this.btnMinimize = new SansationRoundButton();
            this.btnMaxmize = new SansationRoundButton();
            this.btnClose = new SansationRoundButton();
            this.pnlAlertAndNotify = new System.Windows.Forms.Panel();
            this.pnlHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.Red;
            this.pnlHead.Controls.Add(this.btnMinimize);
            this.pnlHead.Controls.Add(this.btnMaxmize);
            this.pnlHead.Controls.Add(this.btnClose);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1422, 46);
            this.pnlHead.TabIndex = 0;
            this.pnlHead.DoubleClick += new System.EventHandler(this.btnMaxmize_Click);
            this.pnlHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseDown);
            this.pnlHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseMove);
            this.pnlHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnMinimize.BackColorMouseOver = System.Drawing.Color.Red;
            this.btnMinimize.BorderColor = System.Drawing.Color.Black;
            this.btnMinimize.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(1260, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(54, 46);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaxmize
            // 
            this.btnMaxmize.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnMaxmize.BackColorMouseOver = System.Drawing.Color.Red;
            this.btnMaxmize.BorderColor = System.Drawing.Color.Black;
            this.btnMaxmize.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnMaxmize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxmize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaxmize.FlatAppearance.BorderSize = 0;
            this.btnMaxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxmize.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxmize.Location = new System.Drawing.Point(1314, 0);
            this.btnMaxmize.Name = "btnMaxmize";
            this.btnMaxmize.Size = new System.Drawing.Size(54, 46);
            this.btnMaxmize.TabIndex = 2;
            this.btnMaxmize.Text = "🗖";
            this.btnMaxmize.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnMaxmize.UseVisualStyleBackColor = false;
            this.btnMaxmize.Click += new System.EventHandler(this.btnMaxmize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BackColorMouseOver = System.Drawing.Color.Red;
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1368, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 46);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlAlertAndNotify
            // 
            this.pnlAlertAndNotify.AutoScroll = true;
            this.pnlAlertAndNotify.BackColor = System.Drawing.Color.Black;
            this.pnlAlertAndNotify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlertAndNotify.Location = new System.Drawing.Point(0, 46);
            this.pnlAlertAndNotify.Name = "pnlAlertAndNotify";
            this.pnlAlertAndNotify.Size = new System.Drawing.Size(1422, 692);
            this.pnlAlertAndNotify.TabIndex = 1;
            // 
            // FrmAlertAndNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1422, 738);
            this.ControlBox = false;
            this.Controls.Add(this.pnlAlertAndNotify);
            this.Controls.Add(this.pnlHead);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlertAndNotify";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAlertAndNotify_FormClosed);
            this.Load += new System.EventHandler(this.FrmAlertAndNotify_Load);
            this.pnlHead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SansationRoundButton btnClose;
        private SansationRoundButton btnMaxmize;
        private SansationRoundButton btnMinimize;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Panel pnlAlertAndNotify;
    }
}
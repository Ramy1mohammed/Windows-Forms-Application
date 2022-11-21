namespace MyFoods
{
    partial class FrmBackUp
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTakeBackUp = new System.Windows.Forms.Button();
            this.btnRestoreBackUp = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Red;
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1438, 46);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Pink;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(1368, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Pink;
            this.label6.Location = new System.Drawing.Point(492, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(455, 46);
            this.label6.TabIndex = 20;
            this.label6.Text = "شاشه النسخ الاحتياطى للأكلات";
            // 
            // btnTakeBackUp
            // 
            this.btnTakeBackUp.BackColor = System.Drawing.Color.Pink;
            this.btnTakeBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakeBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeBackUp.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTakeBackUp.Location = new System.Drawing.Point(341, 166);
            this.btnTakeBackUp.Margin = new System.Windows.Forms.Padding(5);
            this.btnTakeBackUp.Name = "btnTakeBackUp";
            this.btnTakeBackUp.Size = new System.Drawing.Size(689, 99);
            this.btnTakeBackUp.TabIndex = 19;
            this.btnTakeBackUp.Text = "أخذ نسخه احتياطيه";
            this.btnTakeBackUp.UseVisualStyleBackColor = false;
            this.btnTakeBackUp.Click += new System.EventHandler(this.btnTakeBackUp_Click);
            // 
            // btnRestoreBackUp
            // 
            this.btnRestoreBackUp.BackColor = System.Drawing.Color.Pink;
            this.btnRestoreBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestoreBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreBackUp.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRestoreBackUp.Location = new System.Drawing.Point(341, 326);
            this.btnRestoreBackUp.Margin = new System.Windows.Forms.Padding(5);
            this.btnRestoreBackUp.Name = "btnRestoreBackUp";
            this.btnRestoreBackUp.Size = new System.Drawing.Size(689, 99);
            this.btnRestoreBackUp.TabIndex = 21;
            this.btnRestoreBackUp.Text = "استرجاع نسخه احتياطيه";
            this.btnRestoreBackUp.UseVisualStyleBackColor = false;
            this.btnRestoreBackUp.Click += new System.EventHandler(this.btnRestoreBackUp_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.BackColor = System.Drawing.Color.Pink;
            this.btnCanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCanel.Location = new System.Drawing.Point(341, 482);
            this.btnCanel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(689, 99);
            this.btnCanel.TabIndex = 22;
            this.btnCanel.Text = "اغـــــــــــــــــــــــــــــلاق";
            this.btnCanel.UseVisualStyleBackColor = false;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // FrmBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1438, 628);
            this.ControlBox = false;
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnRestoreBackUp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTakeBackUp);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackUp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTakeBackUp;
        private System.Windows.Forms.Button btnRestoreBackUp;
        private System.Windows.Forms.Button btnCanel;
    }
}
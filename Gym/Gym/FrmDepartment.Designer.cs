namespace Gym
{
    partial class FrmDepartment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDeptControls = new System.Windows.Forms.Panel();
            this.cbxDeptMgr = new System.Windows.Forms.ComboBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.dgvShowDept = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReportDept = new SansationRoundButton();
            this.btnDeleteDept = new SansationRoundButton();
            this.btnEditDept = new SansationRoundButton();
            this.btnAddDept = new SansationRoundButton();
            this.btnNewDept = new SansationRoundButton();
            this.lblDeptMgr = new System.Windows.Forms.Label();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.txtDeptCode = new System.Windows.Forms.TextBox();
            this.lblDeptCode = new System.Windows.Forms.Label();
            this.epDept = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlDeptControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDept)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDeptControls
            // 
            this.pnlDeptControls.Controls.Add(this.cbxDeptMgr);
            this.pnlDeptControls.Controls.Add(this.lblMsg);
            this.pnlDeptControls.Controls.Add(this.dgvShowDept);
            this.pnlDeptControls.Controls.Add(this.btnReportDept);
            this.pnlDeptControls.Controls.Add(this.btnDeleteDept);
            this.pnlDeptControls.Controls.Add(this.btnEditDept);
            this.pnlDeptControls.Controls.Add(this.btnAddDept);
            this.pnlDeptControls.Controls.Add(this.btnNewDept);
            this.pnlDeptControls.Controls.Add(this.lblDeptMgr);
            this.pnlDeptControls.Controls.Add(this.txtDeptName);
            this.pnlDeptControls.Controls.Add(this.lblDeptName);
            this.pnlDeptControls.Controls.Add(this.txtDeptCode);
            this.pnlDeptControls.Controls.Add(this.lblDeptCode);
            this.pnlDeptControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeptControls.Location = new System.Drawing.Point(0, 0);
            this.pnlDeptControls.Name = "pnlDeptControls";
            this.pnlDeptControls.Size = new System.Drawing.Size(1422, 713);
            this.pnlDeptControls.TabIndex = 5;
            // 
            // cbxDeptMgr
            // 
            this.cbxDeptMgr.BackColor = System.Drawing.Color.Pink;
            this.cbxDeptMgr.FormattingEnabled = true;
            this.cbxDeptMgr.Location = new System.Drawing.Point(771, 126);
            this.cbxDeptMgr.Name = "cbxDeptMgr";
            this.cbxDeptMgr.Size = new System.Drawing.Size(429, 37);
            this.cbxDeptMgr.TabIndex = 50;
            this.cbxDeptMgr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxDeptMgr_KeyPress);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblMsg.Location = new System.Drawing.Point(924, 252);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(62, 42);
            this.lblMsg.TabIndex = 49;
            this.lblMsg.Text = ">>";
            // 
            // dgvShowDept
            // 
            this.dgvShowDept.AllowUserToAddRows = false;
            this.dgvShowDept.AllowUserToDeleteRows = false;
            this.dgvShowDept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowDept.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowDept.BackgroundColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowDept.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowDept.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowDept.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShowDept.EnableHeadersVisualStyles = false;
            this.dgvShowDept.Location = new System.Drawing.Point(0, 355);
            this.dgvShowDept.Name = "dgvShowDept";
            this.dgvShowDept.ReadOnly = true;
            this.dgvShowDept.RowHeadersWidth = 51;
            this.dgvShowDept.RowTemplate.Height = 24;
            this.dgvShowDept.Size = new System.Drawing.Size(1422, 358);
            this.dgvShowDept.TabIndex = 32;
            this.dgvShowDept.SelectionChanged += new System.EventHandler(this.dgvShowDept_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "deptno";
            this.Column1.HeaderText = "كود القســـم";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "deptname";
            this.Column2.HeaderText = "اسم القســــم";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "deptmanager";
            this.Column3.HeaderText = "مدير القسم";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnReportDept
            // 
            this.btnReportDept.BackColor = System.Drawing.Color.Pink;
            this.btnReportDept.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnReportDept.BorderColor = System.Drawing.Color.Black;
            this.btnReportDept.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnReportDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportDept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReportDept.FlatAppearance.BorderSize = 2;
            this.btnReportDept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportDept.Location = new System.Drawing.Point(415, 182);
            this.btnReportDept.Name = "btnReportDept";
            this.btnReportDept.Size = new System.Drawing.Size(108, 42);
            this.btnReportDept.TabIndex = 31;
            this.btnReportDept.Text = "تقريـر";
            this.btnReportDept.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnReportDept.UseVisualStyleBackColor = false;
            // 
            // btnDeleteDept
            // 
            this.btnDeleteDept.BackColor = System.Drawing.Color.Pink;
            this.btnDeleteDept.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnDeleteDept.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteDept.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnDeleteDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteDept.FlatAppearance.BorderSize = 2;
            this.btnDeleteDept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDept.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteDept.Location = new System.Drawing.Point(529, 182);
            this.btnDeleteDept.Name = "btnDeleteDept";
            this.btnDeleteDept.Size = new System.Drawing.Size(108, 42);
            this.btnDeleteDept.TabIndex = 30;
            this.btnDeleteDept.Text = "حــذف";
            this.btnDeleteDept.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnDeleteDept.UseVisualStyleBackColor = false;
            this.btnDeleteDept.Click += new System.EventHandler(this.btnDeleteDept_Click);
            // 
            // btnEditDept
            // 
            this.btnEditDept.BackColor = System.Drawing.Color.Pink;
            this.btnEditDept.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnEditDept.BorderColor = System.Drawing.Color.Black;
            this.btnEditDept.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnEditDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditDept.FlatAppearance.BorderSize = 2;
            this.btnEditDept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDept.Location = new System.Drawing.Point(643, 182);
            this.btnEditDept.Name = "btnEditDept";
            this.btnEditDept.Size = new System.Drawing.Size(108, 42);
            this.btnEditDept.TabIndex = 29;
            this.btnEditDept.Text = "تعديــل";
            this.btnEditDept.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnEditDept.UseVisualStyleBackColor = false;
            this.btnEditDept.Click += new System.EventHandler(this.btnEditDept_Click);
            // 
            // btnAddDept
            // 
            this.btnAddDept.BackColor = System.Drawing.Color.Pink;
            this.btnAddDept.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnAddDept.BorderColor = System.Drawing.Color.Black;
            this.btnAddDept.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnAddDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddDept.FlatAppearance.BorderSize = 2;
            this.btnAddDept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDept.Location = new System.Drawing.Point(757, 182);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(108, 42);
            this.btnAddDept.TabIndex = 28;
            this.btnAddDept.Text = "اضــافه";
            this.btnAddDept.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnAddDept.UseVisualStyleBackColor = false;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // btnNewDept
            // 
            this.btnNewDept.BackColor = System.Drawing.Color.Pink;
            this.btnNewDept.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnNewDept.BorderColor = System.Drawing.Color.Black;
            this.btnNewDept.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnNewDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewDept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewDept.FlatAppearance.BorderSize = 2;
            this.btnNewDept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDept.Location = new System.Drawing.Point(871, 182);
            this.btnNewDept.Name = "btnNewDept";
            this.btnNewDept.Size = new System.Drawing.Size(108, 42);
            this.btnNewDept.TabIndex = 27;
            this.btnNewDept.Text = "جديد*";
            this.btnNewDept.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnNewDept.UseVisualStyleBackColor = false;
            this.btnNewDept.Click += new System.EventHandler(this.btnNewDept_Click);
            // 
            // lblDeptMgr
            // 
            this.lblDeptMgr.AutoSize = true;
            this.lblDeptMgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptMgr.ForeColor = System.Drawing.Color.Yellow;
            this.lblDeptMgr.Location = new System.Drawing.Point(1275, 129);
            this.lblDeptMgr.Name = "lblDeptMgr";
            this.lblDeptMgr.Size = new System.Drawing.Size(108, 29);
            this.lblDeptMgr.TabIndex = 6;
            this.lblDeptMgr.Text = "مدير القسم:";
            // 
            // txtDeptName
            // 
            this.txtDeptName.BackColor = System.Drawing.Color.Pink;
            this.txtDeptName.Location = new System.Drawing.Point(771, 86);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(429, 34);
            this.txtDeptName.TabIndex = 5;
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptName.ForeColor = System.Drawing.Color.Yellow;
            this.lblDeptName.Location = new System.Drawing.Point(1261, 89);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(122, 29);
            this.lblDeptName.TabIndex = 4;
            this.lblDeptName.Text = "اســم القســم:";
            // 
            // txtDeptCode
            // 
            this.txtDeptCode.BackColor = System.Drawing.Color.Pink;
            this.txtDeptCode.Location = new System.Drawing.Point(771, 46);
            this.txtDeptCode.Name = "txtDeptCode";
            this.txtDeptCode.ReadOnly = true;
            this.txtDeptCode.Size = new System.Drawing.Size(429, 34);
            this.txtDeptCode.TabIndex = 3;
            this.txtDeptCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDeptCode
            // 
            this.lblDeptCode.AutoSize = true;
            this.lblDeptCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptCode.ForeColor = System.Drawing.Color.Yellow;
            this.lblDeptCode.Location = new System.Drawing.Point(1266, 49);
            this.lblDeptCode.Name = "lblDeptCode";
            this.lblDeptCode.Size = new System.Drawing.Size(117, 29);
            this.lblDeptCode.TabIndex = 2;
            this.lblDeptCode.Text = "كود القســـم:";
            // 
            // epDept
            // 
            this.epDept.ContainerControl = this;
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1422, 713);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDeptControls);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDepartment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Deactivate += new System.EventHandler(this.FrmDepartment_Deactivate);
            this.Load += new System.EventHandler(this.FrmDepartment_Load);
            this.pnlDeptControls.ResumeLayout(false);
            this.pnlDeptControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDeptMgr;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.TextBox txtDeptCode;
        private System.Windows.Forms.Label lblDeptCode;
        private SansationRoundButton btnReportDept;
        private SansationRoundButton btnDeleteDept;
        private SansationRoundButton btnEditDept;
        private SansationRoundButton btnAddDept;
        private SansationRoundButton btnNewDept;
        private System.Windows.Forms.DataGridView dgvShowDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel pnlDeptControls;
        private System.Windows.Forms.ErrorProvider epDept;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ComboBox cbxDeptMgr;
    }
}
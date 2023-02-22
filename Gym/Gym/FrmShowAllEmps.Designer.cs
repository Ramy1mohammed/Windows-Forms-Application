namespace Gym
{
    partial class FrmShowAllEmps
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new SansationRoundButton();
            this.btnMaxmize = new SansationRoundButton();
            this.btnClose = new SansationRoundButton();
            this.txtEmpSearch = new System.Windows.Forms.TextBox();
            this.rdoDept = new System.Windows.Forms.RadioButton();
            this.rdoJobtype = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.rdoEmpssn = new System.Windows.Forms.RadioButton();
            this.rdoEmpName = new System.Windows.Forms.RadioButton();
            this.dgvShowEmp = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colshift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.Red;
            this.pnlHead.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1178, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "هذا التطبيق مازال تحت الانشاء بناءا على ما تم تحليله للنظام وتصميمه بداخل قاعده ا" +
    "لبيانات حيث سيتم اضافه شاشات أخرى أساسها موجود بقاعده البيانات";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnMinimize.BackColorMouseOver = System.Drawing.Color.LawnGreen;
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
            this.btnMaxmize.BackColorMouseOver = System.Drawing.Color.LawnGreen;
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
            // txtEmpSearch
            // 
            this.txtEmpSearch.BackColor = System.Drawing.Color.Pink;
            this.txtEmpSearch.Location = new System.Drawing.Point(130, 122);
            this.txtEmpSearch.Name = "txtEmpSearch";
            this.txtEmpSearch.Size = new System.Drawing.Size(341, 34);
            this.txtEmpSearch.TabIndex = 52;
            this.txtEmpSearch.TextChanged += new System.EventHandler(this.txtEmpSearch_TextChanged);
            this.txtEmpSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpSearch_KeyPress);
            // 
            // rdoDept
            // 
            this.rdoDept.AutoSize = true;
            this.rdoDept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoDept.Location = new System.Drawing.Point(872, 123);
            this.rdoDept.Name = "rdoDept";
            this.rdoDept.Size = new System.Drawing.Size(107, 33);
            this.rdoDept.TabIndex = 51;
            this.rdoDept.TabStop = true;
            this.rdoDept.Text = "قسم العمل";
            this.rdoDept.UseVisualStyleBackColor = true;
            this.rdoDept.Click += new System.EventHandler(this.rdoEmpName_Click);
            // 
            // rdoJobtype
            // 
            this.rdoJobtype.AutoSize = true;
            this.rdoJobtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoJobtype.Location = new System.Drawing.Point(742, 123);
            this.rdoJobtype.Name = "rdoJobtype";
            this.rdoJobtype.Size = new System.Drawing.Size(124, 33);
            this.rdoJobtype.TabIndex = 50;
            this.rdoJobtype.TabStop = true;
            this.rdoJobtype.Text = "نوع الوظيفه";
            this.rdoJobtype.UseVisualStyleBackColor = true;
            this.rdoJobtype.Click += new System.EventHandler(this.rdoEmpName_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(37, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 29);
            this.label11.TabIndex = 49;
            this.label11.Text = "البحث:";
            // 
            // rdoEmpssn
            // 
            this.rdoEmpssn.AutoSize = true;
            this.rdoEmpssn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoEmpssn.Location = new System.Drawing.Point(611, 123);
            this.rdoEmpssn.Name = "rdoEmpssn";
            this.rdoEmpssn.Size = new System.Drawing.Size(125, 33);
            this.rdoEmpssn.TabIndex = 48;
            this.rdoEmpssn.TabStop = true;
            this.rdoEmpssn.Text = "الرقم القومى";
            this.rdoEmpssn.UseVisualStyleBackColor = true;
            this.rdoEmpssn.Click += new System.EventHandler(this.rdoEmpName_Click);
            // 
            // rdoEmpName
            // 
            this.rdoEmpName.AutoSize = true;
            this.rdoEmpName.Checked = true;
            this.rdoEmpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoEmpName.Location = new System.Drawing.Point(477, 123);
            this.rdoEmpName.Name = "rdoEmpName";
            this.rdoEmpName.Size = new System.Drawing.Size(128, 33);
            this.rdoEmpName.TabIndex = 47;
            this.rdoEmpName.TabStop = true;
            this.rdoEmpName.Text = "اسم الموظف";
            this.rdoEmpName.UseVisualStyleBackColor = true;
            this.rdoEmpName.Click += new System.EventHandler(this.rdoEmpName_Click);
            // 
            // dgvShowEmp
            // 
            this.dgvShowEmp.AllowUserToAddRows = false;
            this.dgvShowEmp.AllowUserToDeleteRows = false;
            this.dgvShowEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvShowEmp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowEmp.BackgroundColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column12,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.colshift});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowEmp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowEmp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShowEmp.EnableHeadersVisualStyles = false;
            this.dgvShowEmp.Location = new System.Drawing.Point(0, 187);
            this.dgvShowEmp.MultiSelect = false;
            this.dgvShowEmp.Name = "dgvShowEmp";
            this.dgvShowEmp.RowHeadersWidth = 51;
            this.dgvShowEmp.RowTemplate.Height = 24;
            this.dgvShowEmp.Size = new System.Drawing.Size(1422, 551);
            this.dgvShowEmp.TabIndex = 46;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "empno";
            this.Column1.HeaderText = "كود الموظف";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 137;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "empname";
            this.Column2.HeaderText = "اسم الموظف";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 136;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "empssn";
            this.Column3.HeaderText = "بطاقه الرقم القومى";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "empphone";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column12.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column12.HeaderText = "رقم الهاتف";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 124;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "empaddress";
            this.Column4.HeaderText = "العنوان";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 95;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "empbirthdate";
            this.Column5.HeaderText = "تاريخ الميلاد";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 138;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "jobtype";
            this.Column6.HeaderText = "نوع الوظيفه";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 132;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "salary";
            this.Column7.HeaderText = "المرتب";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 96;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "empimage";
            this.Column8.HeaderText = "صوره الموظف";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Width = 159;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "deptworkfor";
            this.Column9.HeaderText = "القسم الذى يعمل به";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 181;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "workstartdate";
            this.Column10.HeaderText = "تاريخ بدايه العمل";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 171;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "workhours";
            this.Column11.HeaderText = "عدد ساعات العمل";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 178;
            // 
            // colshift
            // 
            this.colshift.DataPropertyName = "workshift";
            this.colshift.HeaderText = "شيفت العمل";
            this.colshift.MinimumWidth = 6;
            this.colshift.Name = "colshift";
            this.colshift.Width = 130;
            // 
            // FrmShowAllEmps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1422, 738);
            this.ControlBox = false;
            this.Controls.Add(this.txtEmpSearch);
            this.Controls.Add(this.rdoDept);
            this.Controls.Add(this.rdoJobtype);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rdoEmpssn);
            this.Controls.Add(this.rdoEmpName);
            this.Controls.Add(this.dgvShowEmp);
            this.Controls.Add(this.pnlHead);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowAllEmps";
            this.Opacity = 0.95D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmShowAllEmps_Load);
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private SansationRoundButton btnClose;
        private SansationRoundButton btnMinimize;
        private SansationRoundButton btnMaxmize;
        private System.Windows.Forms.TextBox txtEmpSearch;
        private System.Windows.Forms.RadioButton rdoDept;
        private System.Windows.Forms.RadioButton rdoJobtype;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdoEmpssn;
        private System.Windows.Forms.RadioButton rdoEmpName;
        private System.Windows.Forms.DataGridView dgvShowEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn colshift;
    }
}
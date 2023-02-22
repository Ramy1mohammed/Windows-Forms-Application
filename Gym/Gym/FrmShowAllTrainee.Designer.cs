namespace Gym
{
    partial class FrmShowAllTrainee
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
            this.pnlShowAllTrainee = new System.Windows.Forms.Panel();
            this.rdoTrSubsType = new System.Windows.Forms.RadioButton();
            this.txtTrSearch = new System.Windows.Forms.TextBox();
            this.rdoTrCoach = new System.Windows.Forms.RadioButton();
            this.rdoTrSsn = new System.Windows.Forms.RadioButton();
            this.lblTrSearch = new System.Windows.Forms.Label();
            this.rdoTrName = new System.Windows.Forms.RadioButton();
            this.rdoTrCode = new System.Windows.Forms.RadioButton();
            this.dgvShowTrainee = new System.Windows.Forms.DataGridView();
            this.coltrno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrssn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltraddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrbdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrimage = new System.Windows.Forms.DataGridViewImageColumn();
            this.coltrcoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrsubtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrstartsub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrendsub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colexercisetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHead.SuspendLayout();
            this.pnlShowAllTrainee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTrainee)).BeginInit();
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
            this.pnlHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseDown);
            this.pnlHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseMove);
            this.pnlHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1178, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "هذا التطبيق مازال تحت الانشاء بناءا على ما تم تحليله للنظام وتصميمه بداخل قاعده ا" +
    "لبيانات حيث سيتم اضافه شاشات أخرى أساسها موجود بقاعده البيانات";
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
            // pnlShowAllTrainee
            // 
            this.pnlShowAllTrainee.Controls.Add(this.rdoTrSubsType);
            this.pnlShowAllTrainee.Controls.Add(this.txtTrSearch);
            this.pnlShowAllTrainee.Controls.Add(this.rdoTrCoach);
            this.pnlShowAllTrainee.Controls.Add(this.rdoTrSsn);
            this.pnlShowAllTrainee.Controls.Add(this.lblTrSearch);
            this.pnlShowAllTrainee.Controls.Add(this.rdoTrName);
            this.pnlShowAllTrainee.Controls.Add(this.rdoTrCode);
            this.pnlShowAllTrainee.Controls.Add(this.dgvShowTrainee);
            this.pnlShowAllTrainee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShowAllTrainee.Location = new System.Drawing.Point(0, 46);
            this.pnlShowAllTrainee.Name = "pnlShowAllTrainee";
            this.pnlShowAllTrainee.Size = new System.Drawing.Size(1422, 692);
            this.pnlShowAllTrainee.TabIndex = 1;
            // 
            // rdoTrSubsType
            // 
            this.rdoTrSubsType.AutoSize = true;
            this.rdoTrSubsType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoTrSubsType.Location = new System.Drawing.Point(318, 58);
            this.rdoTrSubsType.Name = "rdoTrSubsType";
            this.rdoTrSubsType.Size = new System.Drawing.Size(137, 33);
            this.rdoTrSubsType.TabIndex = 85;
            this.rdoTrSubsType.Text = "نوع الاشتراك";
            this.rdoTrSubsType.UseVisualStyleBackColor = true;
            this.rdoTrSubsType.Click += new System.EventHandler(this.rdoTrCode_Click);
            // 
            // txtTrSearch
            // 
            this.txtTrSearch.BackColor = System.Drawing.Color.Pink;
            this.txtTrSearch.Location = new System.Drawing.Point(984, 58);
            this.txtTrSearch.Name = "txtTrSearch";
            this.txtTrSearch.Size = new System.Drawing.Size(341, 34);
            this.txtTrSearch.TabIndex = 84;
            this.txtTrSearch.TextChanged += new System.EventHandler(this.txtTrSearch_TextChanged);
            // 
            // rdoTrCoach
            // 
            this.rdoTrCoach.AutoSize = true;
            this.rdoTrCoach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoTrCoach.Location = new System.Drawing.Point(456, 58);
            this.rdoTrCoach.Name = "rdoTrCoach";
            this.rdoTrCoach.Size = new System.Drawing.Size(90, 33);
            this.rdoTrCoach.TabIndex = 83;
            this.rdoTrCoach.Text = "المدرب";
            this.rdoTrCoach.UseVisualStyleBackColor = true;
            this.rdoTrCoach.Click += new System.EventHandler(this.rdoTrCode_Click);
            // 
            // rdoTrSsn
            // 
            this.rdoTrSsn.AutoSize = true;
            this.rdoTrSsn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoTrSsn.Location = new System.Drawing.Point(548, 58);
            this.rdoTrSsn.Name = "rdoTrSsn";
            this.rdoTrSsn.Size = new System.Drawing.Size(125, 33);
            this.rdoTrSsn.TabIndex = 82;
            this.rdoTrSsn.Text = "الرقم القومى";
            this.rdoTrSsn.UseVisualStyleBackColor = true;
            this.rdoTrSsn.Click += new System.EventHandler(this.rdoTrCode_Click);
            // 
            // lblTrSearch
            // 
            this.lblTrSearch.AutoSize = true;
            this.lblTrSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrSearch.ForeColor = System.Drawing.Color.Yellow;
            this.lblTrSearch.Location = new System.Drawing.Point(1331, 58);
            this.lblTrSearch.Name = "lblTrSearch";
            this.lblTrSearch.Size = new System.Drawing.Size(71, 29);
            this.lblTrSearch.TabIndex = 81;
            this.lblTrSearch.Text = "البحث:";
            // 
            // rdoTrName
            // 
            this.rdoTrName.AutoSize = true;
            this.rdoTrName.Checked = true;
            this.rdoTrName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoTrName.Location = new System.Drawing.Point(675, 58);
            this.rdoTrName.Name = "rdoTrName";
            this.rdoTrName.Size = new System.Drawing.Size(130, 33);
            this.rdoTrName.TabIndex = 80;
            this.rdoTrName.TabStop = true;
            this.rdoTrName.Text = "اسم المشترك";
            this.rdoTrName.UseVisualStyleBackColor = true;
            this.rdoTrName.Click += new System.EventHandler(this.rdoTrCode_Click);
            // 
            // rdoTrCode
            // 
            this.rdoTrCode.AutoSize = true;
            this.rdoTrCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoTrCode.Location = new System.Drawing.Point(801, 58);
            this.rdoTrCode.Name = "rdoTrCode";
            this.rdoTrCode.Size = new System.Drawing.Size(131, 33);
            this.rdoTrCode.TabIndex = 79;
            this.rdoTrCode.Text = "كود المشترك";
            this.rdoTrCode.UseVisualStyleBackColor = true;
            this.rdoTrCode.Click += new System.EventHandler(this.rdoTrCode_Click);
            // 
            // dgvShowTrainee
            // 
            this.dgvShowTrainee.AllowUserToAddRows = false;
            this.dgvShowTrainee.AllowUserToDeleteRows = false;
            this.dgvShowTrainee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowTrainee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowTrainee.BackgroundColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowTrainee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowTrainee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowTrainee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coltrno,
            this.coltrname,
            this.coltrssn,
            this.coltrphone,
            this.coltraddress,
            this.coltrbdate,
            this.coltrimage,
            this.coltrcoach,
            this.coltrsubtype,
            this.coltrstartsub,
            this.coltrendsub,
            this.colexercisetype});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowTrainee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowTrainee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShowTrainee.EnableHeadersVisualStyles = false;
            this.dgvShowTrainee.Location = new System.Drawing.Point(0, 141);
            this.dgvShowTrainee.MultiSelect = false;
            this.dgvShowTrainee.Name = "dgvShowTrainee";
            this.dgvShowTrainee.ReadOnly = true;
            this.dgvShowTrainee.RowHeadersWidth = 51;
            this.dgvShowTrainee.RowTemplate.Height = 24;
            this.dgvShowTrainee.Size = new System.Drawing.Size(1422, 551);
            this.dgvShowTrainee.TabIndex = 78;
            // 
            // coltrno
            // 
            this.coltrno.DataPropertyName = "trno";
            this.coltrno.HeaderText = "كود المشترك";
            this.coltrno.MinimumWidth = 6;
            this.coltrno.Name = "coltrno";
            this.coltrno.ReadOnly = true;
            // 
            // coltrname
            // 
            this.coltrname.DataPropertyName = "trname";
            this.coltrname.HeaderText = "اسم المشترك";
            this.coltrname.MinimumWidth = 6;
            this.coltrname.Name = "coltrname";
            this.coltrname.ReadOnly = true;
            // 
            // coltrssn
            // 
            this.coltrssn.DataPropertyName = "trssn";
            this.coltrssn.HeaderText = " بطاقه الرقم القومى ";
            this.coltrssn.MinimumWidth = 6;
            this.coltrssn.Name = "coltrssn";
            this.coltrssn.ReadOnly = true;
            // 
            // coltrphone
            // 
            this.coltrphone.DataPropertyName = "trphone";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.coltrphone.DefaultCellStyle = dataGridViewCellStyle2;
            this.coltrphone.HeaderText = "رقم الهاتف";
            this.coltrphone.MinimumWidth = 6;
            this.coltrphone.Name = "coltrphone";
            this.coltrphone.ReadOnly = true;
            // 
            // coltraddress
            // 
            this.coltraddress.DataPropertyName = "traddress";
            this.coltraddress.HeaderText = "العنوان";
            this.coltraddress.MinimumWidth = 6;
            this.coltraddress.Name = "coltraddress";
            this.coltraddress.ReadOnly = true;
            // 
            // coltrbdate
            // 
            this.coltrbdate.DataPropertyName = "trbirthdate";
            this.coltrbdate.HeaderText = "تاريخ الميلاد";
            this.coltrbdate.MinimumWidth = 6;
            this.coltrbdate.Name = "coltrbdate";
            this.coltrbdate.ReadOnly = true;
            // 
            // coltrimage
            // 
            this.coltrimage.DataPropertyName = "trimage";
            this.coltrimage.HeaderText = "صوره المشترك";
            this.coltrimage.MinimumWidth = 6;
            this.coltrimage.Name = "coltrimage";
            this.coltrimage.ReadOnly = true;
            this.coltrimage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coltrimage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // coltrcoach
            // 
            this.coltrcoach.DataPropertyName = "trcoach";
            this.coltrcoach.HeaderText = "المدرب";
            this.coltrcoach.MinimumWidth = 6;
            this.coltrcoach.Name = "coltrcoach";
            this.coltrcoach.ReadOnly = true;
            // 
            // coltrsubtype
            // 
            this.coltrsubtype.DataPropertyName = "subscriptiontype";
            this.coltrsubtype.HeaderText = "نوع الاشتراك";
            this.coltrsubtype.MinimumWidth = 6;
            this.coltrsubtype.Name = "coltrsubtype";
            this.coltrsubtype.ReadOnly = true;
            // 
            // coltrstartsub
            // 
            this.coltrstartsub.DataPropertyName = "subscriptionstart";
            this.coltrstartsub.HeaderText = "بدايه الاشتراك";
            this.coltrstartsub.MinimumWidth = 6;
            this.coltrstartsub.Name = "coltrstartsub";
            this.coltrstartsub.ReadOnly = true;
            // 
            // coltrendsub
            // 
            this.coltrendsub.DataPropertyName = "subscriptionend";
            this.coltrendsub.HeaderText = "نهايه الاشتراك";
            this.coltrendsub.MinimumWidth = 6;
            this.coltrendsub.Name = "coltrendsub";
            this.coltrendsub.ReadOnly = true;
            // 
            // colexercisetype
            // 
            this.colexercisetype.DataPropertyName = "exercisetype";
            this.colexercisetype.HeaderText = "نوع التمرين";
            this.colexercisetype.MinimumWidth = 6;
            this.colexercisetype.Name = "colexercisetype";
            this.colexercisetype.ReadOnly = true;
            // 
            // FrmShowAllTrainee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1422, 738);
            this.ControlBox = false;
            this.Controls.Add(this.pnlShowAllTrainee);
            this.Controls.Add(this.pnlHead);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowAllTrainee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmShowAllTrainee_Load);
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.pnlShowAllTrainee.ResumeLayout(false);
            this.pnlShowAllTrainee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTrainee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private SansationRoundButton btnClose;
        private SansationRoundButton btnMinimize;
        private SansationRoundButton btnMaxmize;
        private System.Windows.Forms.Panel pnlShowAllTrainee;
        private System.Windows.Forms.RadioButton rdoTrSubsType;
        public System.Windows.Forms.TextBox txtTrSearch;
        private System.Windows.Forms.RadioButton rdoTrCoach;
        private System.Windows.Forms.RadioButton rdoTrSsn;
        private System.Windows.Forms.Label lblTrSearch;
        private System.Windows.Forms.RadioButton rdoTrName;
        private System.Windows.Forms.RadioButton rdoTrCode;
        private System.Windows.Forms.DataGridView dgvShowTrainee;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrno;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrname;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrssn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltraddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrbdate;
        private System.Windows.Forms.DataGridViewImageColumn coltrimage;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrcoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrsubtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrstartsub;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrendsub;
        private System.Windows.Forms.DataGridViewTextBoxColumn colexercisetype;
        private System.Windows.Forms.Label label1;
    }
}
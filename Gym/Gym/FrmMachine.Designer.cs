namespace Gym
{
    partial class FrmMachine
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
            this.pnlMachine = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.dgvShowMach = new System.Windows.Forms.DataGridView();
            this.colmachno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMachName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastMaintain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaintainPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNextMaintain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMachPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMachQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMachSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastSupervision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupervisionPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNextSupervision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMachLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxMachLocation = new System.Windows.Forms.ComboBox();
            this.lblMachLocation = new System.Windows.Forms.Label();
            this.btnReportMach = new SansationRoundButton();
            this.btnDeleteMach = new SansationRoundButton();
            this.btnEditMach = new SansationRoundButton();
            this.btnAddMach = new SansationRoundButton();
            this.btnNewMach = new SansationRoundButton();
            this.txtMachPrice = new System.Windows.Forms.TextBox();
            this.dtpNextSupervision = new System.Windows.Forms.DateTimePicker();
            this.lblNextSupervision = new System.Windows.Forms.Label();
            this.txtSupervisionPeriod = new System.Windows.Forms.TextBox();
            this.lblSupervisionPeriod = new System.Windows.Forms.Label();
            this.dtpLastSupervision = new System.Windows.Forms.DateTimePicker();
            this.lblLastSupervision = new System.Windows.Forms.Label();
            this.cbxMachSupervision = new System.Windows.Forms.ComboBox();
            this.lblMachSupervision = new System.Windows.Forms.Label();
            this.lblMachQty = new System.Windows.Forms.Label();
            this.txtMachQty = new System.Windows.Forms.TextBox();
            this.lblMachPrice = new System.Windows.Forms.Label();
            this.txtMaintainPeriod = new System.Windows.Forms.TextBox();
            this.lblMaintainPeriod = new System.Windows.Forms.Label();
            this.dtpNextMaintain = new System.Windows.Forms.DateTimePicker();
            this.lblNextMaintain = new System.Windows.Forms.Label();
            this.dtpLastMaintain = new System.Windows.Forms.DateTimePicker();
            this.lblLastMaintain = new System.Windows.Forms.Label();
            this.txtMachName = new System.Windows.Forms.TextBox();
            this.lblMachName = new System.Windows.Forms.Label();
            this.txtMachCode = new System.Windows.Forms.TextBox();
            this.lblMachCode = new System.Windows.Forms.Label();
            this.epMach = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlMachine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowMach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMach)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMachine
            // 
            this.pnlMachine.Controls.Add(this.lblMsg);
            this.pnlMachine.Controls.Add(this.dgvShowMach);
            this.pnlMachine.Controls.Add(this.cbxMachLocation);
            this.pnlMachine.Controls.Add(this.lblMachLocation);
            this.pnlMachine.Controls.Add(this.btnReportMach);
            this.pnlMachine.Controls.Add(this.btnDeleteMach);
            this.pnlMachine.Controls.Add(this.btnEditMach);
            this.pnlMachine.Controls.Add(this.btnAddMach);
            this.pnlMachine.Controls.Add(this.btnNewMach);
            this.pnlMachine.Controls.Add(this.txtMachPrice);
            this.pnlMachine.Controls.Add(this.dtpNextSupervision);
            this.pnlMachine.Controls.Add(this.lblNextSupervision);
            this.pnlMachine.Controls.Add(this.txtSupervisionPeriod);
            this.pnlMachine.Controls.Add(this.lblSupervisionPeriod);
            this.pnlMachine.Controls.Add(this.dtpLastSupervision);
            this.pnlMachine.Controls.Add(this.lblLastSupervision);
            this.pnlMachine.Controls.Add(this.cbxMachSupervision);
            this.pnlMachine.Controls.Add(this.lblMachSupervision);
            this.pnlMachine.Controls.Add(this.lblMachQty);
            this.pnlMachine.Controls.Add(this.txtMachQty);
            this.pnlMachine.Controls.Add(this.lblMachPrice);
            this.pnlMachine.Controls.Add(this.txtMaintainPeriod);
            this.pnlMachine.Controls.Add(this.lblMaintainPeriod);
            this.pnlMachine.Controls.Add(this.dtpNextMaintain);
            this.pnlMachine.Controls.Add(this.lblNextMaintain);
            this.pnlMachine.Controls.Add(this.dtpLastMaintain);
            this.pnlMachine.Controls.Add(this.lblLastMaintain);
            this.pnlMachine.Controls.Add(this.txtMachName);
            this.pnlMachine.Controls.Add(this.lblMachName);
            this.pnlMachine.Controls.Add(this.txtMachCode);
            this.pnlMachine.Controls.Add(this.lblMachCode);
            this.pnlMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMachine.Location = new System.Drawing.Point(0, 0);
            this.pnlMachine.Name = "pnlMachine";
            this.pnlMachine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMachine.Size = new System.Drawing.Size(1422, 738);
            this.pnlMachine.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblMsg.Location = new System.Drawing.Point(596, 337);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(62, 42);
            this.lblMsg.TabIndex = 66;
            this.lblMsg.Text = ">>";
            // 
            // dgvShowMach
            // 
            this.dgvShowMach.AllowUserToAddRows = false;
            this.dgvShowMach.AllowUserToDeleteRows = false;
            this.dgvShowMach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowMach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowMach.BackgroundColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowMach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowMach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowMach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmachno,
            this.colMachName,
            this.colLastMaintain,
            this.colMaintainPeriod,
            this.colNextMaintain,
            this.colMachPrice,
            this.colMachQty,
            this.ColMachSupervisor,
            this.colLastSupervision,
            this.colSupervisionPeriod,
            this.colNextSupervision,
            this.colMachLocation});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowMach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowMach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShowMach.EnableHeadersVisualStyles = false;
            this.dgvShowMach.Location = new System.Drawing.Point(0, 442);
            this.dgvShowMach.Name = "dgvShowMach";
            this.dgvShowMach.ReadOnly = true;
            this.dgvShowMach.RowHeadersWidth = 51;
            this.dgvShowMach.RowTemplate.Height = 24;
            this.dgvShowMach.Size = new System.Drawing.Size(1422, 296);
            this.dgvShowMach.TabIndex = 65;
            this.dgvShowMach.SelectionChanged += new System.EventHandler(this.dgvShowMach_SelectionChanged);
            // 
            // colmachno
            // 
            this.colmachno.DataPropertyName = "machno";
            this.colmachno.HeaderText = "كود الجهاز";
            this.colmachno.MinimumWidth = 6;
            this.colmachno.Name = "colmachno";
            this.colmachno.ReadOnly = true;
            // 
            // colMachName
            // 
            this.colMachName.DataPropertyName = "machname";
            this.colMachName.HeaderText = "اسم الجهاز";
            this.colMachName.MinimumWidth = 6;
            this.colMachName.Name = "colMachName";
            this.colMachName.ReadOnly = true;
            // 
            // colLastMaintain
            // 
            this.colLastMaintain.DataPropertyName = "lastmaintain";
            this.colLastMaintain.HeaderText = "تاريخ اخرصيانه";
            this.colLastMaintain.MinimumWidth = 6;
            this.colLastMaintain.Name = "colLastMaintain";
            this.colLastMaintain.ReadOnly = true;
            // 
            // colMaintainPeriod
            // 
            this.colMaintainPeriod.DataPropertyName = "maintainperiod";
            this.colMaintainPeriod.HeaderText = "مده الصيانه اللازمه";
            this.colMaintainPeriod.MinimumWidth = 6;
            this.colMaintainPeriod.Name = "colMaintainPeriod";
            this.colMaintainPeriod.ReadOnly = true;
            // 
            // colNextMaintain
            // 
            this.colNextMaintain.DataPropertyName = "nextmaintain";
            this.colNextMaintain.HeaderText = "تاريخ الصيانه القادم";
            this.colNextMaintain.MinimumWidth = 6;
            this.colNextMaintain.Name = "colNextMaintain";
            this.colNextMaintain.ReadOnly = true;
            // 
            // colMachPrice
            // 
            this.colMachPrice.DataPropertyName = "machprice";
            this.colMachPrice.HeaderText = "سعر الجهاز";
            this.colMachPrice.MinimumWidth = 6;
            this.colMachPrice.Name = "colMachPrice";
            this.colMachPrice.ReadOnly = true;
            // 
            // colMachQty
            // 
            this.colMachQty.DataPropertyName = "machqty";
            this.colMachQty.HeaderText = "الكميه المتاحه";
            this.colMachQty.MinimumWidth = 6;
            this.colMachQty.Name = "colMachQty";
            this.colMachQty.ReadOnly = true;
            // 
            // ColMachSupervisor
            // 
            this.ColMachSupervisor.DataPropertyName = "machsupervisormaintainor";
            this.ColMachSupervisor.HeaderText = "المشرف على الجهاز";
            this.ColMachSupervisor.MinimumWidth = 6;
            this.ColMachSupervisor.Name = "ColMachSupervisor";
            this.ColMachSupervisor.ReadOnly = true;
            // 
            // colLastSupervision
            // 
            this.colLastSupervision.DataPropertyName = "machlastsupervison";
            this.colLastSupervision.HeaderText = "تاريخ اخر اشراف";
            this.colLastSupervision.MinimumWidth = 6;
            this.colLastSupervision.Name = "colLastSupervision";
            this.colLastSupervision.ReadOnly = true;
            // 
            // colSupervisionPeriod
            // 
            this.colSupervisionPeriod.DataPropertyName = "machperiodsupervision";
            this.colSupervisionPeriod.HeaderText = "مده الاشراف اللازمه";
            this.colSupervisionPeriod.MinimumWidth = 6;
            this.colSupervisionPeriod.Name = "colSupervisionPeriod";
            this.colSupervisionPeriod.ReadOnly = true;
            // 
            // colNextSupervision
            // 
            this.colNextSupervision.DataPropertyName = "nextmachsupervision";
            this.colNextSupervision.HeaderText = "تاريخ الاشراف القادم";
            this.colNextSupervision.MinimumWidth = 6;
            this.colNextSupervision.Name = "colNextSupervision";
            this.colNextSupervision.ReadOnly = true;
            // 
            // colMachLocation
            // 
            this.colMachLocation.DataPropertyName = "machlocation";
            this.colMachLocation.HeaderText = "موقع الجهاز بالقسم";
            this.colMachLocation.MinimumWidth = 6;
            this.colMachLocation.Name = "colMachLocation";
            this.colMachLocation.ReadOnly = true;
            // 
            // cbxMachLocation
            // 
            this.cbxMachLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMachLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMachLocation.BackColor = System.Drawing.Color.Pink;
            this.cbxMachLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxMachLocation.FormattingEnabled = true;
            this.cbxMachLocation.Items.AddRange(new object[] {
            "رئيس مجلس الاداره",
            "مساعد رئيس مجلس الاداره",
            "المدير العام",
            "رئيس قسم",
            "مشرف قسم",
            "كابتن تدريب (كمال أجسام)",
            "كابتن تدريب Boxing",
            "مدرب مساج",
            "كابتن تدريب رياضات أخرى",
            "كابتن تدريب تأهيل ولياقه بدنيه",
            "مدرب أيروبكس و زومبا",
            "أخصائى علاج طبيعى",
            "موظفين استقبال",
            "عامل نظافه",
            "عامل جاكوزى وساونا",
            "موظفين سيلز",
            "مبيعات مكملات غذائيه",
            "مبيعات مشروبات وأغذيه",
            "عامل صيانه أجهزه تدريب",
            "عامل صيانه كهرباء"});
            this.cbxMachLocation.Location = new System.Drawing.Point(17, 248);
            this.cbxMachLocation.Name = "cbxMachLocation";
            this.cbxMachLocation.Size = new System.Drawing.Size(467, 37);
            this.cbxMachLocation.TabIndex = 64;
            this.cbxMachLocation.SelectionChangeCommitted += new System.EventHandler(this.cbxMachSupervision_SelectionChangeCommitted);
            this.cbxMachLocation.Click += new System.EventHandler(this.cbxMachSupervision_Click);
            this.cbxMachLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxMachSupervision_KeyDown);
            this.cbxMachLocation.Validating += new System.ComponentModel.CancelEventHandler(this.cbxMachSupervision_Validating);
            // 
            // lblMachLocation
            // 
            this.lblMachLocation.AutoSize = true;
            this.lblMachLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachLocation.ForeColor = System.Drawing.Color.Yellow;
            this.lblMachLocation.Location = new System.Drawing.Point(507, 248);
            this.lblMachLocation.Name = "lblMachLocation";
            this.lblMachLocation.Size = new System.Drawing.Size(180, 29);
            this.lblMachLocation.TabIndex = 63;
            this.lblMachLocation.Text = "موقع الجهاز بالقسم:";
            // 
            // btnReportMach
            // 
            this.btnReportMach.BackColor = System.Drawing.Color.Pink;
            this.btnReportMach.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnReportMach.BorderColor = System.Drawing.Color.Black;
            this.btnReportMach.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnReportMach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportMach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReportMach.FlatAppearance.BorderSize = 2;
            this.btnReportMach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportMach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportMach.Location = new System.Drawing.Point(429, 296);
            this.btnReportMach.Name = "btnReportMach";
            this.btnReportMach.Size = new System.Drawing.Size(108, 34);
            this.btnReportMach.TabIndex = 62;
            this.btnReportMach.Text = "تقريـر";
            this.btnReportMach.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnReportMach.UseVisualStyleBackColor = false;
            // 
            // btnDeleteMach
            // 
            this.btnDeleteMach.BackColor = System.Drawing.Color.Pink;
            this.btnDeleteMach.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnDeleteMach.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteMach.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnDeleteMach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteMach.FlatAppearance.BorderSize = 2;
            this.btnDeleteMach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteMach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMach.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteMach.Location = new System.Drawing.Point(543, 296);
            this.btnDeleteMach.Name = "btnDeleteMach";
            this.btnDeleteMach.Size = new System.Drawing.Size(108, 34);
            this.btnDeleteMach.TabIndex = 61;
            this.btnDeleteMach.Text = "حــذف";
            this.btnDeleteMach.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnDeleteMach.UseVisualStyleBackColor = false;
            this.btnDeleteMach.Click += new System.EventHandler(this.btnDeleteMach_Click);
            // 
            // btnEditMach
            // 
            this.btnEditMach.BackColor = System.Drawing.Color.Pink;
            this.btnEditMach.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnEditMach.BorderColor = System.Drawing.Color.Black;
            this.btnEditMach.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnEditMach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditMach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditMach.FlatAppearance.BorderSize = 2;
            this.btnEditMach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditMach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMach.Location = new System.Drawing.Point(657, 296);
            this.btnEditMach.Name = "btnEditMach";
            this.btnEditMach.Size = new System.Drawing.Size(108, 34);
            this.btnEditMach.TabIndex = 60;
            this.btnEditMach.Text = "تعديــل";
            this.btnEditMach.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnEditMach.UseVisualStyleBackColor = false;
            this.btnEditMach.Click += new System.EventHandler(this.btnEditMach_Click);
            // 
            // btnAddMach
            // 
            this.btnAddMach.BackColor = System.Drawing.Color.Pink;
            this.btnAddMach.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnAddMach.BorderColor = System.Drawing.Color.Black;
            this.btnAddMach.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnAddMach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddMach.FlatAppearance.BorderSize = 2;
            this.btnAddMach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMach.Location = new System.Drawing.Point(771, 296);
            this.btnAddMach.Name = "btnAddMach";
            this.btnAddMach.Size = new System.Drawing.Size(108, 34);
            this.btnAddMach.TabIndex = 59;
            this.btnAddMach.Text = "اضــافه";
            this.btnAddMach.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnAddMach.UseVisualStyleBackColor = false;
            this.btnAddMach.Click += new System.EventHandler(this.btnAddMach_Click);
            // 
            // btnNewMach
            // 
            this.btnNewMach.BackColor = System.Drawing.Color.Pink;
            this.btnNewMach.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnNewMach.BorderColor = System.Drawing.Color.Black;
            this.btnNewMach.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnNewMach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewMach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewMach.FlatAppearance.BorderSize = 2;
            this.btnNewMach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewMach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMach.Location = new System.Drawing.Point(885, 296);
            this.btnNewMach.Name = "btnNewMach";
            this.btnNewMach.Size = new System.Drawing.Size(108, 34);
            this.btnNewMach.TabIndex = 58;
            this.btnNewMach.Text = "جديد*";
            this.btnNewMach.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnNewMach.UseVisualStyleBackColor = false;
            this.btnNewMach.Click += new System.EventHandler(this.btnNewMach_Click);
            // 
            // txtMachPrice
            // 
            this.txtMachPrice.BackColor = System.Drawing.Color.Pink;
            this.txtMachPrice.Location = new System.Drawing.Point(763, 242);
            this.txtMachPrice.Name = "txtMachPrice";
            this.txtMachPrice.Size = new System.Drawing.Size(429, 34);
            this.txtMachPrice.TabIndex = 56;
            this.txtMachPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMachPrice_KeyPress);
            // 
            // dtpNextSupervision
            // 
            this.dtpNextSupervision.CalendarFont = new System.Drawing.Font("Impact", 14F);
            this.dtpNextSupervision.CalendarMonthBackground = System.Drawing.Color.Pink;
            this.dtpNextSupervision.CustomFormat = "yyyy/MM/dd";
            this.dtpNextSupervision.Enabled = false;
            this.dtpNextSupervision.Font = new System.Drawing.Font("Impact", 14F);
            this.dtpNextSupervision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNextSupervision.Location = new System.Drawing.Point(17, 204);
            this.dtpNextSupervision.Name = "dtpNextSupervision";
            this.dtpNextSupervision.RightToLeftLayout = true;
            this.dtpNextSupervision.Size = new System.Drawing.Size(467, 36);
            this.dtpNextSupervision.TabIndex = 55;
            this.dtpNextSupervision.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            // 
            // lblNextSupervision
            // 
            this.lblNextSupervision.AutoSize = true;
            this.lblNextSupervision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextSupervision.ForeColor = System.Drawing.Color.Yellow;
            this.lblNextSupervision.Location = new System.Drawing.Point(502, 203);
            this.lblNextSupervision.Name = "lblNextSupervision";
            this.lblNextSupervision.Size = new System.Drawing.Size(199, 29);
            this.lblNextSupervision.TabIndex = 54;
            this.lblNextSupervision.Text = "تاريخ الاشراف القادم:";
            // 
            // txtSupervisionPeriod
            // 
            this.txtSupervisionPeriod.BackColor = System.Drawing.Color.Pink;
            this.txtSupervisionPeriod.Location = new System.Drawing.Point(17, 164);
            this.txtSupervisionPeriod.Name = "txtSupervisionPeriod";
            this.txtSupervisionPeriod.Size = new System.Drawing.Size(467, 34);
            this.txtSupervisionPeriod.TabIndex = 53;
            this.txtSupervisionPeriod.Text = "0";
            this.txtSupervisionPeriod.TextChanged += new System.EventHandler(this.txtSupervisionPeriod_TextChanged);
            this.txtSupervisionPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaintainPeriod_KeyPress);
            // 
            // lblSupervisionPeriod
            // 
            this.lblSupervisionPeriod.AutoSize = true;
            this.lblSupervisionPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisionPeriod.ForeColor = System.Drawing.Color.Yellow;
            this.lblSupervisionPeriod.Location = new System.Drawing.Point(507, 164);
            this.lblSupervisionPeriod.Name = "lblSupervisionPeriod";
            this.lblSupervisionPeriod.Size = new System.Drawing.Size(194, 29);
            this.lblSupervisionPeriod.TabIndex = 52;
            this.lblSupervisionPeriod.Text = "مده الاشراف اللازمه:";
            // 
            // dtpLastSupervision
            // 
            this.dtpLastSupervision.CalendarFont = new System.Drawing.Font("Impact", 14F);
            this.dtpLastSupervision.CalendarMonthBackground = System.Drawing.Color.Pink;
            this.dtpLastSupervision.CustomFormat = "yyyy/MM/dd";
            this.dtpLastSupervision.Font = new System.Drawing.Font("Impact", 14F);
            this.dtpLastSupervision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLastSupervision.Location = new System.Drawing.Point(17, 121);
            this.dtpLastSupervision.Name = "dtpLastSupervision";
            this.dtpLastSupervision.RightToLeftLayout = true;
            this.dtpLastSupervision.Size = new System.Drawing.Size(467, 36);
            this.dtpLastSupervision.TabIndex = 51;
            this.dtpLastSupervision.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            this.dtpLastSupervision.ValueChanged += new System.EventHandler(this.dtpLastSupervision_ValueChanged);
            // 
            // lblLastSupervision
            // 
            this.lblLastSupervision.AutoSize = true;
            this.lblLastSupervision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastSupervision.ForeColor = System.Drawing.Color.Yellow;
            this.lblLastSupervision.Location = new System.Drawing.Point(527, 121);
            this.lblLastSupervision.Name = "lblLastSupervision";
            this.lblLastSupervision.Size = new System.Drawing.Size(174, 29);
            this.lblLastSupervision.TabIndex = 50;
            this.lblLastSupervision.Text = "تاريخ اخر اشراف:";
            // 
            // cbxMachSupervision
            // 
            this.cbxMachSupervision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMachSupervision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMachSupervision.BackColor = System.Drawing.Color.Pink;
            this.cbxMachSupervision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxMachSupervision.FormattingEnabled = true;
            this.cbxMachSupervision.Items.AddRange(new object[] {
            "رئيس مجلس الاداره",
            "مساعد رئيس مجلس الاداره",
            "المدير العام",
            "رئيس قسم",
            "مشرف قسم",
            "كابتن تدريب (كمال أجسام)",
            "كابتن تدريب Boxing",
            "مدرب مساج",
            "كابتن تدريب رياضات أخرى",
            "كابتن تدريب تأهيل ولياقه بدنيه",
            "مدرب أيروبكس و زومبا",
            "أخصائى علاج طبيعى",
            "موظفين استقبال",
            "عامل نظافه",
            "عامل جاكوزى وساونا",
            "موظفين سيلز",
            "مبيعات مكملات غذائيه",
            "مبيعات مشروبات وأغذيه",
            "عامل صيانه أجهزه تدريب",
            "عامل صيانه كهرباء"});
            this.cbxMachSupervision.Location = new System.Drawing.Point(17, 78);
            this.cbxMachSupervision.Name = "cbxMachSupervision";
            this.cbxMachSupervision.Size = new System.Drawing.Size(467, 37);
            this.cbxMachSupervision.TabIndex = 49;
            this.cbxMachSupervision.SelectionChangeCommitted += new System.EventHandler(this.cbxMachSupervision_SelectionChangeCommitted);
            this.cbxMachSupervision.Click += new System.EventHandler(this.cbxMachSupervision_Click);
            this.cbxMachSupervision.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxMachSupervision_KeyDown);
            this.cbxMachSupervision.Validating += new System.ComponentModel.CancelEventHandler(this.cbxMachSupervision_Validating);
            // 
            // lblMachSupervision
            // 
            this.lblMachSupervision.AutoSize = true;
            this.lblMachSupervision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachSupervision.ForeColor = System.Drawing.Color.Yellow;
            this.lblMachSupervision.Location = new System.Drawing.Point(507, 78);
            this.lblMachSupervision.Name = "lblMachSupervision";
            this.lblMachSupervision.Size = new System.Drawing.Size(194, 29);
            this.lblMachSupervision.TabIndex = 48;
            this.lblMachSupervision.Text = "المشرف على الجهاز:";
            // 
            // lblMachQty
            // 
            this.lblMachQty.AutoSize = true;
            this.lblMachQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachQty.ForeColor = System.Drawing.Color.Yellow;
            this.lblMachQty.Location = new System.Drawing.Point(555, 37);
            this.lblMachQty.Name = "lblMachQty";
            this.lblMachQty.Size = new System.Drawing.Size(136, 29);
            this.lblMachQty.TabIndex = 47;
            this.lblMachQty.Text = "الكميه المتاحه:";
            // 
            // txtMachQty
            // 
            this.txtMachQty.BackColor = System.Drawing.Color.Pink;
            this.txtMachQty.Location = new System.Drawing.Point(17, 37);
            this.txtMachQty.Name = "txtMachQty";
            this.txtMachQty.Size = new System.Drawing.Size(467, 34);
            this.txtMachQty.TabIndex = 46;
            this.txtMachQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaintainPeriod_KeyPress);
            // 
            // lblMachPrice
            // 
            this.lblMachPrice.AutoSize = true;
            this.lblMachPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachPrice.ForeColor = System.Drawing.Color.Yellow;
            this.lblMachPrice.Location = new System.Drawing.Point(1275, 245);
            this.lblMachPrice.Name = "lblMachPrice";
            this.lblMachPrice.Size = new System.Drawing.Size(120, 29);
            this.lblMachPrice.TabIndex = 45;
            this.lblMachPrice.Text = "سعر الجهاز:";
            // 
            // txtMaintainPeriod
            // 
            this.txtMaintainPeriod.BackColor = System.Drawing.Color.Pink;
            this.txtMaintainPeriod.Location = new System.Drawing.Point(763, 160);
            this.txtMaintainPeriod.Name = "txtMaintainPeriod";
            this.txtMaintainPeriod.Size = new System.Drawing.Size(429, 34);
            this.txtMaintainPeriod.TabIndex = 44;
            this.txtMaintainPeriod.Text = "0";
            this.txtMaintainPeriod.TextChanged += new System.EventHandler(this.txtMaintainPeriod_TextChanged);
            this.txtMaintainPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaintainPeriod_KeyPress);
            // 
            // lblMaintainPeriod
            // 
            this.lblMaintainPeriod.AutoSize = true;
            this.lblMaintainPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintainPeriod.ForeColor = System.Drawing.Color.Yellow;
            this.lblMaintainPeriod.Location = new System.Drawing.Point(1221, 160);
            this.lblMaintainPeriod.Name = "lblMaintainPeriod";
            this.lblMaintainPeriod.Size = new System.Drawing.Size(185, 29);
            this.lblMaintainPeriod.TabIndex = 43;
            this.lblMaintainPeriod.Text = "مده الصيانه اللازمه:";
            // 
            // dtpNextMaintain
            // 
            this.dtpNextMaintain.CalendarFont = new System.Drawing.Font("Impact", 14F);
            this.dtpNextMaintain.CalendarMonthBackground = System.Drawing.Color.Pink;
            this.dtpNextMaintain.CustomFormat = "yyyy/MM/dd";
            this.dtpNextMaintain.Enabled = false;
            this.dtpNextMaintain.Font = new System.Drawing.Font("Impact", 14F);
            this.dtpNextMaintain.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNextMaintain.Location = new System.Drawing.Point(763, 200);
            this.dtpNextMaintain.Name = "dtpNextMaintain";
            this.dtpNextMaintain.RightToLeftLayout = true;
            this.dtpNextMaintain.Size = new System.Drawing.Size(429, 36);
            this.dtpNextMaintain.TabIndex = 42;
            this.dtpNextMaintain.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            // 
            // lblNextMaintain
            // 
            this.lblNextMaintain.AutoSize = true;
            this.lblNextMaintain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextMaintain.ForeColor = System.Drawing.Color.Yellow;
            this.lblNextMaintain.Location = new System.Drawing.Point(1216, 207);
            this.lblNextMaintain.Name = "lblNextMaintain";
            this.lblNextMaintain.Size = new System.Drawing.Size(190, 29);
            this.lblNextMaintain.TabIndex = 41;
            this.lblNextMaintain.Text = "تاريخ الصيانه القادم:";
            // 
            // dtpLastMaintain
            // 
            this.dtpLastMaintain.CalendarFont = new System.Drawing.Font("Impact", 14F);
            this.dtpLastMaintain.CalendarMonthBackground = System.Drawing.Color.Pink;
            this.dtpLastMaintain.CustomFormat = "yyyy/MM/dd";
            this.dtpLastMaintain.Font = new System.Drawing.Font("Impact", 14F);
            this.dtpLastMaintain.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLastMaintain.Location = new System.Drawing.Point(763, 118);
            this.dtpLastMaintain.Name = "dtpLastMaintain";
            this.dtpLastMaintain.RightToLeftLayout = true;
            this.dtpLastMaintain.Size = new System.Drawing.Size(429, 36);
            this.dtpLastMaintain.TabIndex = 40;
            this.dtpLastMaintain.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            this.dtpLastMaintain.ValueChanged += new System.EventHandler(this.dtpLastMaintain_ValueChanged);
            // 
            // lblLastMaintain
            // 
            this.lblLastMaintain.AutoSize = true;
            this.lblLastMaintain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMaintain.ForeColor = System.Drawing.Color.Yellow;
            this.lblLastMaintain.Location = new System.Drawing.Point(1239, 118);
            this.lblLastMaintain.Name = "lblLastMaintain";
            this.lblLastMaintain.Size = new System.Drawing.Size(167, 29);
            this.lblLastMaintain.TabIndex = 39;
            this.lblLastMaintain.Text = "تاريخ اخر صيانه:";
            // 
            // txtMachName
            // 
            this.txtMachName.BackColor = System.Drawing.Color.Pink;
            this.txtMachName.Location = new System.Drawing.Point(763, 78);
            this.txtMachName.Name = "txtMachName";
            this.txtMachName.Size = new System.Drawing.Size(429, 34);
            this.txtMachName.TabIndex = 38;
            this.txtMachName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMachName_KeyPress);
            // 
            // lblMachName
            // 
            this.lblMachName.AutoSize = true;
            this.lblMachName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachName.ForeColor = System.Drawing.Color.Yellow;
            this.lblMachName.Location = new System.Drawing.Point(1285, 78);
            this.lblMachName.Name = "lblMachName";
            this.lblMachName.Size = new System.Drawing.Size(112, 29);
            this.lblMachName.TabIndex = 37;
            this.lblMachName.Text = "اسم الجهاز:";
            // 
            // txtMachCode
            // 
            this.txtMachCode.BackColor = System.Drawing.Color.Pink;
            this.txtMachCode.Location = new System.Drawing.Point(763, 38);
            this.txtMachCode.Name = "txtMachCode";
            this.txtMachCode.ReadOnly = true;
            this.txtMachCode.Size = new System.Drawing.Size(429, 34);
            this.txtMachCode.TabIndex = 36;
            this.txtMachCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMachCode
            // 
            this.lblMachCode.AutoSize = true;
            this.lblMachCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachCode.ForeColor = System.Drawing.Color.Yellow;
            this.lblMachCode.Location = new System.Drawing.Point(1284, 40);
            this.lblMachCode.Name = "lblMachCode";
            this.lblMachCode.Size = new System.Drawing.Size(113, 29);
            this.lblMachCode.TabIndex = 35;
            this.lblMachCode.Text = "كود الجهاز:";
            // 
            // epMach
            // 
            this.epMach.ContainerControl = this;
            // 
            // FrmMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1422, 738);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMachine);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMachine";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Deactivate += new System.EventHandler(this.FrmMachine_Deactivate);
            this.Load += new System.EventHandler(this.FrmMachine_Load);
            this.pnlMachine.ResumeLayout(false);
            this.pnlMachine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowMach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMachine;
        private SansationRoundButton btnReportMach;
        private SansationRoundButton btnDeleteMach;
        private SansationRoundButton btnEditMach;
        private SansationRoundButton btnAddMach;
        private SansationRoundButton btnNewMach;
        public System.Windows.Forms.TextBox txtMachPrice;
        public System.Windows.Forms.DateTimePicker dtpNextSupervision;
        private System.Windows.Forms.Label lblNextSupervision;
        public System.Windows.Forms.TextBox txtSupervisionPeriod;
        private System.Windows.Forms.Label lblSupervisionPeriod;
        public System.Windows.Forms.DateTimePicker dtpLastSupervision;
        private System.Windows.Forms.Label lblLastSupervision;
        public System.Windows.Forms.ComboBox cbxMachSupervision;
        private System.Windows.Forms.Label lblMachSupervision;
        private System.Windows.Forms.Label lblMachQty;
        public System.Windows.Forms.TextBox txtMachQty;
        private System.Windows.Forms.Label lblMachPrice;
        public System.Windows.Forms.TextBox txtMaintainPeriod;
        private System.Windows.Forms.Label lblMaintainPeriod;
        public System.Windows.Forms.DateTimePicker dtpNextMaintain;
        private System.Windows.Forms.Label lblNextMaintain;
        public System.Windows.Forms.DateTimePicker dtpLastMaintain;
        private System.Windows.Forms.Label lblLastMaintain;
        public System.Windows.Forms.TextBox txtMachName;
        private System.Windows.Forms.Label lblMachName;
        public System.Windows.Forms.TextBox txtMachCode;
        private System.Windows.Forms.Label lblMachCode;
        public System.Windows.Forms.ComboBox cbxMachLocation;
        private System.Windows.Forms.Label lblMachLocation;
        private System.Windows.Forms.DataGridView dgvShowMach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmachno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMachName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastMaintain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaintainPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNextMaintain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMachPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMachQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMachSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastSupervision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupervisionPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNextSupervision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMachLocation;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ErrorProvider epMach;
    }
}
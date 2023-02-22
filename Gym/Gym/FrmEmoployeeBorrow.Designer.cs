namespace Gym
{
    partial class FrmEmoployeeBorrow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFrmEmployeeBorrow = new System.Windows.Forms.Panel();
            this.rdoBorrowerResponsible = new System.Windows.Forms.RadioButton();
            this.rdoBorrowerName = new System.Windows.Forms.RadioButton();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvShowBorrow = new System.Windows.Forms.DataGridView();
            this.btnReportBorrow = new SansationRoundButton();
            this.btnDeleteBorrow = new SansationRoundButton();
            this.btnEditBorrow = new SansationRoundButton();
            this.btnAddBorrow = new SansationRoundButton();
            this.btnNewBorrow = new SansationRoundButton();
            this.cbxBorrowResponsible = new System.Windows.Forms.ComboBox();
            this.lblBorrowResponsible = new System.Windows.Forms.Label();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.txtRestOfSalary = new System.Windows.Forms.TextBox();
            this.lblRestOfSalary = new System.Windows.Forms.Label();
            this.txtBorrowValue = new System.Windows.Forms.TextBox();
            this.lblBorrowValue = new System.Windows.Forms.Label();
            this.cbxEmpnameBorrow = new System.Windows.Forms.ComboBox();
            this.lblEmpnameBorrow = new System.Windows.Forms.Label();
            this.colempnoborrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpBorrowName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colempsalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRestOfBorrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRestOfSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colempnoresponsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowResponsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFrmEmployeeBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFrmEmployeeBorrow
            // 
            this.pnlFrmEmployeeBorrow.Controls.Add(this.rdoBorrowerResponsible);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.rdoBorrowerName);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.lblMsg);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.txtSearch);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.lblSearch);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.dgvShowBorrow);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.btnReportBorrow);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.btnDeleteBorrow);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.btnEditBorrow);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.btnAddBorrow);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.btnNewBorrow);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.cbxBorrowResponsible);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.lblBorrowResponsible);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.dtpBorrowDate);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.lblBorrowDate);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.txtRestOfSalary);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.lblRestOfSalary);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.txtBorrowValue);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.lblBorrowValue);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.cbxEmpnameBorrow);
            this.pnlFrmEmployeeBorrow.Controls.Add(this.lblEmpnameBorrow);
            this.pnlFrmEmployeeBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFrmEmployeeBorrow.Location = new System.Drawing.Point(0, 0);
            this.pnlFrmEmployeeBorrow.Name = "pnlFrmEmployeeBorrow";
            this.pnlFrmEmployeeBorrow.Size = new System.Drawing.Size(1422, 738);
            this.pnlFrmEmployeeBorrow.TabIndex = 0;
            // 
            // rdoBorrowerResponsible
            // 
            this.rdoBorrowerResponsible.AutoSize = true;
            this.rdoBorrowerResponsible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoBorrowerResponsible.Location = new System.Drawing.Point(969, 333);
            this.rdoBorrowerResponsible.Name = "rdoBorrowerResponsible";
            this.rdoBorrowerResponsible.Size = new System.Drawing.Size(248, 33);
            this.rdoBorrowerResponsible.TabIndex = 84;
            this.rdoBorrowerResponsible.TabStop = true;
            this.rdoBorrowerResponsible.Text = "المسئول عن اعطاء المستلف";
            this.rdoBorrowerResponsible.UseVisualStyleBackColor = true;
            this.rdoBorrowerResponsible.CheckedChanged += new System.EventHandler(this.rdoBorrowerName_CheckedChanged);
            // 
            // rdoBorrowerName
            // 
            this.rdoBorrowerName.AutoSize = true;
            this.rdoBorrowerName.Checked = true;
            this.rdoBorrowerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoBorrowerName.Location = new System.Drawing.Point(1223, 333);
            this.rdoBorrowerName.Name = "rdoBorrowerName";
            this.rdoBorrowerName.Size = new System.Drawing.Size(128, 33);
            this.rdoBorrowerName.TabIndex = 83;
            this.rdoBorrowerName.TabStop = true;
            this.rdoBorrowerName.Text = "اسم المستلف";
            this.rdoBorrowerName.UseVisualStyleBackColor = true;
            this.rdoBorrowerName.CheckedChanged += new System.EventHandler(this.rdoBorrowerName_CheckedChanged);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblMsg.Location = new System.Drawing.Point(562, 347);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(62, 42);
            this.lblMsg.TabIndex = 82;
            this.lblMsg.Text = ">>";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Pink;
            this.txtSearch.Location = new System.Drawing.Point(978, 284);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(341, 34);
            this.txtSearch.TabIndex = 81;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Yellow;
            this.lblSearch.Location = new System.Drawing.Point(1325, 284);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(71, 29);
            this.lblSearch.TabIndex = 80;
            this.lblSearch.Text = "البحث:";
            // 
            // dgvShowBorrow
            // 
            this.dgvShowBorrow.AllowUserToAddRows = false;
            this.dgvShowBorrow.AllowUserToDeleteRows = false;
            this.dgvShowBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowBorrow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowBorrow.BackgroundColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowBorrow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvShowBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colempnoborrow,
            this.colEmpBorrowName,
            this.colempsalary,
            this.colRestOfBorrow,
            this.colRestOfSalary,
            this.colBorrowDate,
            this.colempnoresponsible,
            this.colBorrowResponsible});
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowBorrow.DefaultCellStyle = dataGridViewCellStyle39;
            this.dgvShowBorrow.EnableHeadersVisualStyles = false;
            this.dgvShowBorrow.Location = new System.Drawing.Point(5, 405);
            this.dgvShowBorrow.Name = "dgvShowBorrow";
            this.dgvShowBorrow.ReadOnly = true;
            this.dgvShowBorrow.RowHeadersWidth = 51;
            this.dgvShowBorrow.RowTemplate.Height = 24;
            this.dgvShowBorrow.Size = new System.Drawing.Size(1410, 324);
            this.dgvShowBorrow.TabIndex = 79;
            this.dgvShowBorrow.SelectionChanged += new System.EventHandler(this.dgvShowBorrow_SelectionChanged);
            // 
            // btnReportBorrow
            // 
            this.btnReportBorrow.BackColor = System.Drawing.Color.Pink;
            this.btnReportBorrow.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnReportBorrow.BorderColor = System.Drawing.Color.Black;
            this.btnReportBorrow.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnReportBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportBorrow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReportBorrow.FlatAppearance.BorderSize = 2;
            this.btnReportBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportBorrow.Location = new System.Drawing.Point(381, 284);
            this.btnReportBorrow.Name = "btnReportBorrow";
            this.btnReportBorrow.Size = new System.Drawing.Size(108, 34);
            this.btnReportBorrow.TabIndex = 67;
            this.btnReportBorrow.Text = "تقريـر";
            this.btnReportBorrow.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnReportBorrow.UseVisualStyleBackColor = false;
            // 
            // btnDeleteBorrow
            // 
            this.btnDeleteBorrow.BackColor = System.Drawing.Color.Pink;
            this.btnDeleteBorrow.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnDeleteBorrow.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteBorrow.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnDeleteBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBorrow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteBorrow.FlatAppearance.BorderSize = 2;
            this.btnDeleteBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBorrow.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteBorrow.Location = new System.Drawing.Point(495, 284);
            this.btnDeleteBorrow.Name = "btnDeleteBorrow";
            this.btnDeleteBorrow.Size = new System.Drawing.Size(108, 34);
            this.btnDeleteBorrow.TabIndex = 66;
            this.btnDeleteBorrow.Text = "حــذف";
            this.btnDeleteBorrow.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnDeleteBorrow.UseVisualStyleBackColor = false;
            this.btnDeleteBorrow.Click += new System.EventHandler(this.btnDeleteBorrow_Click);
            // 
            // btnEditBorrow
            // 
            this.btnEditBorrow.BackColor = System.Drawing.Color.Pink;
            this.btnEditBorrow.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnEditBorrow.BorderColor = System.Drawing.Color.Black;
            this.btnEditBorrow.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnEditBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditBorrow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditBorrow.FlatAppearance.BorderSize = 2;
            this.btnEditBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBorrow.Location = new System.Drawing.Point(609, 284);
            this.btnEditBorrow.Name = "btnEditBorrow";
            this.btnEditBorrow.Size = new System.Drawing.Size(108, 34);
            this.btnEditBorrow.TabIndex = 65;
            this.btnEditBorrow.Text = "تعديــل";
            this.btnEditBorrow.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnEditBorrow.UseVisualStyleBackColor = false;
            this.btnEditBorrow.Click += new System.EventHandler(this.btnEditBorrow_Click);
            // 
            // btnAddBorrow
            // 
            this.btnAddBorrow.BackColor = System.Drawing.Color.Pink;
            this.btnAddBorrow.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnAddBorrow.BorderColor = System.Drawing.Color.Black;
            this.btnAddBorrow.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnAddBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBorrow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddBorrow.FlatAppearance.BorderSize = 2;
            this.btnAddBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBorrow.Location = new System.Drawing.Point(723, 284);
            this.btnAddBorrow.Name = "btnAddBorrow";
            this.btnAddBorrow.Size = new System.Drawing.Size(108, 34);
            this.btnAddBorrow.TabIndex = 64;
            this.btnAddBorrow.Text = "اضــافه";
            this.btnAddBorrow.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnAddBorrow.UseVisualStyleBackColor = false;
            this.btnAddBorrow.Click += new System.EventHandler(this.btnAddBorrow_Click);
            // 
            // btnNewBorrow
            // 
            this.btnNewBorrow.BackColor = System.Drawing.Color.Pink;
            this.btnNewBorrow.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnNewBorrow.BorderColor = System.Drawing.Color.Black;
            this.btnNewBorrow.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnNewBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewBorrow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewBorrow.FlatAppearance.BorderSize = 2;
            this.btnNewBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBorrow.Location = new System.Drawing.Point(837, 284);
            this.btnNewBorrow.Name = "btnNewBorrow";
            this.btnNewBorrow.Size = new System.Drawing.Size(108, 34);
            this.btnNewBorrow.TabIndex = 63;
            this.btnNewBorrow.Text = "جديد*";
            this.btnNewBorrow.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnNewBorrow.UseVisualStyleBackColor = false;
            this.btnNewBorrow.Click += new System.EventHandler(this.btnNewBorrow_Click);
            // 
            // cbxBorrowResponsible
            // 
            this.cbxBorrowResponsible.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxBorrowResponsible.BackColor = System.Drawing.Color.Pink;
            this.cbxBorrowResponsible.FormattingEnabled = true;
            this.cbxBorrowResponsible.Location = new System.Drawing.Point(381, 198);
            this.cbxBorrowResponsible.Name = "cbxBorrowResponsible";
            this.cbxBorrowResponsible.Size = new System.Drawing.Size(728, 37);
            this.cbxBorrowResponsible.TabIndex = 62;
            this.cbxBorrowResponsible.SelectionChangeCommitted += new System.EventHandler(this.cbxEmpnameBorrow_SelectionChangeCommitted);
            this.cbxBorrowResponsible.Click += new System.EventHandler(this.cbxEmpnameBorrow_Click);
            this.cbxBorrowResponsible.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxEmpnameBorrow_KeyDown);
            this.cbxBorrowResponsible.Validating += new System.ComponentModel.CancelEventHandler(this.cbxEmpnameBorrow_Validating);
            // 
            // lblBorrowResponsible
            // 
            this.lblBorrowResponsible.AutoSize = true;
            this.lblBorrowResponsible.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowResponsible.ForeColor = System.Drawing.Color.Yellow;
            this.lblBorrowResponsible.Location = new System.Drawing.Point(1152, 198);
            this.lblBorrowResponsible.Name = "lblBorrowResponsible";
            this.lblBorrowResponsible.Size = new System.Drawing.Size(258, 29);
            this.lblBorrowResponsible.TabIndex = 61;
            this.lblBorrowResponsible.Text = "المسئول عن اعطاء المستلف:";
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.CalendarFont = new System.Drawing.Font("Impact", 14F);
            this.dtpBorrowDate.CalendarMonthBackground = System.Drawing.Color.Pink;
            this.dtpBorrowDate.CustomFormat = "yyyy/MM/dd";
            this.dtpBorrowDate.Font = new System.Drawing.Font("Impact", 14F);
            this.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBorrowDate.Location = new System.Drawing.Point(381, 156);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.RightToLeftLayout = true;
            this.dtpBorrowDate.Size = new System.Drawing.Size(728, 36);
            this.dtpBorrowDate.TabIndex = 60;
            this.dtpBorrowDate.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblBorrowDate.Location = new System.Drawing.Point(1259, 162);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(151, 29);
            this.lblBorrowDate.TabIndex = 59;
            this.lblBorrowDate.Text = "تاريخ الاستلاف:";
            // 
            // txtRestOfSalary
            // 
            this.txtRestOfSalary.BackColor = System.Drawing.Color.Pink;
            this.txtRestOfSalary.Location = new System.Drawing.Point(381, 116);
            this.txtRestOfSalary.Name = "txtRestOfSalary";
            this.txtRestOfSalary.ReadOnly = true;
            this.txtRestOfSalary.Size = new System.Drawing.Size(728, 34);
            this.txtRestOfSalary.TabIndex = 58;
            // 
            // lblRestOfSalary
            // 
            this.lblRestOfSalary.AutoSize = true;
            this.lblRestOfSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestOfSalary.ForeColor = System.Drawing.Color.Yellow;
            this.lblRestOfSalary.Location = new System.Drawing.Point(1127, 121);
            this.lblRestOfSalary.Name = "lblRestOfSalary";
            this.lblRestOfSalary.Size = new System.Drawing.Size(292, 29);
            this.lblRestOfSalary.TabIndex = 57;
            this.lblRestOfSalary.Text = "المتبقى من المرتب بعد الاستلاف:";
            // 
            // txtBorrowValue
            // 
            this.txtBorrowValue.BackColor = System.Drawing.Color.Pink;
            this.txtBorrowValue.Location = new System.Drawing.Point(381, 76);
            this.txtBorrowValue.Name = "txtBorrowValue";
            this.txtBorrowValue.Size = new System.Drawing.Size(728, 34);
            this.txtBorrowValue.TabIndex = 56;
            this.txtBorrowValue.TextChanged += new System.EventHandler(this.txtBorrowValue_TextChanged);
            this.txtBorrowValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBorrowValue_KeyPress);
            // 
            // lblBorrowValue
            // 
            this.lblBorrowValue.AutoSize = true;
            this.lblBorrowValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblBorrowValue.Location = new System.Drawing.Point(1259, 76);
            this.lblBorrowValue.Name = "lblBorrowValue";
            this.lblBorrowValue.Size = new System.Drawing.Size(137, 29);
            this.lblBorrowValue.TabIndex = 55;
            this.lblBorrowValue.Text = "قيمه الاستلاف:";
            // 
            // cbxEmpnameBorrow
            // 
            this.cbxEmpnameBorrow.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEmpnameBorrow.BackColor = System.Drawing.Color.Pink;
            this.cbxEmpnameBorrow.FormattingEnabled = true;
            this.cbxEmpnameBorrow.Location = new System.Drawing.Point(381, 36);
            this.cbxEmpnameBorrow.Name = "cbxEmpnameBorrow";
            this.cbxEmpnameBorrow.Size = new System.Drawing.Size(728, 37);
            this.cbxEmpnameBorrow.TabIndex = 54;
            this.cbxEmpnameBorrow.SelectedIndexChanged += new System.EventHandler(this.cbxEmpnameBorrow_SelectedIndexChanged);
            this.cbxEmpnameBorrow.SelectionChangeCommitted += new System.EventHandler(this.cbxEmpnameBorrow_SelectionChangeCommitted);
            this.cbxEmpnameBorrow.Click += new System.EventHandler(this.cbxEmpnameBorrow_Click);
            this.cbxEmpnameBorrow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxEmpnameBorrow_KeyDown);
            this.cbxEmpnameBorrow.Validating += new System.ComponentModel.CancelEventHandler(this.cbxEmpnameBorrow_Validating);
            // 
            // lblEmpnameBorrow
            // 
            this.lblEmpnameBorrow.AutoSize = true;
            this.lblEmpnameBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpnameBorrow.ForeColor = System.Drawing.Color.Yellow;
            this.lblEmpnameBorrow.Location = new System.Drawing.Point(1210, 36);
            this.lblEmpnameBorrow.Name = "lblEmpnameBorrow";
            this.lblEmpnameBorrow.Size = new System.Drawing.Size(200, 29);
            this.lblEmpnameBorrow.TabIndex = 53;
            this.lblEmpnameBorrow.Text = "اسم الموظف المستلف:";
            // 
            // colempnoborrow
            // 
            this.colempnoborrow.DataPropertyName = "empno";
            this.colempnoborrow.HeaderText = "كود المستلف";
            this.colempnoborrow.MinimumWidth = 6;
            this.colempnoborrow.Name = "colempnoborrow";
            this.colempnoborrow.ReadOnly = true;
            this.colempnoborrow.Visible = false;
            // 
            // colEmpBorrowName
            // 
            this.colEmpBorrowName.DataPropertyName = "empname";
            this.colEmpBorrowName.HeaderText = "اسم المستلف";
            this.colEmpBorrowName.MinimumWidth = 6;
            this.colEmpBorrowName.Name = "colEmpBorrowName";
            this.colEmpBorrowName.ReadOnly = true;
            // 
            // colempsalary
            // 
            this.colempsalary.DataPropertyName = "empsalary";
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colempsalary.DefaultCellStyle = dataGridViewCellStyle38;
            this.colempsalary.HeaderText = "مرتب الموظف";
            this.colempsalary.MinimumWidth = 6;
            this.colempsalary.Name = "colempsalary";
            this.colempsalary.ReadOnly = true;
            // 
            // colRestOfBorrow
            // 
            this.colRestOfBorrow.DataPropertyName = "borrowvalue";
            this.colRestOfBorrow.HeaderText = "قيمه الاستلاف";
            this.colRestOfBorrow.MinimumWidth = 6;
            this.colRestOfBorrow.Name = "colRestOfBorrow";
            this.colRestOfBorrow.ReadOnly = true;
            // 
            // colRestOfSalary
            // 
            this.colRestOfSalary.DataPropertyName = "restofsalary";
            this.colRestOfSalary.HeaderText = "المتبقى من المرتب بعد الاستلاف";
            this.colRestOfSalary.MinimumWidth = 6;
            this.colRestOfSalary.Name = "colRestOfSalary";
            this.colRestOfSalary.ReadOnly = true;
            // 
            // colBorrowDate
            // 
            this.colBorrowDate.DataPropertyName = "dateofborrow";
            this.colBorrowDate.HeaderText = "تاريخ الاستلاف";
            this.colBorrowDate.MinimumWidth = 6;
            this.colBorrowDate.Name = "colBorrowDate";
            this.colBorrowDate.ReadOnly = true;
            // 
            // colempnoresponsible
            // 
            this.colempnoresponsible.DataPropertyName = "empresponsibleno";
            this.colempnoresponsible.HeaderText = "كود المسئول عن الاستلاف";
            this.colempnoresponsible.MinimumWidth = 6;
            this.colempnoresponsible.Name = "colempnoresponsible";
            this.colempnoresponsible.ReadOnly = true;
            this.colempnoresponsible.Visible = false;
            // 
            // colBorrowResponsible
            // 
            this.colBorrowResponsible.DataPropertyName = "empreponsiblename";
            this.colBorrowResponsible.HeaderText = "المسئول عن اعطاء المستلف";
            this.colBorrowResponsible.MinimumWidth = 6;
            this.colBorrowResponsible.Name = "colBorrowResponsible";
            this.colBorrowResponsible.ReadOnly = true;
            // 
            // FrmEmoployeeBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1422, 738);
            this.ControlBox = false;
            this.Controls.Add(this.pnlFrmEmployeeBorrow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmoployeeBorrow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Deactivate += new System.EventHandler(this.FrmEmoployeeBorrow_Deactivate);
            this.Load += new System.EventHandler(this.FrmEmoployeeBorrow_Load);
            this.pnlFrmEmployeeBorrow.ResumeLayout(false);
            this.pnlFrmEmployeeBorrow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBorrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFrmEmployeeBorrow;
        private System.Windows.Forms.ComboBox cbxEmpnameBorrow;
        private System.Windows.Forms.Label lblEmpnameBorrow;
        public System.Windows.Forms.TextBox txtBorrowValue;
        private System.Windows.Forms.Label lblBorrowValue;
        public System.Windows.Forms.TextBox txtRestOfSalary;
        private System.Windows.Forms.Label lblRestOfSalary;
        private System.Windows.Forms.ComboBox cbxBorrowResponsible;
        private System.Windows.Forms.Label lblBorrowResponsible;
        public System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Label lblBorrowDate;
        private SansationRoundButton btnReportBorrow;
        private SansationRoundButton btnDeleteBorrow;
        private SansationRoundButton btnEditBorrow;
        private SansationRoundButton btnAddBorrow;
        private SansationRoundButton btnNewBorrow;
        private System.Windows.Forms.DataGridView dgvShowBorrow;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.RadioButton rdoBorrowerResponsible;
        private System.Windows.Forms.RadioButton rdoBorrowerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colempnoborrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpBorrowName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colempsalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRestOfBorrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRestOfSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colempnoresponsible;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowResponsible;
    }
}
namespace Gym
{
    partial class FrmProductsAndSuppliments
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
            this.pnlProductsAndSuupliments = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdoProdPrice = new System.Windows.Forms.RadioButton();
            this.lblSearch = new System.Windows.Forms.Label();
            this.rdoProdName = new System.Windows.Forms.RadioButton();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnSupplyReport = new SansationRoundButton();
            this.btnDeleteSupply = new SansationRoundButton();
            this.btnEditSupply = new SansationRoundButton();
            this.btnAddSupply = new SansationRoundButton();
            this.btnNewSupply = new SansationRoundButton();
            this.dgvShowSupply = new System.Windows.Forms.DataGridView();
            this.lblSupplyQty = new System.Windows.Forms.Label();
            this.txtSupplyQty = new System.Windows.Forms.TextBox();
            this.lblSupplyPrice = new System.Windows.Forms.Label();
            this.txtSupplyPrice = new System.Windows.Forms.TextBox();
            this.lblSupplyExpireDate = new System.Windows.Forms.Label();
            this.dtpSupplyExpireDate = new System.Windows.Forms.DateTimePicker();
            this.lblSupplyProductDate = new System.Windows.Forms.Label();
            this.dtpSupplyProductDate = new System.Windows.Forms.DateTimePicker();
            this.txtSupplyName = new System.Windows.Forms.TextBox();
            this.lblSupplyName = new System.Windows.Forms.Label();
            this.lblSupplyno = new System.Windows.Forms.Label();
            this.txtSupplyno = new System.Windows.Forms.TextBox();
            this.epSupply = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblBuyDate = new System.Windows.Forms.Label();
            this.dtpBuyDate = new System.Windows.Forms.DateTimePicker();
            this.colsupplyno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsupplyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsupplyproddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsupplyexpiredate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsupplyprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsupplyqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProductsAndSuupliments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSupply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSupply)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProductsAndSuupliments
            // 
            this.pnlProductsAndSuupliments.BackColor = System.Drawing.Color.Black;
            this.pnlProductsAndSuupliments.Controls.Add(this.lblBuyDate);
            this.pnlProductsAndSuupliments.Controls.Add(this.dtpBuyDate);
            this.pnlProductsAndSuupliments.Controls.Add(this.txtSearch);
            this.pnlProductsAndSuupliments.Controls.Add(this.rdoProdPrice);
            this.pnlProductsAndSuupliments.Controls.Add(this.lblSearch);
            this.pnlProductsAndSuupliments.Controls.Add(this.rdoProdName);
            this.pnlProductsAndSuupliments.Controls.Add(this.lblMsg);
            this.pnlProductsAndSuupliments.Controls.Add(this.btnSupplyReport);
            this.pnlProductsAndSuupliments.Controls.Add(this.btnDeleteSupply);
            this.pnlProductsAndSuupliments.Controls.Add(this.btnEditSupply);
            this.pnlProductsAndSuupliments.Controls.Add(this.btnAddSupply);
            this.pnlProductsAndSuupliments.Controls.Add(this.btnNewSupply);
            this.pnlProductsAndSuupliments.Controls.Add(this.dgvShowSupply);
            this.pnlProductsAndSuupliments.Controls.Add(this.lblSupplyQty);
            this.pnlProductsAndSuupliments.Controls.Add(this.txtSupplyQty);
            this.pnlProductsAndSuupliments.Controls.Add(this.lblSupplyPrice);
            this.pnlProductsAndSuupliments.Controls.Add(this.txtSupplyPrice);
            this.pnlProductsAndSuupliments.Controls.Add(this.lblSupplyExpireDate);
            this.pnlProductsAndSuupliments.Controls.Add(this.dtpSupplyExpireDate);
            this.pnlProductsAndSuupliments.Controls.Add(this.lblSupplyProductDate);
            this.pnlProductsAndSuupliments.Controls.Add(this.dtpSupplyProductDate);
            this.pnlProductsAndSuupliments.Controls.Add(this.txtSupplyName);
            this.pnlProductsAndSuupliments.Controls.Add(this.lblSupplyName);
            this.pnlProductsAndSuupliments.Controls.Add(this.lblSupplyno);
            this.pnlProductsAndSuupliments.Controls.Add(this.txtSupplyno);
            this.pnlProductsAndSuupliments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductsAndSuupliments.Location = new System.Drawing.Point(0, 0);
            this.pnlProductsAndSuupliments.Name = "pnlProductsAndSuupliments";
            this.pnlProductsAndSuupliments.Size = new System.Drawing.Size(1422, 738);
            this.pnlProductsAndSuupliments.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Pink;
            this.txtSearch.Location = new System.Drawing.Point(979, 397);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(341, 34);
            this.txtSearch.TabIndex = 83;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // rdoProdPrice
            // 
            this.rdoProdPrice.AutoSize = true;
            this.rdoProdPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoProdPrice.Location = new System.Drawing.Point(718, 398);
            this.rdoProdPrice.Name = "rdoProdPrice";
            this.rdoProdPrice.Size = new System.Drawing.Size(118, 33);
            this.rdoProdPrice.TabIndex = 81;
            this.rdoProdPrice.Text = "سعر المنتج";
            this.rdoProdPrice.UseVisualStyleBackColor = true;
            this.rdoProdPrice.Click += new System.EventHandler(this.rdoProdName_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Yellow;
            this.lblSearch.Location = new System.Drawing.Point(1326, 397);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(71, 29);
            this.lblSearch.TabIndex = 80;
            this.lblSearch.Text = "البحث:";
            // 
            // rdoProdName
            // 
            this.rdoProdName.AutoSize = true;
            this.rdoProdName.Checked = true;
            this.rdoProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoProdName.Location = new System.Drawing.Point(848, 398);
            this.rdoProdName.Name = "rdoProdName";
            this.rdoProdName.Size = new System.Drawing.Size(110, 33);
            this.rdoProdName.TabIndex = 79;
            this.rdoProdName.TabStop = true;
            this.rdoProdName.Text = "اسم المنتج";
            this.rdoProdName.UseVisualStyleBackColor = true;
            this.rdoProdName.Click += new System.EventHandler(this.rdoProdName_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblMsg.Location = new System.Drawing.Point(457, 358);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(62, 42);
            this.lblMsg.TabIndex = 77;
            this.lblMsg.Text = ">>";
            // 
            // btnSupplyReport
            // 
            this.btnSupplyReport.BackColor = System.Drawing.Color.Pink;
            this.btnSupplyReport.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnSupplyReport.BorderColor = System.Drawing.Color.Black;
            this.btnSupplyReport.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnSupplyReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplyReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSupplyReport.FlatAppearance.BorderSize = 2;
            this.btnSupplyReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupplyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplyReport.Location = new System.Drawing.Point(537, 357);
            this.btnSupplyReport.Name = "btnSupplyReport";
            this.btnSupplyReport.Size = new System.Drawing.Size(108, 34);
            this.btnSupplyReport.TabIndex = 76;
            this.btnSupplyReport.Text = "تقريـر";
            this.btnSupplyReport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnSupplyReport.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSupply
            // 
            this.btnDeleteSupply.BackColor = System.Drawing.Color.Pink;
            this.btnDeleteSupply.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnDeleteSupply.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteSupply.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnDeleteSupply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSupply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteSupply.FlatAppearance.BorderSize = 2;
            this.btnDeleteSupply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupply.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteSupply.Location = new System.Drawing.Point(651, 357);
            this.btnDeleteSupply.Name = "btnDeleteSupply";
            this.btnDeleteSupply.Size = new System.Drawing.Size(108, 34);
            this.btnDeleteSupply.TabIndex = 75;
            this.btnDeleteSupply.Text = "حــذف";
            this.btnDeleteSupply.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnDeleteSupply.UseVisualStyleBackColor = false;
            this.btnDeleteSupply.Click += new System.EventHandler(this.btnDeleteSupply_Click);
            // 
            // btnEditSupply
            // 
            this.btnEditSupply.BackColor = System.Drawing.Color.Pink;
            this.btnEditSupply.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnEditSupply.BorderColor = System.Drawing.Color.Black;
            this.btnEditSupply.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnEditSupply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSupply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditSupply.FlatAppearance.BorderSize = 2;
            this.btnEditSupply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSupply.Location = new System.Drawing.Point(765, 357);
            this.btnEditSupply.Name = "btnEditSupply";
            this.btnEditSupply.Size = new System.Drawing.Size(108, 34);
            this.btnEditSupply.TabIndex = 74;
            this.btnEditSupply.Text = "تعديــل";
            this.btnEditSupply.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnEditSupply.UseVisualStyleBackColor = false;
            this.btnEditSupply.Click += new System.EventHandler(this.btnEditSupply_Click);
            // 
            // btnAddSupply
            // 
            this.btnAddSupply.BackColor = System.Drawing.Color.Pink;
            this.btnAddSupply.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnAddSupply.BorderColor = System.Drawing.Color.Black;
            this.btnAddSupply.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnAddSupply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSupply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddSupply.FlatAppearance.BorderSize = 2;
            this.btnAddSupply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupply.Location = new System.Drawing.Point(879, 357);
            this.btnAddSupply.Name = "btnAddSupply";
            this.btnAddSupply.Size = new System.Drawing.Size(108, 34);
            this.btnAddSupply.TabIndex = 73;
            this.btnAddSupply.Text = "اضــافه";
            this.btnAddSupply.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnAddSupply.UseVisualStyleBackColor = false;
            this.btnAddSupply.Click += new System.EventHandler(this.btnAddSupply_Click);
            // 
            // btnNewSupply
            // 
            this.btnNewSupply.BackColor = System.Drawing.Color.Pink;
            this.btnNewSupply.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnNewSupply.BorderColor = System.Drawing.Color.Black;
            this.btnNewSupply.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnNewSupply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewSupply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewSupply.FlatAppearance.BorderSize = 2;
            this.btnNewSupply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSupply.Location = new System.Drawing.Point(993, 357);
            this.btnNewSupply.Name = "btnNewSupply";
            this.btnNewSupply.Size = new System.Drawing.Size(108, 34);
            this.btnNewSupply.TabIndex = 72;
            this.btnNewSupply.Text = "جديد*";
            this.btnNewSupply.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnNewSupply.UseVisualStyleBackColor = false;
            this.btnNewSupply.Click += new System.EventHandler(this.btnNewSupply_Click);
            // 
            // dgvShowSupply
            // 
            this.dgvShowSupply.AllowUserToAddRows = false;
            this.dgvShowSupply.AllowUserToDeleteRows = false;
            this.dgvShowSupply.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowSupply.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowSupply.BackgroundColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowSupply.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowSupply.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colsupplyno,
            this.colsupplyname,
            this.colsupplyproddate,
            this.colsupplyexpiredate,
            this.colsupplyprice,
            this.colsupplyqty,
            this.colBuyDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowSupply.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowSupply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShowSupply.EnableHeadersVisualStyles = false;
            this.dgvShowSupply.Location = new System.Drawing.Point(0, 462);
            this.dgvShowSupply.Name = "dgvShowSupply";
            this.dgvShowSupply.ReadOnly = true;
            this.dgvShowSupply.RowHeadersWidth = 51;
            this.dgvShowSupply.RowTemplate.Height = 24;
            this.dgvShowSupply.Size = new System.Drawing.Size(1422, 276);
            this.dgvShowSupply.TabIndex = 71;
            this.dgvShowSupply.SelectionChanged += new System.EventHandler(this.dgvShowSupply_SelectionChanged);
            // 
            // lblSupplyQty
            // 
            this.lblSupplyQty.AutoSize = true;
            this.lblSupplyQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplyQty.ForeColor = System.Drawing.Color.Yellow;
            this.lblSupplyQty.Location = new System.Drawing.Point(1197, 252);
            this.lblSupplyQty.Name = "lblSupplyQty";
            this.lblSupplyQty.Size = new System.Drawing.Size(197, 29);
            this.lblSupplyQty.TabIndex = 69;
            this.lblSupplyQty.Text = "الكميه التى تم شرائها:";
            // 
            // txtSupplyQty
            // 
            this.txtSupplyQty.BackColor = System.Drawing.Color.Pink;
            this.txtSupplyQty.Location = new System.Drawing.Point(607, 247);
            this.txtSupplyQty.Name = "txtSupplyQty";
            this.txtSupplyQty.Size = new System.Drawing.Size(487, 34);
            this.txtSupplyQty.TabIndex = 70;
            this.txtSupplyQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplyQty_KeyPress);
            // 
            // lblSupplyPrice
            // 
            this.lblSupplyPrice.AutoSize = true;
            this.lblSupplyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplyPrice.ForeColor = System.Drawing.Color.Yellow;
            this.lblSupplyPrice.Location = new System.Drawing.Point(1149, 210);
            this.lblSupplyPrice.Name = "lblSupplyPrice";
            this.lblSupplyPrice.Size = new System.Drawing.Size(252, 29);
            this.lblSupplyPrice.TabIndex = 67;
            this.lblSupplyPrice.Text = "سعر شراء المكمل أو المنتج:";
            // 
            // txtSupplyPrice
            // 
            this.txtSupplyPrice.BackColor = System.Drawing.Color.Pink;
            this.txtSupplyPrice.Location = new System.Drawing.Point(607, 207);
            this.txtSupplyPrice.Name = "txtSupplyPrice";
            this.txtSupplyPrice.Size = new System.Drawing.Size(487, 34);
            this.txtSupplyPrice.TabIndex = 68;
            this.txtSupplyPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplyPrice_KeyPress);
            // 
            // lblSupplyExpireDate
            // 
            this.lblSupplyExpireDate.AutoSize = true;
            this.lblSupplyExpireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplyExpireDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblSupplyExpireDate.Location = new System.Drawing.Point(1129, 171);
            this.lblSupplyExpireDate.Name = "lblSupplyExpireDate";
            this.lblSupplyExpireDate.Size = new System.Drawing.Size(281, 29);
            this.lblSupplyExpireDate.TabIndex = 65;
            this.lblSupplyExpireDate.Text = "تاريخ الانتهاء للمكمل أو المنتج:";
            // 
            // dtpSupplyExpireDate
            // 
            this.dtpSupplyExpireDate.CalendarFont = new System.Drawing.Font("Impact", 14F);
            this.dtpSupplyExpireDate.CalendarMonthBackground = System.Drawing.Color.Pink;
            this.dtpSupplyExpireDate.CustomFormat = "yyyy/MM/dd";
            this.dtpSupplyExpireDate.Font = new System.Drawing.Font("Impact", 14F);
            this.dtpSupplyExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSupplyExpireDate.Location = new System.Drawing.Point(607, 165);
            this.dtpSupplyExpireDate.Name = "dtpSupplyExpireDate";
            this.dtpSupplyExpireDate.RightToLeftLayout = true;
            this.dtpSupplyExpireDate.Size = new System.Drawing.Size(487, 36);
            this.dtpSupplyExpireDate.TabIndex = 66;
            this.dtpSupplyExpireDate.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            // 
            // lblSupplyProductDate
            // 
            this.lblSupplyProductDate.AutoSize = true;
            this.lblSupplyProductDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplyProductDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblSupplyProductDate.Location = new System.Drawing.Point(1136, 129);
            this.lblSupplyProductDate.Name = "lblSupplyProductDate";
            this.lblSupplyProductDate.Size = new System.Drawing.Size(274, 29);
            this.lblSupplyProductDate.TabIndex = 63;
            this.lblSupplyProductDate.Text = "تاريخ الانتاج للمكمل أو المنتج:";
            // 
            // dtpSupplyProductDate
            // 
            this.dtpSupplyProductDate.CalendarFont = new System.Drawing.Font("Impact", 14F);
            this.dtpSupplyProductDate.CalendarMonthBackground = System.Drawing.Color.Pink;
            this.dtpSupplyProductDate.CustomFormat = "yyyy/MM/dd";
            this.dtpSupplyProductDate.Font = new System.Drawing.Font("Impact", 14F);
            this.dtpSupplyProductDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSupplyProductDate.Location = new System.Drawing.Point(607, 123);
            this.dtpSupplyProductDate.Name = "dtpSupplyProductDate";
            this.dtpSupplyProductDate.RightToLeftLayout = true;
            this.dtpSupplyProductDate.Size = new System.Drawing.Size(487, 36);
            this.dtpSupplyProductDate.TabIndex = 64;
            this.dtpSupplyProductDate.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            // 
            // txtSupplyName
            // 
            this.txtSupplyName.BackColor = System.Drawing.Color.Pink;
            this.txtSupplyName.Location = new System.Drawing.Point(607, 83);
            this.txtSupplyName.Name = "txtSupplyName";
            this.txtSupplyName.Size = new System.Drawing.Size(487, 34);
            this.txtSupplyName.TabIndex = 62;
            this.txtSupplyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplyName_KeyPress);
            // 
            // lblSupplyName
            // 
            this.lblSupplyName.AutoSize = true;
            this.lblSupplyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplyName.ForeColor = System.Drawing.Color.Yellow;
            this.lblSupplyName.Location = new System.Drawing.Point(1208, 88);
            this.lblSupplyName.Name = "lblSupplyName";
            this.lblSupplyName.Size = new System.Drawing.Size(186, 29);
            this.lblSupplyName.TabIndex = 61;
            this.lblSupplyName.Text = "اسم المكمل أو المنتج";
            // 
            // lblSupplyno
            // 
            this.lblSupplyno.AutoSize = true;
            this.lblSupplyno.BackColor = System.Drawing.Color.Black;
            this.lblSupplyno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplyno.ForeColor = System.Drawing.Color.Yellow;
            this.lblSupplyno.Location = new System.Drawing.Point(1200, 45);
            this.lblSupplyno.Name = "lblSupplyno";
            this.lblSupplyno.Size = new System.Drawing.Size(194, 29);
            this.lblSupplyno.TabIndex = 4;
            this.lblSupplyno.Text = "كود المكمل أو المنتج:";
            // 
            // txtSupplyno
            // 
            this.txtSupplyno.BackColor = System.Drawing.Color.Pink;
            this.txtSupplyno.Location = new System.Drawing.Point(607, 43);
            this.txtSupplyno.Name = "txtSupplyno";
            this.txtSupplyno.ReadOnly = true;
            this.txtSupplyno.Size = new System.Drawing.Size(487, 34);
            this.txtSupplyno.TabIndex = 5;
            this.txtSupplyno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // epSupply
            // 
            this.epSupply.ContainerControl = this;
            // 
            // lblBuyDate
            // 
            this.lblBuyDate.AutoSize = true;
            this.lblBuyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblBuyDate.Location = new System.Drawing.Point(1208, 294);
            this.lblBuyDate.Name = "lblBuyDate";
            this.lblBuyDate.Size = new System.Drawing.Size(181, 29);
            this.lblBuyDate.TabIndex = 84;
            this.lblBuyDate.Text = "تاريخ شراء المكمل:";
            // 
            // dtpBuyDate
            // 
            this.dtpBuyDate.CalendarFont = new System.Drawing.Font("Impact", 14F);
            this.dtpBuyDate.CalendarMonthBackground = System.Drawing.Color.Pink;
            this.dtpBuyDate.CustomFormat = "yyyy/MM/dd";
            this.dtpBuyDate.Font = new System.Drawing.Font("Impact", 14F);
            this.dtpBuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBuyDate.Location = new System.Drawing.Point(607, 287);
            this.dtpBuyDate.Name = "dtpBuyDate";
            this.dtpBuyDate.RightToLeftLayout = true;
            this.dtpBuyDate.Size = new System.Drawing.Size(487, 36);
            this.dtpBuyDate.TabIndex = 85;
            this.dtpBuyDate.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            // 
            // colsupplyno
            // 
            this.colsupplyno.DataPropertyName = "supplyno";
            this.colsupplyno.HeaderText = "كود المكمل أو النتج";
            this.colsupplyno.MinimumWidth = 6;
            this.colsupplyno.Name = "colsupplyno";
            this.colsupplyno.ReadOnly = true;
            // 
            // colsupplyname
            // 
            this.colsupplyname.DataPropertyName = "supplyname";
            this.colsupplyname.HeaderText = "اسم المكمل أو المنتج";
            this.colsupplyname.MinimumWidth = 6;
            this.colsupplyname.Name = "colsupplyname";
            this.colsupplyname.ReadOnly = true;
            // 
            // colsupplyproddate
            // 
            this.colsupplyproddate.DataPropertyName = "proddate";
            this.colsupplyproddate.HeaderText = "تاريخ الانتاج للمكمل أو المنتج";
            this.colsupplyproddate.MinimumWidth = 6;
            this.colsupplyproddate.Name = "colsupplyproddate";
            this.colsupplyproddate.ReadOnly = true;
            // 
            // colsupplyexpiredate
            // 
            this.colsupplyexpiredate.DataPropertyName = "prodexpiredate";
            this.colsupplyexpiredate.HeaderText = "تاريخ الانتهاء للمكمل أو المنتج";
            this.colsupplyexpiredate.MinimumWidth = 6;
            this.colsupplyexpiredate.Name = "colsupplyexpiredate";
            this.colsupplyexpiredate.ReadOnly = true;
            // 
            // colsupplyprice
            // 
            this.colsupplyprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colsupplyprice.DataPropertyName = "prodprice";
            this.colsupplyprice.HeaderText = "سعر المكمل أو المنتج";
            this.colsupplyprice.MinimumWidth = 6;
            this.colsupplyprice.Name = "colsupplyprice";
            this.colsupplyprice.ReadOnly = true;
            this.colsupplyprice.Width = 200;
            // 
            // colsupplyqty
            // 
            this.colsupplyqty.DataPropertyName = "prodqty";
            this.colsupplyqty.HeaderText = "الكميه المتاحه للمكمل أو المنتج";
            this.colsupplyqty.MinimumWidth = 6;
            this.colsupplyqty.Name = "colsupplyqty";
            this.colsupplyqty.ReadOnly = true;
            // 
            // colBuyDate
            // 
            this.colBuyDate.DataPropertyName = "buydate";
            this.colBuyDate.HeaderText = "تاريخ شراء المكمل";
            this.colBuyDate.MinimumWidth = 6;
            this.colBuyDate.Name = "colBuyDate";
            this.colBuyDate.ReadOnly = true;
            // 
            // FrmProductsAndSuppliments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1422, 738);
            this.ControlBox = false;
            this.Controls.Add(this.pnlProductsAndSuupliments);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductsAndSuppliments";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Deactivate += new System.EventHandler(this.FrmProductsAndSuppliments_Deactivate);
            this.Load += new System.EventHandler(this.FrmProductsAndSuppliments_Load);
            this.pnlProductsAndSuupliments.ResumeLayout(false);
            this.pnlProductsAndSuupliments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSupply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSupply)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProductsAndSuupliments;
        private System.Windows.Forms.Label lblSupplyno;
        private System.Windows.Forms.TextBox txtSupplyno;
        private System.Windows.Forms.TextBox txtSupplyName;
        private System.Windows.Forms.Label lblSupplyName;
        private System.Windows.Forms.Label lblSupplyExpireDate;
        public System.Windows.Forms.DateTimePicker dtpSupplyExpireDate;
        private System.Windows.Forms.Label lblSupplyProductDate;
        public System.Windows.Forms.DateTimePicker dtpSupplyProductDate;
        private System.Windows.Forms.Label lblSupplyQty;
        private System.Windows.Forms.TextBox txtSupplyQty;
        private System.Windows.Forms.Label lblSupplyPrice;
        private System.Windows.Forms.TextBox txtSupplyPrice;
        private System.Windows.Forms.DataGridView dgvShowSupply;
        private SansationRoundButton btnSupplyReport;
        private SansationRoundButton btnDeleteSupply;
        private SansationRoundButton btnEditSupply;
        private SansationRoundButton btnAddSupply;
        private SansationRoundButton btnNewSupply;
        private System.Windows.Forms.ErrorProvider epSupply;
        private System.Windows.Forms.Label lblMsg;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdoProdPrice;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.RadioButton rdoProdName;
        private System.Windows.Forms.Label lblBuyDate;
        public System.Windows.Forms.DateTimePicker dtpBuyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsupplyno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsupplyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsupplyproddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsupplyexpiredate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsupplyprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsupplyqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyDate;
    }
}
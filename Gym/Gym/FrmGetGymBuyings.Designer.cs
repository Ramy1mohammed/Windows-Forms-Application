namespace Gym
{
    partial class FrmGetGymBuyings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCalculateIncome = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnReportIncome = new SansationRoundButton();
            this.btnDeleteIncome = new SansationRoundButton();
            this.btnAddIncome = new SansationRoundButton();
            this.btnNewIncome = new SansationRoundButton();
            this.cbxResponsibleEmp = new System.Windows.Forms.ComboBox();
            this.lblResponsibleEmp = new System.Windows.Forms.Label();
            this.dgvShowIncome = new System.Windows.Forms.DataGridView();
            this.colInvno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colempno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyingResponsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuiedProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuiedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalBuiedProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblInvImage = new System.Windows.Forms.Label();
            this.picInvImage = new Gym.MyPictureBox();
            this.btnAddInvPic = new SansationRoundButton();
            this.txtProdOneItemPrice = new System.Windows.Forms.TextBox();
            this.lblProdOneItemPrice = new System.Windows.Forms.Label();
            this.txtTotalProdPrice = new System.Windows.Forms.TextBox();
            this.lblTotalProdPrice = new System.Windows.Forms.Label();
            this.txtProdQty = new System.Windows.Forms.TextBox();
            this.lblProdQty = new System.Windows.Forms.Label();
            this.txtBuingProdName = new System.Windows.Forms.TextBox();
            this.lblBuingProdName = new System.Windows.Forms.Label();
            this.lblBuingDate = new System.Windows.Forms.Label();
            this.dtpBuingDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvBuingNo = new System.Windows.Forms.Label();
            this.txtInvBuingNo = new System.Windows.Forms.TextBox();
            this.pnlCalculateIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInvImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCalculateIncome
            // 
            this.pnlCalculateIncome.Controls.Add(this.lblMsg);
            this.pnlCalculateIncome.Controls.Add(this.btnReportIncome);
            this.pnlCalculateIncome.Controls.Add(this.btnDeleteIncome);
            this.pnlCalculateIncome.Controls.Add(this.btnAddIncome);
            this.pnlCalculateIncome.Controls.Add(this.btnNewIncome);
            this.pnlCalculateIncome.Controls.Add(this.cbxResponsibleEmp);
            this.pnlCalculateIncome.Controls.Add(this.lblResponsibleEmp);
            this.pnlCalculateIncome.Controls.Add(this.dgvShowIncome);
            this.pnlCalculateIncome.Controls.Add(this.lblInvImage);
            this.pnlCalculateIncome.Controls.Add(this.picInvImage);
            this.pnlCalculateIncome.Controls.Add(this.btnAddInvPic);
            this.pnlCalculateIncome.Controls.Add(this.txtProdOneItemPrice);
            this.pnlCalculateIncome.Controls.Add(this.lblProdOneItemPrice);
            this.pnlCalculateIncome.Controls.Add(this.txtTotalProdPrice);
            this.pnlCalculateIncome.Controls.Add(this.lblTotalProdPrice);
            this.pnlCalculateIncome.Controls.Add(this.txtProdQty);
            this.pnlCalculateIncome.Controls.Add(this.lblProdQty);
            this.pnlCalculateIncome.Controls.Add(this.txtBuingProdName);
            this.pnlCalculateIncome.Controls.Add(this.lblBuingProdName);
            this.pnlCalculateIncome.Controls.Add(this.lblBuingDate);
            this.pnlCalculateIncome.Controls.Add(this.dtpBuingDate);
            this.pnlCalculateIncome.Controls.Add(this.lblInvBuingNo);
            this.pnlCalculateIncome.Controls.Add(this.txtInvBuingNo);
            this.pnlCalculateIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCalculateIncome.Location = new System.Drawing.Point(0, 0);
            this.pnlCalculateIncome.Name = "pnlCalculateIncome";
            this.pnlCalculateIncome.Size = new System.Drawing.Size(1422, 738);
            this.pnlCalculateIncome.TabIndex = 6;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblMsg.Location = new System.Drawing.Point(935, 372);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(62, 42);
            this.lblMsg.TabIndex = 87;
            this.lblMsg.Text = ">>";
            // 
            // btnReportIncome
            // 
            this.btnReportIncome.BackColor = System.Drawing.Color.Pink;
            this.btnReportIncome.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnReportIncome.BorderColor = System.Drawing.Color.Black;
            this.btnReportIncome.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnReportIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportIncome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReportIncome.FlatAppearance.BorderSize = 2;
            this.btnReportIncome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportIncome.Location = new System.Drawing.Point(483, 295);
            this.btnReportIncome.Name = "btnReportIncome";
            this.btnReportIncome.Size = new System.Drawing.Size(108, 42);
            this.btnReportIncome.TabIndex = 86;
            this.btnReportIncome.Text = "تقريـر";
            this.btnReportIncome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnReportIncome.UseVisualStyleBackColor = false;
            // 
            // btnDeleteIncome
            // 
            this.btnDeleteIncome.BackColor = System.Drawing.Color.Pink;
            this.btnDeleteIncome.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnDeleteIncome.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteIncome.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnDeleteIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteIncome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteIncome.FlatAppearance.BorderSize = 2;
            this.btnDeleteIncome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIncome.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteIncome.Location = new System.Drawing.Point(601, 295);
            this.btnDeleteIncome.Name = "btnDeleteIncome";
            this.btnDeleteIncome.Size = new System.Drawing.Size(108, 42);
            this.btnDeleteIncome.TabIndex = 85;
            this.btnDeleteIncome.Text = "حــذف";
            this.btnDeleteIncome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnDeleteIncome.UseVisualStyleBackColor = false;
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.BackColor = System.Drawing.Color.Pink;
            this.btnAddIncome.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnAddIncome.BorderColor = System.Drawing.Color.Black;
            this.btnAddIncome.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnAddIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddIncome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddIncome.FlatAppearance.BorderSize = 2;
            this.btnAddIncome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIncome.Location = new System.Drawing.Point(719, 295);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(108, 42);
            this.btnAddIncome.TabIndex = 83;
            this.btnAddIncome.Text = "اضــافه";
            this.btnAddIncome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnAddIncome.UseVisualStyleBackColor = false;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // btnNewIncome
            // 
            this.btnNewIncome.BackColor = System.Drawing.Color.Pink;
            this.btnNewIncome.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnNewIncome.BorderColor = System.Drawing.Color.Black;
            this.btnNewIncome.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnNewIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewIncome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewIncome.FlatAppearance.BorderSize = 2;
            this.btnNewIncome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewIncome.Location = new System.Drawing.Point(833, 295);
            this.btnNewIncome.Name = "btnNewIncome";
            this.btnNewIncome.Size = new System.Drawing.Size(108, 42);
            this.btnNewIncome.TabIndex = 82;
            this.btnNewIncome.Text = "جديد*";
            this.btnNewIncome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnNewIncome.UseVisualStyleBackColor = false;
            this.btnNewIncome.Click += new System.EventHandler(this.btnNewIncome_Click);
            // 
            // cbxResponsibleEmp
            // 
            this.cbxResponsibleEmp.BackColor = System.Drawing.Color.Pink;
            this.cbxResponsibleEmp.FormattingEnabled = true;
            this.cbxResponsibleEmp.Location = new System.Drawing.Point(426, 58);
            this.cbxResponsibleEmp.Name = "cbxResponsibleEmp";
            this.cbxResponsibleEmp.Size = new System.Drawing.Size(660, 37);
            this.cbxResponsibleEmp.TabIndex = 81;
            // 
            // lblResponsibleEmp
            // 
            this.lblResponsibleEmp.AutoSize = true;
            this.lblResponsibleEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsibleEmp.ForeColor = System.Drawing.Color.Yellow;
            this.lblResponsibleEmp.Location = new System.Drawing.Point(1135, 58);
            this.lblResponsibleEmp.Name = "lblResponsibleEmp";
            this.lblResponsibleEmp.Size = new System.Drawing.Size(269, 29);
            this.lblResponsibleEmp.TabIndex = 80;
            this.lblResponsibleEmp.Text = "الموظف المشرف على الشراء:";
            // 
            // dgvShowIncome
            // 
            this.dgvShowIncome.AllowUserToAddRows = false;
            this.dgvShowIncome.AllowUserToDeleteRows = false;
            this.dgvShowIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowIncome.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowIncome.BackgroundColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvno,
            this.colempno,
            this.colBuyingResponsible,
            this.colBuyDate,
            this.colBuiedProduct,
            this.colBuiedQty,
            this.colTotalBuiedProduct,
            this.colProdImage});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowIncome.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowIncome.EnableHeadersVisualStyles = false;
            this.dgvShowIncome.Location = new System.Drawing.Point(0, 429);
            this.dgvShowIncome.Name = "dgvShowIncome";
            this.dgvShowIncome.ReadOnly = true;
            this.dgvShowIncome.RowHeadersWidth = 51;
            this.dgvShowIncome.RowTemplate.Height = 24;
            this.dgvShowIncome.Size = new System.Drawing.Size(1419, 306);
            this.dgvShowIncome.TabIndex = 79;
            this.dgvShowIncome.SelectionChanged += new System.EventHandler(this.dgvShowIncome_SelectionChanged);
            // 
            // colInvno
            // 
            this.colInvno.DataPropertyName = "invno";
            this.colInvno.HeaderText = "كود فاتوره الشراء";
            this.colInvno.MinimumWidth = 6;
            this.colInvno.Name = "colInvno";
            this.colInvno.ReadOnly = true;
            // 
            // colempno
            // 
            this.colempno.DataPropertyName = "empno";
            this.colempno.HeaderText = "كود الموظف";
            this.colempno.MinimumWidth = 6;
            this.colempno.Name = "colempno";
            this.colempno.ReadOnly = true;
            this.colempno.Visible = false;
            // 
            // colBuyingResponsible
            // 
            this.colBuyingResponsible.DataPropertyName = "empname";
            this.colBuyingResponsible.HeaderText = "الموظف المشرف على الشراء";
            this.colBuyingResponsible.MinimumWidth = 6;
            this.colBuyingResponsible.Name = "colBuyingResponsible";
            this.colBuyingResponsible.ReadOnly = true;
            // 
            // colBuyDate
            // 
            this.colBuyDate.DataPropertyName = "buyingdate";
            this.colBuyDate.HeaderText = "تاريخ الشراء";
            this.colBuyDate.MinimumWidth = 6;
            this.colBuyDate.Name = "colBuyDate";
            this.colBuyDate.ReadOnly = true;
            // 
            // colBuiedProduct
            // 
            this.colBuiedProduct.DataPropertyName = "thingbyiedname";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colBuiedProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.colBuiedProduct.HeaderText = "اسم المنتج الذى تم شرائه";
            this.colBuiedProduct.MinimumWidth = 6;
            this.colBuiedProduct.Name = "colBuiedProduct";
            this.colBuiedProduct.ReadOnly = true;
            // 
            // colBuiedQty
            // 
            this.colBuiedQty.DataPropertyName = "thingqty";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colBuiedQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.colBuiedQty.HeaderText = "كميه المنتج الذى تم شرائه";
            this.colBuiedQty.MinimumWidth = 6;
            this.colBuiedQty.Name = "colBuiedQty";
            this.colBuiedQty.ReadOnly = true;
            // 
            // colTotalBuiedProduct
            // 
            this.colTotalBuiedProduct.DataPropertyName = "thingprice";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colTotalBuiedProduct.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTotalBuiedProduct.HeaderText = "سعر الوحده للمنتج الذى تم شرائه";
            this.colTotalBuiedProduct.MinimumWidth = 6;
            this.colTotalBuiedProduct.Name = "colTotalBuiedProduct";
            this.colTotalBuiedProduct.ReadOnly = true;
            // 
            // colProdImage
            // 
            this.colProdImage.DataPropertyName = "thingimage";
            this.colProdImage.HeaderText = "صوره الفاتوره";
            this.colProdImage.MinimumWidth = 6;
            this.colProdImage.Name = "colProdImage";
            this.colProdImage.ReadOnly = true;
            this.colProdImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProdImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblInvImage
            // 
            this.lblInvImage.AutoSize = true;
            this.lblInvImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvImage.ForeColor = System.Drawing.Color.Yellow;
            this.lblInvImage.Location = new System.Drawing.Point(39, 48);
            this.lblInvImage.Name = "lblInvImage";
            this.lblInvImage.Size = new System.Drawing.Size(138, 29);
            this.lblInvImage.TabIndex = 72;
            this.lblInvImage.Text = "صوره الفاتوره";
            // 
            // picInvImage
            // 
            this.picInvImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.picInvImage.Location = new System.Drawing.Point(29, 91);
            this.picInvImage.Name = "picInvImage";
            this.picInvImage.Size = new System.Drawing.Size(150, 150);
            this.picInvImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInvImage.TabIndex = 71;
            this.picInvImage.TabStop = false;
            // 
            // btnAddInvPic
            // 
            this.btnAddInvPic.BackColor = System.Drawing.Color.Pink;
            this.btnAddInvPic.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnAddInvPic.BorderColor = System.Drawing.Color.Black;
            this.btnAddInvPic.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnAddInvPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddInvPic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddInvPic.FlatAppearance.BorderSize = 2;
            this.btnAddInvPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddInvPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvPic.Location = new System.Drawing.Point(29, 248);
            this.btnAddInvPic.Name = "btnAddInvPic";
            this.btnAddInvPic.Size = new System.Drawing.Size(150, 35);
            this.btnAddInvPic.TabIndex = 70;
            this.btnAddInvPic.Text = "اضافه صوره";
            this.btnAddInvPic.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnAddInvPic.UseVisualStyleBackColor = false;
            this.btnAddInvPic.Click += new System.EventHandler(this.btnAddInvPic_Click);
            // 
            // txtProdOneItemPrice
            // 
            this.txtProdOneItemPrice.BackColor = System.Drawing.Color.Pink;
            this.txtProdOneItemPrice.Location = new System.Drawing.Point(426, 207);
            this.txtProdOneItemPrice.Name = "txtProdOneItemPrice";
            this.txtProdOneItemPrice.Size = new System.Drawing.Size(660, 34);
            this.txtProdOneItemPrice.TabIndex = 68;
            // 
            // lblProdOneItemPrice
            // 
            this.lblProdOneItemPrice.AutoSize = true;
            this.lblProdOneItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdOneItemPrice.ForeColor = System.Drawing.Color.Yellow;
            this.lblProdOneItemPrice.Location = new System.Drawing.Point(1105, 210);
            this.lblProdOneItemPrice.Name = "lblProdOneItemPrice";
            this.lblProdOneItemPrice.Size = new System.Drawing.Size(299, 29);
            this.lblProdOneItemPrice.TabIndex = 67;
            this.lblProdOneItemPrice.Text = "سعر الوحده للمنتج الذى تم شرائه:";
            // 
            // txtTotalProdPrice
            // 
            this.txtTotalProdPrice.BackColor = System.Drawing.Color.Pink;
            this.txtTotalProdPrice.Location = new System.Drawing.Point(426, 245);
            this.txtTotalProdPrice.Name = "txtTotalProdPrice";
            this.txtTotalProdPrice.Size = new System.Drawing.Size(660, 34);
            this.txtTotalProdPrice.TabIndex = 66;
            // 
            // lblTotalProdPrice
            // 
            this.lblTotalProdPrice.AutoSize = true;
            this.lblTotalProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProdPrice.ForeColor = System.Drawing.Color.Yellow;
            this.lblTotalProdPrice.Location = new System.Drawing.Point(1104, 250);
            this.lblTotalProdPrice.Name = "lblTotalProdPrice";
            this.lblTotalProdPrice.Size = new System.Drawing.Size(300, 29);
            this.lblTotalProdPrice.TabIndex = 65;
            this.lblTotalProdPrice.Text = "السعر الكلى للمنتج الذى تم شرائه:";
            // 
            // txtProdQty
            // 
            this.txtProdQty.BackColor = System.Drawing.Color.Pink;
            this.txtProdQty.Location = new System.Drawing.Point(426, 171);
            this.txtProdQty.Name = "txtProdQty";
            this.txtProdQty.Size = new System.Drawing.Size(660, 34);
            this.txtProdQty.TabIndex = 64;
            // 
            // lblProdQty
            // 
            this.lblProdQty.AutoSize = true;
            this.lblProdQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdQty.ForeColor = System.Drawing.Color.Yellow;
            this.lblProdQty.Location = new System.Drawing.Point(1166, 171);
            this.lblProdQty.Name = "lblProdQty";
            this.lblProdQty.Size = new System.Drawing.Size(238, 29);
            this.lblProdQty.TabIndex = 63;
            this.lblProdQty.Text = "كميه المنتج الذى تم شرائه:";
            // 
            // txtBuingProdName
            // 
            this.txtBuingProdName.BackColor = System.Drawing.Color.Pink;
            this.txtBuingProdName.Location = new System.Drawing.Point(426, 135);
            this.txtBuingProdName.Name = "txtBuingProdName";
            this.txtBuingProdName.Size = new System.Drawing.Size(660, 34);
            this.txtBuingProdName.TabIndex = 62;
            // 
            // lblBuingProdName
            // 
            this.lblBuingProdName.AutoSize = true;
            this.lblBuingProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuingProdName.ForeColor = System.Drawing.Color.Yellow;
            this.lblBuingProdName.Location = new System.Drawing.Point(1174, 133);
            this.lblBuingProdName.Name = "lblBuingProdName";
            this.lblBuingProdName.Size = new System.Drawing.Size(230, 29);
            this.lblBuingProdName.TabIndex = 61;
            this.lblBuingProdName.Text = "اسم المنتج الذى تم شرائه:";
            // 
            // lblBuingDate
            // 
            this.lblBuingDate.AutoSize = true;
            this.lblBuingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuingDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblBuingDate.Location = new System.Drawing.Point(1273, 97);
            this.lblBuingDate.Name = "lblBuingDate";
            this.lblBuingDate.Size = new System.Drawing.Size(131, 29);
            this.lblBuingDate.TabIndex = 48;
            this.lblBuingDate.Text = "تاريخ الشراء:";
            // 
            // dtpBuingDate
            // 
            this.dtpBuingDate.CalendarFont = new System.Drawing.Font("Impact", 14F);
            this.dtpBuingDate.CalendarMonthBackground = System.Drawing.Color.Pink;
            this.dtpBuingDate.CustomFormat = "yyyy/MM/dd";
            this.dtpBuingDate.Font = new System.Drawing.Font("Impact", 14F);
            this.dtpBuingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBuingDate.Location = new System.Drawing.Point(426, 97);
            this.dtpBuingDate.Name = "dtpBuingDate";
            this.dtpBuingDate.RightToLeftLayout = true;
            this.dtpBuingDate.Size = new System.Drawing.Size(660, 36);
            this.dtpBuingDate.TabIndex = 49;
            this.dtpBuingDate.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            // 
            // lblInvBuingNo
            // 
            this.lblInvBuingNo.AutoSize = true;
            this.lblInvBuingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvBuingNo.ForeColor = System.Drawing.Color.Yellow;
            this.lblInvBuingNo.Location = new System.Drawing.Point(1231, 21);
            this.lblInvBuingNo.Name = "lblInvBuingNo";
            this.lblInvBuingNo.Size = new System.Drawing.Size(173, 29);
            this.lblInvBuingNo.TabIndex = 6;
            this.lblInvBuingNo.Text = "كود فاتوره الشراء:";
            // 
            // txtInvBuingNo
            // 
            this.txtInvBuingNo.BackColor = System.Drawing.Color.Pink;
            this.txtInvBuingNo.Location = new System.Drawing.Point(426, 22);
            this.txtInvBuingNo.Name = "txtInvBuingNo";
            this.txtInvBuingNo.Size = new System.Drawing.Size(660, 34);
            this.txtInvBuingNo.TabIndex = 7;
            this.txtInvBuingNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmGetGymBuyings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1422, 738);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCalculateIncome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetGymBuyings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCalculateIncome_Load);
            this.pnlCalculateIncome.ResumeLayout(false);
            this.pnlCalculateIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInvImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCalculateIncome;
        private System.Windows.Forms.Label lblInvBuingNo;
        private System.Windows.Forms.TextBox txtInvBuingNo;
        private System.Windows.Forms.Label lblBuingDate;
        public System.Windows.Forms.DateTimePicker dtpBuingDate;
        private System.Windows.Forms.TextBox txtProdOneItemPrice;
        private System.Windows.Forms.Label lblProdOneItemPrice;
        private System.Windows.Forms.TextBox txtTotalProdPrice;
        private System.Windows.Forms.Label lblTotalProdPrice;
        private System.Windows.Forms.TextBox txtProdQty;
        private System.Windows.Forms.Label lblProdQty;
        private System.Windows.Forms.TextBox txtBuingProdName;
        private System.Windows.Forms.Label lblBuingProdName;
        private System.Windows.Forms.Label lblInvImage;
        private MyPictureBox picInvImage;
        private SansationRoundButton btnAddInvPic;
        private System.Windows.Forms.DataGridView dgvShowIncome;
        private System.Windows.Forms.ComboBox cbxResponsibleEmp;
        private System.Windows.Forms.Label lblResponsibleEmp;
        private System.Windows.Forms.Label lblMsg;
        private SansationRoundButton btnReportIncome;
        private SansationRoundButton btnDeleteIncome;
        private SansationRoundButton btnAddIncome;
        private SansationRoundButton btnNewIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colempno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyingResponsible;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuiedProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuiedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalBuiedProduct;
        private System.Windows.Forms.DataGridViewImageColumn colProdImage;
    }
}
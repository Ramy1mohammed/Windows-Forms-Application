namespace Gym
{
    partial class FrmNurtionSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNurtionSales));
            this.pnlNurtionSales = new System.Windows.Forms.Panel();
            this.dgvShowSaledProd = new System.Windows.Forms.DataGridView();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSaledQty = new System.Windows.Forms.TextBox();
            this.lblSaledQty = new System.Windows.Forms.Label();
            this.txtSaledProdPrice = new System.Windows.Forms.TextBox();
            this.lblSaledProdPrice = new System.Windows.Forms.Label();
            this.cbxSaledProd = new System.Windows.Forms.ComboBox();
            this.lblSaledProd = new System.Windows.Forms.Label();
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.lblBuyerName = new System.Windows.Forms.Label();
            this.txtInvNum = new System.Windows.Forms.TextBox();
            this.lblInvNum = new System.Windows.Forms.Label();
            this.pDoc = new System.Drawing.Printing.PrintDocument();
            this.ppDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.colInvNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsaledProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaledProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaledProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotalProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowOldInv = new SansationRoundButton();
            this.btnPrintInv = new SansationRoundButton();
            this.btnAddNewSaledProd = new SansationRoundButton();
            this.pnlNurtionSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSaledProd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNurtionSales
            // 
            this.pnlNurtionSales.Controls.Add(this.btnShowOldInv);
            this.pnlNurtionSales.Controls.Add(this.dgvShowSaledProd);
            this.pnlNurtionSales.Controls.Add(this.dtpSaleDate);
            this.pnlNurtionSales.Controls.Add(this.lblSaleDate);
            this.pnlNurtionSales.Controls.Add(this.btnPrintInv);
            this.pnlNurtionSales.Controls.Add(this.btnAddNewSaledProd);
            this.pnlNurtionSales.Controls.Add(this.txtTotal);
            this.pnlNurtionSales.Controls.Add(this.lblTotal);
            this.pnlNurtionSales.Controls.Add(this.txtSaledQty);
            this.pnlNurtionSales.Controls.Add(this.lblSaledQty);
            this.pnlNurtionSales.Controls.Add(this.txtSaledProdPrice);
            this.pnlNurtionSales.Controls.Add(this.lblSaledProdPrice);
            this.pnlNurtionSales.Controls.Add(this.cbxSaledProd);
            this.pnlNurtionSales.Controls.Add(this.lblSaledProd);
            this.pnlNurtionSales.Controls.Add(this.txtBuyerName);
            this.pnlNurtionSales.Controls.Add(this.lblBuyerName);
            this.pnlNurtionSales.Controls.Add(this.txtInvNum);
            this.pnlNurtionSales.Controls.Add(this.lblInvNum);
            this.pnlNurtionSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNurtionSales.Location = new System.Drawing.Point(0, 0);
            this.pnlNurtionSales.Name = "pnlNurtionSales";
            this.pnlNurtionSales.Size = new System.Drawing.Size(1422, 738);
            this.pnlNurtionSales.TabIndex = 6;
            // 
            // dgvShowSaledProd
            // 
            this.dgvShowSaledProd.AllowUserToAddRows = false;
            this.dgvShowSaledProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowSaledProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowSaledProd.BackgroundColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowSaledProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowSaledProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowSaledProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvNum,
            this.colsaledProd,
            this.colSaledProdQty,
            this.colSaledProdPrice,
            this.colSubTotalProd,
            this.colProdNo});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowSaledProd.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShowSaledProd.EnableHeadersVisualStyles = false;
            this.dgvShowSaledProd.Location = new System.Drawing.Point(3, 392);
            this.dgvShowSaledProd.Name = "dgvShowSaledProd";
            this.dgvShowSaledProd.ReadOnly = true;
            this.dgvShowSaledProd.RowHeadersWidth = 51;
            this.dgvShowSaledProd.RowTemplate.Height = 24;
            this.dgvShowSaledProd.Size = new System.Drawing.Size(1419, 346);
            this.dgvShowSaledProd.TabIndex = 33;
            this.dgvShowSaledProd.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvShowSaledProd_RowsAdded);
            this.dgvShowSaledProd.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvShowSaledProd_RowsRemoved);
            this.dgvShowSaledProd.SelectionChanged += new System.EventHandler(this.dgvShowSaledProd_SelectionChanged);
            this.dgvShowSaledProd.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvShowSaledProd_UserDeletingRow);
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.CalendarFont = new System.Drawing.Font("Impact", 14F);
            this.dtpSaleDate.CalendarMonthBackground = System.Drawing.Color.Pink;
            this.dtpSaleDate.CustomFormat = "yyyy/MM/dd";
            this.dtpSaleDate.Font = new System.Drawing.Font("Impact", 14F);
            this.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaleDate.Location = new System.Drawing.Point(426, 53);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.RightToLeftLayout = true;
            this.dtpSaleDate.Size = new System.Drawing.Size(307, 36);
            this.dtpSaleDate.TabIndex = 28;
            this.dtpSaleDate.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblSaleDate.Location = new System.Drawing.Point(739, 53);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(113, 29);
            this.lblSaleDate.TabIndex = 27;
            this.lblSaleDate.Text = "تاريخ البيع:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.DeepPink;
            this.txtTotal.Location = new System.Drawing.Point(265, 179);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(149, 34);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Yellow;
            this.lblTotal.Location = new System.Drawing.Point(282, 139);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(111, 29);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "↓الاجمالى↓";
            // 
            // txtSaledQty
            // 
            this.txtSaledQty.BackColor = System.Drawing.Color.Pink;
            this.txtSaledQty.Location = new System.Drawing.Point(425, 179);
            this.txtSaledQty.Name = "txtSaledQty";
            this.txtSaledQty.Size = new System.Drawing.Size(301, 34);
            this.txtSaledQty.TabIndex = 17;
            this.txtSaledQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaledQty_KeyPress);
            // 
            // lblSaledQty
            // 
            this.lblSaledQty.AutoSize = true;
            this.lblSaledQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaledQty.ForeColor = System.Drawing.Color.Yellow;
            this.lblSaledQty.Location = new System.Drawing.Point(751, 182);
            this.lblSaledQty.Name = "lblSaledQty";
            this.lblSaledQty.Size = new System.Drawing.Size(136, 29);
            this.lblSaledQty.TabIndex = 16;
            this.lblSaledQty.Text = "الكميه المباعه:";
            // 
            // txtSaledProdPrice
            // 
            this.txtSaledProdPrice.BackColor = System.Drawing.Color.Pink;
            this.txtSaledProdPrice.Location = new System.Drawing.Point(925, 179);
            this.txtSaledProdPrice.Name = "txtSaledProdPrice";
            this.txtSaledProdPrice.Size = new System.Drawing.Size(301, 34);
            this.txtSaledProdPrice.TabIndex = 15;
            this.txtSaledProdPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaledProdPrice_KeyPress);
            // 
            // lblSaledProdPrice
            // 
            this.lblSaledProdPrice.AutoSize = true;
            this.lblSaledProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaledProdPrice.ForeColor = System.Drawing.Color.Yellow;
            this.lblSaledProdPrice.Location = new System.Drawing.Point(1276, 179);
            this.lblSaledProdPrice.Name = "lblSaledProdPrice";
            this.lblSaledProdPrice.Size = new System.Drawing.Size(102, 29);
            this.lblSaledProdPrice.TabIndex = 14;
            this.lblSaledProdPrice.Text = "سعر البيع:";
            // 
            // cbxSaledProd
            // 
            this.cbxSaledProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSaledProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSaledProd.BackColor = System.Drawing.Color.Pink;
            this.cbxSaledProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxSaledProd.FormattingEnabled = true;
            this.cbxSaledProd.Items.AddRange(new object[] {
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
            "موظف شئون عاملين",
            "مبيعات مكملات غذائيه",
            "مبيعات مشروبات وأغذيه",
            "عامل صيانه أجهزه تدريب",
            "عامل صيانه كهرباء"});
            this.cbxSaledProd.Location = new System.Drawing.Point(426, 136);
            this.cbxSaledProd.Name = "cbxSaledProd";
            this.cbxSaledProd.Size = new System.Drawing.Size(800, 37);
            this.cbxSaledProd.TabIndex = 13;
            // 
            // lblSaledProd
            // 
            this.lblSaledProd.AutoSize = true;
            this.lblSaledProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaledProd.ForeColor = System.Drawing.Color.Yellow;
            this.lblSaledProd.Location = new System.Drawing.Point(1251, 139);
            this.lblSaledProd.Name = "lblSaledProd";
            this.lblSaledProd.Size = new System.Drawing.Size(137, 29);
            this.lblSaledProd.TabIndex = 12;
            this.lblSaledProd.Text = "الصنف المباع:";
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.BackColor = System.Drawing.Color.Pink;
            this.txtBuyerName.Location = new System.Drawing.Point(426, 96);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Size = new System.Drawing.Size(800, 34);
            this.txtBuyerName.TabIndex = 9;
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.AutoSize = true;
            this.lblBuyerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerName.ForeColor = System.Drawing.Color.Yellow;
            this.lblBuyerName.Location = new System.Drawing.Point(1276, 96);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.Size = new System.Drawing.Size(113, 29);
            this.lblBuyerName.TabIndex = 8;
            this.lblBuyerName.Text = "اسم الزبون:";
            // 
            // txtInvNum
            // 
            this.txtInvNum.BackColor = System.Drawing.Color.Pink;
            this.txtInvNum.ForeColor = System.Drawing.Color.Red;
            this.txtInvNum.Location = new System.Drawing.Point(857, 56);
            this.txtInvNum.Name = "txtInvNum";
            this.txtInvNum.ReadOnly = true;
            this.txtInvNum.Size = new System.Drawing.Size(369, 34);
            this.txtInvNum.TabIndex = 7;
            this.txtInvNum.Text = "00000000";
            this.txtInvNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInvNum
            // 
            this.lblInvNum.AutoSize = true;
            this.lblInvNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvNum.ForeColor = System.Drawing.Color.Yellow;
            this.lblInvNum.Location = new System.Drawing.Point(1276, 56);
            this.lblInvNum.Name = "lblInvNum";
            this.lblInvNum.Size = new System.Drawing.Size(121, 29);
            this.lblInvNum.TabIndex = 6;
            this.lblInvNum.Text = "رقم الفاتوره:";
            // 
            // pDoc
            // 
            this.pDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDoc_PrintPage);
            // 
            // ppDialog
            // 
            this.ppDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.ppDialog.Document = this.pDoc;
            this.ppDialog.Enabled = true;
            this.ppDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("ppDialog.Icon")));
            this.ppDialog.Name = "ppDialog";
            this.ppDialog.Visible = false;
            // 
            // colInvNum
            // 
            this.colInvNum.HeaderText = "رقم الفاتوره";
            this.colInvNum.MinimumWidth = 6;
            this.colInvNum.Name = "colInvNum";
            this.colInvNum.ReadOnly = true;
            this.colInvNum.Visible = false;
            // 
            // colsaledProd
            // 
            this.colsaledProd.HeaderText = "الصنف المباع";
            this.colsaledProd.MinimumWidth = 6;
            this.colsaledProd.Name = "colsaledProd";
            this.colsaledProd.ReadOnly = true;
            // 
            // colSaledProdQty
            // 
            this.colSaledProdQty.HeaderText = "الكميه المباعه";
            this.colSaledProdQty.MinimumWidth = 6;
            this.colSaledProdQty.Name = "colSaledProdQty";
            this.colSaledProdQty.ReadOnly = true;
            // 
            // colSaledProdPrice
            // 
            this.colSaledProdPrice.HeaderText = "سعر البيع للوحده";
            this.colSaledProdPrice.MinimumWidth = 6;
            this.colSaledProdPrice.Name = "colSaledProdPrice";
            this.colSaledProdPrice.ReadOnly = true;
            // 
            // colSubTotalProd
            // 
            this.colSubTotalProd.HeaderText = "الاجمالى الفرعى";
            this.colSubTotalProd.MinimumWidth = 6;
            this.colSubTotalProd.Name = "colSubTotalProd";
            this.colSubTotalProd.ReadOnly = true;
            // 
            // colProdNo
            // 
            this.colProdNo.HeaderText = "كود الصنف المباع";
            this.colProdNo.MinimumWidth = 6;
            this.colProdNo.Name = "colProdNo";
            this.colProdNo.ReadOnly = true;
            this.colProdNo.Visible = false;
            // 
            // btnShowOldInv
            // 
            this.btnShowOldInv.BackColor = System.Drawing.Color.Pink;
            this.btnShowOldInv.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnShowOldInv.BorderColor = System.Drawing.Color.Black;
            this.btnShowOldInv.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnShowOldInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowOldInv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnShowOldInv.FlatAppearance.BorderSize = 2;
            this.btnShowOldInv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowOldInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOldInv.Location = new System.Drawing.Point(12, 293);
            this.btnShowOldInv.Name = "btnShowOldInv";
            this.btnShowOldInv.Size = new System.Drawing.Size(222, 58);
            this.btnShowOldInv.TabIndex = 34;
            this.btnShowOldInv.Text = "اظهار الفواتير القديمه";
            this.btnShowOldInv.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnShowOldInv.UseVisualStyleBackColor = false;
            this.btnShowOldInv.Click += new System.EventHandler(this.btnShowOldInv_Click);
            // 
            // btnPrintInv
            // 
            this.btnPrintInv.BackColor = System.Drawing.Color.Pink;
            this.btnPrintInv.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnPrintInv.BorderColor = System.Drawing.Color.Black;
            this.btnPrintInv.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnPrintInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintInv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrintInv.FlatAppearance.BorderSize = 2;
            this.btnPrintInv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInv.Location = new System.Drawing.Point(1004, 289);
            this.btnPrintInv.Name = "btnPrintInv";
            this.btnPrintInv.Size = new System.Drawing.Size(108, 62);
            this.btnPrintInv.TabIndex = 26;
            this.btnPrintInv.Text = "طباعه";
            this.btnPrintInv.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnPrintInv.UseVisualStyleBackColor = false;
            this.btnPrintInv.Click += new System.EventHandler(this.btnPrintInv_Click);
            // 
            // btnAddNewSaledProd
            // 
            this.btnAddNewSaledProd.BackColor = System.Drawing.Color.Pink;
            this.btnAddNewSaledProd.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnAddNewSaledProd.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewSaledProd.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnAddNewSaledProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewSaledProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddNewSaledProd.FlatAppearance.BorderSize = 2;
            this.btnAddNewSaledProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewSaledProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewSaledProd.Location = new System.Drawing.Point(1118, 289);
            this.btnAddNewSaledProd.Name = "btnAddNewSaledProd";
            this.btnAddNewSaledProd.Size = new System.Drawing.Size(108, 62);
            this.btnAddNewSaledProd.TabIndex = 25;
            this.btnAddNewSaledProd.Text = "اضــافه";
            this.btnAddNewSaledProd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnAddNewSaledProd.UseVisualStyleBackColor = false;
            this.btnAddNewSaledProd.Click += new System.EventHandler(this.btnAddNewSaledProd_Click);
            // 
            // FrmNurtionSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1422, 738);
            this.ControlBox = false;
            this.Controls.Add(this.pnlNurtionSales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNurtionSales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmNurtionSales_Load);
            this.pnlNurtionSales.ResumeLayout(false);
            this.pnlNurtionSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSaledProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNurtionSales;
        public System.Windows.Forms.TextBox txtBuyerName;
        private System.Windows.Forms.Label lblBuyerName;
        public System.Windows.Forms.TextBox txtInvNum;
        private System.Windows.Forms.Label lblInvNum;
        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.TextBox txtSaledQty;
        private System.Windows.Forms.Label lblSaledQty;
        public System.Windows.Forms.TextBox txtSaledProdPrice;
        private System.Windows.Forms.Label lblSaledProdPrice;
        public System.Windows.Forms.ComboBox cbxSaledProd;
        private System.Windows.Forms.Label lblSaledProd;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.Label lblSaleDate;
        private SansationRoundButton btnPrintInv;
        private SansationRoundButton btnAddNewSaledProd;
        private System.Windows.Forms.DataGridView dgvShowSaledProd;
        private SansationRoundButton btnShowOldInv;
        private System.Drawing.Printing.PrintDocument pDoc;
        private System.Windows.Forms.PrintPreviewDialog ppDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsaledProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaledProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaledProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotalProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdNo;
    }
}
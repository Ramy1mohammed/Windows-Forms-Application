namespace Gym
{
    partial class FrmShowOldInv
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
            this.pnlHead = new System.Windows.Forms.Panel();
            this.dgvShowOldSaledSuppliments = new System.Windows.Forms.DataGridView();
            this.colInvNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsaledProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaledProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaledProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdoBuierName = new System.Windows.Forms.RadioButton();
            this.rdoInvNum = new System.Windows.Forms.RadioButton();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDeleteAllOldInv = new SansationRoundButton();
            this.btnDeleteOne = new SansationRoundButton();
            this.btnOldInvReport = new SansationRoundButton();
            this.btnMinimize = new SansationRoundButton();
            this.btnMaxmize = new SansationRoundButton();
            this.btnClose = new SansationRoundButton();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOldSaledSuppliments)).BeginInit();
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
            this.pnlHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseDown);
            this.pnlHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseMove);
            this.pnlHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseUp);
            // 
            // dgvShowOldSaledSuppliments
            // 
            this.dgvShowOldSaledSuppliments.AllowUserToAddRows = false;
            this.dgvShowOldSaledSuppliments.AllowUserToDeleteRows = false;
            this.dgvShowOldSaledSuppliments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowOldSaledSuppliments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowOldSaledSuppliments.BackgroundColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowOldSaledSuppliments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowOldSaledSuppliments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowOldSaledSuppliments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvNum,
            this.colBuyerName,
            this.colsaledProd,
            this.colBuyingDate,
            this.colSaledProdPrice,
            this.colSaledProdQty});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowOldSaledSuppliments.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowOldSaledSuppliments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShowOldSaledSuppliments.EnableHeadersVisualStyles = false;
            this.dgvShowOldSaledSuppliments.Location = new System.Drawing.Point(0, 312);
            this.dgvShowOldSaledSuppliments.Name = "dgvShowOldSaledSuppliments";
            this.dgvShowOldSaledSuppliments.RowHeadersWidth = 51;
            this.dgvShowOldSaledSuppliments.RowTemplate.Height = 24;
            this.dgvShowOldSaledSuppliments.Size = new System.Drawing.Size(1422, 426);
            this.dgvShowOldSaledSuppliments.TabIndex = 34;
            // 
            // colInvNum
            // 
            this.colInvNum.DataPropertyName = "invnum";
            this.colInvNum.HeaderText = "رقم الفاتوره";
            this.colInvNum.MinimumWidth = 6;
            this.colInvNum.Name = "colInvNum";
            // 
            // colBuyerName
            // 
            this.colBuyerName.DataPropertyName = "trname";
            this.colBuyerName.HeaderText = "اسم المشترى";
            this.colBuyerName.MinimumWidth = 6;
            this.colBuyerName.Name = "colBuyerName";
            // 
            // colsaledProd
            // 
            this.colsaledProd.DataPropertyName = "supplyname";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colsaledProd.DefaultCellStyle = dataGridViewCellStyle2;
            this.colsaledProd.HeaderText = "الصنف المباع";
            this.colsaledProd.MinimumWidth = 6;
            this.colsaledProd.Name = "colsaledProd";
            // 
            // colBuyingDate
            // 
            this.colBuyingDate.DataPropertyName = "buydate";
            this.colBuyingDate.HeaderText = "تاريخ البيع";
            this.colBuyingDate.MinimumWidth = 6;
            this.colBuyingDate.Name = "colBuyingDate";
            // 
            // colSaledProdPrice
            // 
            this.colSaledProdPrice.DataPropertyName = "price";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colSaledProdPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSaledProdPrice.HeaderText = "سعر البيع للوحده";
            this.colSaledProdPrice.MinimumWidth = 6;
            this.colSaledProdPrice.Name = "colSaledProdPrice";
            // 
            // colSaledProdQty
            // 
            this.colSaledProdQty.DataPropertyName = "qty";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colSaledProdQty.DefaultCellStyle = dataGridViewCellStyle4;
            this.colSaledProdQty.HeaderText = "الكميه المباعه";
            this.colSaledProdQty.MinimumWidth = 6;
            this.colSaledProdQty.Name = "colSaledProdQty";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Pink;
            this.txtSearch.Location = new System.Drawing.Point(108, 97);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(341, 34);
            this.txtSearch.TabIndex = 51;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // rdoBuierName
            // 
            this.rdoBuierName.AutoSize = true;
            this.rdoBuierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoBuierName.Location = new System.Drawing.Point(594, 98);
            this.rdoBuierName.Name = "rdoBuierName";
            this.rdoBuierName.Size = new System.Drawing.Size(131, 33);
            this.rdoBuierName.TabIndex = 50;
            this.rdoBuierName.Text = "اسم المشترى";
            this.rdoBuierName.UseVisualStyleBackColor = true;
            this.rdoBuierName.Click += new System.EventHandler(this.rdoInvNum_Click);
            // 
            // rdoInvNum
            // 
            this.rdoInvNum.AutoSize = true;
            this.rdoInvNum.Checked = true;
            this.rdoInvNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoInvNum.Location = new System.Drawing.Point(464, 98);
            this.rdoInvNum.Name = "rdoInvNum";
            this.rdoInvNum.Size = new System.Drawing.Size(123, 33);
            this.rdoInvNum.TabIndex = 49;
            this.rdoInvNum.TabStop = true;
            this.rdoInvNum.Text = "رقم الفاتوره";
            this.rdoInvNum.UseVisualStyleBackColor = true;
            this.rdoInvNum.Click += new System.EventHandler(this.rdoInvNum_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Yellow;
            this.lblSearch.Location = new System.Drawing.Point(22, 97);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(71, 29);
            this.lblSearch.TabIndex = 48;
            this.lblSearch.Text = "البحث:";
            // 
            // btnDeleteAllOldInv
            // 
            this.btnDeleteAllOldInv.BackColor = System.Drawing.Color.Pink;
            this.btnDeleteAllOldInv.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnDeleteAllOldInv.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteAllOldInv.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnDeleteAllOldInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAllOldInv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteAllOldInv.FlatAppearance.BorderSize = 2;
            this.btnDeleteAllOldInv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteAllOldInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllOldInv.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteAllOldInv.Location = new System.Drawing.Point(1157, 212);
            this.btnDeleteAllOldInv.Name = "btnDeleteAllOldInv";
            this.btnDeleteAllOldInv.Size = new System.Drawing.Size(230, 48);
            this.btnDeleteAllOldInv.TabIndex = 54;
            this.btnDeleteAllOldInv.Text = "حذف الجميع";
            this.btnDeleteAllOldInv.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnDeleteAllOldInv.UseVisualStyleBackColor = false;
            this.btnDeleteAllOldInv.Click += new System.EventHandler(this.btnDeleteAllOldInv_Click);
            // 
            // btnDeleteOne
            // 
            this.btnDeleteOne.BackColor = System.Drawing.Color.Pink;
            this.btnDeleteOne.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnDeleteOne.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteOne.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnDeleteOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteOne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteOne.FlatAppearance.BorderSize = 2;
            this.btnDeleteOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOne.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteOne.Location = new System.Drawing.Point(254, 212);
            this.btnDeleteOne.Name = "btnDeleteOne";
            this.btnDeleteOne.Size = new System.Drawing.Size(140, 48);
            this.btnDeleteOne.TabIndex = 53;
            this.btnDeleteOne.Text = "حذف";
            this.btnDeleteOne.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnDeleteOne.UseVisualStyleBackColor = false;
            this.btnDeleteOne.Click += new System.EventHandler(this.btnDeleteOne_Click);
            // 
            // btnOldInvReport
            // 
            this.btnOldInvReport.BackColor = System.Drawing.Color.Pink;
            this.btnOldInvReport.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnOldInvReport.BorderColor = System.Drawing.Color.Black;
            this.btnOldInvReport.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnOldInvReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOldInvReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOldInvReport.FlatAppearance.BorderSize = 2;
            this.btnOldInvReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOldInvReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOldInvReport.Location = new System.Drawing.Point(108, 212);
            this.btnOldInvReport.Name = "btnOldInvReport";
            this.btnOldInvReport.Size = new System.Drawing.Size(140, 48);
            this.btnOldInvReport.TabIndex = 52;
            this.btnOldInvReport.Text = "تقرير";
            this.btnOldInvReport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnOldInvReport.UseVisualStyleBackColor = false;
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
            // FrmShowOldInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1422, 738);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeleteAllOldInv);
            this.Controls.Add(this.btnDeleteOne);
            this.Controls.Add(this.btnOldInvReport);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rdoBuierName);
            this.Controls.Add(this.rdoInvNum);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvShowOldSaledSuppliments);
            this.Controls.Add(this.pnlHead);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowOldInv";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmShowOldInv_Load);
            this.pnlHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOldSaledSuppliments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private SansationRoundButton btnClose;
        private SansationRoundButton btnMinimize;
        private SansationRoundButton btnMaxmize;
        private System.Windows.Forms.DataGridView dgvShowOldSaledSuppliments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsaledProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaledProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaledProdQty;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdoBuierName;
        private System.Windows.Forms.RadioButton rdoInvNum;
        private System.Windows.Forms.Label lblSearch;
        private SansationRoundButton btnOldInvReport;
        private SansationRoundButton btnDeleteOne;
        private SansationRoundButton btnDeleteAllOldInv;
    }
}
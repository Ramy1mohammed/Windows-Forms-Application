namespace EmplyeeWithDataTable
{
    partial class FrmEmp
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.rdoGreaterThan = new System.Windows.Forms.RadioButton();
            this.rdoLessThan = new System.Windows.Forms.RadioButton();
            this.lblDataSearch = new System.Windows.Forms.Label();
            this.dgvSerarch = new System.Windows.Forms.DataGridView();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchText = new System.Windows.Forms.Label();
            this.rdoSalary = new System.Windows.Forms.RadioButton();
            this.rdoAddress = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.rdoNumber = new System.Windows.Forms.RadioButton();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblDataInput = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.lblempname = new System.Windows.Forms.Label();
            this.txtempnum = new System.Windows.Forms.TextBox();
            this.lblempnum = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerarch)).BeginInit();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.DarkGreen;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblHeader.Location = new System.Drawing.Point(613, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(338, 52);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Employee Form";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.rdoGreaterThan);
            this.pnlSearch.Controls.Add(this.rdoLessThan);
            this.pnlSearch.Controls.Add(this.lblDataSearch);
            this.pnlSearch.Controls.Add(this.dgvSerarch);
            this.pnlSearch.Controls.Add(this.lblResults);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearchText);
            this.pnlSearch.Controls.Add(this.rdoSalary);
            this.pnlSearch.Controls.Add(this.rdoAddress);
            this.pnlSearch.Controls.Add(this.rdoName);
            this.pnlSearch.Controls.Add(this.rdoNumber);
            this.pnlSearch.Controls.Add(this.lblSearchBy);
            this.pnlSearch.Location = new System.Drawing.Point(750, 71);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(783, 575);
            this.pnlSearch.TabIndex = 13;
            // 
            // rdoGreaterThan
            // 
            this.rdoGreaterThan.AutoSize = true;
            this.rdoGreaterThan.ForeColor = System.Drawing.Color.Aqua;
            this.rdoGreaterThan.Location = new System.Drawing.Point(654, 105);
            this.rdoGreaterThan.Name = "rdoGreaterThan";
            this.rdoGreaterThan.Size = new System.Drawing.Size(52, 35);
            this.rdoGreaterThan.TabIndex = 28;
            this.rdoGreaterThan.Text = ">";
            this.rdoGreaterThan.UseVisualStyleBackColor = true;
            this.rdoGreaterThan.Visible = false;
            // 
            // rdoLessThan
            // 
            this.rdoLessThan.AutoSize = true;
            this.rdoLessThan.ForeColor = System.Drawing.Color.Aqua;
            this.rdoLessThan.Location = new System.Drawing.Point(588, 105);
            this.rdoLessThan.Name = "rdoLessThan";
            this.rdoLessThan.Size = new System.Drawing.Size(52, 35);
            this.rdoLessThan.TabIndex = 27;
            this.rdoLessThan.Text = "<";
            this.rdoLessThan.UseVisualStyleBackColor = true;
            this.rdoLessThan.Visible = false;
            // 
            // lblDataSearch
            // 
            this.lblDataSearch.AutoSize = true;
            this.lblDataSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSearch.ForeColor = System.Drawing.Color.Blue;
            this.lblDataSearch.Location = new System.Drawing.Point(291, 7);
            this.lblDataSearch.Name = "lblDataSearch";
            this.lblDataSearch.Size = new System.Drawing.Size(217, 39);
            this.lblDataSearch.TabIndex = 26;
            this.lblDataSearch.Text = "Data Search";
            // 
            // dgvSerarch
            // 
            this.dgvSerarch.AllowUserToAddRows = false;
            this.dgvSerarch.AllowUserToDeleteRows = false;
            this.dgvSerarch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSerarch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSerarch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSerarch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSerarch.Location = new System.Drawing.Point(0, 247);
            this.dgvSerarch.MultiSelect = false;
            this.dgvSerarch.Name = "dgvSerarch";
            this.dgvSerarch.ReadOnly = true;
            this.dgvSerarch.RowHeadersWidth = 51;
            this.dgvSerarch.RowTemplate.Height = 24;
            this.dgvSerarch.Size = new System.Drawing.Size(781, 326);
            this.dgvSerarch.TabIndex = 21;
            this.dgvSerarch.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSerarch_RowsAdded);
            this.dgvSerarch.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvSerarch_RowsRemoved);
            this.dgvSerarch.SelectionChanged += new System.EventHandler(this.dgvSerarch_SelectionChanged);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.ForeColor = System.Drawing.Color.Maroon;
            this.lblResults.Location = new System.Drawing.Point(17, 203);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(255, 31);
            this.lblResults.TabIndex = 20;
            this.lblResults.Text = "Results: 0  Row(s)";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSearch.FlatAppearance.BorderSize = 3;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.ForeColor = System.Drawing.Color.Aqua;
            this.btnSearch.Location = new System.Drawing.Point(576, 146);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 40);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(203, 147);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(356, 38);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSearchText
            // 
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.Location = new System.Drawing.Point(17, 153);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(180, 31);
            this.lblSearchText.TabIndex = 19;
            this.lblSearchText.Text = "Search Text:";
            // 
            // rdoSalary
            // 
            this.rdoSalary.AutoSize = true;
            this.rdoSalary.ForeColor = System.Drawing.Color.Aqua;
            this.rdoSalary.Location = new System.Drawing.Point(588, 49);
            this.rdoSalary.Name = "rdoSalary";
            this.rdoSalary.Size = new System.Drawing.Size(118, 35);
            this.rdoSalary.TabIndex = 18;
            this.rdoSalary.Text = "Salary";
            this.rdoSalary.UseVisualStyleBackColor = true;
            this.rdoSalary.CheckedChanged += new System.EventHandler(this.rdoSalary_CheckedChanged);
            // 
            // rdoAddress
            // 
            this.rdoAddress.AutoSize = true;
            this.rdoAddress.ForeColor = System.Drawing.Color.Aqua;
            this.rdoAddress.Location = new System.Drawing.Point(440, 49);
            this.rdoAddress.Name = "rdoAddress";
            this.rdoAddress.Size = new System.Drawing.Size(142, 35);
            this.rdoAddress.TabIndex = 17;
            this.rdoAddress.Text = "Address";
            this.rdoAddress.UseVisualStyleBackColor = true;
            this.rdoAddress.CheckedChanged += new System.EventHandler(this.rdoSalary_CheckedChanged);
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Checked = true;
            this.rdoName.ForeColor = System.Drawing.Color.Aqua;
            this.rdoName.Location = new System.Drawing.Point(323, 50);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(111, 35);
            this.rdoName.TabIndex = 16;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "Name";
            this.rdoName.UseVisualStyleBackColor = true;
            this.rdoName.CheckedChanged += new System.EventHandler(this.rdoSalary_CheckedChanged);
            // 
            // rdoNumber
            // 
            this.rdoNumber.AutoSize = true;
            this.rdoNumber.ForeColor = System.Drawing.Color.Aqua;
            this.rdoNumber.Location = new System.Drawing.Point(180, 50);
            this.rdoNumber.Name = "rdoNumber";
            this.rdoNumber.Size = new System.Drawing.Size(137, 35);
            this.rdoNumber.TabIndex = 15;
            this.rdoNumber.Text = "Number";
            this.rdoNumber.UseVisualStyleBackColor = true;
            this.rdoNumber.CheckedChanged += new System.EventHandler(this.rdoSalary_CheckedChanged);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(17, 49);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(157, 31);
            this.lblSearchBy.TabIndex = 14;
            this.lblSearchBy.Text = "Search By:";
            // 
            // pnlData
            // 
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.btnReport);
            this.pnlData.Controls.Add(this.btnNew);
            this.pnlData.Controls.Add(this.lblDataInput);
            this.pnlData.Controls.Add(this.btnFind);
            this.pnlData.Controls.Add(this.btnDelete);
            this.pnlData.Controls.Add(this.btnEdit);
            this.pnlData.Controls.Add(this.btnadd);
            this.pnlData.Controls.Add(this.txtSalary);
            this.pnlData.Controls.Add(this.lblSalary);
            this.pnlData.Controls.Add(this.txtaddress);
            this.pnlData.Controls.Add(this.lbladdress);
            this.pnlData.Controls.Add(this.txtempname);
            this.pnlData.Controls.Add(this.lblempname);
            this.pnlData.Controls.Add(this.txtempnum);
            this.pnlData.Controls.Add(this.lblempnum);
            this.pnlData.Location = new System.Drawing.Point(2, 71);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(742, 575);
            this.pnlData.TabIndex = 14;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnNew.FlatAppearance.BorderSize = 3;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.ForeColor = System.Drawing.Color.Aqua;
            this.btnNew.Location = new System.Drawing.Point(33, 362);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(110, 45);
            this.btnNew.TabIndex = 26;
            this.btnNew.Text = "New*";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblDataInput
            // 
            this.lblDataInput.AutoSize = true;
            this.lblDataInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInput.ForeColor = System.Drawing.Color.Blue;
            this.lblDataInput.Location = new System.Drawing.Point(291, 10);
            this.lblDataInput.Name = "lblDataInput";
            this.lblDataInput.Size = new System.Drawing.Size(184, 39);
            this.lblDataInput.TabIndex = 25;
            this.lblDataInput.Text = "Data Input";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnFind.FlatAppearance.BorderSize = 3;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.ForeColor = System.Drawing.Color.Aqua;
            this.btnFind.Location = new System.Drawing.Point(485, 362);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(110, 45);
            this.btnFind.TabIndex = 24;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.Aqua;
            this.btnDelete.Location = new System.Drawing.Point(372, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 45);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEdit.FlatAppearance.BorderSize = 3;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.ForeColor = System.Drawing.Color.Aqua;
            this.btnEdit.Location = new System.Drawing.Point(259, 362);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 45);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnadd.FlatAppearance.BorderSize = 3;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.ForeColor = System.Drawing.Color.Aqua;
            this.btnadd.Location = new System.Drawing.Point(146, 362);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(110, 45);
            this.btnadd.TabIndex = 21;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSalary.Location = new System.Drawing.Point(278, 268);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(445, 38);
            this.txtSalary.TabIndex = 20;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(11, 271);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(106, 31);
            this.lblSalary.TabIndex = 19;
            this.lblSalary.Text = "Salary:";
            // 
            // txtaddress
            // 
            this.txtaddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtaddress.Location = new System.Drawing.Point(278, 224);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(445, 38);
            this.txtaddress.TabIndex = 18;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(11, 227);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(130, 31);
            this.lbladdress.TabIndex = 17;
            this.lbladdress.Text = "Address:";
            // 
            // txtempname
            // 
            this.txtempname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtempname.Location = new System.Drawing.Point(278, 180);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(445, 38);
            this.txtempname.TabIndex = 16;
            this.txtempname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Location = new System.Drawing.Point(11, 183);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(235, 31);
            this.lblempname.TabIndex = 15;
            this.lblempname.Text = "Employee Name:";
            // 
            // txtempnum
            // 
            this.txtempnum.BackColor = System.Drawing.SystemColors.Window;
            this.txtempnum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtempnum.Location = new System.Drawing.Point(278, 136);
            this.txtempnum.Name = "txtempnum";
            this.txtempnum.ReadOnly = true;
            this.txtempnum.Size = new System.Drawing.Size(445, 38);
            this.txtempnum.TabIndex = 14;
            this.txtempnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblempnum
            // 
            this.lblempnum.AutoSize = true;
            this.lblempnum.Location = new System.Drawing.Point(11, 139);
            this.lblempnum.Name = "lblempnum";
            this.lblempnum.Size = new System.Drawing.Size(261, 31);
            this.lblempnum.TabIndex = 13;
            this.lblempnum.Text = "Employee Number:";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnReport.FlatAppearance.BorderSize = 3;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.ForeColor = System.Drawing.Color.Aqua;
            this.btnReport.Location = new System.Drawing.Point(598, 362);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(110, 45);
            this.btnReport.TabIndex = 27;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // FrmEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1565, 657);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Form";
            this.Load += new System.EventHandler(this.FrmEmp_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerarch)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.DataGridView dgvSerarch;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchText;
        private System.Windows.Forms.RadioButton rdoSalary;
        private System.Windows.Forms.RadioButton rdoAddress;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.RadioButton rdoNumber;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label lblDataSearch;
        private System.Windows.Forms.Label lblDataInput;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.TextBox txtempnum;
        private System.Windows.Forms.Label lblempnum;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.RadioButton rdoGreaterThan;
        private System.Windows.Forms.RadioButton rdoLessThan;
        private System.Windows.Forms.Button btnReport;
    }
}


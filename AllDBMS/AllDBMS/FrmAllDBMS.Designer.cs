namespace AllDBMS
{
    partial class FrmAllDBMS
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
            this.lblDBMS = new System.Windows.Forms.Label();
            this.cbxDBMS = new System.Windows.Forms.ComboBox();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.pnlAll = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoSalary = new System.Windows.Forms.RadioButton();
            this.rdoCity = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.rdoNumber = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.pnlAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDBMS
            // 
            this.lblDBMS.AutoSize = true;
            this.lblDBMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBMS.ForeColor = System.Drawing.Color.Navy;
            this.lblDBMS.Location = new System.Drawing.Point(406, 9);
            this.lblDBMS.Name = "lblDBMS";
            this.lblDBMS.Size = new System.Drawing.Size(454, 39);
            this.lblDBMS.TabIndex = 0;
            this.lblDBMS.Text = " All DBMS - Not Connected";
            // 
            // cbxDBMS
            // 
            this.cbxDBMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDBMS.FormattingEnabled = true;
            this.cbxDBMS.Items.AddRange(new object[] {
            "Not Connected",
            "Access",
            "SQL Server",
            "MySQL",
            "Oracle",
            "Postgre SQL",
            "SQLite"});
            this.cbxDBMS.Location = new System.Drawing.Point(7, 9);
            this.cbxDBMS.Name = "cbxDBMS";
            this.cbxDBMS.Size = new System.Drawing.Size(393, 37);
            this.cbxDBMS.TabIndex = 1;
            this.cbxDBMS.SelectedIndexChanged += new System.EventHandler(this.cbxDBMS_SelectedIndexChanged);
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(7, 52);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(393, 44);
            this.btnCreateTable.TabIndex = 2;
            this.btnCreateTable.Text = "Create employee Table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // pnlAll
            // 
            this.pnlAll.Controls.Add(this.btnReport);
            this.pnlAll.Controls.Add(this.dgvData);
            this.pnlAll.Controls.Add(this.btnSearch);
            this.pnlAll.Controls.Add(this.txtSearch);
            this.pnlAll.Controls.Add(this.label6);
            this.pnlAll.Controls.Add(this.rdoSalary);
            this.pnlAll.Controls.Add(this.rdoCity);
            this.pnlAll.Controls.Add(this.rdoName);
            this.pnlAll.Controls.Add(this.rdoNumber);
            this.pnlAll.Controls.Add(this.label5);
            this.pnlAll.Controls.Add(this.btnFind);
            this.pnlAll.Controls.Add(this.btnEdit);
            this.pnlAll.Controls.Add(this.btnAdd);
            this.pnlAll.Controls.Add(this.btnDelete);
            this.pnlAll.Controls.Add(this.btnNew);
            this.pnlAll.Controls.Add(this.txtSalary);
            this.pnlAll.Controls.Add(this.label4);
            this.pnlAll.Controls.Add(this.txtCity);
            this.pnlAll.Controls.Add(this.label3);
            this.pnlAll.Controls.Add(this.txtName);
            this.pnlAll.Controls.Add(this.label2);
            this.pnlAll.Controls.Add(this.txtNumber);
            this.pnlAll.Controls.Add(this.label1);
            this.pnlAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAll.Location = new System.Drawing.Point(0, 168);
            this.pnlAll.Name = "pnlAll";
            this.pnlAll.Size = new System.Drawing.Size(1359, 595);
            this.pnlAll.TabIndex = 3;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empno,
            this.empname,
            this.empCity,
            this.empAddress});
            this.dgvData.Location = new System.Drawing.Point(619, 165);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(728, 418);
            this.dgvData.TabIndex = 21;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
            // 
            // empno
            // 
            this.empno.DataPropertyName = "empno";
            this.empno.HeaderText = "Number";
            this.empno.MinimumWidth = 6;
            this.empno.Name = "empno";
            this.empno.ReadOnly = true;
            // 
            // empname
            // 
            this.empname.DataPropertyName = "empname";
            this.empname.HeaderText = "Name";
            this.empname.MinimumWidth = 6;
            this.empname.Name = "empname";
            this.empname.ReadOnly = true;
            // 
            // empCity
            // 
            this.empCity.DataPropertyName = "city";
            this.empCity.HeaderText = "City";
            this.empCity.MinimumWidth = 6;
            this.empCity.Name = "empCity";
            this.empCity.ReadOnly = true;
            // 
            // empAddress
            // 
            this.empAddress.DataPropertyName = "salary";
            this.empAddress.HeaderText = "Salary";
            this.empAddress.MinimumWidth = 6;
            this.empAddress.Name = "empAddress";
            this.empAddress.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(1179, 122);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 34);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(772, 122);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(401, 34);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Search Text:";
            // 
            // rdoSalary
            // 
            this.rdoSalary.AutoSize = true;
            this.rdoSalary.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdoSalary.Location = new System.Drawing.Point(1077, 45);
            this.rdoSalary.Name = "rdoSalary";
            this.rdoSalary.Size = new System.Drawing.Size(107, 33);
            this.rdoSalary.TabIndex = 17;
            this.rdoSalary.Text = "Salary";
            this.rdoSalary.UseVisualStyleBackColor = true;
            this.rdoSalary.CheckedChanged += new System.EventHandler(this.rdoSalary_CheckedChanged);
            // 
            // rdoCity
            // 
            this.rdoCity.AutoSize = true;
            this.rdoCity.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdoCity.Location = new System.Drawing.Point(997, 45);
            this.rdoCity.Name = "rdoCity";
            this.rdoCity.Size = new System.Drawing.Size(78, 33);
            this.rdoCity.TabIndex = 16;
            this.rdoCity.Text = "City";
            this.rdoCity.UseVisualStyleBackColor = true;
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Checked = true;
            this.rdoName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdoName.Location = new System.Drawing.Point(892, 45);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(103, 33);
            this.rdoName.TabIndex = 15;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "Name";
            this.rdoName.UseVisualStyleBackColor = true;
            // 
            // rdoNumber
            // 
            this.rdoNumber.AutoSize = true;
            this.rdoNumber.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdoNumber.Location = new System.Drawing.Point(763, 45);
            this.rdoNumber.Name = "rdoNumber";
            this.rdoNumber.Size = new System.Drawing.Size(127, 33);
            this.rdoNumber.TabIndex = 14;
            this.rdoNumber.Text = "Number";
            this.rdoNumber.UseVisualStyleBackColor = true;
            this.rdoNumber.CheckedChanged += new System.EventHandler(this.rdoNumber_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search By:";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.Location = new System.Drawing.Point(441, 245);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(101, 42);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(227, 245);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 42);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(120, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 42);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(334, 245);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 42);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Location = new System.Drawing.Point(13, 245);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 42);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "*New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalary.Location = new System.Drawing.Point(143, 162);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(412, 34);
            this.txtSalary.TabIndex = 7;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "salary:";
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Location = new System.Drawing.Point(143, 122);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(412, 34);
            this.txtCity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "City:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(143, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(412, 34);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.White;
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.Location = new System.Drawing.Point(143, 42);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(412, 34);
            this.txtNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Location = new System.Drawing.Point(13, 304);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(529, 42);
            this.btnReport.TabIndex = 22;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // FrmAllDBMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1359, 763);
            this.Controls.Add(this.pnlAll);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.cbxDBMS);
            this.Controls.Add(this.lblDBMS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmAllDBMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All DBMS";
            this.Load += new System.EventHandler(this.FrmAllDBMS_Load);
            this.pnlAll.ResumeLayout(false);
            this.pnlAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDBMS;
        private System.Windows.Forms.ComboBox cbxDBMS;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Panel pnlAll;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdoSalary;
        private System.Windows.Forms.RadioButton rdoCity;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.RadioButton rdoNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn empname;
        private System.Windows.Forms.DataGridViewTextBoxColumn empCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn empAddress;
        private System.Windows.Forms.Button btnReport;
    }
}


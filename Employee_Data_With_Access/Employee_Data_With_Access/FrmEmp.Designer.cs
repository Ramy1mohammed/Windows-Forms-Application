namespace Employee_Data_With_Access
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
            this.pnlNewEmp = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNmae = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblEmpData = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblSearching = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdoSalary = new System.Windows.Forms.RadioButton();
            this.rdoAddress = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.rdoNumber = new System.Windows.Forms.RadioButton();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.employee_DataDataSet = new Employee_Data_With_Access.Employee_DataDataSet();
            this.bgwork = new System.ComponentModel.BackgroundWorker();
            this.pnlNewEmp.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_DataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNewEmp
            // 
            this.pnlNewEmp.Controls.Add(this.btnFind);
            this.pnlNewEmp.Controls.Add(this.btnReport);
            this.pnlNewEmp.Controls.Add(this.btnDelete);
            this.pnlNewEmp.Controls.Add(this.btnEdit);
            this.pnlNewEmp.Controls.Add(this.btnAdd);
            this.pnlNewEmp.Controls.Add(this.btnNew);
            this.pnlNewEmp.Controls.Add(this.txtSalary);
            this.pnlNewEmp.Controls.Add(this.lblSalary);
            this.pnlNewEmp.Controls.Add(this.txtAddress);
            this.pnlNewEmp.Controls.Add(this.lblAddress);
            this.pnlNewEmp.Controls.Add(this.txtName);
            this.pnlNewEmp.Controls.Add(this.lblNmae);
            this.pnlNewEmp.Controls.Add(this.txtNumber);
            this.pnlNewEmp.Controls.Add(this.lblNumber);
            this.pnlNewEmp.Controls.Add(this.lblEmpData);
            this.pnlNewEmp.Location = new System.Drawing.Point(825, 139);
            this.pnlNewEmp.Name = "pnlNewEmp";
            this.pnlNewEmp.Size = new System.Drawing.Size(692, 510);
            this.pnlNewEmp.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFind.FlatAppearance.BorderSize = 3;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.Location = new System.Drawing.Point(453, 392);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(93, 52);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "اظهار";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReport.FlatAppearance.BorderSize = 3;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Location = new System.Drawing.Point(21, 392);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(93, 52);
            this.btnReport.TabIndex = 13;
            this.btnReport.Text = "تقرير";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(129, 392);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 52);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatAppearance.BorderSize = 3;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(237, 392);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 52);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(345, 392);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 52);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "اضافه";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNew.FlatAppearance.BorderSize = 3;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Location = new System.Drawing.Point(561, 392);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(93, 52);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "جديد*";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(34, 286);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(457, 38);
            this.txtSalary.TabIndex = 8;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(584, 289);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(84, 32);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "المرتب:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(34, 216);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(457, 38);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(525, 222);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(156, 32);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "عنوان الموظف:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(34, 149);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(457, 38);
            this.txtName.TabIndex = 4;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNmae
            // 
            this.lblNmae.AutoSize = true;
            this.lblNmae.Location = new System.Drawing.Point(548, 155);
            this.lblNmae.Name = "lblNmae";
            this.lblNmae.Size = new System.Drawing.Size(133, 32);
            this.lblNmae.TabIndex = 3;
            this.lblNmae.Text = "اسم الموظف:";
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumber.Location = new System.Drawing.Point(34, 75);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(457, 38);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(550, 81);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(131, 32);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "رقم الموظف:";
            // 
            // lblEmpData
            // 
            this.lblEmpData.AutoSize = true;
            this.lblEmpData.BackColor = System.Drawing.Color.Khaki;
            this.lblEmpData.Location = new System.Drawing.Point(240, 11);
            this.lblEmpData.Name = "lblEmpData";
            this.lblEmpData.Size = new System.Drawing.Size(118, 32);
            this.lblEmpData.TabIndex = 0;
            this.lblEmpData.Text = "موظف جديد";
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblHeader.Font = new System.Drawing.Font("Impact", 28F);
            this.lblHeader.Location = new System.Drawing.Point(576, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(377, 82);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "بيانات الموظف";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.dgvSearch);
            this.pnlSearch.Controls.Add(this.lblResult);
            this.pnlSearch.Controls.Add(this.lblSearching);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.rdoSalary);
            this.pnlSearch.Controls.Add(this.rdoAddress);
            this.pnlSearch.Controls.Add(this.rdoName);
            this.pnlSearch.Controls.Add(this.rdoNumber);
            this.pnlSearch.Controls.Add(this.lblSearchBy);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Location = new System.Drawing.Point(12, 139);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(807, 510);
            this.pnlSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.BorderSize = 3;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(131, 132);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 38);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.empname,
            this.address,
            this.salary});
            this.dgvSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSearch.Location = new System.Drawing.Point(0, 254);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowHeadersWidth = 51;
            this.dgvSearch.RowTemplate.Height = 24;
            this.dgvSearch.Size = new System.Drawing.Size(807, 256);
            this.dgvSearch.TabIndex = 21;
            this.dgvSearch.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSearch_RowsAdded);
            this.dgvSearch.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvSearch_RowsRemoved);
            this.dgvSearch.SelectionChanged += new System.EventHandler(this.dgvSearch_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "empno";
            this.Column1.HeaderText = "رقم الموظف";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // empname
            // 
            this.empname.DataPropertyName = "empnam";
            this.empname.HeaderText = "اسم الموظف";
            this.empname.MinimumWidth = 6;
            this.empname.Name = "empname";
            this.empname.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "عنوان الموظف";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "المرتب";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(571, 216);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(217, 32);
            this.lblResult.TabIndex = 20;
            this.lblResult.Text = "نتيجه البحث: 0 موظف";
            // 
            // lblSearching
            // 
            this.lblSearching.AutoSize = true;
            this.lblSearching.Location = new System.Drawing.Point(713, 138);
            this.lblSearching.Name = "lblSearching";
            this.lblSearching.Size = new System.Drawing.Size(75, 32);
            this.lblSearching.TabIndex = 19;
            this.lblSearching.Text = "البحث:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(255, 132);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(399, 38);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // rdoSalary
            // 
            this.rdoSalary.AutoSize = true;
            this.rdoSalary.Location = new System.Drawing.Point(255, 71);
            this.rdoSalary.Name = "rdoSalary";
            this.rdoSalary.Size = new System.Drawing.Size(95, 36);
            this.rdoSalary.TabIndex = 18;
            this.rdoSalary.Text = "المرتب";
            this.rdoSalary.UseVisualStyleBackColor = true;
            this.rdoSalary.CheckedChanged += new System.EventHandler(this.rdoNumber_CheckedChanged);
            // 
            // rdoAddress
            // 
            this.rdoAddress.AutoSize = true;
            this.rdoAddress.Location = new System.Drawing.Point(358, 71);
            this.rdoAddress.Name = "rdoAddress";
            this.rdoAddress.Size = new System.Drawing.Size(97, 36);
            this.rdoAddress.TabIndex = 17;
            this.rdoAddress.Text = "العنوان";
            this.rdoAddress.UseVisualStyleBackColor = true;
            this.rdoAddress.CheckedChanged += new System.EventHandler(this.rdoNumber_CheckedChanged);
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Checked = true;
            this.rdoName.Location = new System.Drawing.Point(472, 71);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(80, 36);
            this.rdoName.TabIndex = 16;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "الاسم";
            this.rdoName.UseVisualStyleBackColor = true;
            this.rdoName.CheckedChanged += new System.EventHandler(this.rdoNumber_CheckedChanged);
            // 
            // rdoNumber
            // 
            this.rdoNumber.AutoSize = true;
            this.rdoNumber.Location = new System.Drawing.Point(559, 71);
            this.rdoNumber.Name = "rdoNumber";
            this.rdoNumber.Size = new System.Drawing.Size(77, 36);
            this.rdoNumber.TabIndex = 15;
            this.rdoNumber.Text = "الرقم";
            this.rdoNumber.UseVisualStyleBackColor = true;
            this.rdoNumber.CheckedChanged += new System.EventHandler(this.rdoNumber_CheckedChanged);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(651, 75);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(137, 32);
            this.lblSearchBy.TabIndex = 14;
            this.lblSearchBy.Text = "بحث بواسطه:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Khaki;
            this.lblSearch.Location = new System.Drawing.Point(295, 11);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(215, 32);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "بحث عن بيانات موظف";
            // 
            // employee_DataDataSet
            // 
            this.employee_DataDataSet.DataSetName = "Employee_DataDataSet";
            this.employee_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bgwork
            // 
            this.bgwork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwork_DoWork);
            // 
            // FrmEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1529, 663);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlNewEmp);
            this.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FrmEmp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشه الموظفين";
            this.Load += new System.EventHandler(this.FrmEmp_Load);
            this.pnlNewEmp.ResumeLayout(false);
            this.pnlNewEmp.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_DataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNewEmp;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNmae;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblEmpData;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblSearching;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdoSalary;
        private System.Windows.Forms.RadioButton rdoAddress;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.RadioButton rdoNumber;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Label lblSearch;
        private Employee_DataDataSet employee_DataDataSet;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empname;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.ComponentModel.BackgroundWorker bgwork;
    }
}


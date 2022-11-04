namespace Employee_Data_With_Access
{
    partial class Form1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.employee_DataDataSet = new Employee_Data_With_Access.Employee_DataDataSet();
            this.employeeDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_DataDataSet1 = new Employee_Data_With_Access.Employee_DataDataSet1();
            this.empBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empTableAdapter = new Employee_Data_With_Access.Employee_DataDataSet1TableAdapters.empTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employee_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_DataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.empBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Employee_Data_With_Access.Employee.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1040, 641);
            this.reportViewer1.TabIndex = 0;
            // 
            // employee_DataDataSet
            // 
            this.employee_DataDataSet.DataSetName = "Employee_DataDataSet";
            this.employee_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDataDataSetBindingSource
            // 
            this.employeeDataDataSetBindingSource.DataSource = this.employee_DataDataSet;
            this.employeeDataDataSetBindingSource.Position = 0;
            // 
            // empBindingSource
            // 
            this.empBindingSource.DataMember = "emp";
            this.empBindingSource.DataSource = this.employee_DataDataSet;
            // 
            // employee_DataDataSet1
            // 
            this.employee_DataDataSet1.DataSetName = "Employee_DataDataSet1";
            this.employee_DataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empBindingSource1
            // 
            this.empBindingSource1.DataMember = "emp";
            this.empBindingSource1.DataSource = this.employee_DataDataSet1;
            // 
            // empTableAdapter
            // 
            this.empTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 641);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_DataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource employeeDataDataSetBindingSource;
        private System.Windows.Forms.BindingSource empBindingSource;
        private Employee_DataDataSet1 employee_DataDataSet1;
        private System.Windows.Forms.BindingSource empBindingSource1;
        public Employee_DataDataSet employee_DataDataSet;
        public Employee_DataDataSet1TableAdapters.empTableAdapter empTableAdapter;
    }
}
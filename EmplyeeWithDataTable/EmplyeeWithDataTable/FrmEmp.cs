using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;


/// <summary>
/// this App is for processing Employee Data 
/// with Dynamic DataTabl xml Files Without DBMS
/// </summary>
namespace EmplyeeWithDataTable
{
    public partial class FrmEmp : Form
    {
        public FrmEmp()
        {
            InitializeComponent();
        }
        /// <summary>
        ///Creating Attributes Like DataTable instance
        ///and local variables for xml files path
        /// </summary>
        DataTable tblEmp = new DataTable("Employee");
        string DataEmpFolder = "data";
        string DataEmpFileSchema = "emp_s.xml";
        string DataEmpFile = "emp.xml";


        /// <summary>
        /// Creating the Schema For DataTable with Columns And Constraints
        /// note that Table Columns will be Created unless there is
        /// no Columns in it else the Table Will Retains it's Columns Schema
        /// </summary>
        private void CreateEmpTable()
        {
            if (tblEmp.Columns.Count < 1)
            {
                tblEmp.Columns.Add("Number", typeof(int));
                tblEmp.Columns.Add("Name");
                tblEmp.Columns.Add("Address");
                tblEmp.Columns.Add("Salary",typeof(int));

                tblEmp.Constraints.Add("Emp_PK", tblEmp.Columns["Number"], true);
            }
        }

        /// <summary>
        /// this Method Check if The Contained Folder for xml files is exists
        /// or not and it Will be Created if didn't exists
        /// </summary>
        private void CreateFolderData()
        {
            if (!Directory.Exists(DataEmpFolder)) Directory.CreateDirectory(DataEmpFolder);
        }


        /// <summary>
        /// this function Check if xml fils within mean path exists or not
        /// i will use this function in reading files so the File will be not read
        /// if this functin return false
        /// </summary>
        /// <returns>retrns true if files exists or return false if not</returns>
        private bool CheckEmpFiles()
        {
            if (File.Exists(DataEmpFolder + "/" + DataEmpFileSchema) && File.Exists(DataEmpFolder + "/" + DataEmpFile))
                return true;
            else
                return false;
        }
        /// <summary>
        /// this procedure used for save or writing the Schema and the Data of
        /// TableData Created
        /// note before writing or saving Data the procedure Check if the folder path
        /// exists or not through CreateFolderData then Create The Table if Not Created
        /// then it Saves Data in Files
        /// Files Here Represented As Database System And Managing through Visual Studio
        /// </summary>
        private void SaveEmpFiles()
        {
            CreateFolderData();
            CreateEmpTable();
            tblEmp.WriteXmlSchema(DataEmpFolder+"/"+DataEmpFileSchema);
            tblEmp.WriteXml(DataEmpFolder + "/" + DataEmpFile);
        }

        /// <summary>
        /// this Reads from The Exisisting xml Files And it first Check if The Files
        /// Exists Or Not And Reading Will Occur under This Condition Only For Avoiding Any Errors
        /// if Files Not Exists
        /// </summary>

        private void ReadEmpFiles()
        {
            if(CheckEmpFiles())
            {
                tblEmp.ReadXmlSchema(DataEmpFolder + "/" + DataEmpFileSchema);
                tblEmp.ReadXml(DataEmpFolder + "/" + DataEmpFile);
            }
        }

        /// <summary>
        /// Here i'm using My Tools Class That i Created it before For helping in more Functionality things
        /// The ClearData Direct Access Function Used For looping TextBoxes for a container Like Passed Panel(pnlData)
        /// and Clear Text From Them After one more mission So i will uses it more
        ///Then i created Auto Numbering According To Number Of Rows in DataTable through Compute function
        ///That Gets Max Of The Primary Key Number Of The First Column and  Added 1 For Result 
        ///the end Result will be added after form loaded int the employeeNumber TextBox When rendering this function
        ///in the form load event
        ///i made add employee button enabled after clear Data That Will be Ready for adding New Employee Data
        ///Edit and Delete Buttons Will be Disabled because there is no Data in TextBoxes For Updating Them Or Delete
        ///i will make Edit And Delete Buttons Enabled in next Parts Of The Application just follow next
        /// </summary>
        private void ClearData()
        {
            Tools.ClearData(pnlData);
            string AutoNum = "";
            if(tblEmp.Rows.Count < 1)
            {
                AutoNum = "1";
            }
            else
            {
                int intAutoNum = Convert.ToInt32(tblEmp.Compute("max(Number)",""))+1;
                AutoNum = intAutoNum + "";
            }
            txtempnum.Text = AutoNum;
            btnadd.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            //after clearing data i focus and select employee name TextBox That Will Be Ready
            //For New DataEntry
            txtempname.Focus();
            txtempname.Select();
        }
        /// <summary>
        /// this Function Used For Validation By Means it Checks if TextBoxes Are empty Or Not Before Clicking Adding Button
        /// And Adding New Employee will Not Happens if There is One TextBox Is Empty And User 
        /// will Be Notified Through Message Box Of My Tools Class By Suitable Message
        /// </summary>
        /// <returns>OK Boolean Varaible Will Be Returned With False Value if There is
        /// One TextBox Is Empty And Will Return True Value if All TextBoxes Are Filled With Suitable Data
        /// </returns>
        private bool CheckTextBox()
        {
            bool OK = true;
            if(txtempnum.Text.Trim()=="")
            {
                Tools.MsgBox("Number Empty! Press New* Button");
                return false;
            }
            else if(txtempname.Text.Trim() == "")
            {
                Tools.MsgBox("Name Empty!");
                txtempname.Focus();
                return false;
            }
            else if (txtaddress.Text.Trim() == "")
            {
                Tools.MsgBox("Address Empty!");
                txtaddress.Focus();
                return false;
            }
            else if (txtSalary.Text.Trim() == "")
            {
                Tools.MsgBox("Salary Empty!");
                txtSalary.Focus();
                return false;
            }

            return OK;
        }


        /// <summary>
        /// this Function Find Row According To The Entered Priamry Key By Mean
        /// Find Method Uses Primary Key Value Entered By User And it Find The Full Row
        /// And it Returns In Data Row instance Then I will Make Useful Changing in this Row Like Editing Or Deleting it And Then Save Data 
        /// The GetNumberOnly Method i Created it Before In My Tools Class This Method Used For Filtering The input String
        /// and Returns Only Integer Values
        /// </summary>
        /// <param name="empNumber">this Value Represnts One Value Of The Primary Key Table</param>
        /// <returns>Returns The Finded Row Of the Enterd Primary Key Value</returns>
        private DataRow FindRow(string empNumber)
        {
            int numwithNumbers = Tools.GetNumberOnly(empNumber);
            DataRow row= tblEmp.Rows.Find(numwithNumbers);
            return row;
        }


        /// <summary>
        /// This Is The Form Loading Procedure And will Be Excuted When Form Load
        /// First I Will Create The Data Folder That it Will Be Containg xml Files When I render SaveEmpFiles Method
        /// then i make Condition That Chack if Files Is Exists Or Not
        /// if Files Exists I will Make Reading Data Functionality else i will Create,Write and Saving Data
        /// then I Will Display My Data After Reading in DataGridView When Form Loading Surely
        /// Last Data Will Be Cleared And Auto Number Will Be Auto Created As i Explained in ClearData Method
        /// </summary>
        /// <param name="sender">Represnts The Sender is FrmEmp</param>
        /// <param name="e">Represents The Event Is Loading Event</param>
        private void FrmEmp_Load(object sender, EventArgs e)
        {
           
            CreateFolderData();
            if(CheckEmpFiles())
            {
                ReadEmpFiles();
            }
            else
            {
                SaveEmpFiles();
            }
            dgvSerarch.DataSource = tblEmp;
            ClearData();
        }


       /// <summary>
       /// this Method For Clearing Data After Any Adding Or Editing...
       /// </summary>
       /// <param name="sender">btnNew</param>
       /// <param name="e">Clicking Event instance</param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        /// <summary>
        /// This Button Add New Emplyee if Only All TextBoxes Are Filled With Data
        /// note That The if Condition is CheckTextBoxes
        /// Data Will Be Added Through Add Function According To The Sorting Of Table Columns
        /// After Adding it's For Normal That i Will Saving And Writing Data Through SaveEmpFiles Procedure
        /// After Filling And Saving Data I Will Clear Data For Reading To Adding New Record       
        /// </summary>
        /// <param name="sender">Sender is btnAdd</param>
        /// <param name="e">Represnts Click Event instance</param>
        private void btnadd_Click(object sender, EventArgs e)
        {
         if(CheckTextBox())
          {
                int intempnum = Convert.ToInt32(txtempnum.Text);
                string strempname = txtempname.Text;
                string straddress = txtaddress.Text;
                int intsalary = Convert.ToInt32(txtSalary.Text);

                tblEmp.Rows.Add(intempnum, strempname, straddress, intsalary);

                SaveEmpFiles();
                ClearData();
          }
        }


        /// <summary>
        /// this Procedure While KeyPress Event FindOut if The Key Pressed Is Number Or Not
        /// if The Number is Pressed From KeyBoard it Will Be Accepted in The Salary TextBox
        /// if onther Key Like Sympols Or Letters They Will Be Not Accepted
        /// Note That the Last Part Of If Condition Accepting BackSpace Character And Floating Point 
        /// Second if Checks if The Salary TextBox Contains Floatin Point Or Not , if it Contains Then it Will Be Not Accepted For Another One
        /// Note it Can be using Unicode Characters For That Mission
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar=='0'|| e.KeyChar == '1'|| e.KeyChar == '2'|| e.KeyChar == '3'|| e.KeyChar == '4'|| e.KeyChar == '5'|| e.KeyChar == '6'|| e.KeyChar == '7'|| e.KeyChar == '8'|| e.KeyChar == '9'||e.KeyChar== ''||e.KeyChar=='.'))
            {
                e.Handled = true;
            }
            if (txtSalary.Text.Contains("."))
            {
                if (e.KeyChar == '.') e.Handled = true;
            }
        }


        /// <summary>
        /// This Procedure Used For Finding The Row According To Primary Key Value
        ///  And Then Displays Row Values in The Suitable TextBoxes 
        ///  First it Uses InputBox Method That I Created In My Tools Class 
        ///  This Method Returns The Value That User Input it in TextBox in it
        ///  and Find Method Uses This Value For Find The Row
        /// </summary>
        /// <param name="sender">btnFind</param>
        /// <param name="e">Click Event instance</param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            string strNum = Tools.InputBox("Enter Employee Number", "Enter Employee Number:");
            DataRow row = FindRow(strNum);
            if(row == null)
            {
                Tools.MsgBox("Number Not Found!");
            }
            else
            {
                txtempnum.Text = row["Number"].ToString();
                txtempname.Text = row["Name"].ToString();
                txtaddress.Text = row["Address"].ToString();
                txtSalary.Text = row["Salary"].ToString();
                btnadd.Enabled = false;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                dgvSerarch.CurrentRow.Selected = false;
            }
        }


        /// <summary>
        /// This Procedure Displays DatagridView Values in The TextBoxes When Any Row selected
        /// Before Doing Displaying Data i Clear Selection From The Current Selected Row Because This Conflict With 
        /// The Same Process That The Prvious Procedure Execution
        /// After Displaying I Made Edit and Delete Buttons Enabled For Displayed Data And i Disable Add Button To Prevent
        /// it From Adding Same Data, Note That The Primary Key Displayed should not be Repeated
        /// </summary>
        /// <param name="sender">dgvSearch Sended</param>
        /// <param name="e">SelectionChanged Event instance</param>
        private void dgvSerarch_SelectionChanged(object sender, EventArgs e)
        {
            dgvSerarch.CurrentRow.Selected = false;
            if (dgvSerarch.CurrentRow!=null)
            {
                txtempnum.Text = dgvSerarch.CurrentRow.Cells[0].Value.ToString();
                txtempname.Text = dgvSerarch.CurrentRow.Cells[1].Value.ToString();
                txtaddress.Text = dgvSerarch.CurrentRow.Cells[2].Value.ToString();
                txtSalary.Text = dgvSerarch.CurrentRow.Cells[3].Value.ToString();
                btnadd.Enabled = false;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
        }


        /// <summary>
        /// this Procedure Edit Row ,First user Find Row Through The Previous Procedure
        /// Then The Name TextBox Will Be Focused From Find Or DgvSearch Procedures
        /// User Can Enter Any Name ,Address And Salary  The Primary Key in Editing Will Be Consistent
        /// Sure Baecause I made The Employee Number TextBox ReadOnly Property On True
        /// After Clicking Editing Button I Renderd SaveEmpFiles Method For Saving The New Editing Data With Same Employee Number As a Primary Key
        /// After Editing And Saving Data Will Be Cleared
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(CheckTextBox())
            {
                DataRow row = FindRow(txtempnum.Text);
                row["Number"] = txtempnum.Text;
                row["Name"] = txtempname.Text;
                row["Address"] = txtaddress.Text;
                row["Salary"] = txtSalary.Text;

                SaveEmpFiles();
                ClearData();
            }
        }
        /// <summary>
        /// This Method Delete Data After Finding The Row Using The FindRow Function Created Before According To The Number Of Employee Displayed
        /// Then I Save Data Without Deleted Row Then Data Will Be Cleared From TextBoxes
        /// </summary>
        /// <param name="sender">btnDelete Button object</param>
        /// <param name="e">Clicking Event instance</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow row = FindRow(txtempnum.Text);
            if(Tools.MsgBoxYesNo("Do You Want To Delete Employee?"))
            {
                row.Delete();
                SaveEmpFiles();
                ClearData();
            }
        }


        /// <summary>
        /// This Procedure Will Search Data And Filter Data According To RadioButton is Checked
        /// </summary>
        /// <param name="sender">btnSearch</param>
        /// <param name="e">Click Event</param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //This Table Will be Filled With New Filtered New Data After Searching
            DataTable tblSearch = new DataTable();
            //filling tblSearch With Same Columns Of The Main Employee Tables
            //Note That The Differ Only In Data Filterd Not in Columns
            foreach(DataColumn col in tblEmp.Columns)
             tblSearch.Columns.Add(col.ColumnName, col.DataType);

            //This Collection Decalration For Rows That Will Be Filled According To 
            //Filtering Data
            DataRow[] rows;

            //if This Condition is True Then Rows Will Be Filled With All Main Table Data Without Filtering Data
            if (txtSearch.Text.Trim() == "") rows = tblEmp.Select();
            //if This Condition is True when Number RadioButton Checked Rows Will Be Filled With Data
            //Filterd By Number Entered
            else if (rdoNumber.Checked)
            {
                //using Of GetNumberOnly Filtering The Text Entered By User
                int num = Tools.GetNumberOnly(txtSearch.Text);
                rows = tblEmp.Select("Number=" + num);
            }
            //if This Condition is True when Name RadioButton Checked Rows Will Be Filled With Data
            //Filterd By Name Matching Entered
            else if (rdoName.Checked)
            {
                rows = tblEmp.Select("Name like'%" + txtSearch.Text + "%'");
            }
            //if This Condition is True when Address RadioButton Checked Rows Will Be Filled With Data
            //Filterd By Address Matcing Entered
            else if (rdoAddress.Checked)
            {
                rows = tblEmp.Select("Address like'%" + txtSearch.Text + "%'");
            }
            //else for Last One(Salary RadioButton and it's Categoried RadioButtons><) Checked Rows Will Be Filled With Data
            //Filterd By Salary Entered 
            else
            {
                //Filtering Text Entered
                int num = Tools.GetNumberOnly(txtSearch.Text);
                //if Less Than RadioButton Checked Rows Will Be Filled With Salaries That Are Less Than
                //Entered Salary
                if (rdoLessThan.Checked)
                {
                    rows = tblEmp.Select("Salary<" + num);
                }
                //if Greater Than RadioButton Checked Rows Will Be Filled With Salaries That Are Greater Than
                //Entered Salary
                else if (rdoGreaterThan.Checked)
                {
                    rows = tblEmp.Select("Salary>" + num);
                }
                //else for Salary As Right Value and Rows Will Be Filled With This Value
                else
                {
                    rows = tblEmp.Select("Salary=" + num);
                }
            }

            //At The End The Filtered Rows Will Be Looped And Will Be Exported To TblSearch
            foreach (DataRow row in rows) tblSearch.ImportRow(row);
            //The DataSource For DataGridView Here Will Be TblSearch Not Main Table
            dgvSerarch.DataSource = tblSearch;
            //At The End Of This Process Data Should Be Cleared From TextBoxes
            ClearData();
        }
        /// <summary>
        /// This Procedure Will Make Less and Greater RadioButtons Visbility(True) Compitable With Only The 
        /// Checking Of Salary RadioButton
        /// Note That All RadioButtons(Number,Name,Address) Will Take The Same Procedure
        /// </summary>
        private void CheckRadioSearch()
        {
            //if (True) >< RadioButtons Will Be Visible
            if (!rdoLessThan.Checked && !rdoGreaterThan.Checked)
            {
                rdoLessThan.Visible = rdoSalary.Checked;
                rdoGreaterThan.Visible = rdoSalary.Checked;
            }
        }
        /// <summary>
        /// As i Explained in The Previous Procedure I Rendered The Previous One For The Visibility Of >< RadioButtons 
        /// Note That All RadioButtons(Number,Name,Address) Will Take The Same Procedure
        /// </summary>
        /// <param name="sender">rdoSalary,rdoNumber,rdoName,rdoAddress</param>
        /// <param name="e">CheckedChanged</param>
        private void rdoSalary_CheckedChanged(object sender, EventArgs e)
        {
            CheckRadioSearch();
        }
        /// <summary>
        /// This Mehod For Find DataGridView Rows Conut
        /// </summary>
        private void RowsCount()
        {
            lblResults.Text = "Results: " + dgvSerarch.Rows.Count + " Row(s) Found";
        }
        /// <summary>
        /// in this Procdure And The Next One When Rows Added Or Deleted From The Grid View The lblResult Label Text
        /// Will Be Displayed With Rows Count
        /// </summary>
        /// <param name="sender">DataGridView dgvSearch object</param>
        /// <param name="e">RowsAdded</param>
        private void dgvSerarch_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RowsCount();
        }
        /// <summary>
        /// Look At Summary xml Documentation For The Previous Procedure
        /// </summary>
        /// <param name="sender">DataGridView dgvSearch object</param>
        /// <param name="e">RowsRemoved</param>
        private void dgvSerarch_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RowsCount();
        }
        /// <summary>
        /// This Procedure For Reportaion The Report Design was Created And it Takes The Source Of Created DataSet
        /// with its Table Fields As a Source Then The Form Is Added For Displaying The Reprot Through Report Viewer Tool
        /// Here I First Create instance For Linking DataSet With Main Local Table(tblEmp) Then , Clear Any DataSource For The Report Viewer As For Button Clicking Clear it
        /// Then I Linked The Data Source For The Rport Viewer with the RportDataSource object
        /// Then I Make Refresh For Displaying The Report
        /// At End It would Be Should For Showing The Container Form
        /// </summary>
        /// <param name="sender">btnReport</param>
        /// <param name="e">Click</param>
        private void btnReport_Click(object sender, EventArgs e)
        {
            frmempreport frm = new frmempreport();
            ReportDataSource rds = new ReportDataSource("DataSet1", tblEmp);
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rds);
            frm.reportViewer1.LocalReport.Refresh();

            frm.ShowDialog();
        }
    }
}

namespace MyFoods
{
    partial class FrmFood
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFoodCode = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImgPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.btnAddImag = new System.Windows.Forms.Button();
            this.txtCatigories = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCatigories = new System.Windows.Forms.Button();
            this.txtComponent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.lbxComponents = new System.Windows.Forms.ListBox();
            this.btnDelSelected = new System.Windows.Forms.Button();
            this.btnDelLast = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSuggest = new System.Windows.Forms.Button();
            this.btnAddSuggest = new System.Windows.Forms.Button();
            this.txtCatSuggest = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.rdoCategory = new System.Windows.Forms.RadioButton();
            this.rdoDesc = new System.Windows.Forms.RadioButton();
            this.rdoComponents = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreateView = new System.Windows.Forms.Button();
            this.btnShowAllInBiGForm = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Firebrick;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.btnBackUp);
            this.pnlHeader.Controls.Add(this.picIcon);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1440, 47);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.DarkRed;
            this.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.picIcon.Location = new System.Drawing.Point(0, 0);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(50, 45);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Pink;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinimize.Location = new System.Drawing.Point(1280, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(70, 45);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "--";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Pink;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(1368, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "كـــــود الأكـــــله:";
            this.label1.Visible = false;
            // 
            // txtFoodCode
            // 
            this.txtFoodCode.BackColor = System.Drawing.Color.Pink;
            this.txtFoodCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoodCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodCode.ForeColor = System.Drawing.Color.DarkRed;
            this.txtFoodCode.Location = new System.Drawing.Point(217, 90);
            this.txtFoodCode.Name = "txtFoodCode";
            this.txtFoodCode.ReadOnly = true;
            this.txtFoodCode.Size = new System.Drawing.Size(495, 38);
            this.txtFoodCode.TabIndex = 2;
            this.txtFoodCode.Visible = false;
            // 
            // txtFoodName
            // 
            this.txtFoodName.BackColor = System.Drawing.Color.Pink;
            this.txtFoodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodName.ForeColor = System.Drawing.Color.DarkRed;
            this.txtFoodName.Location = new System.Drawing.Point(217, 129);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(495, 38);
            this.txtFoodName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Pink;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "اســـــم الأكــــــله:";
            // 
            // txtImgPath
            // 
            this.txtImgPath.BackColor = System.Drawing.Color.Pink;
            this.txtImgPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImgPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImgPath.ForeColor = System.Drawing.Color.DarkRed;
            this.txtImgPath.Location = new System.Drawing.Point(217, 168);
            this.txtImgPath.Name = "txtImgPath";
            this.txtImgPath.ReadOnly = true;
            this.txtImgPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtImgPath.Size = new System.Drawing.Size(345, 26);
            this.txtImgPath.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Pink;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "صوره الأكلـــــه:";
            // 
            // picFood
            // 
            this.picFood.BackColor = System.Drawing.Color.Pink;
            this.picFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFood.Location = new System.Drawing.Point(568, 168);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(144, 82);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFood.TabIndex = 7;
            this.picFood.TabStop = false;
            // 
            // btnAddImag
            // 
            this.btnAddImag.BackColor = System.Drawing.Color.Pink;
            this.btnAddImag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddImag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImag.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAddImag.Location = new System.Drawing.Point(217, 196);
            this.btnAddImag.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddImag.Name = "btnAddImag";
            this.btnAddImag.Size = new System.Drawing.Size(345, 55);
            this.btnAddImag.TabIndex = 3;
            this.btnAddImag.Text = "اضافه صوره";
            this.btnAddImag.UseVisualStyleBackColor = false;
            this.btnAddImag.Click += new System.EventHandler(this.btnAddImag_Click);
            // 
            // txtCatigories
            // 
            this.txtCatigories.BackColor = System.Drawing.Color.Pink;
            this.txtCatigories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatigories.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatigories.ForeColor = System.Drawing.Color.DarkRed;
            this.txtCatigories.Location = new System.Drawing.Point(217, 254);
            this.txtCatigories.Multiline = true;
            this.txtCatigories.Name = "txtCatigories";
            this.txtCatigories.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCatigories.Size = new System.Drawing.Size(401, 48);
            this.txtCatigories.TabIndex = 9;
            this.txtCatigories.WordWrap = false;
            this.txtCatigories.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCatigories_KeyDown);
            this.txtCatigories.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCatigories_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Pink;
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "تصنيــفات الأكـــله:";
            // 
            // btnAddCatigories
            // 
            this.btnAddCatigories.BackColor = System.Drawing.Color.Pink;
            this.btnAddCatigories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCatigories.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCatigories.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAddCatigories.Location = new System.Drawing.Point(617, 254);
            this.btnAddCatigories.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddCatigories.Name = "btnAddCatigories";
            this.btnAddCatigories.Size = new System.Drawing.Size(95, 42);
            this.btnAddCatigories.TabIndex = 10;
            this.btnAddCatigories.Text = "+";
            this.btnAddCatigories.UseVisualStyleBackColor = false;
            this.btnAddCatigories.Click += new System.EventHandler(this.btnAddCatigories_Click);
            // 
            // txtComponent
            // 
            this.txtComponent.BackColor = System.Drawing.Color.Pink;
            this.txtComponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComponent.ForeColor = System.Drawing.Color.DarkRed;
            this.txtComponent.Location = new System.Drawing.Point(217, 300);
            this.txtComponent.Name = "txtComponent";
            this.txtComponent.Size = new System.Drawing.Size(401, 38);
            this.txtComponent.TabIndex = 12;
            this.txtComponent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComponent_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Pink;
            this.label5.Location = new System.Drawing.Point(12, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "المقاديــــــر:";
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.BackColor = System.Drawing.Color.Pink;
            this.btnAddComponent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComponent.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAddComponent.Location = new System.Drawing.Point(617, 298);
            this.btnAddComponent.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(95, 40);
            this.btnAddComponent.TabIndex = 13;
            this.btnAddComponent.Text = "+";
            this.btnAddComponent.UseVisualStyleBackColor = false;
            this.btnAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // lbxComponents
            // 
            this.lbxComponents.BackColor = System.Drawing.Color.Pink;
            this.lbxComponents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxComponents.ForeColor = System.Drawing.Color.DarkRed;
            this.lbxComponents.FormattingEnabled = true;
            this.lbxComponents.ItemHeight = 29;
            this.lbxComponents.Location = new System.Drawing.Point(217, 335);
            this.lbxComponents.Name = "lbxComponents";
            this.lbxComponents.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxComponents.Size = new System.Drawing.Size(495, 89);
            this.lbxComponents.TabIndex = 14;
            // 
            // btnDelSelected
            // 
            this.btnDelSelected.BackColor = System.Drawing.Color.Pink;
            this.btnDelSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelSelected.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDelSelected.Location = new System.Drawing.Point(19, 330);
            this.btnDelSelected.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelSelected.Name = "btnDelSelected";
            this.btnDelSelected.Size = new System.Drawing.Size(191, 30);
            this.btnDelSelected.TabIndex = 15;
            this.btnDelSelected.Text = "حذف المحدد";
            this.btnDelSelected.UseVisualStyleBackColor = false;
            this.btnDelSelected.Click += new System.EventHandler(this.btnDelSelected_Click);
            // 
            // btnDelLast
            // 
            this.btnDelLast.BackColor = System.Drawing.Color.Pink;
            this.btnDelLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelLast.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDelLast.Location = new System.Drawing.Point(19, 362);
            this.btnDelLast.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelLast.Name = "btnDelLast";
            this.btnDelLast.Size = new System.Drawing.Size(191, 31);
            this.btnDelLast.TabIndex = 16;
            this.btnDelLast.Text = "حذف اخر عنصر";
            this.btnDelLast.UseVisualStyleBackColor = false;
            this.btnDelLast.Click += new System.EventHandler(this.btnDelLast_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.BackColor = System.Drawing.Color.Pink;
            this.btnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAll.ForeColor = System.Drawing.Color.Red;
            this.btnDelAll.Location = new System.Drawing.Point(19, 395);
            this.btnDelAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(191, 29);
            this.btnDelAll.TabIndex = 17;
            this.btnDelAll.Text = "حذف الكــل";
            this.btnDelAll.UseVisualStyleBackColor = false;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Pink;
            this.label6.Location = new System.Drawing.Point(748, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 46);
            this.label6.TabIndex = 18;
            this.label6.Text = "أكلاتى";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.Pink;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.Color.DarkRed;
            this.txtDesc.Location = new System.Drawing.Point(217, 427);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(495, 90);
            this.txtDesc.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Pink;
            this.label7.Location = new System.Drawing.Point(12, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "طريـــقه التحضيــر:";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Pink;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.DarkRed;
            this.btnNew.Location = new System.Drawing.Point(16, 571);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(138, 51);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "*جديــــد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Pink;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAdd.Location = new System.Drawing.Point(164, 571);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 51);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "اضافـــه";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.EnabledChanged += new System.EventHandler(this.btnAdd_EnabledChanged);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Pink;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEdit.Location = new System.Drawing.Point(312, 571);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(138, 51);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "تعديـــل";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.EnabledChanged += new System.EventHandler(this.btnAdd_EnabledChanged);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Pink;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(460, 571);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 51);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.EnabledChanged += new System.EventHandler(this.btnAdd_EnabledChanged);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Pink;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.DarkRed;
            this.btnReport.Location = new System.Drawing.Point(608, 571);
            this.btnReport.Margin = new System.Windows.Forms.Padding(5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(138, 51);
            this.btnReport.TabIndex = 25;
            this.btnReport.Text = "تقريـــر";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Pink;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(756, 571);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 51);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "خـــروج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSuggest
            // 
            this.btnSuggest.BackColor = System.Drawing.Color.Pink;
            this.btnSuggest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuggest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuggest.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSuggest.Location = new System.Drawing.Point(904, 581);
            this.btnSuggest.Margin = new System.Windows.Forms.Padding(5);
            this.btnSuggest.Name = "btnSuggest";
            this.btnSuggest.Size = new System.Drawing.Size(525, 40);
            this.btnSuggest.TabIndex = 27;
            this.btnSuggest.Text = "اقتراح أكلــه";
            this.btnSuggest.UseVisualStyleBackColor = false;
            this.btnSuggest.Click += new System.EventHandler(this.btnSuggest_Click);
            // 
            // btnAddSuggest
            // 
            this.btnAddSuggest.BackColor = System.Drawing.Color.Pink;
            this.btnAddSuggest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSuggest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSuggest.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAddSuggest.Location = new System.Drawing.Point(1363, 525);
            this.btnAddSuggest.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddSuggest.Name = "btnAddSuggest";
            this.btnAddSuggest.Size = new System.Drawing.Size(65, 46);
            this.btnAddSuggest.TabIndex = 29;
            this.btnAddSuggest.Text = "+";
            this.btnAddSuggest.UseVisualStyleBackColor = false;
            this.btnAddSuggest.Click += new System.EventHandler(this.btnAddSuggest_Click);
            // 
            // txtCatSuggest
            // 
            this.txtCatSuggest.BackColor = System.Drawing.Color.Pink;
            this.txtCatSuggest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatSuggest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatSuggest.ForeColor = System.Drawing.Color.DarkRed;
            this.txtCatSuggest.Location = new System.Drawing.Point(904, 528);
            this.txtCatSuggest.Multiline = true;
            this.txtCatSuggest.Name = "txtCatSuggest";
            this.txtCatSuggest.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCatSuggest.Size = new System.Drawing.Size(460, 45);
            this.txtCatSuggest.TabIndex = 28;
            this.txtCatSuggest.WordWrap = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Yellow;
            this.lblMessage.Location = new System.Drawing.Point(22, 531);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(48, 31);
            this.lblMessage.TabIndex = 30;
            this.lblMessage.Text = ">>";
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Checked = true;
            this.rdoName.ForeColor = System.Drawing.Color.Yellow;
            this.rdoName.Location = new System.Drawing.Point(724, 134);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(89, 33);
            this.rdoName.TabIndex = 31;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "الاســم";
            this.rdoName.UseVisualStyleBackColor = true;
            // 
            // rdoCategory
            // 
            this.rdoCategory.AutoSize = true;
            this.rdoCategory.ForeColor = System.Drawing.Color.Yellow;
            this.rdoCategory.Location = new System.Drawing.Point(819, 134);
            this.rdoCategory.Name = "rdoCategory";
            this.rdoCategory.Size = new System.Drawing.Size(108, 33);
            this.rdoCategory.TabIndex = 32;
            this.rdoCategory.TabStop = true;
            this.rdoCategory.Text = "التصنيف";
            this.rdoCategory.UseVisualStyleBackColor = true;
            // 
            // rdoDesc
            // 
            this.rdoDesc.AutoSize = true;
            this.rdoDesc.ForeColor = System.Drawing.Color.Yellow;
            this.rdoDesc.Location = new System.Drawing.Point(1022, 134);
            this.rdoDesc.Name = "rdoDesc";
            this.rdoDesc.Size = new System.Drawing.Size(108, 33);
            this.rdoDesc.TabIndex = 34;
            this.rdoDesc.TabStop = true;
            this.rdoDesc.Text = "التحضير";
            this.rdoDesc.UseVisualStyleBackColor = true;
            // 
            // rdoComponents
            // 
            this.rdoComponents.AutoSize = true;
            this.rdoComponents.ForeColor = System.Drawing.Color.Yellow;
            this.rdoComponents.Location = new System.Drawing.Point(927, 134);
            this.rdoComponents.Name = "rdoComponents";
            this.rdoComponents.Size = new System.Drawing.Size(99, 33);
            this.rdoComponents.TabIndex = 33;
            this.rdoComponents.TabStop = true;
            this.rdoComponents.Text = "المقادير";
            this.rdoComponents.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Pink;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkRed;
            this.txtSearch.Location = new System.Drawing.Point(1136, 139);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(292, 34);
            this.txtSearch.TabIndex = 35;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFood.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFood.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFood.Location = new System.Drawing.Point(724, 221);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.RowTemplate.Height = 24;
            this.dgvFood.Size = new System.Drawing.Size(704, 296);
            this.dgvFood.TabIndex = 36;
            this.dgvFood.SelectionChanged += new System.EventHandler(this.dgvFood_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FoodName";
            this.Column1.FillWeight = 111.631F;
            this.Column1.HeaderText = "الأكــله";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FoodImage";
            this.Column2.FillWeight = 111.631F;
            this.Column2.HeaderText = "الصوره";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Category";
            this.Column3.FillWeight = 53.47594F;
            this.Column3.HeaderText = "التصنيفات";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 128;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Components";
            this.Column4.FillWeight = 111.631F;
            this.Column4.HeaderText = "المقاديــر";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Desc";
            this.Column5.FillWeight = 111.631F;
            this.Column5.HeaderText = "التحضيـــر";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "FoodCode";
            this.Column6.HeaderText = "كود الأكله";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // btnCreateView
            // 
            this.btnCreateView.Location = new System.Drawing.Point(1136, 67);
            this.btnCreateView.Name = "btnCreateView";
            this.btnCreateView.Size = new System.Drawing.Size(268, 46);
            this.btnCreateView.TabIndex = 37;
            this.btnCreateView.Text = "Create View";
            this.btnCreateView.UseVisualStyleBackColor = true;
            this.btnCreateView.Visible = false;
            this.btnCreateView.Click += new System.EventHandler(this.btnCreateView_Click);
            // 
            // btnShowAllInBiGForm
            // 
            this.btnShowAllInBiGForm.BackColor = System.Drawing.Color.Pink;
            this.btnShowAllInBiGForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAllInBiGForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllInBiGForm.ForeColor = System.Drawing.Color.DarkRed;
            this.btnShowAllInBiGForm.Location = new System.Drawing.Point(724, 181);
            this.btnShowAllInBiGForm.Margin = new System.Windows.Forms.Padding(5);
            this.btnShowAllInBiGForm.Name = "btnShowAllInBiGForm";
            this.btnShowAllInBiGForm.Size = new System.Drawing.Size(221, 40);
            this.btnShowAllInBiGForm.TabIndex = 38;
            this.btnShowAllInBiGForm.Text = "عرض الكل فى شاشه كبيره";
            this.btnShowAllInBiGForm.UseVisualStyleBackColor = false;
            this.btnShowAllInBiGForm.Click += new System.EventHandler(this.btnShowAllInBiGForm_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Pink;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.DarkRed;
            this.btnShowAll.Location = new System.Drawing.Point(950, 181);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(103, 40);
            this.btnShowAll.TabIndex = 39;
            this.btnShowAll.Text = "عرض الكل";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Yellow;
            this.lblCount.Location = new System.Drawing.Point(1061, 183);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(23, 31);
            this.lblCount.TabIndex = 40;
            this.lblCount.Text = ".";
            // 
            // btnBackUp
            // 
            this.btnBackUp.BackColor = System.Drawing.Color.LightGreen;
            this.btnBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBackUp.Location = new System.Drawing.Point(976, -1);
            this.btnBackUp.Margin = new System.Windows.Forms.Padding(5);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(218, 40);
            this.btnBackUp.TabIndex = 41;
            this.btnBackUp.Text = "النسخ الاحتياطى";
            this.btnBackUp.UseVisualStyleBackColor = false;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // FrmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1440, 630);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnShowAllInBiGForm);
            this.Controls.Add(this.btnCreateView);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rdoDesc);
            this.Controls.Add(this.rdoComponents);
            this.Controls.Add(this.rdoCategory);
            this.Controls.Add(this.rdoName);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnAddSuggest);
            this.Controls.Add(this.txtCatSuggest);
            this.Controls.Add(this.btnSuggest);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnDelLast);
            this.Controls.Add(this.btnDelSelected);
            this.Controls.Add(this.lbxComponents);
            this.Controls.Add(this.btnAddComponent);
            this.Controls.Add(this.txtComponent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddCatigories);
            this.Controls.Add(this.txtCatigories);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddImag);
            this.Controls.Add(this.picFood);
            this.Controls.Add(this.txtImgPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFoodCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmFood";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFood_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFoodCode;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImgPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picFood;
        private System.Windows.Forms.Button btnAddImag;
        private System.Windows.Forms.TextBox txtCatigories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddCatigories;
        private System.Windows.Forms.TextBox txtComponent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.ListBox lbxComponents;
        private System.Windows.Forms.Button btnDelSelected;
        private System.Windows.Forms.Button btnDelLast;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSuggest;
        private System.Windows.Forms.Button btnAddSuggest;
        private System.Windows.Forms.TextBox txtCatSuggest;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.RadioButton rdoCategory;
        private System.Windows.Forms.RadioButton rdoDesc;
        private System.Windows.Forms.RadioButton rdoComponents;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Button btnCreateView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnShowAllInBiGForm;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnBackUp;
    }
}


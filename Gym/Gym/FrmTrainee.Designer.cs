namespace Gym
{
    partial class FrmTrainee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTrCode = new System.Windows.Forms.TextBox();
            this.lblTrCode = new System.Windows.Forms.Label();
            this.lblTrName = new System.Windows.Forms.Label();
            this.lblTrSsn = new System.Windows.Forms.Label();
            this.lblTrPhone = new System.Windows.Forms.Label();
            this.lbxTrPhones = new System.Windows.Forms.ListBox();
            this.dtpTrBirth = new System.Windows.Forms.DateTimePicker();
            this.txtTrAddress = new System.Windows.Forms.TextBox();
            this.lblTrBirth = new System.Windows.Forms.Label();
            this.lblTrAddress = new System.Windows.Forms.Label();
            this.lblTrCoachName = new System.Windows.Forms.Label();
            this.cbxTrCoachName = new System.Windows.Forms.ComboBox();
            this.lblSubsType = new System.Windows.Forms.Label();
            this.cbxSubsType = new System.Windows.Forms.ComboBox();
            this.lblSubsStart = new System.Windows.Forms.Label();
            this.dtpSubsStart = new System.Windows.Forms.DateTimePicker();
            this.dtpSubsEnd = new System.Windows.Forms.DateTimePicker();
            this.lblSubsEnd = new System.Windows.Forms.Label();
            this.txtTrName = new System.Windows.Forms.TextBox();
            this.txtTrSsn = new System.Windows.Forms.TextBox();
            this.txtTrPhone = new System.Windows.Forms.TextBox();
            this.pnlTrainee = new System.Windows.Forms.Panel();
            this.lblSubsPrice = new System.Windows.Forms.Label();
            this.txtSubsPrice = new System.Windows.Forms.TextBox();
            this.cbxExerciseType = new System.Windows.Forms.ComboBox();
            this.lblExerciseType = new System.Windows.Forms.Label();
            this.rdoTrSubsType = new System.Windows.Forms.RadioButton();
            this.txtTrSearch = new System.Windows.Forms.TextBox();
            this.rdoTrCoach = new System.Windows.Forms.RadioButton();
            this.rdoTrSsn = new System.Windows.Forms.RadioButton();
            this.lblTrSearch = new System.Windows.Forms.Label();
            this.rdoTrName = new System.Windows.Forms.RadioButton();
            this.rdoTrCode = new System.Windows.Forms.RadioButton();
            this.lblMsg = new System.Windows.Forms.Label();
            this.dgvShowTrainee = new System.Windows.Forms.DataGridView();
            this.coltrno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrssn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltraddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrbdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrimage = new System.Windows.Forms.DataGridViewImageColumn();
            this.coltrcoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrsubtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrstartsub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrendsub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colexercisetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epTrainee = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnShowAllTrainee = new SansationRoundButton();
            this.PicTrainee = new Gym.MyPictureBox();
            this.btnReportEmp = new SansationRoundButton();
            this.btnDeleteEmp = new SansationRoundButton();
            this.btnEditEmp = new SansationRoundButton();
            this.btnAddEmp = new SansationRoundButton();
            this.btnNewEmp = new SansationRoundButton();
            this.btnSubsDetails = new SansationRoundButton();
            this.btnAddTrPhone = new SansationRoundButton();
            this.btnDelSelectedlbxPhoneItem = new SansationRoundButton();
            this.btnDelLastlbxPhoneItem = new SansationRoundButton();
            this.btnDelAlllbxPhone = new SansationRoundButton();
            this.btnAddTrPic = new SansationRoundButton();
            this.pnlTrainee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTrainee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTrainee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTrainee)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTrCode
            // 
            this.txtTrCode.BackColor = System.Drawing.Color.Pink;
            this.txtTrCode.Location = new System.Drawing.Point(780, 9);
            this.txtTrCode.Name = "txtTrCode";
            this.txtTrCode.ReadOnly = true;
            this.txtTrCode.Size = new System.Drawing.Size(429, 34);
            this.txtTrCode.TabIndex = 3;
            this.txtTrCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTrCode
            // 
            this.lblTrCode.AutoSize = true;
            this.lblTrCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrCode.ForeColor = System.Drawing.Color.Yellow;
            this.lblTrCode.Location = new System.Drawing.Point(1274, 8);
            this.lblTrCode.Name = "lblTrCode";
            this.lblTrCode.Size = new System.Drawing.Size(128, 29);
            this.lblTrCode.TabIndex = 2;
            this.lblTrCode.Text = "كود المشترك:";
            // 
            // lblTrName
            // 
            this.lblTrName.AutoSize = true;
            this.lblTrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrName.ForeColor = System.Drawing.Color.Yellow;
            this.lblTrName.Location = new System.Drawing.Point(1275, 48);
            this.lblTrName.Name = "lblTrName";
            this.lblTrName.Size = new System.Drawing.Size(127, 29);
            this.lblTrName.TabIndex = 5;
            this.lblTrName.Text = "اسم المشترك:";
            // 
            // lblTrSsn
            // 
            this.lblTrSsn.AutoSize = true;
            this.lblTrSsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrSsn.ForeColor = System.Drawing.Color.Yellow;
            this.lblTrSsn.Location = new System.Drawing.Point(1232, 88);
            this.lblTrSsn.Name = "lblTrSsn";
            this.lblTrSsn.Size = new System.Drawing.Size(176, 29);
            this.lblTrSsn.TabIndex = 7;
            this.lblTrSsn.Text = "بطاقه الرقم القومى:";
            // 
            // lblTrPhone
            // 
            this.lblTrPhone.AutoSize = true;
            this.lblTrPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrPhone.ForeColor = System.Drawing.Color.Yellow;
            this.lblTrPhone.Location = new System.Drawing.Point(1258, 128);
            this.lblTrPhone.Name = "lblTrPhone";
            this.lblTrPhone.Size = new System.Drawing.Size(144, 29);
            this.lblTrPhone.TabIndex = 9;
            this.lblTrPhone.Text = "هاتف المشترك:";
            // 
            // lbxTrPhones
            // 
            this.lbxTrPhones.BackColor = System.Drawing.Color.Pink;
            this.lbxTrPhones.FormattingEnabled = true;
            this.lbxTrPhones.ItemHeight = 29;
            this.lbxTrPhones.Location = new System.Drawing.Point(779, 169);
            this.lbxTrPhones.Name = "lbxTrPhones";
            this.lbxTrPhones.ScrollAlwaysVisible = true;
            this.lbxTrPhones.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxTrPhones.Size = new System.Drawing.Size(430, 120);
            this.lbxTrPhones.TabIndex = 40;
            // 
            // dtpTrBirth
            // 
            this.dtpTrBirth.CalendarFont = new System.Drawing.Font("Impact", 14F);
            this.dtpTrBirth.CalendarMonthBackground = System.Drawing.Color.Pink;
            this.dtpTrBirth.CustomFormat = "yyyy/MM/dd";
            this.dtpTrBirth.Font = new System.Drawing.Font("Impact", 14F);
            this.dtpTrBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTrBirth.Location = new System.Drawing.Point(174, 50);
            this.dtpTrBirth.Name = "dtpTrBirth";
            this.dtpTrBirth.RightToLeftLayout = true;
            this.dtpTrBirth.Size = new System.Drawing.Size(273, 36);
            this.dtpTrBirth.TabIndex = 47;
            this.dtpTrBirth.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            // 
            // txtTrAddress
            // 
            this.txtTrAddress.BackColor = System.Drawing.Color.Pink;
            this.txtTrAddress.Location = new System.Drawing.Point(174, 10);
            this.txtTrAddress.Name = "txtTrAddress";
            this.txtTrAddress.Size = new System.Drawing.Size(273, 34);
            this.txtTrAddress.TabIndex = 45;
            this.txtTrAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrAddress_KeyPress);
            // 
            // lblTrBirth
            // 
            this.lblTrBirth.AutoSize = true;
            this.lblTrBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrBirth.ForeColor = System.Drawing.Color.Yellow;
            this.lblTrBirth.Location = new System.Drawing.Point(521, 54);
            this.lblTrBirth.Name = "lblTrBirth";
            this.lblTrBirth.Size = new System.Drawing.Size(128, 29);
            this.lblTrBirth.TabIndex = 46;
            this.lblTrBirth.Text = "تاريخ الميلاد:";
            // 
            // lblTrAddress
            // 
            this.lblTrAddress.AutoSize = true;
            this.lblTrAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrAddress.ForeColor = System.Drawing.Color.Yellow;
            this.lblTrAddress.Location = new System.Drawing.Point(521, 12);
            this.lblTrAddress.Name = "lblTrAddress";
            this.lblTrAddress.Size = new System.Drawing.Size(128, 29);
            this.lblTrAddress.TabIndex = 44;
            this.lblTrAddress.Text = "العنــــــــوان:";
            // 
            // lblTrCoachName
            // 
            this.lblTrCoachName.AutoSize = true;
            this.lblTrCoachName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrCoachName.ForeColor = System.Drawing.Color.Yellow;
            this.lblTrCoachName.Location = new System.Drawing.Point(468, 95);
            this.lblTrCoachName.Name = "lblTrCoachName";
            this.lblTrCoachName.Size = new System.Drawing.Size(185, 29);
            this.lblTrCoachName.TabIndex = 50;
            this.lblTrCoachName.Text = "اسم المدرب الخاص:";
            // 
            // cbxTrCoachName
            // 
            this.cbxTrCoachName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTrCoachName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTrCoachName.BackColor = System.Drawing.Color.Pink;
            this.cbxTrCoachName.FormattingEnabled = true;
            this.cbxTrCoachName.Location = new System.Drawing.Point(174, 92);
            this.cbxTrCoachName.Name = "cbxTrCoachName";
            this.cbxTrCoachName.Size = new System.Drawing.Size(273, 37);
            this.cbxTrCoachName.TabIndex = 51;
            this.cbxTrCoachName.SelectionChangeCommitted += new System.EventHandler(this.cbxTrCoachName_SelectionChangeCommitted);
            this.cbxTrCoachName.Click += new System.EventHandler(this.cbxTrCoachName_Click);
            this.cbxTrCoachName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxTrCoachName_KeyDown);
            this.cbxTrCoachName.Validating += new System.ComponentModel.CancelEventHandler(this.cbxTrCoachName_Validating);
            // 
            // lblSubsType
            // 
            this.lblSubsType.AutoSize = true;
            this.lblSubsType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubsType.ForeColor = System.Drawing.Color.Yellow;
            this.lblSubsType.Location = new System.Drawing.Point(515, 137);
            this.lblSubsType.Name = "lblSubsType";
            this.lblSubsType.Size = new System.Drawing.Size(134, 29);
            this.lblSubsType.TabIndex = 52;
            this.lblSubsType.Text = "نوع الاشتراك:";
            // 
            // cbxSubsType
            // 
            this.cbxSubsType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSubsType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSubsType.BackColor = System.Drawing.Color.Pink;
            this.cbxSubsType.FormattingEnabled = true;
            this.cbxSubsType.Items.AddRange(new object[] {
            "اسبوعى",
            "شهرى",
            "ثلاث شهور",
            "ست شهور",
            "سنوى"});
            this.cbxSubsType.Location = new System.Drawing.Point(174, 135);
            this.cbxSubsType.Name = "cbxSubsType";
            this.cbxSubsType.Size = new System.Drawing.Size(273, 37);
            this.cbxSubsType.TabIndex = 53;
            this.cbxSubsType.SelectedIndexChanged += new System.EventHandler(this.cbxSubsType_SelectedIndexChanged);
            this.cbxSubsType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxSubsType_KeyPress);
            // 
            // lblSubsStart
            // 
            this.lblSubsStart.AutoSize = true;
            this.lblSubsStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubsStart.ForeColor = System.Drawing.Color.Yellow;
            this.lblSubsStart.Location = new System.Drawing.Point(508, 180);
            this.lblSubsStart.Name = "lblSubsStart";
            this.lblSubsStart.Size = new System.Drawing.Size(141, 29);
            this.lblSubsStart.TabIndex = 54;
            this.lblSubsStart.Text = "بدايه الاشتراك:";
            // 
            // dtpSubsStart
            // 
            this.dtpSubsStart.CalendarFont = new System.Drawing.Font("Impact", 14F);
            this.dtpSubsStart.CalendarMonthBackground = System.Drawing.Color.Pink;
            this.dtpSubsStart.CustomFormat = "yyyy/MM/dd";
            this.dtpSubsStart.Font = new System.Drawing.Font("Impact", 14F);
            this.dtpSubsStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSubsStart.Location = new System.Drawing.Point(174, 178);
            this.dtpSubsStart.Name = "dtpSubsStart";
            this.dtpSubsStart.RightToLeftLayout = true;
            this.dtpSubsStart.Size = new System.Drawing.Size(273, 36);
            this.dtpSubsStart.TabIndex = 55;
            this.dtpSubsStart.Value = new System.DateTime(2022, 11, 24, 0, 0, 0, 0);
            this.dtpSubsStart.ValueChanged += new System.EventHandler(this.dtpSubsStart_ValueChanged);
            // 
            // dtpSubsEnd
            // 
            this.dtpSubsEnd.CalendarFont = new System.Drawing.Font("Impact", 14F);
            this.dtpSubsEnd.CalendarMonthBackground = System.Drawing.Color.Pink;
            this.dtpSubsEnd.CustomFormat = "yyyy/MM/dd";
            this.dtpSubsEnd.Enabled = false;
            this.dtpSubsEnd.Font = new System.Drawing.Font("Impact", 14F);
            this.dtpSubsEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSubsEnd.Location = new System.Drawing.Point(174, 220);
            this.dtpSubsEnd.Name = "dtpSubsEnd";
            this.dtpSubsEnd.RightToLeftLayout = true;
            this.dtpSubsEnd.Size = new System.Drawing.Size(273, 36);
            this.dtpSubsEnd.TabIndex = 57;
            this.dtpSubsEnd.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            // 
            // lblSubsEnd
            // 
            this.lblSubsEnd.AutoSize = true;
            this.lblSubsEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubsEnd.ForeColor = System.Drawing.Color.Yellow;
            this.lblSubsEnd.Location = new System.Drawing.Point(506, 222);
            this.lblSubsEnd.Name = "lblSubsEnd";
            this.lblSubsEnd.Size = new System.Drawing.Size(143, 29);
            this.lblSubsEnd.TabIndex = 56;
            this.lblSubsEnd.Text = "نهايه الاشتراك:";
            // 
            // txtTrName
            // 
            this.txtTrName.BackColor = System.Drawing.Color.Pink;
            this.txtTrName.Location = new System.Drawing.Point(780, 49);
            this.txtTrName.Name = "txtTrName";
            this.txtTrName.Size = new System.Drawing.Size(429, 34);
            this.txtTrName.TabIndex = 60;
            this.txtTrName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrName_KeyPress);
            // 
            // txtTrSsn
            // 
            this.txtTrSsn.BackColor = System.Drawing.Color.Pink;
            this.txtTrSsn.Location = new System.Drawing.Point(780, 89);
            this.txtTrSsn.Name = "txtTrSsn";
            this.txtTrSsn.Size = new System.Drawing.Size(429, 34);
            this.txtTrSsn.TabIndex = 61;
            this.txtTrSsn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrSsn_KeyPress);
            // 
            // txtTrPhone
            // 
            this.txtTrPhone.BackColor = System.Drawing.Color.Pink;
            this.txtTrPhone.Location = new System.Drawing.Point(845, 129);
            this.txtTrPhone.Name = "txtTrPhone";
            this.txtTrPhone.Size = new System.Drawing.Size(364, 34);
            this.txtTrPhone.TabIndex = 62;
            this.txtTrPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTrPhone_KeyDown);
            this.txtTrPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrSsn_KeyPress);
            // 
            // pnlTrainee
            // 
            this.pnlTrainee.Controls.Add(this.lblSubsPrice);
            this.pnlTrainee.Controls.Add(this.txtSubsPrice);
            this.pnlTrainee.Controls.Add(this.cbxExerciseType);
            this.pnlTrainee.Controls.Add(this.lblExerciseType);
            this.pnlTrainee.Controls.Add(this.btnShowAllTrainee);
            this.pnlTrainee.Controls.Add(this.rdoTrSubsType);
            this.pnlTrainee.Controls.Add(this.txtTrSearch);
            this.pnlTrainee.Controls.Add(this.rdoTrCoach);
            this.pnlTrainee.Controls.Add(this.rdoTrSsn);
            this.pnlTrainee.Controls.Add(this.lblTrSearch);
            this.pnlTrainee.Controls.Add(this.rdoTrName);
            this.pnlTrainee.Controls.Add(this.rdoTrCode);
            this.pnlTrainee.Controls.Add(this.lblMsg);
            this.pnlTrainee.Controls.Add(this.PicTrainee);
            this.pnlTrainee.Controls.Add(this.btnReportEmp);
            this.pnlTrainee.Controls.Add(this.btnDeleteEmp);
            this.pnlTrainee.Controls.Add(this.btnEditEmp);
            this.pnlTrainee.Controls.Add(this.btnAddEmp);
            this.pnlTrainee.Controls.Add(this.btnNewEmp);
            this.pnlTrainee.Controls.Add(this.dgvShowTrainee);
            this.pnlTrainee.Controls.Add(this.cbxTrCoachName);
            this.pnlTrainee.Controls.Add(this.txtTrPhone);
            this.pnlTrainee.Controls.Add(this.lblTrCode);
            this.pnlTrainee.Controls.Add(this.txtTrSsn);
            this.pnlTrainee.Controls.Add(this.txtTrCode);
            this.pnlTrainee.Controls.Add(this.txtTrName);
            this.pnlTrainee.Controls.Add(this.lblTrName);
            this.pnlTrainee.Controls.Add(this.lblTrSsn);
            this.pnlTrainee.Controls.Add(this.btnSubsDetails);
            this.pnlTrainee.Controls.Add(this.lblTrPhone);
            this.pnlTrainee.Controls.Add(this.dtpSubsEnd);
            this.pnlTrainee.Controls.Add(this.btnAddTrPhone);
            this.pnlTrainee.Controls.Add(this.lblSubsEnd);
            this.pnlTrainee.Controls.Add(this.lbxTrPhones);
            this.pnlTrainee.Controls.Add(this.dtpSubsStart);
            this.pnlTrainee.Controls.Add(this.btnDelSelectedlbxPhoneItem);
            this.pnlTrainee.Controls.Add(this.lblSubsStart);
            this.pnlTrainee.Controls.Add(this.btnDelLastlbxPhoneItem);
            this.pnlTrainee.Controls.Add(this.cbxSubsType);
            this.pnlTrainee.Controls.Add(this.btnDelAlllbxPhone);
            this.pnlTrainee.Controls.Add(this.lblSubsType);
            this.pnlTrainee.Controls.Add(this.lblTrAddress);
            this.pnlTrainee.Controls.Add(this.lblTrBirth);
            this.pnlTrainee.Controls.Add(this.lblTrCoachName);
            this.pnlTrainee.Controls.Add(this.txtTrAddress);
            this.pnlTrainee.Controls.Add(this.btnAddTrPic);
            this.pnlTrainee.Controls.Add(this.dtpTrBirth);
            this.pnlTrainee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrainee.Location = new System.Drawing.Point(0, 0);
            this.pnlTrainee.Name = "pnlTrainee";
            this.pnlTrainee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlTrainee.Size = new System.Drawing.Size(1444, 711);
            this.pnlTrainee.TabIndex = 63;
            // 
            // lblSubsPrice
            // 
            this.lblSubsPrice.AutoSize = true;
            this.lblSubsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubsPrice.ForeColor = System.Drawing.Color.Yellow;
            this.lblSubsPrice.Location = new System.Drawing.Point(28, 261);
            this.lblSubsPrice.Name = "lblSubsPrice";
            this.lblSubsPrice.Size = new System.Drawing.Size(132, 29);
            this.lblSubsPrice.TabIndex = 82;
            this.lblSubsPrice.Text = "سعر الاشتراك";
            // 
            // txtSubsPrice
            // 
            this.txtSubsPrice.BackColor = System.Drawing.Color.DarkRed;
            this.txtSubsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubsPrice.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSubsPrice.Location = new System.Drawing.Point(27, 297);
            this.txtSubsPrice.Name = "txtSubsPrice";
            this.txtSubsPrice.ReadOnly = true;
            this.txtSubsPrice.Size = new System.Drawing.Size(130, 38);
            this.txtSubsPrice.TabIndex = 81;
            this.txtSubsPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxExerciseType
            // 
            this.cbxExerciseType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxExerciseType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxExerciseType.BackColor = System.Drawing.Color.Pink;
            this.cbxExerciseType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxExerciseType.FormattingEnabled = true;
            this.cbxExerciseType.Items.AddRange(new object[] {
            "تمرين كمال أجسام",
            "تمرين Boxing",
            "تمرين مساج",
            "تمرين لياقه بدنيه وتأهيل بدنى",
            "تمرين أيروبكس",
            "تمرين زومبا",
            "تمارين رياضات أخرى"});
            this.cbxExerciseType.Location = new System.Drawing.Point(174, 258);
            this.cbxExerciseType.Name = "cbxExerciseType";
            this.cbxExerciseType.Size = new System.Drawing.Size(273, 37);
            this.cbxExerciseType.TabIndex = 80;
            this.cbxExerciseType.SelectedIndexChanged += new System.EventHandler(this.cbxExerciseType_SelectedIndexChanged);
            this.cbxExerciseType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxSubsType_KeyPress);
            // 
            // lblExerciseType
            // 
            this.lblExerciseType.AutoSize = true;
            this.lblExerciseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExerciseType.ForeColor = System.Drawing.Color.Yellow;
            this.lblExerciseType.Location = new System.Drawing.Point(518, 261);
            this.lblExerciseType.Name = "lblExerciseType";
            this.lblExerciseType.Size = new System.Drawing.Size(122, 29);
            this.lblExerciseType.TabIndex = 79;
            this.lblExerciseType.Text = "نوع التمرين:";
            // 
            // rdoTrSubsType
            // 
            this.rdoTrSubsType.AutoSize = true;
            this.rdoTrSubsType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoTrSubsType.Location = new System.Drawing.Point(792, 341);
            this.rdoTrSubsType.Name = "rdoTrSubsType";
            this.rdoTrSubsType.Size = new System.Drawing.Size(137, 33);
            this.rdoTrSubsType.TabIndex = 77;
            this.rdoTrSubsType.Text = "نوع الاشتراك";
            this.rdoTrSubsType.UseVisualStyleBackColor = true;
            this.rdoTrSubsType.Click += new System.EventHandler(this.rdoTrCode_Click);
            // 
            // txtTrSearch
            // 
            this.txtTrSearch.BackColor = System.Drawing.Color.Pink;
            this.txtTrSearch.Location = new System.Drawing.Point(955, 297);
            this.txtTrSearch.Name = "txtTrSearch";
            this.txtTrSearch.Size = new System.Drawing.Size(341, 34);
            this.txtTrSearch.TabIndex = 76;
            this.txtTrSearch.TextChanged += new System.EventHandler(this.txtTrSearch_TextChanged);
            this.txtTrSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrSearch_KeyPress);
            // 
            // rdoTrCoach
            // 
            this.rdoTrCoach.AutoSize = true;
            this.rdoTrCoach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoTrCoach.Location = new System.Drawing.Point(930, 341);
            this.rdoTrCoach.Name = "rdoTrCoach";
            this.rdoTrCoach.Size = new System.Drawing.Size(90, 33);
            this.rdoTrCoach.TabIndex = 75;
            this.rdoTrCoach.Text = "المدرب";
            this.rdoTrCoach.UseVisualStyleBackColor = true;
            this.rdoTrCoach.Click += new System.EventHandler(this.rdoTrCode_Click);
            // 
            // rdoTrSsn
            // 
            this.rdoTrSsn.AutoSize = true;
            this.rdoTrSsn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoTrSsn.Location = new System.Drawing.Point(1022, 341);
            this.rdoTrSsn.Name = "rdoTrSsn";
            this.rdoTrSsn.Size = new System.Drawing.Size(125, 33);
            this.rdoTrSsn.TabIndex = 74;
            this.rdoTrSsn.Text = "الرقم القومى";
            this.rdoTrSsn.UseVisualStyleBackColor = true;
            this.rdoTrSsn.Click += new System.EventHandler(this.rdoTrCode_Click);
            // 
            // lblTrSearch
            // 
            this.lblTrSearch.AutoSize = true;
            this.lblTrSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrSearch.ForeColor = System.Drawing.Color.Yellow;
            this.lblTrSearch.Location = new System.Drawing.Point(1302, 297);
            this.lblTrSearch.Name = "lblTrSearch";
            this.lblTrSearch.Size = new System.Drawing.Size(71, 29);
            this.lblTrSearch.TabIndex = 73;
            this.lblTrSearch.Text = "البحث:";
            // 
            // rdoTrName
            // 
            this.rdoTrName.AutoSize = true;
            this.rdoTrName.Checked = true;
            this.rdoTrName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoTrName.Location = new System.Drawing.Point(1149, 341);
            this.rdoTrName.Name = "rdoTrName";
            this.rdoTrName.Size = new System.Drawing.Size(130, 33);
            this.rdoTrName.TabIndex = 72;
            this.rdoTrName.TabStop = true;
            this.rdoTrName.Text = "اسم المشترك";
            this.rdoTrName.UseVisualStyleBackColor = true;
            this.rdoTrName.Click += new System.EventHandler(this.rdoTrCode_Click);
            // 
            // rdoTrCode
            // 
            this.rdoTrCode.AutoSize = true;
            this.rdoTrCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoTrCode.Location = new System.Drawing.Point(1275, 341);
            this.rdoTrCode.Name = "rdoTrCode";
            this.rdoTrCode.Size = new System.Drawing.Size(131, 33);
            this.rdoTrCode.TabIndex = 71;
            this.rdoTrCode.Text = "كود المشترك";
            this.rdoTrCode.UseVisualStyleBackColor = true;
            this.rdoTrCode.Click += new System.EventHandler(this.rdoTrCode_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblMsg.Location = new System.Drawing.Point(527, 341);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(62, 42);
            this.lblMsg.TabIndex = 70;
            this.lblMsg.Text = ">>";
            // 
            // dgvShowTrainee
            // 
            this.dgvShowTrainee.AllowUserToAddRows = false;
            this.dgvShowTrainee.AllowUserToDeleteRows = false;
            this.dgvShowTrainee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowTrainee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowTrainee.BackgroundColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowTrainee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowTrainee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowTrainee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coltrno,
            this.coltrname,
            this.coltrssn,
            this.coltrphone,
            this.coltraddress,
            this.coltrbdate,
            this.coltrimage,
            this.coltrcoach,
            this.coltrsubtype,
            this.coltrstartsub,
            this.coltrendsub,
            this.colexercisetype});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowTrainee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowTrainee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShowTrainee.EnableHeadersVisualStyles = false;
            this.dgvShowTrainee.Location = new System.Drawing.Point(0, 420);
            this.dgvShowTrainee.MultiSelect = false;
            this.dgvShowTrainee.Name = "dgvShowTrainee";
            this.dgvShowTrainee.ReadOnly = true;
            this.dgvShowTrainee.RowHeadersWidth = 51;
            this.dgvShowTrainee.RowTemplate.Height = 24;
            this.dgvShowTrainee.Size = new System.Drawing.Size(1444, 291);
            this.dgvShowTrainee.TabIndex = 63;
            this.dgvShowTrainee.SelectionChanged += new System.EventHandler(this.dgvShowTrainee_SelectionChanged);
            // 
            // coltrno
            // 
            this.coltrno.DataPropertyName = "trno";
            this.coltrno.HeaderText = "كود المشترك";
            this.coltrno.MinimumWidth = 6;
            this.coltrno.Name = "coltrno";
            this.coltrno.ReadOnly = true;
            // 
            // coltrname
            // 
            this.coltrname.DataPropertyName = "trname";
            this.coltrname.HeaderText = "اسم المشترك";
            this.coltrname.MinimumWidth = 6;
            this.coltrname.Name = "coltrname";
            this.coltrname.ReadOnly = true;
            // 
            // coltrssn
            // 
            this.coltrssn.DataPropertyName = "trssn";
            this.coltrssn.HeaderText = " بطاقه الرقم القومى ";
            this.coltrssn.MinimumWidth = 6;
            this.coltrssn.Name = "coltrssn";
            this.coltrssn.ReadOnly = true;
            // 
            // coltrphone
            // 
            this.coltrphone.DataPropertyName = "trphone";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.coltrphone.DefaultCellStyle = dataGridViewCellStyle2;
            this.coltrphone.HeaderText = "رقم الهاتف";
            this.coltrphone.MinimumWidth = 6;
            this.coltrphone.Name = "coltrphone";
            this.coltrphone.ReadOnly = true;
            // 
            // coltraddress
            // 
            this.coltraddress.DataPropertyName = "traddress";
            this.coltraddress.HeaderText = "العنوان";
            this.coltraddress.MinimumWidth = 6;
            this.coltraddress.Name = "coltraddress";
            this.coltraddress.ReadOnly = true;
            // 
            // coltrbdate
            // 
            this.coltrbdate.DataPropertyName = "trbirthdate";
            this.coltrbdate.HeaderText = "تاريخ الميلاد";
            this.coltrbdate.MinimumWidth = 6;
            this.coltrbdate.Name = "coltrbdate";
            this.coltrbdate.ReadOnly = true;
            // 
            // coltrimage
            // 
            this.coltrimage.DataPropertyName = "trimage";
            this.coltrimage.HeaderText = "صوره المشترك";
            this.coltrimage.MinimumWidth = 6;
            this.coltrimage.Name = "coltrimage";
            this.coltrimage.ReadOnly = true;
            this.coltrimage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coltrimage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // coltrcoach
            // 
            this.coltrcoach.DataPropertyName = "trcoach";
            this.coltrcoach.HeaderText = "المدرب";
            this.coltrcoach.MinimumWidth = 6;
            this.coltrcoach.Name = "coltrcoach";
            this.coltrcoach.ReadOnly = true;
            // 
            // coltrsubtype
            // 
            this.coltrsubtype.DataPropertyName = "subscriptiontype";
            this.coltrsubtype.HeaderText = "نوع الاشتراك";
            this.coltrsubtype.MinimumWidth = 6;
            this.coltrsubtype.Name = "coltrsubtype";
            this.coltrsubtype.ReadOnly = true;
            // 
            // coltrstartsub
            // 
            this.coltrstartsub.DataPropertyName = "subscriptionstart";
            this.coltrstartsub.HeaderText = "بدايه الاشتراك";
            this.coltrstartsub.MinimumWidth = 6;
            this.coltrstartsub.Name = "coltrstartsub";
            this.coltrstartsub.ReadOnly = true;
            // 
            // coltrendsub
            // 
            this.coltrendsub.DataPropertyName = "subscriptionend";
            this.coltrendsub.HeaderText = "نهايه الاشتراك";
            this.coltrendsub.MinimumWidth = 6;
            this.coltrendsub.Name = "coltrendsub";
            this.coltrendsub.ReadOnly = true;
            // 
            // colexercisetype
            // 
            this.colexercisetype.DataPropertyName = "exercisetype";
            this.colexercisetype.HeaderText = "نوع التمرين";
            this.colexercisetype.MinimumWidth = 6;
            this.colexercisetype.Name = "colexercisetype";
            this.colexercisetype.ReadOnly = true;
            // 
            // epTrainee
            // 
            this.epTrainee.ContainerControl = this;
            // 
            // btnShowAllTrainee
            // 
            this.btnShowAllTrainee.BackColor = System.Drawing.Color.Pink;
            this.btnShowAllTrainee.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnShowAllTrainee.BorderColor = System.Drawing.Color.Black;
            this.btnShowAllTrainee.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnShowAllTrainee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAllTrainee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnShowAllTrainee.FlatAppearance.BorderSize = 2;
            this.btnShowAllTrainee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAllTrainee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllTrainee.Location = new System.Drawing.Point(28, 348);
            this.btnShowAllTrainee.Name = "btnShowAllTrainee";
            this.btnShowAllTrainee.Size = new System.Drawing.Size(345, 34);
            this.btnShowAllTrainee.TabIndex = 78;
            this.btnShowAllTrainee.Text = "عرض الجميع فى شاشه كبيره";
            this.btnShowAllTrainee.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnShowAllTrainee.UseVisualStyleBackColor = false;
            this.btnShowAllTrainee.Click += new System.EventHandler(this.btnShowAllTrainee_Click);
            // 
            // PicTrainee
            // 
            this.PicTrainee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.PicTrainee.Location = new System.Drawing.Point(7, 17);
            this.PicTrainee.Name = "PicTrainee";
            this.PicTrainee.Size = new System.Drawing.Size(150, 150);
            this.PicTrainee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTrainee.TabIndex = 69;
            this.PicTrainee.TabStop = false;
            // 
            // btnReportEmp
            // 
            this.btnReportEmp.BackColor = System.Drawing.Color.Pink;
            this.btnReportEmp.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnReportEmp.BorderColor = System.Drawing.Color.Black;
            this.btnReportEmp.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnReportEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReportEmp.FlatAppearance.BorderSize = 2;
            this.btnReportEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportEmp.Location = new System.Drawing.Point(379, 303);
            this.btnReportEmp.Name = "btnReportEmp";
            this.btnReportEmp.Size = new System.Drawing.Size(108, 34);
            this.btnReportEmp.TabIndex = 68;
            this.btnReportEmp.Text = "تقريـر";
            this.btnReportEmp.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnReportEmp.UseVisualStyleBackColor = false;
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.BackColor = System.Drawing.Color.Pink;
            this.btnDeleteEmp.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnDeleteEmp.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteEmp.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnDeleteEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteEmp.FlatAppearance.BorderSize = 2;
            this.btnDeleteEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmp.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteEmp.Location = new System.Drawing.Point(493, 303);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(108, 34);
            this.btnDeleteEmp.TabIndex = 67;
            this.btnDeleteEmp.Text = "حــذف";
            this.btnDeleteEmp.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnDeleteEmp.UseVisualStyleBackColor = false;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.BackColor = System.Drawing.Color.Pink;
            this.btnEditEmp.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnEditEmp.BorderColor = System.Drawing.Color.Black;
            this.btnEditEmp.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnEditEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditEmp.FlatAppearance.BorderSize = 2;
            this.btnEditEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmp.Location = new System.Drawing.Point(607, 303);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(108, 34);
            this.btnEditEmp.TabIndex = 66;
            this.btnEditEmp.Text = "تعديــل";
            this.btnEditEmp.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnEditEmp.UseVisualStyleBackColor = false;
            this.btnEditEmp.Click += new System.EventHandler(this.btnEditEmp_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.Pink;
            this.btnAddEmp.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnAddEmp.BorderColor = System.Drawing.Color.Black;
            this.btnAddEmp.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnAddEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddEmp.FlatAppearance.BorderSize = 2;
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.Location = new System.Drawing.Point(721, 303);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(108, 34);
            this.btnAddEmp.TabIndex = 65;
            this.btnAddEmp.Text = "اضــافه";
            this.btnAddEmp.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnNewEmp
            // 
            this.btnNewEmp.BackColor = System.Drawing.Color.Pink;
            this.btnNewEmp.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnNewEmp.BorderColor = System.Drawing.Color.Black;
            this.btnNewEmp.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnNewEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewEmp.FlatAppearance.BorderSize = 2;
            this.btnNewEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEmp.Location = new System.Drawing.Point(835, 303);
            this.btnNewEmp.Name = "btnNewEmp";
            this.btnNewEmp.Size = new System.Drawing.Size(108, 34);
            this.btnNewEmp.TabIndex = 64;
            this.btnNewEmp.Text = "جديد*";
            this.btnNewEmp.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnNewEmp.UseVisualStyleBackColor = false;
            this.btnNewEmp.Click += new System.EventHandler(this.btnNewEmp_Click);
            // 
            // btnSubsDetails
            // 
            this.btnSubsDetails.BackColor = System.Drawing.Color.Pink;
            this.btnSubsDetails.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnSubsDetails.BorderColor = System.Drawing.Color.Black;
            this.btnSubsDetails.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnSubsDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubsDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSubsDetails.FlatAppearance.BorderSize = 2;
            this.btnSubsDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubsDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubsDetails.Location = new System.Drawing.Point(7, 214);
            this.btnSubsDetails.Name = "btnSubsDetails";
            this.btnSubsDetails.Size = new System.Drawing.Size(150, 38);
            this.btnSubsDetails.TabIndex = 58;
            this.btnSubsDetails.Text = "تفاصيل الاشتراك";
            this.btnSubsDetails.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnSubsDetails.UseVisualStyleBackColor = false;
            this.btnSubsDetails.Click += new System.EventHandler(this.btnSubsDetails_Click);
            // 
            // btnAddTrPhone
            // 
            this.btnAddTrPhone.BackColor = System.Drawing.Color.Pink;
            this.btnAddTrPhone.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnAddTrPhone.BorderColor = System.Drawing.Color.Black;
            this.btnAddTrPhone.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnAddTrPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTrPhone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddTrPhone.FlatAppearance.BorderSize = 2;
            this.btnAddTrPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTrPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrPhone.Location = new System.Drawing.Point(780, 129);
            this.btnAddTrPhone.Name = "btnAddTrPhone";
            this.btnAddTrPhone.Size = new System.Drawing.Size(63, 29);
            this.btnAddTrPhone.TabIndex = 37;
            this.btnAddTrPhone.Text = "+";
            this.btnAddTrPhone.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnAddTrPhone.UseVisualStyleBackColor = false;
            this.btnAddTrPhone.Click += new System.EventHandler(this.btnAddTrPhone_Click);
            // 
            // btnDelSelectedlbxPhoneItem
            // 
            this.btnDelSelectedlbxPhoneItem.BackColor = System.Drawing.Color.Pink;
            this.btnDelSelectedlbxPhoneItem.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnDelSelectedlbxPhoneItem.BorderColor = System.Drawing.Color.Black;
            this.btnDelSelectedlbxPhoneItem.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnDelSelectedlbxPhoneItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelSelectedlbxPhoneItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDelSelectedlbxPhoneItem.FlatAppearance.BorderSize = 2;
            this.btnDelSelectedlbxPhoneItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelSelectedlbxPhoneItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelSelectedlbxPhoneItem.Location = new System.Drawing.Point(1228, 169);
            this.btnDelSelectedlbxPhoneItem.Name = "btnDelSelectedlbxPhoneItem";
            this.btnDelSelectedlbxPhoneItem.Size = new System.Drawing.Size(150, 29);
            this.btnDelSelectedlbxPhoneItem.TabIndex = 41;
            this.btnDelSelectedlbxPhoneItem.Text = "حذف المحدد";
            this.btnDelSelectedlbxPhoneItem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnDelSelectedlbxPhoneItem.UseVisualStyleBackColor = false;
            this.btnDelSelectedlbxPhoneItem.Click += new System.EventHandler(this.btnDelSelectedlbxPhoneItem_Click);
            // 
            // btnDelLastlbxPhoneItem
            // 
            this.btnDelLastlbxPhoneItem.BackColor = System.Drawing.Color.Pink;
            this.btnDelLastlbxPhoneItem.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnDelLastlbxPhoneItem.BorderColor = System.Drawing.Color.Black;
            this.btnDelLastlbxPhoneItem.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnDelLastlbxPhoneItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelLastlbxPhoneItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDelLastlbxPhoneItem.FlatAppearance.BorderSize = 2;
            this.btnDelLastlbxPhoneItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelLastlbxPhoneItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelLastlbxPhoneItem.Location = new System.Drawing.Point(1228, 204);
            this.btnDelLastlbxPhoneItem.Name = "btnDelLastlbxPhoneItem";
            this.btnDelLastlbxPhoneItem.Size = new System.Drawing.Size(150, 29);
            this.btnDelLastlbxPhoneItem.TabIndex = 42;
            this.btnDelLastlbxPhoneItem.Text = "حذف اخر عنصر";
            this.btnDelLastlbxPhoneItem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnDelLastlbxPhoneItem.UseVisualStyleBackColor = false;
            this.btnDelLastlbxPhoneItem.Click += new System.EventHandler(this.btnDelLastlbxPhoneItem_Click);
            // 
            // btnDelAlllbxPhone
            // 
            this.btnDelAlllbxPhone.BackColor = System.Drawing.Color.Pink;
            this.btnDelAlllbxPhone.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnDelAlllbxPhone.BorderColor = System.Drawing.Color.Black;
            this.btnDelAlllbxPhone.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnDelAlllbxPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelAlllbxPhone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDelAlllbxPhone.FlatAppearance.BorderSize = 2;
            this.btnDelAlllbxPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelAlllbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAlllbxPhone.ForeColor = System.Drawing.Color.Red;
            this.btnDelAlllbxPhone.Location = new System.Drawing.Point(1228, 239);
            this.btnDelAlllbxPhone.Name = "btnDelAlllbxPhone";
            this.btnDelAlllbxPhone.Size = new System.Drawing.Size(150, 29);
            this.btnDelAlllbxPhone.TabIndex = 43;
            this.btnDelAlllbxPhone.Text = "حذف الكل";
            this.btnDelAlllbxPhone.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnDelAlllbxPhone.UseVisualStyleBackColor = false;
            this.btnDelAlllbxPhone.Click += new System.EventHandler(this.btnDelAlllbxPhone_Click);
            // 
            // btnAddTrPic
            // 
            this.btnAddTrPic.BackColor = System.Drawing.Color.Pink;
            this.btnAddTrPic.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnAddTrPic.BorderColor = System.Drawing.Color.Black;
            this.btnAddTrPic.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnAddTrPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTrPic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddTrPic.FlatAppearance.BorderSize = 2;
            this.btnAddTrPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTrPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrPic.Location = new System.Drawing.Point(7, 173);
            this.btnAddTrPic.Name = "btnAddTrPic";
            this.btnAddTrPic.Size = new System.Drawing.Size(150, 35);
            this.btnAddTrPic.TabIndex = 49;
            this.btnAddTrPic.Text = "اضافه صوره";
            this.btnAddTrPic.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnAddTrPic.UseVisualStyleBackColor = false;
            this.btnAddTrPic.Click += new System.EventHandler(this.btnAddTrPic_Click);
            // 
            // FrmTrainee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1444, 711);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTrainee);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTrainee";
            this.Opacity = 0.95D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Deactivate += new System.EventHandler(this.FrmTrainee_Deactivate);
            this.Load += new System.EventHandler(this.FrmTrainee_Load_1);
            this.pnlTrainee.ResumeLayout(false);
            this.pnlTrainee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTrainee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTrainee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTrainee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTrCode;
        private System.Windows.Forms.Label lblTrCode;
        private System.Windows.Forms.Label lblTrName;
        private System.Windows.Forms.Label lblTrSsn;
        private System.Windows.Forms.Label lblTrPhone;
        private SansationRoundButton btnAddTrPhone;
        private SansationRoundButton btnDelAlllbxPhone;
        private SansationRoundButton btnDelLastlbxPhoneItem;
        private SansationRoundButton btnDelSelectedlbxPhoneItem;
        public System.Windows.Forms.ListBox lbxTrPhones;
        private SansationRoundButton btnAddTrPic;
        public System.Windows.Forms.DateTimePicker dtpTrBirth;
        private System.Windows.Forms.TextBox txtTrAddress;
        private System.Windows.Forms.Label lblTrBirth;
        private System.Windows.Forms.Label lblTrAddress;
        private System.Windows.Forms.Label lblTrCoachName;
        public System.Windows.Forms.ComboBox cbxTrCoachName;
        private System.Windows.Forms.Label lblSubsType;
        public System.Windows.Forms.ComboBox cbxSubsType;
        private System.Windows.Forms.Label lblSubsStart;
        public System.Windows.Forms.DateTimePicker dtpSubsStart;
        public System.Windows.Forms.DateTimePicker dtpSubsEnd;
        private System.Windows.Forms.Label lblSubsEnd;
        private SansationRoundButton btnSubsDetails;
        private System.Windows.Forms.TextBox txtTrName;
        private System.Windows.Forms.TextBox txtTrSsn;
        private System.Windows.Forms.TextBox txtTrPhone;
        private System.Windows.Forms.Panel pnlTrainee;
        private System.Windows.Forms.DataGridView dgvShowTrainee;
        private SansationRoundButton btnReportEmp;
        private SansationRoundButton btnDeleteEmp;
        private SansationRoundButton btnEditEmp;
        private SansationRoundButton btnAddEmp;
        private SansationRoundButton btnNewEmp;
        private MyPictureBox PicTrainee;
        private System.Windows.Forms.ErrorProvider epTrainee;
        private System.Windows.Forms.Label lblMsg;
        public System.Windows.Forms.TextBox txtTrSearch;
        private System.Windows.Forms.RadioButton rdoTrCoach;
        private System.Windows.Forms.RadioButton rdoTrSsn;
        private System.Windows.Forms.Label lblTrSearch;
        private System.Windows.Forms.RadioButton rdoTrName;
        private System.Windows.Forms.RadioButton rdoTrCode;
        private System.Windows.Forms.RadioButton rdoTrSubsType;
        private SansationRoundButton btnShowAllTrainee;
        public System.Windows.Forms.ComboBox cbxExerciseType;
        private System.Windows.Forms.Label lblExerciseType;
        private System.Windows.Forms.Label lblSubsPrice;
        private System.Windows.Forms.TextBox txtSubsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrno;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrname;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrssn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltraddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrbdate;
        private System.Windows.Forms.DataGridViewImageColumn coltrimage;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrcoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrsubtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrstartsub;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrendsub;
        private System.Windows.Forms.DataGridViewTextBoxColumn colexercisetype;
    }
}
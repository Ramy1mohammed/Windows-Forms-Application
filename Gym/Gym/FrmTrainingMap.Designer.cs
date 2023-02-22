namespace Gym
{
    partial class FrmTrainingMap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTrainingMap = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.cbxMapCategory = new System.Windows.Forms.ComboBox();
            this.dgvShowTrainingMap = new System.Windows.Forms.DataGridView();
            this.colmapcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmapname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmapcat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmapimage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colmapdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTrainingDesc = new System.Windows.Forms.TextBox();
            this.lblMapCategory = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMapName = new System.Windows.Forms.TextBox();
            this.lblMapName = new System.Windows.Forms.Label();
            this.txtMapCode = new System.Windows.Forms.TextBox();
            this.lblMapCode = new System.Windows.Forms.Label();
            this.btnMapTrainingReport = new SansationRoundButton();
            this.btnDeleteMapTraining = new SansationRoundButton();
            this.btnEditMapTraining = new SansationRoundButton();
            this.btnAddNewMapTraining = new SansationRoundButton();
            this.btnNewMapTraining = new SansationRoundButton();
            this.PicTainingMap = new Gym.MyPictureBox();
            this.btnAddTrainingPic = new SansationRoundButton();
            this.epTrMap = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTrainingMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTrainingMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTainingMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTrMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTrainingMap
            // 
            this.pnlTrainingMap.BackColor = System.Drawing.Color.Black;
            this.pnlTrainingMap.Controls.Add(this.lblMsg);
            this.pnlTrainingMap.Controls.Add(this.cbxMapCategory);
            this.pnlTrainingMap.Controls.Add(this.btnMapTrainingReport);
            this.pnlTrainingMap.Controls.Add(this.btnDeleteMapTraining);
            this.pnlTrainingMap.Controls.Add(this.btnEditMapTraining);
            this.pnlTrainingMap.Controls.Add(this.btnAddNewMapTraining);
            this.pnlTrainingMap.Controls.Add(this.btnNewMapTraining);
            this.pnlTrainingMap.Controls.Add(this.dgvShowTrainingMap);
            this.pnlTrainingMap.Controls.Add(this.txtTrainingDesc);
            this.pnlTrainingMap.Controls.Add(this.lblMapCategory);
            this.pnlTrainingMap.Controls.Add(this.label10);
            this.pnlTrainingMap.Controls.Add(this.PicTainingMap);
            this.pnlTrainingMap.Controls.Add(this.btnAddTrainingPic);
            this.pnlTrainingMap.Controls.Add(this.txtMapName);
            this.pnlTrainingMap.Controls.Add(this.lblMapName);
            this.pnlTrainingMap.Controls.Add(this.txtMapCode);
            this.pnlTrainingMap.Controls.Add(this.lblMapCode);
            this.pnlTrainingMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrainingMap.Location = new System.Drawing.Point(0, 0);
            this.pnlTrainingMap.Name = "pnlTrainingMap";
            this.pnlTrainingMap.Size = new System.Drawing.Size(1420, 711);
            this.pnlTrainingMap.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblMsg.Location = new System.Drawing.Point(922, 286);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(62, 42);
            this.lblMsg.TabIndex = 64;
            this.lblMsg.Text = ">>";
            // 
            // cbxMapCategory
            // 
            this.cbxMapCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMapCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMapCategory.BackColor = System.Drawing.Color.Pink;
            this.cbxMapCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxMapCategory.FormattingEnabled = true;
            this.cbxMapCategory.Items.AddRange(new object[] {
            "تمرين كمال أجسام",
            "تمرين Boxing",
            "تمرين مساج",
            "تمرين لياقه بدنيه وتأهيل بدنى",
            "تمرين أيروبكس",
            "تمرين زومبا",
            "تمارين رياضات أخرى"});
            this.cbxMapCategory.Location = new System.Drawing.Point(816, 96);
            this.cbxMapCategory.Name = "cbxMapCategory";
            this.cbxMapCategory.Size = new System.Drawing.Size(429, 37);
            this.cbxMapCategory.TabIndex = 63;
            this.cbxMapCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxMapCategory_KeyPress);
            // 
            // dgvShowTrainingMap
            // 
            this.dgvShowTrainingMap.AllowUserToAddRows = false;
            this.dgvShowTrainingMap.AllowUserToDeleteRows = false;
            this.dgvShowTrainingMap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowTrainingMap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowTrainingMap.BackgroundColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowTrainingMap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowTrainingMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowTrainingMap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmapcode,
            this.colmapname,
            this.colmapcat,
            this.colmapimage,
            this.colmapdesc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowTrainingMap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowTrainingMap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShowTrainingMap.EnableHeadersVisualStyles = false;
            this.dgvShowTrainingMap.Location = new System.Drawing.Point(0, 368);
            this.dgvShowTrainingMap.MultiSelect = false;
            this.dgvShowTrainingMap.Name = "dgvShowTrainingMap";
            this.dgvShowTrainingMap.ReadOnly = true;
            this.dgvShowTrainingMap.RowHeadersWidth = 51;
            this.dgvShowTrainingMap.RowTemplate.Height = 24;
            this.dgvShowTrainingMap.Size = new System.Drawing.Size(1420, 343);
            this.dgvShowTrainingMap.TabIndex = 57;
            this.dgvShowTrainingMap.SelectionChanged += new System.EventHandler(this.dgvShowTrainingMap_SelectionChanged);
            // 
            // colmapcode
            // 
            this.colmapcode.DataPropertyName = "trainingno";
            this.colmapcode.FillWeight = 24.73262F;
            this.colmapcode.HeaderText = "كود التمرين";
            this.colmapcode.MinimumWidth = 6;
            this.colmapcode.Name = "colmapcode";
            this.colmapcode.ReadOnly = true;
            // 
            // colmapname
            // 
            this.colmapname.DataPropertyName = "trainingname";
            this.colmapname.FillWeight = 24.73262F;
            this.colmapname.HeaderText = "اسم التمرين";
            this.colmapname.MinimumWidth = 6;
            this.colmapname.Name = "colmapname";
            this.colmapname.ReadOnly = true;
            // 
            // colmapcat
            // 
            this.colmapcat.DataPropertyName = "trainingcategory";
            this.colmapcat.FillWeight = 24.73262F;
            this.colmapcat.HeaderText = "تصنيف التمرين";
            this.colmapcat.MinimumWidth = 6;
            this.colmapcat.Name = "colmapcat";
            this.colmapcat.ReadOnly = true;
            // 
            // colmapimage
            // 
            this.colmapimage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colmapimage.DataPropertyName = "trainingimage";
            this.colmapimage.FillWeight = 401.0695F;
            this.colmapimage.HeaderText = "صوره التمرين";
            this.colmapimage.MinimumWidth = 6;
            this.colmapimage.Name = "colmapimage";
            this.colmapimage.ReadOnly = true;
            this.colmapimage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colmapimage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colmapimage.Width = 150;
            // 
            // colmapdesc
            // 
            this.colmapdesc.DataPropertyName = "desc";
            this.colmapdesc.FillWeight = 24.73262F;
            this.colmapdesc.HeaderText = "وصف التمرين";
            this.colmapdesc.MinimumWidth = 6;
            this.colmapdesc.Name = "colmapdesc";
            this.colmapdesc.ReadOnly = true;
            // 
            // txtTrainingDesc
            // 
            this.txtTrainingDesc.BackColor = System.Drawing.Color.Pink;
            this.txtTrainingDesc.Location = new System.Drawing.Point(178, 12);
            this.txtTrainingDesc.Multiline = true;
            this.txtTrainingDesc.Name = "txtTrainingDesc";
            this.txtTrainingDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTrainingDesc.Size = new System.Drawing.Size(429, 211);
            this.txtTrainingDesc.TabIndex = 56;
            // 
            // lblMapCategory
            // 
            this.lblMapCategory.AutoSize = true;
            this.lblMapCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapCategory.ForeColor = System.Drawing.Color.Yellow;
            this.lblMapCategory.Location = new System.Drawing.Point(1252, 99);
            this.lblMapCategory.Name = "lblMapCategory";
            this.lblMapCategory.Size = new System.Drawing.Size(152, 29);
            this.lblMapCategory.TabIndex = 54;
            this.lblMapCategory.Text = "تصنيف التمرين:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(627, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 29);
            this.label10.TabIndex = 53;
            this.label10.Text = "وصف التمرين:";
            // 
            // txtMapName
            // 
            this.txtMapName.BackColor = System.Drawing.Color.Pink;
            this.txtMapName.Location = new System.Drawing.Point(816, 54);
            this.txtMapName.Name = "txtMapName";
            this.txtMapName.Size = new System.Drawing.Size(429, 34);
            this.txtMapName.TabIndex = 7;
            // 
            // lblMapName
            // 
            this.lblMapName.AutoSize = true;
            this.lblMapName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapName.ForeColor = System.Drawing.Color.Yellow;
            this.lblMapName.Location = new System.Drawing.Point(1282, 57);
            this.lblMapName.Name = "lblMapName";
            this.lblMapName.Size = new System.Drawing.Size(119, 29);
            this.lblMapName.TabIndex = 6;
            this.lblMapName.Text = "اسم التمرين:";
            // 
            // txtMapCode
            // 
            this.txtMapCode.BackColor = System.Drawing.Color.Pink;
            this.txtMapCode.Location = new System.Drawing.Point(816, 14);
            this.txtMapCode.Name = "txtMapCode";
            this.txtMapCode.ReadOnly = true;
            this.txtMapCode.Size = new System.Drawing.Size(429, 34);
            this.txtMapCode.TabIndex = 5;
            this.txtMapCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMapCode
            // 
            this.lblMapCode.AutoSize = true;
            this.lblMapCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapCode.ForeColor = System.Drawing.Color.Yellow;
            this.lblMapCode.Location = new System.Drawing.Point(1282, 17);
            this.lblMapCode.Name = "lblMapCode";
            this.lblMapCode.Size = new System.Drawing.Size(120, 29);
            this.lblMapCode.TabIndex = 4;
            this.lblMapCode.Text = "كود التمرين:";
            // 
            // btnMapTrainingReport
            // 
            this.btnMapTrainingReport.BackColor = System.Drawing.Color.Pink;
            this.btnMapTrainingReport.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnMapTrainingReport.BorderColor = System.Drawing.Color.Black;
            this.btnMapTrainingReport.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnMapTrainingReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMapTrainingReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMapTrainingReport.FlatAppearance.BorderSize = 2;
            this.btnMapTrainingReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMapTrainingReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapTrainingReport.Location = new System.Drawing.Point(428, 244);
            this.btnMapTrainingReport.Name = "btnMapTrainingReport";
            this.btnMapTrainingReport.Size = new System.Drawing.Size(108, 34);
            this.btnMapTrainingReport.TabIndex = 62;
            this.btnMapTrainingReport.Text = "تقريـر";
            this.btnMapTrainingReport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnMapTrainingReport.UseVisualStyleBackColor = false;
            // 
            // btnDeleteMapTraining
            // 
            this.btnDeleteMapTraining.BackColor = System.Drawing.Color.Pink;
            this.btnDeleteMapTraining.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnDeleteMapTraining.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteMapTraining.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnDeleteMapTraining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMapTraining.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteMapTraining.FlatAppearance.BorderSize = 2;
            this.btnDeleteMapTraining.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteMapTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMapTraining.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteMapTraining.Location = new System.Drawing.Point(542, 244);
            this.btnDeleteMapTraining.Name = "btnDeleteMapTraining";
            this.btnDeleteMapTraining.Size = new System.Drawing.Size(108, 34);
            this.btnDeleteMapTraining.TabIndex = 61;
            this.btnDeleteMapTraining.Text = "حــذف";
            this.btnDeleteMapTraining.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnDeleteMapTraining.UseVisualStyleBackColor = false;
            this.btnDeleteMapTraining.Click += new System.EventHandler(this.btnDeleteMapTraining_Click);
            // 
            // btnEditMapTraining
            // 
            this.btnEditMapTraining.BackColor = System.Drawing.Color.Pink;
            this.btnEditMapTraining.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnEditMapTraining.BorderColor = System.Drawing.Color.Black;
            this.btnEditMapTraining.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnEditMapTraining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditMapTraining.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditMapTraining.FlatAppearance.BorderSize = 2;
            this.btnEditMapTraining.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditMapTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMapTraining.Location = new System.Drawing.Point(656, 244);
            this.btnEditMapTraining.Name = "btnEditMapTraining";
            this.btnEditMapTraining.Size = new System.Drawing.Size(108, 34);
            this.btnEditMapTraining.TabIndex = 60;
            this.btnEditMapTraining.Text = "تعديــل";
            this.btnEditMapTraining.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnEditMapTraining.UseVisualStyleBackColor = false;
            this.btnEditMapTraining.Click += new System.EventHandler(this.btnEditMapTraining_Click);
            // 
            // btnAddNewMapTraining
            // 
            this.btnAddNewMapTraining.BackColor = System.Drawing.Color.Pink;
            this.btnAddNewMapTraining.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnAddNewMapTraining.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewMapTraining.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnAddNewMapTraining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewMapTraining.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddNewMapTraining.FlatAppearance.BorderSize = 2;
            this.btnAddNewMapTraining.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewMapTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMapTraining.Location = new System.Drawing.Point(770, 244);
            this.btnAddNewMapTraining.Name = "btnAddNewMapTraining";
            this.btnAddNewMapTraining.Size = new System.Drawing.Size(108, 34);
            this.btnAddNewMapTraining.TabIndex = 59;
            this.btnAddNewMapTraining.Text = "اضــافه";
            this.btnAddNewMapTraining.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnAddNewMapTraining.UseVisualStyleBackColor = false;
            this.btnAddNewMapTraining.Click += new System.EventHandler(this.btnAddNewMapTraining_Click);
            // 
            // btnNewMapTraining
            // 
            this.btnNewMapTraining.BackColor = System.Drawing.Color.Pink;
            this.btnNewMapTraining.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnNewMapTraining.BorderColor = System.Drawing.Color.Black;
            this.btnNewMapTraining.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnNewMapTraining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewMapTraining.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewMapTraining.FlatAppearance.BorderSize = 2;
            this.btnNewMapTraining.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewMapTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMapTraining.Location = new System.Drawing.Point(884, 244);
            this.btnNewMapTraining.Name = "btnNewMapTraining";
            this.btnNewMapTraining.Size = new System.Drawing.Size(108, 34);
            this.btnNewMapTraining.TabIndex = 58;
            this.btnNewMapTraining.Text = "جديد*";
            this.btnNewMapTraining.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnNewMapTraining.UseVisualStyleBackColor = false;
            this.btnNewMapTraining.Click += new System.EventHandler(this.btnNewMapTraining_Click);
            // 
            // PicTainingMap
            // 
            this.PicTainingMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.PicTainingMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicTainingMap.InitialImage = null;
            this.PicTainingMap.Location = new System.Drawing.Point(12, 17);
            this.PicTainingMap.Name = "PicTainingMap";
            this.PicTainingMap.Size = new System.Drawing.Size(150, 150);
            this.PicTainingMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTainingMap.TabIndex = 52;
            this.PicTainingMap.TabStop = false;
            // 
            // btnAddTrainingPic
            // 
            this.btnAddTrainingPic.BackColor = System.Drawing.Color.Pink;
            this.btnAddTrainingPic.BackColorMouseOver = System.Drawing.Color.LawnGreen;
            this.btnAddTrainingPic.BorderColor = System.Drawing.Color.Black;
            this.btnAddTrainingPic.BorderColorMouseOver = System.Drawing.Color.Black;
            this.btnAddTrainingPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTrainingPic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddTrainingPic.FlatAppearance.BorderSize = 2;
            this.btnAddTrainingPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTrainingPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrainingPic.Location = new System.Drawing.Point(12, 188);
            this.btnAddTrainingPic.Name = "btnAddTrainingPic";
            this.btnAddTrainingPic.Size = new System.Drawing.Size(150, 35);
            this.btnAddTrainingPic.TabIndex = 51;
            this.btnAddTrainingPic.Text = "اضافه صوره";
            this.btnAddTrainingPic.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnAddTrainingPic.UseVisualStyleBackColor = false;
            this.btnAddTrainingPic.Click += new System.EventHandler(this.btnAddTrainingPic_Click);
            // 
            // epTrMap
            // 
            this.epTrMap.ContainerControl = this;
            // 
            // FrmTrainingMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1420, 711);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTrainingMap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTrainingMap";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Deactivate += new System.EventHandler(this.FrmTrainingMap_Deactivate);
            this.Load += new System.EventHandler(this.FrmTrainingMap_Load);
            this.pnlTrainingMap.ResumeLayout(false);
            this.pnlTrainingMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTrainingMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTainingMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTrMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTrainingMap;
        private System.Windows.Forms.TextBox txtMapCode;
        private System.Windows.Forms.Label lblMapCode;
        private System.Windows.Forms.TextBox txtMapName;
        private System.Windows.Forms.Label lblMapName;
        private MyPictureBox PicTainingMap;
        private SansationRoundButton btnAddTrainingPic;
        private System.Windows.Forms.TextBox txtTrainingDesc;
        private System.Windows.Forms.Label lblMapCategory;
        private System.Windows.Forms.Label label10;
        private SansationRoundButton btnMapTrainingReport;
        private SansationRoundButton btnDeleteMapTraining;
        private SansationRoundButton btnEditMapTraining;
        private SansationRoundButton btnAddNewMapTraining;
        private SansationRoundButton btnNewMapTraining;
        public System.Windows.Forms.ComboBox cbxMapCategory;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.DataGridView dgvShowTrainingMap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmapcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmapname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmapcat;
        private System.Windows.Forms.DataGridViewImageColumn colmapimage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmapdesc;
        private System.Windows.Forms.ErrorProvider epTrMap;
    }
}
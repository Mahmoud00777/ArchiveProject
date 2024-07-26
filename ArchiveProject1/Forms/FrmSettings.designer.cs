namespace ArchiveProject1.Forms
{
    partial class FrmSettings
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
            this.radNo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnAutoBackupPath = new System.Windows.Forms.Button();
            this.txtAutoBackupPath = new System.Windows.Forms.TextBox();
            this.txtBackupDays = new System.Windows.Forms.TextBox();
            this.txtBackupFiles = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.ckbStartupSystem = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDateFormat = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.bntCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDays = new System.Windows.Forms.CheckBox();
            this.chkFiles = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lable7 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtSQLPassword = new System.Windows.Forms.TextBox();
            this.txtSQLUser = new System.Windows.Forms.TextBox();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.txtBackupName = new System.Windows.Forms.TextBox();
            this.btnBackupPath = new System.Windows.Forms.Button();
            this.btnRestoeDatabase = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblWait = new System.Windows.Forms.Label();
            this.btnAsyncBackup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtDiskArchivePath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDiskArchivePath = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Checked = true;
            this.radNo.Font = new System.Drawing.Font("Hacen Saudi Arabia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNo.ForeColor = System.Drawing.Color.White;
            this.radNo.Location = new System.Drawing.Point(120, 17);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(47, 38);
            this.radNo.TabIndex = 227;
            this.radNo.TabStop = true;
            this.radNo.Text = "لا";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(265, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 25);
            this.label7.TabIndex = 236;
            this.label7.Text = "اسم مستخدم قاعدة البيانات";
            // 
            // ofd
            // 
            this.ofd.FileName = "OpenFileDialog1";
            // 
            // btnAutoBackupPath
            // 
            this.btnAutoBackupPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnAutoBackupPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoBackupPath.FlatAppearance.BorderSize = 0;
            this.btnAutoBackupPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoBackupPath.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoBackupPath.ForeColor = System.Drawing.Color.Snow;
            this.btnAutoBackupPath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAutoBackupPath.Location = new System.Drawing.Point(3, 65);
            this.btnAutoBackupPath.Name = "btnAutoBackupPath";
            this.btnAutoBackupPath.Size = new System.Drawing.Size(214, 34);
            this.btnAutoBackupPath.TabIndex = 231;
            this.btnAutoBackupPath.Text = "مـسـار الـنـسـخ الـتـلقـائي";
            this.btnAutoBackupPath.UseVisualStyleBackColor = false;
            this.btnAutoBackupPath.Click += new System.EventHandler(this.btnAutoBackupPath_Click);
            // 
            // txtAutoBackupPath
            // 
            this.txtAutoBackupPath.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtAutoBackupPath.Location = new System.Drawing.Point(222, 66);
            this.txtAutoBackupPath.Name = "txtAutoBackupPath";
            this.txtAutoBackupPath.ReadOnly = true;
            this.txtAutoBackupPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAutoBackupPath.Size = new System.Drawing.Size(280, 34);
            this.txtAutoBackupPath.TabIndex = 228;
            this.txtAutoBackupPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBackupDays
            // 
            this.txtBackupDays.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtBackupDays.Location = new System.Drawing.Point(172, 199);
            this.txtBackupDays.Name = "txtBackupDays";
            this.txtBackupDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBackupDays.Size = new System.Drawing.Size(196, 34);
            this.txtBackupDays.TabIndex = 224;
            this.txtBackupDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBackupFiles
            // 
            this.txtBackupFiles.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtBackupFiles.Location = new System.Drawing.Point(172, 154);
            this.txtBackupFiles.Name = "txtBackupFiles";
            this.txtBackupFiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBackupFiles.Size = new System.Drawing.Size(196, 34);
            this.txtBackupFiles.TabIndex = 223;
            this.txtBackupFiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hacen Saudi Arabia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(384, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 222;
            this.label3.Text = "الحد الاقصى لعدد الايام";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAutoBackupPath);
            this.panel1.Controls.Add(this.txtAutoBackupPath);
            this.panel1.Controls.Add(this.radNo);
            this.panel1.Controls.Add(this.radYes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 121);
            this.panel1.TabIndex = 220;
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Font = new System.Drawing.Font("Hacen Saudi Arabia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radYes.ForeColor = System.Drawing.Color.White;
            this.radYes.Location = new System.Drawing.Point(41, 17);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(73, 38);
            this.radYes.TabIndex = 226;
            this.radYes.Text = "نعم";
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 25);
            this.label1.TabIndex = 225;
            this.label1.Text = "هل تريد اخد نسخة إحتياطيه تلقائيا عند الاغلاق ؟";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 233;
            this.label4.Text = "اســم الخــادم";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnTestConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestConnection.FlatAppearance.BorderSize = 0;
            this.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestConnection.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConnection.ForeColor = System.Drawing.Color.Snow;
            this.btnTestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestConnection.Location = new System.Drawing.Point(71, 192);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(316, 40);
            this.btnTestConnection.TabIndex = 304;
            this.btnTestConnection.Text = "إخــتـبـار الاتــصــال";
            this.btnTestConnection.UseVisualStyleBackColor = false;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // ckbStartupSystem
            // 
            this.ckbStartupSystem.AutoSize = true;
            this.ckbStartupSystem.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStartupSystem.ForeColor = System.Drawing.Color.White;
            this.ckbStartupSystem.Location = new System.Drawing.Point(143, 421);
            this.ckbStartupSystem.Name = "ckbStartupSystem";
            this.ckbStartupSystem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbStartupSystem.Size = new System.Drawing.Size(323, 29);
            this.ckbStartupSystem.TabIndex = 303;
            this.ckbStartupSystem.Text = "تشغيل المنظومة تلقائياً عند تشغيل الجهاز";
            this.ckbStartupSystem.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(314, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 25);
            this.label11.TabIndex = 302;
            this.label11.Text = "صـــيـــغـــة الـــتــــاريــــخ";
            // 
            // cmbDateFormat
            // 
            this.cmbDateFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDateFormat.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.cmbDateFormat.FormattingEnabled = true;
            this.cmbDateFormat.Location = new System.Drawing.Point(20, 381);
            this.cmbDateFormat.Name = "cmbDateFormat";
            this.cmbDateFormat.Size = new System.Drawing.Size(246, 33);
            this.cmbDateFormat.TabIndex = 301;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(338, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 25);
            this.label10.TabIndex = 251;
            this.label10.Text = "إســــم الــــشــــركة";
            // 
            // txtCompany
            // 
            this.txtCompany.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtCompany.Location = new System.Drawing.Point(20, 339);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCompany.Size = new System.Drawing.Size(246, 34);
            this.txtCompany.TabIndex = 250;
            this.txtCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bntCancel
            // 
            this.bntCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.bntCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCancel.FlatAppearance.BorderSize = 0;
            this.bntCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCancel.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancel.ForeColor = System.Drawing.Color.Snow;
            this.bntCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntCancel.Location = new System.Drawing.Point(71, 522);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(316, 40);
            this.bntCancel.TabIndex = 249;
            this.bntCancel.Text = "خـــر و ج";
            this.bntCancel.UseVisualStyleBackColor = false;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Snow;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(71, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(316, 40);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "حــفــظ الاعــداد ت";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDays);
            this.groupBox2.Controls.Add(this.chkFiles);
            this.groupBox2.Controls.Add(this.txtBackupDays);
            this.groupBox2.Controls.Add(this.txtBackupFiles);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(14, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(543, 249);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "النسخ التلقائي لقواعد البيانات";
            // 
            // chkDays
            // 
            this.chkDays.AutoSize = true;
            this.chkDays.Font = new System.Drawing.Font("Hacen Saudi Arabia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDays.ForeColor = System.Drawing.Color.White;
            this.chkDays.Location = new System.Drawing.Point(36, 201);
            this.chkDays.Name = "chkDays";
            this.chkDays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDays.Size = new System.Drawing.Size(120, 35);
            this.chkDays.TabIndex = 313;
            this.chkDays.Text = "غير محدود";
            this.chkDays.UseVisualStyleBackColor = true;
            this.chkDays.CheckedChanged += new System.EventHandler(this.chkDays_CheckedChanged);
            // 
            // chkFiles
            // 
            this.chkFiles.AutoSize = true;
            this.chkFiles.Font = new System.Drawing.Font("Hacen Saudi Arabia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiles.ForeColor = System.Drawing.Color.White;
            this.chkFiles.Location = new System.Drawing.Point(36, 157);
            this.chkFiles.Name = "chkFiles";
            this.chkFiles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkFiles.Size = new System.Drawing.Size(120, 35);
            this.chkFiles.TabIndex = 312;
            this.chkFiles.Text = "غير محدود";
            this.chkFiles.UseVisualStyleBackColor = true;
            this.chkFiles.CheckedChanged += new System.EventHandler(this.chkFiles_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hacen Saudi Arabia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(368, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 221;
            this.label2.Text = "الحد الاقصى لعدد الملفات";
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtAdminPass.Location = new System.Drawing.Point(20, 298);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdminPass.Size = new System.Drawing.Size(246, 34);
            this.txtAdminPass.TabIndex = 247;
            this.txtAdminPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdminPass.UseSystemPasswordChar = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTestConnection);
            this.groupBox3.Controls.Add(this.ckbStartupSystem);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cmbDateFormat);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtCompany);
            this.groupBox3.Controls.Add(this.bntCancel);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.txtAdminPass);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.lable7);
            this.groupBox3.Controls.Add(this.txtServer);
            this.groupBox3.Controls.Add(this.txtAdminName);
            this.groupBox3.Controls.Add(this.txtDatabase);
            this.groupBox3.Controls.Add(this.txtSQLPassword);
            this.groupBox3.Controls.Add(this.txtSQLUser);
            this.groupBox3.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(587, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(474, 571);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اعدادت الاتصال بالنظام";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 25);
            this.label6.TabIndex = 237;
            this.label6.Text = "كلمة مرور قاعدة البيانات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 234;
            this.label5.Text = "اسـم قــاعـدة البـيـانـات";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(20, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 5);
            this.panel3.TabIndex = 238;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(325, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 25);
            this.label9.TabIndex = 239;
            this.label9.Text = "اســـم الـــمـــســـؤول";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(22, 454);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(421, 5);
            this.panel4.TabIndex = 241;
            // 
            // lable7
            // 
            this.lable7.AutoSize = true;
            this.lable7.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable7.Location = new System.Drawing.Point(263, 307);
            this.lable7.Name = "lable7";
            this.lable7.Size = new System.Drawing.Size(209, 25);
            this.lable7.TabIndex = 240;
            this.lable7.Text = "كـــلــمـــة مـــرور الـمـــســـؤول";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtServer.Location = new System.Drawing.Point(17, 24);
            this.txtServer.Name = "txtServer";
            this.txtServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServer.Size = new System.Drawing.Size(246, 34);
            this.txtServer.TabIndex = 242;
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdminName
            // 
            this.txtAdminName.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtAdminName.Location = new System.Drawing.Point(20, 257);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdminName.Size = new System.Drawing.Size(246, 34);
            this.txtAdminName.TabIndex = 246;
            this.txtAdminName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtDatabase.Location = new System.Drawing.Point(17, 65);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDatabase.Size = new System.Drawing.Size(246, 34);
            this.txtDatabase.TabIndex = 243;
            this.txtDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSQLPassword
            // 
            this.txtSQLPassword.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtSQLPassword.Location = new System.Drawing.Point(17, 148);
            this.txtSQLPassword.Name = "txtSQLPassword";
            this.txtSQLPassword.PasswordChar = '•';
            this.txtSQLPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSQLPassword.Size = new System.Drawing.Size(246, 34);
            this.txtSQLPassword.TabIndex = 245;
            this.txtSQLPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSQLUser
            // 
            this.txtSQLUser.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtSQLUser.Location = new System.Drawing.Point(17, 107);
            this.txtSQLUser.Name = "txtSQLUser";
            this.txtSQLUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSQLUser.Size = new System.Drawing.Size(246, 34);
            this.txtSQLUser.TabIndex = 244;
            this.txtSQLUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Enabled = false;
            this.txtBackupPath.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtBackupPath.Location = new System.Drawing.Point(236, 42);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.ReadOnly = true;
            this.txtBackupPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBackupPath.Size = new System.Drawing.Size(280, 34);
            this.txtBackupPath.TabIndex = 234;
            this.txtBackupPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBackupName
            // 
            this.txtBackupName.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtBackupName.Location = new System.Drawing.Point(236, 84);
            this.txtBackupName.Name = "txtBackupName";
            this.txtBackupName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBackupName.Size = new System.Drawing.Size(280, 34);
            this.txtBackupName.TabIndex = 232;
            this.txtBackupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBackupPath
            // 
            this.btnBackupPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnBackupPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackupPath.FlatAppearance.BorderSize = 0;
            this.btnBackupPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupPath.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupPath.ForeColor = System.Drawing.Color.Snow;
            this.btnBackupPath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackupPath.Location = new System.Drawing.Point(12, 42);
            this.btnBackupPath.Name = "btnBackupPath";
            this.btnBackupPath.Size = new System.Drawing.Size(218, 34);
            this.btnBackupPath.TabIndex = 229;
            this.btnBackupPath.Text = "مسـار الـنـسـخ الإحتـيـاطي";
            this.btnBackupPath.UseVisualStyleBackColor = false;
            this.btnBackupPath.Click += new System.EventHandler(this.btnBackupPath_Click);
            // 
            // btnRestoeDatabase
            // 
            this.btnRestoeDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnRestoeDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestoeDatabase.FlatAppearance.BorderSize = 0;
            this.btnRestoeDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoeDatabase.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoeDatabase.ForeColor = System.Drawing.Color.Snow;
            this.btnRestoeDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestoeDatabase.Location = new System.Drawing.Point(236, 187);
            this.btnRestoeDatabase.Name = "btnRestoeDatabase";
            this.btnRestoeDatabase.Size = new System.Drawing.Size(280, 40);
            this.btnRestoeDatabase.TabIndex = 230;
            this.btnRestoeDatabase.Text = "اسـتـعـادة نـسـخـة إحـتـيـاطية";
            this.btnRestoeDatabase.UseVisualStyleBackColor = false;
            this.btnRestoeDatabase.Click += new System.EventHandler(this.btnRestoeDatabase_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRestoeDatabase);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblWait);
            this.groupBox1.Controls.Add(this.btnAsyncBackup);
            this.groupBox1.Controls.Add(this.txtBackupPath);
            this.groupBox1.Controls.Add(this.txtBackupName);
            this.groupBox1.Controls.Add(this.btnBackupPath);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(543, 252);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "النسخ اليدوي لقواعد البيانات ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 25);
            this.label8.TabIndex = 283;
            this.label8.Text = "اسـم مـلـف الـنـسـخـة الاحتياطيه";
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Font = new System.Drawing.Font("Hacen Saudi Arabia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWait.ForeColor = System.Drawing.Color.Green;
            this.lblWait.Location = new System.Drawing.Point(6, 226);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(303, 24);
            this.lblWait.TabIndex = 282;
            this.lblWait.Text = "جاري انشاء النسخة الاحتياطية .. الرجاء الانتظار";
            this.lblWait.Visible = false;
            // 
            // btnAsyncBackup
            // 
            this.btnAsyncBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnAsyncBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsyncBackup.FlatAppearance.BorderSize = 0;
            this.btnAsyncBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsyncBackup.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsyncBackup.ForeColor = System.Drawing.Color.Snow;
            this.btnAsyncBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsyncBackup.Location = new System.Drawing.Point(236, 136);
            this.btnAsyncBackup.Name = "btnAsyncBackup";
            this.btnAsyncBackup.Size = new System.Drawing.Size(279, 40);
            this.btnAsyncBackup.TabIndex = 235;
            this.btnAsyncBackup.Text = "نـسـخ احـتـيـاطـي Async";
            this.btnAsyncBackup.UseVisualStyleBackColor = false;
            this.btnAsyncBackup.Click += new System.EventHandler(this.btnAsyncBackup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ArchiveProject1.Properties.Resources.backup__1_;
            this.pictureBox1.Location = new System.Drawing.Point(26, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 228;
            this.pictureBox1.TabStop = false;
            // 
            // txtDiskArchivePath
            // 
            this.txtDiskArchivePath.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtDiskArchivePath.Location = new System.Drawing.Point(250, 559);
            this.txtDiskArchivePath.Name = "txtDiskArchivePath";
            this.txtDiskArchivePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDiskArchivePath.Size = new System.Drawing.Size(279, 34);
            this.txtDiskArchivePath.TabIndex = 315;
            this.txtDiskArchivePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(327, 531);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 25);
            this.label12.TabIndex = 314;
            this.label12.Text = "ملف الأرشفة على القرص الصلب";
            // 
            // btnDiskArchivePath
            // 
            this.btnDiskArchivePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnDiskArchivePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiskArchivePath.FlatAppearance.BorderSize = 0;
            this.btnDiskArchivePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiskArchivePath.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiskArchivePath.ForeColor = System.Drawing.Color.Snow;
            this.btnDiskArchivePath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiskArchivePath.Location = new System.Drawing.Point(26, 559);
            this.btnDiskArchivePath.Name = "btnDiskArchivePath";
            this.btnDiskArchivePath.Size = new System.Drawing.Size(218, 34);
            this.btnDiskArchivePath.TabIndex = 232;
            this.btnDiskArchivePath.Text = "مـسـار النـسـخ التـلـقـائـي";
            this.btnDiskArchivePath.UseVisualStyleBackColor = false;
            this.btnDiskArchivePath.Click += new System.EventHandler(this.btnDiskArchivePath_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1073, 625);
            this.Controls.Add(this.btnDiskArchivePath);
            this.Controls.Add(this.txtDiskArchivePath);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادات النظام";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.HandleCreated += new System.EventHandler(this.FrmMain_HandleCreated);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.RadioButton radNo;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.OpenFileDialog ofd;
        internal System.Windows.Forms.Button btnAutoBackupPath;
        internal System.Windows.Forms.TextBox txtAutoBackupPath;
        internal System.Windows.Forms.TextBox txtBackupDays;
        internal System.Windows.Forms.TextBox txtBackupFiles;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.RadioButton radYes;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnTestConnection;
        internal System.Windows.Forms.CheckBox ckbStartupSystem;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.ComboBox cmbDateFormat;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtCompany;
        internal System.Windows.Forms.Button bntCancel;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtAdminPass;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Label lable7;
        internal System.Windows.Forms.TextBox txtServer;
        internal System.Windows.Forms.TextBox txtAdminName;
        internal System.Windows.Forms.TextBox txtDatabase;
        internal System.Windows.Forms.TextBox txtSQLPassword;
        internal System.Windows.Forms.TextBox txtSQLUser;
        internal System.Windows.Forms.TextBox txtBackupPath;
        internal System.Windows.Forms.TextBox txtBackupName;
        internal System.Windows.Forms.Button btnBackupPath;
        internal System.Windows.Forms.Button btnRestoeDatabase;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label lblWait;
        internal System.Windows.Forms.Button btnAsyncBackup;
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        internal System.Windows.Forms.CheckBox chkDays;
        internal System.Windows.Forms.CheckBox chkFiles;
        internal System.Windows.Forms.TextBox txtDiskArchivePath;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Button btnDiskArchivePath;
    }
}
namespace ArchiveProject1.Forms
{
    partial class FrmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.chkSettings = new System.Windows.Forms.CheckBox();
            this.chkUsers = new System.Windows.Forms.CheckBox();
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.chkInsert = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.pnlPermissions = new System.Windows.Forms.Panel();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserJob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.BtnResetPass = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadPic = new System.Windows.Forms.Button();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeletePicture = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            this.pnlPermissions.SuspendLayout();
            this.grpUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.BackColor = System.Drawing.Color.Transparent;
            this.chkAdmin.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.chkAdmin.ForeColor = System.Drawing.Color.Maroon;
            this.chkAdmin.Location = new System.Drawing.Point(30, 15);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAdmin.Size = new System.Drawing.Size(123, 29);
            this.chkAdmin.TabIndex = 59;
            this.chkAdmin.Text = "جميع الصلاحيات";
            this.chkAdmin.UseVisualStyleBackColor = false;
            this.chkAdmin.CheckedChanged += new System.EventHandler(this.chkAdmin_CheckedChanged);
            // 
            // chkSettings
            // 
            this.chkSettings.AutoSize = true;
            this.chkSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSettings.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.chkSettings.ForeColor = System.Drawing.Color.Black;
            this.chkSettings.Location = new System.Drawing.Point(277, 15);
            this.chkSettings.Name = "chkSettings";
            this.chkSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSettings.Size = new System.Drawing.Size(127, 29);
            this.chkSettings.TabIndex = 58;
            this.chkSettings.Text = "اعدادات المنظومة";
            this.chkSettings.UseVisualStyleBackColor = true;
            this.chkSettings.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // chkUsers
            // 
            this.chkUsers.AutoSize = true;
            this.chkUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkUsers.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.chkUsers.ForeColor = System.Drawing.Color.Black;
            this.chkUsers.Location = new System.Drawing.Point(413, 15);
            this.chkUsers.Name = "chkUsers";
            this.chkUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkUsers.Size = new System.Drawing.Size(123, 29);
            this.chkUsers.TabIndex = 57;
            this.chkUsers.Text = "ادارة المستخدمين";
            this.chkUsers.UseVisualStyleBackColor = true;
            this.chkUsers.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // chkPrint
            // 
            this.chkPrint.AutoSize = true;
            this.chkPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPrint.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.chkPrint.ForeColor = System.Drawing.Color.Black;
            this.chkPrint.Location = new System.Drawing.Point(548, 15);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPrint.Size = new System.Drawing.Size(107, 29);
            this.chkPrint.TabIndex = 56;
            this.chkPrint.Text = "طباعة التقارير";
            this.chkPrint.UseVisualStyleBackColor = true;
            this.chkPrint.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // chkInsert
            // 
            this.chkInsert.AutoSize = true;
            this.chkInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkInsert.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.chkInsert.ForeColor = System.Drawing.Color.Black;
            this.chkInsert.Location = new System.Drawing.Point(778, 15);
            this.chkInsert.Name = "chkInsert";
            this.chkInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkInsert.Size = new System.Drawing.Size(102, 29);
            this.chkInsert.TabIndex = 54;
            this.chkInsert.Text = "اضافة بيانات";
            this.chkInsert.UseVisualStyleBackColor = true;
            this.chkInsert.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picAdd);
            this.panel2.Controls.Add(this.picDelete);
            this.panel2.Controls.Add(this.picRefresh);
            this.panel2.Controls.Add(this.picUpdate);
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 287);
            this.panel2.TabIndex = 952;
            // 
            // picAdd
            // 
            this.picAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdd.Image = global::ArchiveProject1.Properties.Resources.following;
            this.picAdd.Location = new System.Drawing.Point(19, 8);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(63, 60);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdd.TabIndex = 800;
            this.picAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.picAdd, "اضافة");
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // picDelete
            // 
            this.picDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDelete.Image = global::ArchiveProject1.Properties.Resources.delete_user;
            this.picDelete.Location = new System.Drawing.Point(19, 146);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(63, 60);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDelete.TabIndex = 799;
            this.picDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.picDelete, "حذف");
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Image = global::ArchiveProject1.Properties.Resources.refresh_button;
            this.picRefresh.Location = new System.Drawing.Point(19, 215);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(63, 60);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRefresh.TabIndex = 798;
            this.picRefresh.TabStop = false;
            this.toolTip1.SetToolTip(this.picRefresh, "تحديث");
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // picUpdate
            // 
            this.picUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUpdate.Image = global::ArchiveProject1.Properties.Resources.update;
            this.picUpdate.Location = new System.Drawing.Point(19, 77);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(63, 60);
            this.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUpdate.TabIndex = 797;
            this.picUpdate.TabStop = false;
            this.toolTip1.SetToolTip(this.picUpdate, "تعديل");
            this.picUpdate.Click += new System.EventHandler(this.picUpdate_Click);
            // 
            // pnlPermissions
            // 
            this.pnlPermissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.pnlPermissions.Controls.Add(this.chkAdmin);
            this.pnlPermissions.Controls.Add(this.chkSettings);
            this.pnlPermissions.Controls.Add(this.chkUsers);
            this.pnlPermissions.Controls.Add(this.chkPrint);
            this.pnlPermissions.Controls.Add(this.chkUpdate);
            this.pnlPermissions.Controls.Add(this.chkInsert);
            this.pnlPermissions.Location = new System.Drawing.Point(126, 226);
            this.pnlPermissions.Name = "pnlPermissions";
            this.pnlPermissions.Size = new System.Drawing.Size(923, 56);
            this.pnlPermissions.TabIndex = 950;
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkUpdate.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.chkUpdate.ForeColor = System.Drawing.Color.Black;
            this.chkUpdate.Location = new System.Drawing.Point(664, 15);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkUpdate.Size = new System.Drawing.Size(108, 29);
            this.chkUpdate.TabIndex = 55;
            this.chkUpdate.Text = "تعديل البيانات";
            this.chkUpdate.UseVisualStyleBackColor = true;
            this.chkUpdate.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(355, 49);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserName.Size = new System.Drawing.Size(219, 34);
            this.txtUserName.TabIndex = 229;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtUserPassword.ForeColor = System.Drawing.Color.Black;
            this.txtUserPassword.Location = new System.Drawing.Point(37, 49);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserPassword.Size = new System.Drawing.Size(219, 34);
            this.txtUserPassword.TabIndex = 226;
            this.txtUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(265, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 225;
            this.label3.Text = "كلمة المرور";
            // 
            // txtUserJob
            // 
            this.txtUserJob.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.txtUserJob.ForeColor = System.Drawing.Color.Black;
            this.txtUserJob.Location = new System.Drawing.Point(355, 117);
            this.txtUserJob.Name = "txtUserJob";
            this.txtUserJob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserJob.Size = new System.Drawing.Size(219, 34);
            this.txtUserJob.TabIndex = 224;
            this.txtUserJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(615, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 223;
            this.label2.Text = "الوظيفة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(579, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 222;
            this.label1.Text = "اسم المستخدم";
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.Controls.Add(this.txtUserName);
            this.grpUserInfo.Controls.Add(this.BtnResetPass);
            this.grpUserInfo.Controls.Add(this.txtUserPassword);
            this.grpUserInfo.Controls.Add(this.label3);
            this.grpUserInfo.Controls.Add(this.txtUserJob);
            this.grpUserInfo.Controls.Add(this.label2);
            this.grpUserInfo.Controls.Add(this.label1);
            this.grpUserInfo.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.grpUserInfo.ForeColor = System.Drawing.Color.White;
            this.grpUserInfo.Location = new System.Drawing.Point(334, 4);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpUserInfo.Size = new System.Drawing.Size(715, 199);
            this.grpUserInfo.TabIndex = 951;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "بيانات المستخدم";
            // 
            // BtnResetPass
            // 
            this.BtnResetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.BtnResetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResetPass.FlatAppearance.BorderSize = 2;
            this.BtnResetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetPass.ForeColor = System.Drawing.Color.Black;
            this.BtnResetPass.Location = new System.Drawing.Point(37, 117);
            this.BtnResetPass.Name = "BtnResetPass";
            this.BtnResetPass.Size = new System.Drawing.Size(219, 34);
            this.BtnResetPass.TabIndex = 228;
            this.BtnResetPass.Text = "ضبط كلمة المرور";
            this.toolTip1.SetToolTip(this.BtnResetPass, "ضبط كلمة المرور الى: 0000");
            this.BtnResetPass.UseVisualStyleBackColor = false;
            this.BtnResetPass.Click += new System.EventHandler(this.BtnResetPass_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "OpenFileDialog1";
            // 
            // btnLoadPic
            // 
            this.btnLoadPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnLoadPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPic.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.btnLoadPic.ForeColor = System.Drawing.Color.Black;
            this.btnLoadPic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadPic.Location = new System.Drawing.Point(126, 16);
            this.btnLoadPic.Name = "btnLoadPic";
            this.btnLoadPic.Size = new System.Drawing.Size(184, 48);
            this.btnLoadPic.TabIndex = 954;
            this.btnLoadPic.Text = "تحميل الصورة";
            this.btnLoadPic.UseVisualStyleBackColor = false;
            // 
            // picUser
            // 
            this.picUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUser.Location = new System.Drawing.Point(127, 68);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(183, 134);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 953;
            this.picUser.TabStop = false;
            this.picUser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picUser_MouseUp);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "منظومة الارشفة";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "إشعار";
            this.notifyIcon1.Visible = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowDrop = true;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.UserName,
            this.UserPassword,
            this.UserJob,
            this.Id,
            this.column5});
            this.dgvUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.Gray;
            this.dgvUsers.Location = new System.Drawing.Point(0, 304);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 102;
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1074, 278);
            this.dgvUsers.TabIndex = 955;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            this.dgvUsers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_ColumnHeaderMouseClick);
            this.dgvUsers.Sorted += new System.EventHandler(this.dgvUsers_Sorted);
            this.dgvUsers.Click += new System.EventHandler(this.dgvUsers_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 35.53299F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ت";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "إسم المستخدم";
            this.UserName.MinimumWidth = 12;
            this.UserName.Name = "UserName";
            // 
            // UserPassword
            // 
            this.UserPassword.HeaderText = "كلمة المرور";
            this.UserPassword.MinimumWidth = 12;
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserJob
            // 
            this.UserJob.HeaderText = "الوظيفة";
            this.UserJob.MinimumWidth = 12;
            this.UserJob.Name = "UserJob";
            // 
            // Id
            // 
            this.Id.HeaderText = "رقم التسجيل";
            this.Id.MinimumWidth = 12;
            this.Id.Name = "Id";
            // 
            // column5
            // 
            this.column5.HeaderText = "الصورة";
            this.column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.column5.MinimumWidth = 12;
            this.column5.Name = "column5";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeletePicture});
            this.contextMenuStrip1.Name = "ContextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            // 
            // cmsDeletePicture
            // 
            this.cmsDeletePicture.Name = "cmsDeletePicture";
            this.cmsDeletePicture.Size = new System.Drawing.Size(136, 22);
            this.cmsDeletePicture.Text = "مسح الصورة";
            this.cmsDeletePicture.Click += new System.EventHandler(this.cmsDeletePicture_Click);
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1074, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlPermissions);
            this.Controls.Add(this.grpUserInfo);
            this.Controls.Add(this.btnLoadPic);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.dgvUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المستخدمين";
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            this.HandleCreated += new System.EventHandler(this.FrmMain_HandleCreated);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            this.pnlPermissions.ResumeLayout(false);
            this.pnlPermissions.PerformLayout();
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.CheckBox chkAdmin;
        internal System.Windows.Forms.CheckBox chkSettings;
        internal System.Windows.Forms.CheckBox chkUsers;
        internal System.Windows.Forms.CheckBox chkPrint;
        internal System.Windows.Forms.CheckBox chkInsert;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.PictureBox picAdd;
        internal System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.PictureBox picDelete;
        internal System.Windows.Forms.PictureBox picRefresh;
        internal System.Windows.Forms.PictureBox picUpdate;
        internal System.Windows.Forms.Panel pnlPermissions;
        internal System.Windows.Forms.CheckBox chkUpdate;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.TextBox txtUserPassword;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtUserJob;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.GroupBox grpUserInfo;
        internal System.Windows.Forms.Button BtnResetPass;
        internal System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.Button btnLoadPic;
        internal System.Windows.Forms.PictureBox picUser;
        internal System.Windows.Forms.NotifyIcon notifyIcon1;
        internal System.Windows.Forms.DataGridView dgvUsers;
        internal System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem cmsDeletePicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewImageColumn column5;
    }
}
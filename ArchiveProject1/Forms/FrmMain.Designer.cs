namespace ArchiveProject1.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssLblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSetings = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnOutter = new System.Windows.Forms.Button();
            this.btnInner = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.picUser = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.statusStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLblDateTime,
            this.tssLblUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(964, 27);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "StatusStrip1";
            // 
            // tssLblDateTime
            // 
            this.tssLblDateTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssLblDateTime.ForeColor = System.Drawing.Color.Black;
            this.tssLblDateTime.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.tssLblDateTime.Name = "tssLblDateTime";
            this.tssLblDateTime.Size = new System.Drawing.Size(133, 22);
            this.tssLblDateTime.Text = "TssLblDateTime";
            // 
            // tssLblUser
            // 
            this.tssLblUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssLblUser.ForeColor = System.Drawing.Color.Black;
            this.tssLblUser.Margin = new System.Windows.Forms.Padding(700, 4, 0, 2);
            this.tssLblUser.Name = "tssLblUser";
            this.tssLblUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tssLblUser.Size = new System.Drawing.Size(97, 21);
            this.tssLblUser.Text = "TssLblUser";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "document (3).png");
            this.imageList1.Images.SetKeyName(1, "file (1).png");
            this.imageList1.Images.SetKeyName(2, "document (2).png");
            this.imageList1.Images.SetKeyName(3, "file.png");
            this.imageList1.Images.SetKeyName(4, "document (1).png");
            this.imageList1.Images.SetKeyName(5, "document.png");
            this.imageList1.Images.SetKeyName(6, "files-and-folders.png");
            this.imageList1.Images.SetKeyName(7, "file-storage.png");
            this.imageList1.Images.SetKeyName(8, "mail (1).png");
            this.imageList1.Images.SetKeyName(9, "mail.png");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "تم اخذ النسخة الاحتياطية بنجاح";
            this.notifyIcon1.BalloonTipTitle = "النسخ الاحتياطي";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "NotifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnChangePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Image = global::ArchiveProject1.Properties.Resources.reset_password;
            this.btnChangePass.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangePass.Location = new System.Drawing.Point(0, 420);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(130, 131);
            this.btnChangePass.TabIndex = 48;
            this.btnChangePass.Text = "تغيير كلمة المرور";
            this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Hacen Saudi Arabia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = global::ArchiveProject1.Properties.Resources.report;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReports.Location = new System.Drawing.Point(94, 136);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(232, 178);
            this.btnReports.TabIndex = 47;
            this.btnReports.Text = "التــقــاريــر";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnSetings
            // 
            this.btnSetings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSetings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetings.FlatAppearance.BorderSize = 0;
            this.btnSetings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSetings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.btnSetings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetings.Font = new System.Drawing.Font("Hacen Saudi Arabia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetings.ForeColor = System.Drawing.Color.White;
            this.btnSetings.Image = global::ArchiveProject1.Properties.Resources.gear__1_;
            this.btnSetings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetings.Location = new System.Drawing.Point(208, 342);
            this.btnSetings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetings.Name = "btnSetings";
            this.btnSetings.Size = new System.Drawing.Size(232, 178);
            this.btnSetings.TabIndex = 46;
            this.btnSetings.Text = "إعــدادت الـنـظـام";
            this.btnSetings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSetings.UseVisualStyleBackColor = true;
            this.btnSetings.Click += new System.EventHandler(this.btnSetings_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Hacen Saudi Arabia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::ArchiveProject1.Properties.Resources.gear;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.Location = new System.Drawing.Point(514, 342);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(266, 178);
            this.btnUsers.TabIndex = 45;
            this.btnUsers.Text = "إدارة بـيــانــات المــستـخدمـيـن";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnOutter
            // 
            this.btnOutter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOutter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutter.FlatAppearance.BorderSize = 0;
            this.btnOutter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnOutter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.btnOutter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutter.Font = new System.Drawing.Font("Hacen Saudi Arabia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutter.ForeColor = System.Drawing.Color.White;
            this.btnOutter.Image = global::ArchiveProject1.Properties.Resources.outbox;
            this.btnOutter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOutter.Location = new System.Drawing.Point(362, 136);
            this.btnOutter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOutter.Name = "btnOutter";
            this.btnOutter.Size = new System.Drawing.Size(232, 178);
            this.btnOutter.TabIndex = 44;
            this.btnOutter.Text = "ارشفة الـبـريــد الصــادر";
            this.btnOutter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOutter.UseVisualStyleBackColor = true;
            this.btnOutter.Click += new System.EventHandler(this.btnOutter_Click);
            // 
            // btnInner
            // 
            this.btnInner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInner.FlatAppearance.BorderSize = 0;
            this.btnInner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnInner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.btnInner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInner.Font = new System.Drawing.Font("Hacen Saudi Arabia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInner.ForeColor = System.Drawing.Color.White;
            this.btnInner.Image = global::ArchiveProject1.Properties.Resources.email__2_;
            this.btnInner.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInner.Location = new System.Drawing.Point(631, 136);
            this.btnInner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInner.Name = "btnInner";
            this.btnInner.Size = new System.Drawing.Size(232, 178);
            this.btnInner.TabIndex = 43;
            this.btnInner.Text = "ارشـفـة البـريــد الــوارد";
            this.btnInner.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInner.UseVisualStyleBackColor = true;
            this.btnInner.Click += new System.EventHandler(this.btnInner_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(9, 4);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(121, 109);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 49;
            this.picUser.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(964, 581);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnSetings);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnOutter);
            this.Controls.Add(this.btnInner);
            this.Controls.Add(this.picUser);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "منظومة ارشفة البريد الصادر والوارد والملفات";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel tssLblDateTime;
        internal System.Windows.Forms.ToolStripStatusLabel tssLblUser;
        internal System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.NotifyIcon notifyIcon1;
        internal System.Windows.Forms.Button btnChangePass;
        internal System.Windows.Forms.Button btnReports;
        internal System.Windows.Forms.Button btnSetings;
        internal System.Windows.Forms.Button btnUsers;
        internal System.Windows.Forms.Button btnOutter;
        internal System.Windows.Forms.Button btnInner;
        internal System.Windows.Forms.Timer timer2;
        internal System.Windows.Forms.PictureBox picUser;
    }
}
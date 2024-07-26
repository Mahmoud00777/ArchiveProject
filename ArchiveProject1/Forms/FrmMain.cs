using ArchiveProject1.Classes;
using ArchiveProject1.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ArchiveProject1.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        ResizeControls r = new ResizeControls();
        private void FrmMain_HandleCreated(object sender, EventArgs e)
        {
            r.Container = this;
        }
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            r.ResizeControl();
            tssLblUser.Margin = new Padding(this.Width - (tssLblUser.Width + tssLblDateTime.Width + 50), 5, 0, 5);
        }
        public void FrmMain_Load(object sender, EventArgs e)
        {
          
            if (VariablesClass.usersPermission == false)
            {
                btnUsers.Visible = false;
            }
            if (VariablesClass.settingsPermission == false)
            {
                btnSetings.Visible = false;
            }


            tssLblDateTime.Text = Convert.ToString(DateTime.Now.Date) + " - " + DateTime.Now.TimeOfDay.ToString();
            tssLblUser.Text = " المستخدم  : " + VariablesClass.userName + " - " + VariablesClass.userJob;
            tssLblUser.Margin = new Padding(this.Width - (tssLblUser.Width + tssLblDateTime.Width + 50), 5, 0, 5);
            setFormSize();
        }
        void setFormSize()
        {
            if (Settings.Default.FrmMainWindowState == (int)FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
            {
                this.Size = Settings.Default.FrmMainSize;
                this.Location = Settings.Default.FrmMainLocation;
            }
        }
        private void btnOutter_Click(object sender, EventArgs e)
        {
            FrmOutter frmOutter = new FrmOutter();
            frmOutter.ShowDialog();
        }
        private void btnInner_Click(object sender, EventArgs e)
        {
            FrmInner frmInner = new FrmInner();
            frmInner.ShowDialog();
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            FrmUsers frmUsers = new FrmUsers();
            frmUsers.ShowDialog();
        }
        private void btnSetings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.ShowDialog();
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            FrmReports frmReports = new FrmReports();
            frmReports.ShowDialog();
        }
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            FrmChangePassword frmChangePassword = new FrmChangePassword();
            frmChangePassword.ShowDialog();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VariablesClass.backupProcess == true)
            {
                MessageBox.Show("لا يمكن اغلاق المنظومة .. جاري أخذ نسخة احتياطية من قاعدة البيانات" + Environment.NewLine, "نسخ احتياطي  لقاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }

            if (MessageBox.Show("هل تريد إغلاق المنظومة", "تأكيد طلب إغلاق", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = true;

                if (Settings.Default.AutoBackup == true)
                    BackupDatabase();

                SaveFormSize();

                timer2.Enabled = true;
            }
            else
                e.Cancel = true;
        }

        void SaveFormSize()
        {
            if (this.WindowState == FormWindowState.Normal )
            {
                Settings.Default.FrmMainSize = this.Size;
                Settings.Default.FrmMainLocation = this.Location;
            }

            Settings.Default.FrmMainWindowState = (int)this.WindowState;
            Settings.Default.Save();
        }
        void BackupDatabase()
        {
            try
            {
                if (!Directory.Exists(Settings.Default.AutoBackupPath))
                {
                    Directory.CreateDirectory(Settings.Default.AutoBackupPath);
                    Settings.Default.BackupCounter = 0;
                    Settings.Default.Save();
                }

                ConClass.sqlQuery = "backup database " + Settings.Default.Database + " TO DISK ='" + Settings.Default.AutoBackupPath + @"\" + "(" + DateTime.Now.ToString("dd-MM-yyyy") + ")" + "Auto_" + Settings.Default.Database + "-" + (Settings.Default.BackupCounter + 1) + ".bak' WITH INIT";
                ConClass.cmd = new SqlCommand(ConClass.sqlQuery, ConClass.con);
                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();
                Settings.Default.BackupCounter = Settings.Default.BackupCounter + 1;
                Settings.Default.Save();

                ShowBackupInfo();
                DeleteBackupDays();
                DeleteBackupFiles();
            }

            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("فشل في أخذ نسخة احتياطية من قاعدة البيانات" + Environment.NewLine + ex.Message, "نسخ احتياطي  لقاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            }
        }
        void ShowBackupInfo()
        {
            var di = new DirectoryInfo(Settings.Default.AutoBackupPath);
            var fl = di.GetFileSystemInfos().ToList();
            string last = (from file in from file in fl select file orderby file.CreationTime descending select file).FirstOrDefault().FullName;
            var fi = new FileInfo(last);

            notifyIcon1.BalloonTipText += Environment.NewLine + fi.FullName + Environment.NewLine + "(" + fi.Length / 1024L / 1024L + " MBytes) " + Convert.ToString(fi.LastWriteTime);
            notifyIcon1.ShowBalloonTip(1);

            DriveInfo dri = 
                new DriveInfo(Path.GetPathRoot(Settings.Default.AutoBackupPath));

            if (dri.AvailableFreeSpace < fi.Length * 3L)
            {
                MessageBox.Show("المساحة المتاحة للنسخ الإحتياطي انتهت سيتم ايقاف النسخ الإحتياطي التلقائي ", "تحذير انخفاض مساحة القرص الصلب", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Settings.Default.AutoBackup = false;
                Settings.Default.Save();
            }
            else if (dri.AvailableFreeSpace < fi.Length * 6L)
            {
                MessageBox.Show("المساحة المتاحة للنسخ الإحتياطي لقواعد البيانات في القرص الصلب على وشك الانتهاء ", "تحذير انخفاض مساحة القرص الصلب", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        void DeleteBackupDays()
        {
            if (Settings.Default.BackupDays == 0)
                return;

            var di = new DirectoryInfo(Settings.Default.AutoBackupPath);

            foreach (FileInfo file in di.GetFiles("*.bak", SearchOption.TopDirectoryOnly))
            {
                if ((DateTime.Now - file.CreationTime).Days > Settings.Default.BackupDays)
                    file.Delete();
            }
        }
        void DeleteBackupFiles()
        {
            if (Settings.Default.BackupFiles == 0)
                return;

            var di = new DirectoryInfo(Settings.Default.AutoBackupPath);

            var fl = di.GetFiles("*.bak", SearchOption.TopDirectoryOnly);  /*var fl = di.GetFileSystemInfos().ToList();*/

            foreach (var ff in from file in from file in fl select file orderby file.CreationTime ascending select file)
            {
                if (di.GetFiles("*.bak", SearchOption.TopDirectoryOnly).Count() > Settings.Default.BackupFiles)
                    ff.Delete();
            }
        }
        //-----------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            tssLblDateTime.Text = DateTime.Now.ToString();
            tssLblDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt");
            tssLblDateTime.Text = DateTime.Now.ToString(Settings.Default.DateFormat + " h:mm:ss tt");
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.03;
            if (this.Opacity <= 0.2)
            {
                Environment.Exit(0);
            }
        }
    }
}

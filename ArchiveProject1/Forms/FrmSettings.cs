using ArchiveProject1.Classes;
using ArchiveProject1.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveProject1.Forms
{
    public partial class FrmSettings : Form
    {

        public FrmSettings()
        {
            InitializeComponent();
        }
        bool testCon = true;

        //SqlConnection ConTest;
        //var a = Directory.GetLogicalDrives();
        //cmbDrives.DataSource = a;


        ResizeControls r = new ResizeControls();
        private void FrmMain_HandleCreated(object sender, EventArgs e)
        {
            r.Container = this;
        }
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            r.ResizeControl();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {

            txtServer.Text = Settings.Default.Server;
            txtDatabase.Text = Settings.Default.Database;
            txtSQLUser.Text = Settings.Default.SQLLogin;
            txtSQLPassword.Text = Settings.Default.SQLPassword;

            txtAdminName.Text = Settings.Default.AdminName;
            txtAdminPass.Text = Settings.Default.AdminPassword;

            if (VariablesClass.userId != 1)
            {
                txtAdminName.ReadOnly = true;
                txtAdminName.UseSystemPasswordChar = true;
                txtAdminPass.ReadOnly = true;

                btnRestoeDatabase.Enabled = false;
            }

            txtCompany.Text = Settings.Default.Company;
            txtAutoBackupPath.Text = Settings.Default.AutoBackupPath;

            if (Settings.Default.BackupFiles == 0)
                chkFiles.Checked = true;
            else
                txtBackupFiles.Text = Settings.Default.BackupFiles.ToString();

            if (Settings.Default.BackupDays == 0)
                chkDays.Checked = true;
            else
                txtBackupDays.Text = Settings.Default.BackupDays.ToString();

            radYes.Checked = Settings.Default.AutoBackup;

            cmbDateFormat.Items.Add("dd-MM-yyyy");
            cmbDateFormat.Items.Add("dd.MM.yyyy");
            cmbDateFormat.Items.Add("dd/MM/yyyy");

            cmbDateFormat.Text = Settings.Default.DateFormat;
            txtDiskArchivePath.Text = Settings.Default.DiskArchivePath;

            ckbStartupSystem.Checked = Settings.Default.StartUp;
            txtBackupPath.Select();

            setFormSize();

        }
        void setFormSize()
        {
            FrmMain frmMain = Application.OpenForms.OfType<FrmMain>().FirstOrDefault();
            if (frmMain != null)
            {
                this.Size = frmMain.Size - new Size(0, 60);
                this.Left = frmMain.Left;
                this.Top = frmMain.Top + 30;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل تريد حفظ اعدادات النظام؟", "حفظ اعدادات النظام", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (Settings.Default.Server == txtServer.Text.Trim() & Settings.Default.Database == txtDatabase.Text.Trim() & Settings.Default.SQLLogin == txtSQLUser.Text.Trim() & Settings.Default.SQLPassword == txtSQLPassword.Text)
                    testCon = true;  //  bool testCon = true;
                else
                    btnTestConnection_Click(sender, e);

                if (testCon == false)
                {
                    MessageBox.Show("لا يمكن حفظ الإعدادات, خطأ في اعدادات الإتصال ", "خطأ في الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Settings.Default.Server = txtServer.Text.Trim();
                Settings.Default.Database = txtDatabase.Text.Trim();
                Settings.Default.SQLLogin = txtSQLUser.Text.Trim();
                Settings.Default.SQLPassword = txtSQLPassword.Text;

                Settings.Default.AdminName = txtAdminName.Text.Trim();
                Settings.Default.AdminPassword = txtAdminPass.Text;
                Settings.Default.Company = txtCompany.Text.Trim();
                // -------------------------------------------------
                Settings.Default.AutoBackup = radYes.Checked; // True Or False
                Settings.Default.AutoBackupPath = txtAutoBackupPath.Text; // D:\StudentBak
                //Settings.Default.BackupFiles = Convert.ToInt32(txtBackupFiles.Text);

                int backupFiles, backupDays;
                int.TryParse(txtBackupFiles.Text, out backupFiles);
                Settings.Default.BackupFiles = backupFiles;
                int.TryParse(txtBackupDays.Text, out backupDays);
                Settings.Default.BackupDays = backupDays;
                // --------------------------------------------------------
                Settings.Default.DateFormat = cmbDateFormat.Text;
                Settings.Default.DiskArchivePath = txtDiskArchivePath.Text;

                setStartup();
                Settings.Default.Save();

                //---------------Refresh FrmMain_Load---------------------------------------
                //FrmMain frmMain = Application.OpenForms.OfType<FrmMain>().FirstOrDefault();
                //if (frmMain != null)
                //    frmMain.FrmMain_Load(sender, e); // public void FrmMain_Load(object sender, EventArgs e)    //form.FrmMain_Load(sender, EventArgs.Empty);  
                //--------------------------------------------------------

                MessageBox.Show("تم حفظ اعدادات النظام بنجاح", "حفظ اعدادات النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }



        }
        void setStartup()
        {
            if (ckbStartupSystem.Checked == true)
            {
                Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true).SetValue(Application.ProductName, Application.ExecutablePath);
                Settings.Default.StartUp = true;
            }
            else
            {
                try
                {
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run\", true).DeleteValue(Application.ProductName, true);
                    Settings.Default.StartUp = false;
                }
                catch (Exception)
                {
                }
            }
        }
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            var newCon = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;Integrated Security=False;User Id=" + txtSQLUser.Text + ";Password=" + txtSQLPassword.Text + ";");
            var dt = new DataTable();
            try
            {
                ConClass.sqlQuery = "SELECT * FROM sys.databases WHERE name = '" + txtDatabase.Text + "'";
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, newCon);
                ConClass.da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("اسم قاعدة البيانات غير صحيح");
                    testCon = false;
                }
                else
                {
                    MessageBox.Show("The Connection Is True");
                    testCon = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("خطأ في اعدادات الإتصال " + Environment.NewLine + Environment.NewLine + ex.Message);
                testCon = false;
            }
        }

        private void btnBackupPath_Click(object sender, EventArgs e)
        {
            string DeskTopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath != @"C:\" & folderBrowserDialog1.SelectedPath != DeskTopPath)
                    txtBackupPath.Text = folderBrowserDialog1.SelectedPath;
                else
                    MessageBox.Show("The backup cannot be placed on the hard disk " + Environment.NewLine + @"'C:\'" + " directly or on the desktop");
            }
        }

        void backupDatabase()
        {
            try
            {
                ConClass.sqlQuery = "BACKUP DATABASE " + Settings.Default.Database + " TO DISK ='" + txtBackupPath.Text.Trim() + @"\" + txtBackupName.Text.Trim() + ".bak' WITH INIT";
                ConClass.cmd = new SqlCommand(ConClass.sqlQuery, ConClass.con);
                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();
                //Thread.Sleep(10000); //للشرح فقط 
                MessageBox.Show("تم اخذ النسخة الإحتياطية لقاعدة البيانات بنجاح", "Backup Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("فشل في اخذ النسخة الاحتياطية لقاعدة البيانات" + Environment.NewLine + ex.Message, "Backup Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAsyncBackup_Click(object sender, EventArgs e)
        {
            if (txtBackupPath.Text == "")
            {
                btnBackupPath.PerformClick();
                return;
            }
            if (txtBackupName.Text == "")
            {
                MessageBox.Show("Please insert Backup name", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBackupName.Focus();
                return;
            }

            Task task = new Task(backupDatabase);
            task.Start();

            lblWait.Visible = true;
            this.UseWaitCursor = true;
            VariablesClass.backupProcess = true;
            await task;
            VariablesClass.backupProcess = false;
            this.UseWaitCursor = false;
            lblWait.Visible = false;

            //backupDatabase();
        }

        private void btnRestoeDatabase_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Bakup files (*.Bak)|*.Bak|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ConClass.sqlQuery = "Use master Restore Database " + Settings.Default.Database + " From Disk= '" + ofd.FileName + "' WITH REPLACE";
                    //ConClass.sqlQuery = "Use master Restore Database StudentDB From Disk= 'D:\\bak\\test1.bak' WITH REPLACE";

                    ConClass.cmd = new SqlCommand(ConClass.sqlQuery, ConClass.con);
                    ConClass.con.Open();
                    ConClass.cmd.ExecuteNonQuery();
                    ConClass.con.Close();
                    MessageBox.Show("تم استعادة النسخة الإحتياطية من قواعد البيانات بنجاح", "انشاء نسخة أحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    ConClass.con.Close();
                    if (MessageBox.Show("تم ايقاف العملية " + Environment.NewLine + ex.Message, "استعادة نسخة أحتياطية", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.Retry)
                        btnRestoeDatabase_Click(sender, e);
                }
            }
        }

        private void btnAutoBackupPath_Click(object sender, EventArgs e)
        {
            string DeskTopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath != @"C:\" & folderBrowserDialog1.SelectedPath != DeskTopPath)
                {
                    txtAutoBackupPath.Text = folderBrowserDialog1.SelectedPath;
                }
                else
                {
                    //MessageBox.Show("لا يمكن وضع النسخة الإحتياطية على القرص الصلب" + Environment.NewLine + @"C:\" + "مباشرة أو على سطح المكتب");
                    MessageBox.Show("The backup cannot be placed on the hard disk " + Environment.NewLine + @"'C:\'" + " directly or on the desktop");
                }
            }
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkFiles_CheckedChanged(object sender, EventArgs e)
        {
            txtBackupFiles.Text = "";
            if (chkFiles.Checked)
                txtBackupFiles.Enabled = false;
            else
            {
                txtBackupFiles.Enabled = true;
                txtBackupFiles.Focus();
            }
        }

        private void chkDays_CheckedChanged(object sender, EventArgs e)
        {
            txtBackupDays.Text = "";
            if (chkDays.Checked)
                txtBackupDays.Enabled = false;
            else
            {
                txtBackupDays.Enabled = true;
                txtBackupDays.Focus();
            }
        }

        private void btnDiskArchivePath_Click(object sender, EventArgs e)
        {
            string DeskTopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath != @"C:\" & folderBrowserDialog1.SelectedPath != DeskTopPath)
                    txtDiskArchivePath.Text = folderBrowserDialog1.SelectedPath;
                else
                    MessageBox.Show("The backup cannot be placed on the hard disk " + Environment.NewLine + @"'C:\'" + " directly or on the desktop");
            }
        }
    }
}

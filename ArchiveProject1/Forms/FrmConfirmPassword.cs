using ArchiveProject1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveProject1.Forms
{
    public partial class FrmConfirmPassword : Form
    {
        public FrmConfirmPassword()
        {
            InitializeComponent();
        }

        private void FrmConfirmPassword_Load(object sender, EventArgs e)
        {
            txtPassword.Select();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == VariablesClass.userPassword)
            {
                this.Hide();
                FrmSettings frmSettingsControl = new FrmSettings();
                frmSettingsControl.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("كلمة المرور الحالية غير صحيحة " + Environment.NewLine + " أنت لست " + VariablesClass.userName, "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Text = "";
                txtPassword.Focus();
                return;
            }
        }
    }
}

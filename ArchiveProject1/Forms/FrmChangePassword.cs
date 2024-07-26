using ArchiveProject1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveProject1.Forms
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            txtUserName.Text = VariablesClass.userName;
            txtOldPass.Select();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "")
            {
                MessageBox.Show("يرجى ادخال كلمة المرور الحالية", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPass.Focus();
                return;
            }
            if (txtNewPass.Text == "")
            {
                MessageBox.Show("يرجى ادخال كلمة المرور الجديدة", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPass.Focus();
                return;
            }

            try
            {
                ConClass.sqlQuery = "UPDATE TblUsers SET UserPassword='" + txtNewPass.Text + "' WHERE Id=" + VariablesClass.userId;
                ConClass.cmd = new SqlCommand(ConClass.sqlQuery, ConClass.con);
                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();
                MessageBox.Show("تم تعديل كلمة المرور بنجاح", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VariablesClass.userPassword = txtNewPass.Text;
                this.Close();
            }
            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("خطأ اتصال" + Environment.NewLine + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtOldPass.UseSystemPasswordChar = false;
                txtNewPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtOldPass.UseSystemPasswordChar = true;
                txtNewPass.UseSystemPasswordChar = true;
            }
        }

        private void txtOldPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                txtNewPass.Focus();
            }
        }

        private void txtOldPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNewPass.Focus();
            }
        }

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            if (txtOldPass.Text != VariablesClass.userPassword)
            {
                txtOldPass.Text = "";
                txtOldPass.Focus();
                lblError.Visible = true;
            }
        }
        private void txtConfirmPass_Enter(object sender, EventArgs e)
        {
            txtNewPass_Enter(sender, e);
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtOldPass.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            txtOldPass.UseSystemPasswordChar = true;
            checkBox1.Checked = false;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = false;
        }
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = true;
            checkBox1.Checked = false;
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmPass.UseSystemPasswordChar = false;
        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmPass.UseSystemPasswordChar = true;
            checkBox1.Checked = false;
        }

       
    }
}

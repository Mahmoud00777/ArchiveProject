using ArchiveProject1.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ArchiveProject1.Forms
{
    public partial class FrmContacts : Form
    {
        public FrmContacts()
        {
            InitializeComponent();
        }
        DataTable dtContacts = new DataTable();
        int contactId = 0, cr = -1;
        private void FrmContacts_Load(object sender, EventArgs e)
        {
            getContacts();
        }
        private void getContacts()
        {
            try
            {
                dtContacts.Clear();
                dgvContacts.Rows.Clear();
                ConClass.sqlQuery = "SELECT * FROM TblContacts ORDER BY ContactName ASC";
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                ConClass.da.Fill(dtContacts);

                for (int i = 0; i <= dtContacts.Rows.Count - 1; i++)
                {
                    dgvContacts.Rows.Add();
                    dgvContacts.Rows[i].Cells[0].Value = dtContacts.Rows[i][0];
                    dgvContacts.Rows[i].Cells[1].Value = i + 1;
                    dgvContacts.Rows[i].Cells[2].Value = dtContacts.Rows[i][1];
                }
                dgvContacts.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال");
                this.Close();
            }
        }
        private void clearData()
        {
            contactId = 0;
            cr = -1;
            txtAddContact.Text = "";
            txtUpdateContact.Text = "";
            dgvContacts.ClearSelection();
        }

        private void dgvContacts_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContacts.CurrentRow == null) return;
                if (dgvContacts.CurrentRow.Index == dgvContacts.Rows.Count
                    | dgvContacts.Rows[dgvContacts.CurrentRow.Index].Cells[0].Value == null
                    | dgvContacts.Rows[dgvContacts.CurrentRow.Index].Selected == false)
                    return;
            }
            catch
            {
                return;
            }

            cr = dgvContacts.CurrentRow.Index;
            contactId = (int)dgvContacts.Rows[cr].Cells[0].Value;
            txtUpdateContact.Text = dgvContacts.Rows[cr].Cells[2].Value.ToString();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            if (txtAddContact.Text.Trim() == "")
                return;

            try
            {
                // -------------------شحن الاوامر-----------------
                ConClass.cmd = new SqlCommand("InsertContact", ConClass.con);
                ConClass.cmd.CommandType = CommandType.StoredProcedure;
                // -----------------------اضافة الباراميترات-------------
                SqlParameter param;
                param = new SqlParameter("@ContactName", txtAddContact.Text.Trim());
                ConClass.cmd.Parameters.Add(param);
                ConClass.cmd.Parameters.Add("@saveState", SqlDbType.Int).Direction = ParameterDirection.Output;
                // ------------------------التنفيذ-------------
                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();

                int saveState = (int)ConClass.cmd.Parameters["@saveState"].Value;
                if (saveState == 1)
                {
                    getContacts();
                    selectContact();
                    MessageBox.Show("تم الحفظ بنجاح", "اضافة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (saveState == 2)
                {
                    getContacts();
                    selectContact();
                    MessageBox.Show("ًلم يتم الحفظ اسم الجهة مسجل مسبقا", "اضافة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (saveState == 0)
                {
                    MessageBox.Show("لم يتم الحفظ، خطأ في تنفيذ العملية", "اضافة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void selectContact()
        {
            for (int i = 0; i <= dtContacts.Rows.Count - 1; i++)
            {
                if (txtAddContact.Text.Trim() == dtContacts.Rows[i][1].ToString())
                {
                    dgvContacts.Rows[i].Selected = true;
                    dgvContacts.FirstDisplayedScrollingRowIndex = i;
                    contactId = (int)dtContacts.Rows[i][0];
                    txtUpdateContact.Text = dtContacts.Rows[i][1].ToString();
                    cr = i;
                    txtAddContact.Text = "";
                    break;
                }
            }
        }


        private void picNew_Click(object sender, EventArgs e)
        {
            getContacts();
            clearData();
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            if (contactId == 0)
                return;

            if (MessageBox.Show("هل أنت متأكد تريد حذف الجهة", "تأكيد حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // -----------------شحن الأوامر------------------
                    ConClass.cmd = new SqlCommand("DeleteContact", ConClass.con);
                    ConClass.cmd.CommandType = CommandType.StoredProcedure;
                    // -----------------اضافة البارامترات-----------------
                    SqlParameter param;
                    param = new SqlParameter("@Id", contactId);
                    ConClass.cmd.Parameters.Add(param);
                    ConClass.cmd.Parameters.Add("@saveState", SqlDbType.Int).Direction = ParameterDirection.Output;
                    // -----------------التنفيذ----------------
                    ConClass.con.Open();
                    ConClass.cmd.ExecuteNonQuery();
                    ConClass.con.Close();

                    int saveState = (int)ConClass.cmd.Parameters["@saveState"].Value;
                    if (saveState == 1)
                    {
                        picNew_Click(sender, e);
                        MessageBox.Show("تم الحذف بنجاح", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (saveState == 2)
                    {
                        MessageBox.Show("لايمكن حذف الجهة لانه يوجد ملفات مؤرشفة لها", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        picNew_Click(sender, e);
                    }

                    else if (saveState == 0)
                    {
                        MessageBox.Show(" لم يتم الحفظ، خطأ في تنفيذ العملية", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    ConClass.con.Close();
                    MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picUpdate_Click(object sender, EventArgs e)
        {
            if (txtUpdateContact.Text.Trim() == "" | contactId == 0)
                return;

            try
            {
                ConClass.cmd = new SqlCommand("UpdateContact", ConClass.con);
                ConClass.cmd.CommandType = CommandType.StoredProcedure;

                var param = new SqlParameter[2];
                param[0] = new SqlParameter("@ID", contactId);
                param[1] = new SqlParameter("@ContactName", txtUpdateContact.Text.Trim());
                ConClass.cmd.Parameters.AddRange(param);
                ConClass.cmd.Parameters.Add("@saveState", SqlDbType.Int).Direction = ParameterDirection.Output;

                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();

                int saveState = (int)ConClass.cmd.Parameters["@saveState"].Value;
                if (saveState == 1)
                {
                    picNew_Click(sender, e);
                    MessageBox.Show("تم الحفظ بنجاح", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (saveState == 2)
                {
                    MessageBox.Show("لم يتم الحفظ اسم الجهة مسجل مسبقا", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (saveState == 0)
                {
                    MessageBox.Show(" لم يتم الحفظ، خطأ في تنفيذ العملية", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picNew_MouseEnter(object sender, EventArgs e)
        {
            picNew.SetBounds(picNew.Left - 5, picNew.Top - 5, picNew.Width + 10, picNew.Height + 10);
        }
        private void picNew_MouseLeave(object sender, EventArgs e)
        {
            picNew.SetBounds(picNew.Left + 5, picNew.Top + 5, picNew.Width - 10, picNew.Height - 10);
        }
        private void picAdd_MouseEnter(object sender, EventArgs e)
        {
            picAdd.SetBounds(picAdd.Left - 5, picAdd.Top - 5, picAdd.Width + 10, picAdd.Height + 10);
        }
        private void picAdd_MouseLeave(object sender, EventArgs e)
        {
            picAdd.SetBounds(picAdd.Left + 5, picAdd.Top + 5, picAdd.Width - 10, picAdd.Height - 10);
        }
        private void picUpdate_MouseEnter(object sender, EventArgs e)
        {
            picUpdate.SetBounds(picUpdate.Left - 5, picUpdate.Top - 5, picUpdate.Width + 10, picUpdate.Height + 10);
        }
        private void picUpdate_MouseLeave(object sender, EventArgs e)
        {
            picUpdate.SetBounds(picUpdate.Left + 5, picUpdate.Top + 5, picUpdate.Width - 10, picUpdate.Height - 10);
        }
        private void picDelete_MouseEnter(object sender, EventArgs e)
        {
            picDelete.SetBounds(picDelete.Left - 5, picDelete.Top - 5, picDelete.Width + 10, picDelete.Height + 10);
        }
        private void picDelete_MouseLeave(object sender, EventArgs e)
        {
            picDelete.SetBounds(picDelete.Left + 5, picDelete.Top + 5, picDelete.Width - 10, picDelete.Height - 10);
        }
        private void dgvContacts_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvContacts.SortOrder.ToString() == "Ascending")
                dtContacts.DefaultView.Sort = dgvContacts.SortedColumn.Name + " ASC";
            else if (dgvContacts.SortOrder.ToString() == "Descending")
                dtContacts.DefaultView.Sort = dgvContacts.SortedColumn.Name + " DESC";

            dtContacts = dtContacts.DefaultView.ToTable();
        }

        private void dgvContacts_Sorted(object sender, EventArgs e)
        {
            clearData();
        }
    }
}


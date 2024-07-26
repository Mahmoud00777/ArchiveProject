using ArchiveProject1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveProject1.Forms
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        ResizeControls r = new ResizeControls();
        DataTable dtReportsO = new DataTable();
        DataTable dtReportsI = new DataTable();
        DataTable dtContacts = new DataTable();
        string nameTable;
        bool o, i;
        private void FrmReports_HandleCreated(object sender, EventArgs e)
        {
            r.Container = this;
        }
        private void FrmReports_Resize(object sender, EventArgs e)
        {
            r.ResizeControl();
        }
        private void FrmReports_Load(object sender, EventArgs e)
        {
            setFormSize();
            getContacts();
            setCmbYear();
            
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (radOutter.Checked == true)
            {
                nameTable = "TblOutters";
                o = true;
                i = false;

                if (radSubject.Checked == true)
                {
                    getDateSubject();
                    fillDgvReportsOutter();
                }
                else if (radNum.Checked == true)
                {
                    getDateNum();
                    fillDgvReportsOutter();
                }
                else if (radContact.Checked == true)
                {
                    getDateContact();
                    fillDgvReportsOutter();
                }
                else if (radSendDate.Checked == true)
                {
                    getDateSend();
                    fillDgvReportsOutter();
                }
                else if (radRegDate.Checked == true)
                {
                    getDateReg();
                    fillDgvReportsOutter();
                }


            }
            else if (radInner.Checked == true)
            {
                nameTable = "TblInners";
                i = true;
                o = false;

                if (radSubject.Checked == true)
                {
                    getDateSubject();
                    fillDgvReportsInner();
                }
                else if (radNum.Checked == true)
                {
                    getDateNum();
                    fillDgvReportsInner();
                }
                else if (radContact.Checked == true)
                {
                    getDateContact();
                    fillDgvReportsInner();
                }
                else if (radSendDate.Checked == true)
                {
                    getDateSend();
                    fillDgvReportsInner();
                }
                else if (radRegDate.Checked == true)
                {
                    getDateReg();
                    fillDgvReportsInner();
                }
                else if (radRecivedNum.Checked == true)
                {
                    getDateReciveNum();
                    fillDgvReportsInner();
                }

            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            clearText();
        }
        private void radInner_CheckedChanged(object sender, EventArgs e)
        {
            if (radOutter.Checked == true)
            {

            }
            else if (radInner.Checked == true)
            {

            }

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (radOutter.Checked == true)
            {
                var f = new FrmPrint();
                var c = new Reports.CrtPrintList();

                c.SetDataSource(dtReportsO);
                f.crystalReportViewer1.ReportSource = c;

                c.SetParameterValue("Title","الــبريــد الـصــادر");
                c.SetParameterValue("UserName",VariablesClass.userName);
                 
                f.crystalReportViewer1.Refresh();
                f.crystalReportViewer1.Zoom(100);
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
            else if (radInner.Checked == true)
            {
                var f = new FrmPrint();
                var c = new Reports.CrtPrintList();

                c.SetDataSource(dtReportsI);
                f.crystalReportViewer1.ReportSource = c;
                c.SetParameterValue("Title", "الــبـريـد الــوارد");
                c.SetParameterValue("UserName", VariablesClass.userName);


                f.crystalReportViewer1.Refresh();
                f.crystalReportViewer1.Zoom(100);
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        //******************************Function************************************************
        void getDateSubject()
        {
            try
            {
                dtReportsO.Clear();
                dtReportsI.Clear();
                ConClass.sqlQuery = "select " + nameTable + ".*,TblContacts.ContactName,UserName from " + nameTable + ",TblContacts,TblUsers  where TblContacts.Id=" + nameTable + ".ContactID and TblUsers.Id=" + nameTable + ".UserId and Subject like '%" + txtSubject.Text.Trim() + "%' ORDER BY YEAR DESC,Num ASC";
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                if (o == true)
                {
                    ConClass.da.Fill(dtReportsO);
                }
                else if (i == true)
                {
                    ConClass.da.Fill(dtReportsI);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void getDateNum()
        {
            try
            {
                dtReportsO.Clear();
                dtReportsI.Clear();
                ConClass.sqlQuery = "SELECT " + nameTable + ".*,TblContacts.ContactName,TblUsers.UserName FROM " + nameTable + ",TblContacts,TblUsers WHERE " + nameTable + ".ContactId=TblContacts.Id AND TblUsers.ID=" + nameTable + ".UserId AND Year=" + cmbYear.Text + " and Num=" + txtNum.Text.Trim() + " ORDER BY Year DESC, Num ASC";
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                if (o == true)
                {
                    ConClass.da.Fill(dtReportsO);
                }
                else if (i == true)
                {
                    ConClass.da.Fill(dtReportsI);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void getDateContact()
        {
            try
            {
                dtReportsO.Clear();
                dtReportsI.Clear();
                ConClass.sqlQuery = "SELECT " + nameTable + ".*,TblContacts.ContactName,TblUsers.UserName FROM " + nameTable + ",TblContacts,TblUsers  WHERE " + nameTable + ".ContactId=TblContacts.Id  AND TblUsers.ID=" + nameTable + ".UserId  AND TblContacts.ContactName='" + cmbContacts.Text + "' ORDER BY Year DESC, Num ASC";
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                if (o == true)
                {
                    ConClass.da.Fill(dtReportsO);
                }
                else if (i == true)
                {
                    ConClass.da.Fill(dtReportsI);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void getDateSend()
        {
            try
            {
                dtReportsO.Clear();
                dtReportsI.Clear();
                ConClass.sqlQuery = "SELECT " + nameTable + ".*,TblContacts.ContactName,TblUsers.UserName  FROM " + nameTable + ",TblContacts,TblUsers   WHERE " + nameTable + ".ContactId=TblContacts.Id   AND TblUsers.ID=" + nameTable + ".UserId   AND  SendDate BETWEEN '" + dtpSendFrom.Value.Date + "' AND '" + dtpSendTo.Value.Date + "' ORDER BY Year DESC, Num ASC";
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                if (o == true)
                {
                    ConClass.da.Fill(dtReportsO);
                }
                else if (i == true)
                {
                    ConClass.da.Fill(dtReportsI);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void getDateReg()
        {
            try
            {
                dtReportsO.Clear();
                dtReportsI.Clear();
                ConClass.sqlQuery = "SELECT " + nameTable + ".*,TblContacts.ContactName,TblUsers.UserName  FROM " + nameTable + ",TblContacts,TblUsers   WHERE " + nameTable + ".ContactId=TblContacts.Id   AND TblUsers.ID=" + nameTable + ".UserId   AND  SendDate BETWEEN '" + dtpRegFrom.Value.Date + "' AND '" + dtpRegTo.Value.Date + "' ORDER BY Year DESC, Num ASC";
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                if (o == true)
                {
                    ConClass.da.Fill(dtReportsO);
                }
                else if (i == true)
                {
                    ConClass.da.Fill(dtReportsI);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void getDateReciveNum()
        {
            try
            {
                dtReportsO.Clear();
                dtReportsI.Clear();
                ConClass.sqlQuery = "select " + nameTable + ".*,TblContacts.ContactName,UserName from " + nameTable + ",TblContacts,TblUsers  where TblContacts.Id=" + nameTable + ".ContactID and TblUsers.Id=" + nameTable + ".UserId and RecivedNum like '%" + txtRecivedNum.Text.Trim() + "%' ORDER BY YEAR DESC,Num ASC";
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                if (o == true)
                {
                    ConClass.da.Fill(dtReportsO);
                }
                else if (i == true)
                {
                    ConClass.da.Fill(dtReportsI);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void getContacts()
        {
            try
            {
                dtContacts.Clear();
                ConClass.sqlQuery = "SELECT * FROM TblContacts ORDER BY ContactName ASC";
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                ConClass.da.Fill(dtContacts);

                cmbContacts.DataSource = dtContacts;
                cmbContacts.DisplayMember = "ContactName";
                cmbContacts.ValueMember = "Id";
                cmbContacts.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        void setCmbYear()
        {
            cmbYear.Items.Clear();
            for (int i = DateTime.Now.Date.Year; i >= DateTime.Now.Date.Year - 10; i--)
            {
                cmbYear.Items.Add(i);

            }
            cmbYear.SelectedIndex = 0;
        }
        private void fillDgvReportsOutter()
        {

            dgvReport.Rows.Clear();
            for (int i = 0; i <= dtReportsO.Rows.Count - 1; i++)
            {
                dgvReport.Rows.Add();
                dgvReport.Rows[i].Cells[1].Value = dtReportsO.Rows[i][0];
                dgvReport.Rows[i].Cells[0].Value = i + 1;
                //dgvOutter.Rows[i].Cells[2].Value = string.Format(dtOutter.Rows[i][1].ToString(), "0000") + "/" + dtOutter.Rows[i][2];
                dgvReport.Rows[i].Cells[2].Value = dtReportsO.Rows[i][1].ToString() + "/" + dtReportsO.Rows[i][2];
                dgvReport.Rows[i].Cells[3].Value = dtReportsO.Rows[i][3];
                dgvReport.Rows[i].Cells[4].Value = dtReportsO.Rows[i][12];
                dgvReport.Rows[i].Cells[5].Value = dtReportsO.Rows[i][5];
                dgvReport.Rows[i].Cells[6].Value = dtReportsO.Rows[i][6];
                dgvReport.Rows[i].Cells[7].Value = dtReportsO.Rows[i][7].ToString() + dtReportsO.Rows[i][8].ToString();

                if (!(dtReportsO.Rows[i][9] is DBNull == true))
                {
                    byte[] img = (byte[])dtReportsO.Rows[i][9];
                    var ms = new MemoryStream(img);                   // using System.IO
                    dgvReport.Rows[i].Cells[8].Value = Image.FromStream(ms);
                }

                dgvReport.Rows[i].Cells[9].Value = dtReportsO.Rows[i][13];
            }
            dgvReport.ClearSelection();
        }
        private void fillDgvReportsInner()
        {

            dgvReport.Rows.Clear();
            for (int i = 0; i <= dtReportsI.Rows.Count - 1; i++)
            {
                dgvReport.Rows.Add();
                dgvReport.Rows[i].Cells[1].Value = dtReportsI.Rows[i][0];
                dgvReport.Rows[i].Cells[0].Value = i + 1;
                //dgvOutter.Rows[i].Cells[2].Value = string.Format(dtOutter.Rows[i][1].ToString(), "0000") + "/" + dtOutter.Rows[i][2];
                dgvReport.Rows[i].Cells[2].Value = dtReportsI.Rows[i][1].ToString() + "/" + dtReportsI.Rows[i][2];
                dgvReport.Rows[i].Cells[3].Value = dtReportsI.Rows[i][4];
                dgvReport.Rows[i].Cells[4].Value = dtReportsI.Rows[i][13];
                dgvReport.Rows[i].Cells[5].Value = dtReportsI.Rows[i][6];
                dgvReport.Rows[i].Cells[6].Value = dtReportsI.Rows[i][7];
                dgvReport.Rows[i].Cells[7].Value = dtReportsI.Rows[i][8].ToString() + dtReportsI.Rows[i][9].ToString();

                if (!(dtReportsI.Rows[i][10] is DBNull == true))
                {
                    byte[] img = (byte[])dtReportsI.Rows[i][10];
                    var ms = new MemoryStream(img);                   // using System.IO
                    dgvReport.Rows[i].Cells[8].Value = Image.FromStream(ms);
                }

                dgvReport.Rows[i].Cells[9].Value = dtReportsI.Rows[i][14];
            }
            dgvReport.ClearSelection();
        }
        void clearText()
        {
            dtReportsI.Clear();
            dtReportsO.Clear();
            nameTable = "";
            cmbContacts.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            txtNum.Text = "";
            txtRecivedNum.Text = "";
            txtSubject.Text = "";
            dtpSendFrom.Value = DateTime.Now;
            dtpSendTo.Value = DateTime.Now;
            dtpRegFrom.Value = DateTime.Now;
            dtpRegTo.Value = DateTime.Now;
            dgvReport.Rows.Clear();

        }
        //***************************************************************************



    }
}

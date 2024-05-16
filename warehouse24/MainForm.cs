using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using warehouse24.DataBase;
using warehouse24.Invoices;
using warehouse24.Models.ORM;
using warehouse24.ReportsWindows;

namespace warehouse24
{
    public partial class MainForm : Form

    {
        ORM orm = new ORM();
        public MainForm()
        {
            InitializeComponent();

        }

        private void ShowButton()
        {
            butConectDB.Visible = false;
            butInvoices.Visible = !butConectDB.Visible;
            butDataBase.Visible = !butConectDB.Visible;
            butReport.Visible = !butConectDB.Visible;

            toolStripStatusLabel2.Text = "Ready";
        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butConectDB_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(orm.cnnString))
                {
                    conn.Open();
                    if (conn != null)
                    {
                        ShowButton();
                        toolStripStatusLabel2.Text = "Connected To DB!!";
                    }
                    else
                    {

                        toolStripStatusLabel2.Text = "Disconnected to DB!!";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void butDataBase_Click(object sender, EventArgs e)
        {
            DataBaseForm dataBase = new DataBaseForm();
            dataBase.StartPosition = FormStartPosition.CenterScreen;
            dataBase.Show();
            this.Hide();
        }

        private void butInvoices_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceWindow = new InvoiceForm();
            invoiceWindow.Show();
            this.Hide();
        }

        private void butReport_Click(object sender, EventArgs e)
        {
            
            ReportsForm reportsWindows = new ReportsForm();
            reportsWindows.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

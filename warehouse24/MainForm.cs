﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using warehouse24.DataBase;
using warehouse24.Invoices;
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

            toolStripStatusLabel1.Text = "Ready!!";
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
                        toolStripStatusLabel1.Text = "Connected To DB!!";
                    }
                    else
                    {

                        toolStripStatusLabel1.Text = "Disconnected to DB!!";
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
            dataBase.ShowDialog();
        }

        private void butInvoices_Click(object sender, EventArgs e)
        {
            InvoiceWindow invoiceWindow = new InvoiceWindow();
            invoiceWindow.Show();
            this.Hide();
        }

        private void butReport_Click(object sender, EventArgs e)
        {
            
            ReportsWindow reportsWindows = new ReportsWindow();
            reportsWindows.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehouse24.Models.Classes;
using warehouse24.Models.ORM;

namespace warehouse24.DataBase
{
    public partial class ConsumerForm : Form
    {
        public ConsumerForm()
        {
            InitializeComponent();
        }

        private void labelCONSUMER_Click(object sender, EventArgs e)
        {

        }

        private void Consumer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouse24DataSet.Consumer' table. You can move, or remove it, as needed.
            this.consumerTableAdapter.Fill(this.warehouse24DataSet.Consumer);

        }

        private void butBackConsu_Click(object sender, EventArgs e)
        {
            DataBaseForm dataBase = new DataBaseForm();
            dataBase.StartPosition = FormStartPosition.CenterScreen;
            dataBase.Show();
            this.Hide();
        }

        private void butAddConsu_Click(object sender, EventArgs e)
        {
            if (textBoxConsumerName.Text != "")
            {
                string newconsumerName = textBoxConsumerName.Text;

                ORM orm = new ORM();
                orm.AddConsumer(newconsumerName);
                toolStripStatusLabel1.Text = newconsumerName + "HaS BEEN ADD";
                ConsumerForm consumer = new ConsumerForm();
                consumer.StartPosition = FormStartPosition.CenterScreen;
                consumer.Show();
                this.consumerTableAdapter.Fill(this.warehouse24DataSet.Consumer);
                this.Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Please Add the Consumer Name";
            }
        }

        private void butDeleteConsu_Click(object sender, EventArgs e)
        {
            if (textBoxConsumerName.Text != "")
            {
                string newconsumerName = textBoxConsumerName.Text;

                ORM orm = new ORM();
                orm.DeleteConsumer(newconsumerName);
                toolStripStatusLabel1.Text = newconsumerName + "HaS BEEN Deleted";
                ConsumerForm consumer = new ConsumerForm();
                consumer.StartPosition = FormStartPosition.CenterScreen;
                consumer.Show();
                this.consumerTableAdapter.Fill(this.warehouse24DataSet.Consumer);
                this.Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Please Add the Consumer Name That you want to Delete ";
            }

        }

        private void butEditConsu_Click(object sender, EventArgs e)
        {
            if (textBoxConsumerName.Text != "" && (int)numericUpDownId.Value != 0)
            {
                string newconsumerName = textBoxConsumerName.Text;
                int idconsumer = (int)numericUpDownId.Value;
                ORM orm = new ORM();
                orm.EditConsumer(idconsumer, newconsumerName);
                toolStripStatusLabel1.Text = newconsumerName + "HaS BEEN Edit";
                ConsumerForm consumer = new ConsumerForm();
                consumer.StartPosition = FormStartPosition.CenterScreen;
                this.consumerTableAdapter.Fill(this.warehouse24DataSet.Consumer);
                consumer.Show();
                this.Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Please Add the Consumer Name and ID";
            }
        }
    }
}

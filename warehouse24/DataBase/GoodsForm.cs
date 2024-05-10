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

namespace warehouse24.DataBase
{
    public partial class GoodsForm : Form
    {
        public GoodsForm()
        {
            InitializeComponent();
        }

        private void Goods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouse24DataSet.Goods' table. You can move, or remove it, as needed.
            this.goodsTableAdapter.Fill(this.warehouse24DataSet.Goods);

        }

        private void butGoods_Click(object sender, EventArgs e)
        {
            DataBaseForm dataBase = new DataBaseForm();
            dataBase.StartPosition = FormStartPosition.CenterScreen;
            dataBase.Show();
            this.Hide();
        }

        private void butImagePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }

        private void butAddGoods_Click(object sender, EventArgs e)
        {
            if (textBoxGoodsName.Text != "")
            {
                string newgoodsName = textBoxGoodsName.Text;

                ORM orm = new ORM();
                orm.AddGoods(newgoodsName);
                toolStripStatusLabel1.Text = newgoodsName + "HaS BEEN ADD";
                GoodsForm goods = new GoodsForm();
                goods.StartPosition = FormStartPosition.CenterScreen;
                goods.Show();
                this.Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Please Add the Goods Name";
            }
        }

        private void butDeleteGoods_Click(object sender, EventArgs e)
        {
            if (textBoxGoodsName.Text != "")
            {
                string newgoodsName = textBoxGoodsName.Text;

                ORM orm = new ORM();
                orm.DeleteGoods(newgoodsName);
                toolStripStatusLabel1.Text = newgoodsName + "HaS BEEN Deleted";
                GoodsForm goods = new GoodsForm();
                goods.StartPosition = FormStartPosition.CenterScreen;
                goods.Show();
                this.Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Please Add the WareHouse Name That you want to Delete ";
            }
        }

        private void butEditGoods_Click(object sender, EventArgs e)
        {
            if (textBoxGoodsName.Text != "" && (int)numericUpDownId.Value != 0)
            {
                string newgoodsName = textBoxGoodsName.Text;
                int idgoods = (int)numericUpDownId.Value;
                ORM orm = new ORM();
                orm.EditGoods(idgoods, newgoodsName);
                toolStripStatusLabel1.Text = newgoodsName + "HaS BEEN Edit";
                GoodsForm goods = new GoodsForm();
                goods.StartPosition = FormStartPosition.CenterScreen;
                goods.Show();
                this.Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Please Add the Goods Name and ID";
            }
        }
    }

       
    
}

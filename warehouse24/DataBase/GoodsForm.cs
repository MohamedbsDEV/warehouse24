using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Close();
        }

        private void butImagePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }
    }
}

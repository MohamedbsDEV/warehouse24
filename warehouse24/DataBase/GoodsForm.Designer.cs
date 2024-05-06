namespace warehouse24.DataBase
{
    partial class GoodsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.butAddGoods = new System.Windows.Forms.Button();
            this.butDeleteGoods = new System.Windows.Forms.Button();
            this.butc = new System.Windows.Forms.Button();
            this.labelGOODS = new System.Windows.Forms.Label();
            this.butGoods = new System.Windows.Forms.Button();
            this.labelGoodImage = new System.Windows.Forms.Label();
            this.pictureBoxGoods = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse24DataSet = new warehouse24.warehouse24DataSet();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxGoodsName = new System.Windows.Forms.TextBox();
            this.goodsTableAdapter = new warehouse24.warehouse24DataSetTableAdapters.GoodsTableAdapter();
            this.textBoxImagePath = new System.Windows.Forms.TextBox();
            this.butImagePath = new System.Windows.Forms.Button();
            this.textBoxSearchGoods = new System.Windows.Forms.TextBox();
            this.butSearchGoods = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownGoodCost = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoodCost)).BeginInit();
            this.SuspendLayout();
            // 
            // butAddGoods
            // 
            this.butAddGoods.BackColor = System.Drawing.Color.Transparent;
            this.butAddGoods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAddGoods.FlatAppearance.BorderSize = 0;
            this.butAddGoods.Location = new System.Drawing.Point(262, 359);
            this.butAddGoods.Name = "butAddGoods";
            this.butAddGoods.Size = new System.Drawing.Size(112, 40);
            this.butAddGoods.TabIndex = 0;
            this.butAddGoods.Text = "Add Goods";
            this.butAddGoods.UseVisualStyleBackColor = false;
            // 
            // butDeleteGoods
            // 
            this.butDeleteGoods.BackColor = System.Drawing.Color.Transparent;
            this.butDeleteGoods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butDeleteGoods.FlatAppearance.BorderSize = 0;
            this.butDeleteGoods.Location = new System.Drawing.Point(600, 359);
            this.butDeleteGoods.Name = "butDeleteGoods";
            this.butDeleteGoods.Size = new System.Drawing.Size(118, 40);
            this.butDeleteGoods.TabIndex = 1;
            this.butDeleteGoods.Text = "DeleteGoods";
            this.butDeleteGoods.UseVisualStyleBackColor = false;
            // 
            // butc
            // 
            this.butc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butc.FlatAppearance.BorderSize = 0;
            this.butc.Location = new System.Drawing.Point(426, 359);
            this.butc.Name = "butc";
            this.butc.Size = new System.Drawing.Size(120, 40);
            this.butc.TabIndex = 2;
            this.butc.Text = "Edit Goods";
            this.butc.UseVisualStyleBackColor = true;
            // 
            // labelGOODS
            // 
            this.labelGOODS.AutoSize = true;
            this.labelGOODS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGOODS.Location = new System.Drawing.Point(407, 9);
            this.labelGOODS.Name = "labelGOODS";
            this.labelGOODS.Size = new System.Drawing.Size(61, 16);
            this.labelGOODS.TabIndex = 3;
            this.labelGOODS.Text = "GOODS";
            // 
            // butGoods
            // 
            this.butGoods.BackColor = System.Drawing.Color.Transparent;
            this.butGoods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butGoods.FlatAppearance.BorderSize = 0;
            this.butGoods.Location = new System.Drawing.Point(13, 396);
            this.butGoods.Name = "butGoods";
            this.butGoods.Size = new System.Drawing.Size(75, 23);
            this.butGoods.TabIndex = 4;
            this.butGoods.Text = "Back";
            this.butGoods.UseVisualStyleBackColor = false;
            this.butGoods.Click += new System.EventHandler(this.butGoods_Click);
            // 
            // labelGoodImage
            // 
            this.labelGoodImage.AutoSize = true;
            this.labelGoodImage.Location = new System.Drawing.Point(631, 29);
            this.labelGoodImage.Name = "labelGoodImage";
            this.labelGoodImage.Size = new System.Drawing.Size(65, 13);
            this.labelGoodImage.TabIndex = 7;
            this.labelGoodImage.Text = "Good Image";
            // 
            // pictureBoxGoods
            // 
            this.pictureBoxGoods.Location = new System.Drawing.Point(498, 45);
            this.pictureBoxGoods.Name = "pictureBoxGoods";
            this.pictureBoxGoods.Size = new System.Drawing.Size(304, 156);
            this.pictureBoxGoods.TabIndex = 8;
            this.pictureBoxGoods.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.goodsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 200);
            this.dataGridView1.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // goodsBindingSource1
            // 
            this.goodsBindingSource1.DataMember = "Goods";
            this.goodsBindingSource1.DataSource = this.warehouse24DataSet;
            // 
            // warehouse24DataSet
            // 
            this.warehouse24DataSet.DataSetName = "warehouse24DataSet";
            this.warehouse24DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this.warehouse24DataSet;
            // 
            // textBoxGoodsName
            // 
            this.textBoxGoodsName.Location = new System.Drawing.Point(97, 279);
            this.textBoxGoodsName.Name = "textBoxGoodsName";
            this.textBoxGoodsName.Size = new System.Drawing.Size(299, 20);
            this.textBoxGoodsName.TabIndex = 10;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxImagePath
            // 
            this.textBoxImagePath.Location = new System.Drawing.Point(536, 238);
            this.textBoxImagePath.Name = "textBoxImagePath";
            this.textBoxImagePath.Size = new System.Drawing.Size(275, 20);
            this.textBoxImagePath.TabIndex = 14;
            // 
            // butImagePath
            // 
            this.butImagePath.Location = new System.Drawing.Point(441, 238);
            this.butImagePath.Name = "butImagePath";
            this.butImagePath.Size = new System.Drawing.Size(89, 23);
            this.butImagePath.TabIndex = 13;
            this.butImagePath.Text = "import image";
            this.butImagePath.UseVisualStyleBackColor = true;
            this.butImagePath.Click += new System.EventHandler(this.butImagePath_Click);
            // 
            // textBoxSearchGoods
            // 
            this.textBoxSearchGoods.Location = new System.Drawing.Point(94, 29);
            this.textBoxSearchGoods.Name = "textBoxSearchGoods";
            this.textBoxSearchGoods.Size = new System.Drawing.Size(316, 20);
            this.textBoxSearchGoods.TabIndex = 16;
            // 
            // butSearchGoods
            // 
            this.butSearchGoods.Location = new System.Drawing.Point(12, 29);
            this.butSearchGoods.Name = "butSearchGoods";
            this.butSearchGoods.Size = new System.Drawing.Size(76, 23);
            this.butSearchGoods.TabIndex = 15;
            this.butSearchGoods.Text = "Search";
            this.butSearchGoods.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Good name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Good  cost";
            // 
            // numericUpDownGoodCost
            // 
            this.numericUpDownGoodCost.Location = new System.Drawing.Point(97, 310);
            this.numericUpDownGoodCost.Name = "numericUpDownGoodCost";
            this.numericUpDownGoodCost.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownGoodCost.TabIndex = 19;
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 444);
            this.Controls.Add(this.numericUpDownGoodCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearchGoods);
            this.Controls.Add(this.butSearchGoods);
            this.Controls.Add(this.textBoxImagePath);
            this.Controls.Add(this.butImagePath);
            this.Controls.Add(this.textBoxGoodsName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBoxGoods);
            this.Controls.Add(this.labelGoodImage);
            this.Controls.Add(this.butGoods);
            this.Controls.Add(this.labelGOODS);
            this.Controls.Add(this.butc);
            this.Controls.Add(this.butDeleteGoods);
            this.Controls.Add(this.butAddGoods);
            this.Name = "GoodsForm";
            this.Text = "Goods";
            this.Load += new System.EventHandler(this.Goods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoodCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAddGoods;
        private System.Windows.Forms.Button butDeleteGoods;
        private System.Windows.Forms.Button butc;
        private System.Windows.Forms.Label labelGOODS;
        private System.Windows.Forms.Button butGoods;
        private System.Windows.Forms.Label labelGoodImage;
        private System.Windows.Forms.PictureBox pictureBoxGoods;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxGoodsName;
        private warehouse24DataSet warehouse24DataSet;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private warehouse24DataSetTableAdapters.GoodsTableAdapter goodsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxImagePath;
        private System.Windows.Forms.Button butImagePath;
        private System.Windows.Forms.TextBox textBoxSearchGoods;
        private System.Windows.Forms.Button butSearchGoods;
        private System.Windows.Forms.BindingSource goodsBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownGoodCost;
    }
}
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
            this.butEditGoods = new System.Windows.Forms.Button();
            this.labelGOODS = new System.Windows.Forms.Label();
            this.butBackGoods = new System.Windows.Forms.Button();
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
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            this.labelId = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoodCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.butAddGoods.Click += new System.EventHandler(this.butAddGoods_Click);
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
            this.butDeleteGoods.Text = "Delete Goods";
            this.butDeleteGoods.UseVisualStyleBackColor = false;
            this.butDeleteGoods.Click += new System.EventHandler(this.butDeleteGoods_Click);
            // 
            // butEditGoods
            // 
            this.butEditGoods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butEditGoods.FlatAppearance.BorderSize = 0;
            this.butEditGoods.Location = new System.Drawing.Point(426, 359);
            this.butEditGoods.Name = "butEditGoods";
            this.butEditGoods.Size = new System.Drawing.Size(120, 40);
            this.butEditGoods.TabIndex = 2;
            this.butEditGoods.Text = "Edit Goods";
            this.butEditGoods.UseVisualStyleBackColor = true;
            this.butEditGoods.Click += new System.EventHandler(this.butEditGoods_Click);
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
            // butBackGoods
            // 
            this.butBackGoods.BackColor = System.Drawing.Color.Transparent;
            this.butBackGoods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butBackGoods.FlatAppearance.BorderSize = 0;
            this.butBackGoods.Location = new System.Drawing.Point(13, 396);
            this.butBackGoods.Name = "butBackGoods";
            this.butBackGoods.Size = new System.Drawing.Size(75, 23);
            this.butBackGoods.TabIndex = 4;
            this.butBackGoods.Text = "Back";
            this.butBackGoods.UseVisualStyleBackColor = false;
            this.butBackGoods.Click += new System.EventHandler(this.butGoods_Click);
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
            this.pictureBoxGoods.Location = new System.Drawing.Point(553, 45);
            this.pictureBoxGoods.Name = "pictureBoxGoods";
            this.pictureBoxGoods.Size = new System.Drawing.Size(224, 156);
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
            this.numericUpDownGoodCost.Location = new System.Drawing.Point(94, 312);
            this.numericUpDownGoodCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownGoodCost.Name = "numericUpDownGoodCost";
            this.numericUpDownGoodCost.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownGoodCost.TabIndex = 19;
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(94, 349);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownId.TabIndex = 21;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(61, 351);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 20;
            this.labelId.Text = "Id";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(828, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Read!!";
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 444);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.numericUpDownId);
            this.Controls.Add(this.labelId);
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
            this.Controls.Add(this.butBackGoods);
            this.Controls.Add(this.labelGOODS);
            this.Controls.Add(this.butEditGoods);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAddGoods;
        private System.Windows.Forms.Button butDeleteGoods;
        private System.Windows.Forms.Button butEditGoods;
        private System.Windows.Forms.Label labelGOODS;
        private System.Windows.Forms.Button butBackGoods;
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
        private System.Windows.Forms.NumericUpDown numericUpDownId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
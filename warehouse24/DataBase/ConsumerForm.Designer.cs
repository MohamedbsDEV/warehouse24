﻿namespace warehouse24.DataBase
{
    partial class ConsumerForm
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
            this.butAddConsu = new System.Windows.Forms.Button();
            this.butEditConsu = new System.Windows.Forms.Button();
            this.butDeleteConsu = new System.Windows.Forms.Button();
            this.labelCONSUMER = new System.Windows.Forms.Label();
            this.butBackConsu = new System.Windows.Forms.Button();
            this.dataGridConsumer = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse24DataSet = new warehouse24.warehouse24DataSet();
            this.labelConsumrName = new System.Windows.Forms.Label();
            this.textBoxConsumerName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.butSearchConsumer = new System.Windows.Forms.Button();
            this.consumerTableAdapter = new warehouse24.warehouse24DataSetTableAdapters.ConsumerTableAdapter();
            this.consumerTableAdapter1 = new warehouse24.warehouse24DataSetTableAdapters.ConsumerTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelId = new System.Windows.Forms.Label();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            this.SuspendLayout();
            // 
            // butAddConsu
            // 
            this.butAddConsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAddConsu.FlatAppearance.BorderSize = 0;
            this.butAddConsu.Location = new System.Drawing.Point(13, 369);
            this.butAddConsu.Name = "butAddConsu";
            this.butAddConsu.Size = new System.Drawing.Size(110, 42);
            this.butAddConsu.TabIndex = 0;
            this.butAddConsu.Text = "Add Consumer";
            this.butAddConsu.UseVisualStyleBackColor = true;
            this.butAddConsu.Click += new System.EventHandler(this.butAddConsu_Click);
            // 
            // butEditConsu
            // 
            this.butEditConsu.BackColor = System.Drawing.Color.Transparent;
            this.butEditConsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butEditConsu.FlatAppearance.BorderSize = 0;
            this.butEditConsu.Location = new System.Drawing.Point(157, 369);
            this.butEditConsu.Name = "butEditConsu";
            this.butEditConsu.Size = new System.Drawing.Size(102, 42);
            this.butEditConsu.TabIndex = 2;
            this.butEditConsu.Text = "Edit Consumer";
            this.butEditConsu.UseVisualStyleBackColor = false;
            this.butEditConsu.Click += new System.EventHandler(this.butEditConsu_Click);
            // 
            // butDeleteConsu
            // 
            this.butDeleteConsu.BackColor = System.Drawing.Color.Transparent;
            this.butDeleteConsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butDeleteConsu.FlatAppearance.BorderSize = 0;
            this.butDeleteConsu.Location = new System.Drawing.Point(285, 369);
            this.butDeleteConsu.Name = "butDeleteConsu";
            this.butDeleteConsu.Size = new System.Drawing.Size(121, 42);
            this.butDeleteConsu.TabIndex = 3;
            this.butDeleteConsu.Text = "Delete Consumer";
            this.butDeleteConsu.UseVisualStyleBackColor = false;
            this.butDeleteConsu.Click += new System.EventHandler(this.butDeleteConsu_Click);
            // 
            // labelCONSUMER
            // 
            this.labelCONSUMER.AutoSize = true;
            this.labelCONSUMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCONSUMER.Location = new System.Drawing.Point(14, 18);
            this.labelCONSUMER.Name = "labelCONSUMER";
            this.labelCONSUMER.Size = new System.Drawing.Size(93, 16);
            this.labelCONSUMER.TabIndex = 4;
            this.labelCONSUMER.Text = "CONSUMER";
            this.labelCONSUMER.Click += new System.EventHandler(this.labelCONSUMER_Click);
            // 
            // butBackConsu
            // 
            this.butBackConsu.BackColor = System.Drawing.Color.Transparent;
            this.butBackConsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butBackConsu.FlatAppearance.BorderSize = 0;
            this.butBackConsu.Location = new System.Drawing.Point(12, 416);
            this.butBackConsu.Name = "butBackConsu";
            this.butBackConsu.Size = new System.Drawing.Size(105, 23);
            this.butBackConsu.TabIndex = 7;
            this.butBackConsu.Text = "Back";
            this.butBackConsu.UseVisualStyleBackColor = false;
            this.butBackConsu.Click += new System.EventHandler(this.butBackConsu_Click);
            // 
            // dataGridConsumer
            // 
            this.dataGridConsumer.AllowUserToOrderColumns = true;
            this.dataGridConsumer.AutoGenerateColumns = false;
            this.dataGridConsumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsumer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridConsumer.DataSource = this.consumerBindingSource;
            this.dataGridConsumer.Location = new System.Drawing.Point(17, 79);
            this.dataGridConsumer.Name = "dataGridConsumer";
            this.dataGridConsumer.Size = new System.Drawing.Size(408, 203);
            this.dataGridConsumer.TabIndex = 8;
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
            // consumerBindingSource
            // 
            this.consumerBindingSource.DataMember = "Consumer";
            this.consumerBindingSource.DataSource = this.warehouse24DataSet;
            // 
            // warehouse24DataSet
            // 
            this.warehouse24DataSet.DataSetName = "warehouse24DataSet";
            this.warehouse24DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelConsumrName
            // 
            this.labelConsumrName.AutoSize = true;
            this.labelConsumrName.Location = new System.Drawing.Point(48, 346);
            this.labelConsumrName.Name = "labelConsumrName";
            this.labelConsumrName.Size = new System.Drawing.Size(82, 13);
            this.labelConsumrName.TabIndex = 9;
            this.labelConsumrName.Text = "ConsumerName";
            // 
            // textBoxConsumerName
            // 
            this.textBoxConsumerName.Location = new System.Drawing.Point(136, 343);
            this.textBoxConsumerName.Name = "textBoxConsumerName";
            this.textBoxConsumerName.Size = new System.Drawing.Size(332, 20);
            this.textBoxConsumerName.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(349, 20);
            this.textBox2.TabIndex = 11;
            // 
            // butSearchConsumer
            // 
            this.butSearchConsumer.Location = new System.Drawing.Point(17, 49);
            this.butSearchConsumer.Name = "butSearchConsumer";
            this.butSearchConsumer.Size = new System.Drawing.Size(53, 24);
            this.butSearchConsumer.TabIndex = 12;
            this.butSearchConsumer.Text = "Search";
            this.butSearchConsumer.UseVisualStyleBackColor = true;
            // 
            // consumerTableAdapter
            // 
            this.consumerTableAdapter.ClearBeforeFill = true;
            // 
            // consumerTableAdapter1
            // 
            this.consumerTableAdapter1.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(546, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Read!!";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(84, 319);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 14;
            this.labelId.Text = "Id";
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(136, 317);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownId.TabIndex = 15;
            // 
            // ConsumerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(546, 479);
            this.Controls.Add(this.numericUpDownId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridConsumer);
            this.Controls.Add(this.butSearchConsumer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxConsumerName);
            this.Controls.Add(this.labelConsumrName);
            this.Controls.Add(this.butBackConsu);
            this.Controls.Add(this.labelCONSUMER);
            this.Controls.Add(this.butDeleteConsu);
            this.Controls.Add(this.butEditConsu);
            this.Controls.Add(this.butAddConsu);
            this.Name = "ConsumerForm";
            this.Text = "Consumer";
            this.Load += new System.EventHandler(this.Consumer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAddConsu;
        private System.Windows.Forms.Button butEditConsu;
        private System.Windows.Forms.Button butDeleteConsu;
        private System.Windows.Forms.Label labelCONSUMER;
        private System.Windows.Forms.Button butBackConsu;
        private System.Windows.Forms.DataGridView dataGridConsumer;
        private System.Windows.Forms.Label labelConsumrName;
        private System.Windows.Forms.TextBox textBoxConsumerName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button butSearchConsumer;
        private warehouse24DataSet warehouse24DataSet;
        private System.Windows.Forms.BindingSource consumerBindingSource;
        private warehouse24DataSetTableAdapters.ConsumerTableAdapter consumerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private warehouse24DataSetTableAdapters.ConsumerTableAdapter consumerTableAdapter1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
    }
}
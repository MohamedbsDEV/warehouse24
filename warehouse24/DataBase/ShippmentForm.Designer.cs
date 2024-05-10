namespace warehouse24.DataBase
{
    partial class ShippmentForm
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
            this.butEditShippment = new System.Windows.Forms.Button();
            this.butDeleteShippment = new System.Windows.Forms.Button();
            this.butAddShippment = new System.Windows.Forms.Button();
            this.labelSHIPMENT = new System.Windows.Forms.Label();
            this.butBack = new System.Windows.Forms.Button();
            this.dateTimePickerTimeShipment = new System.Windows.Forms.DateTimePicker();
            this.labelTimeShipment = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse24DataSet = new warehouse24.warehouse24DataSet();
            this.shipmentTableAdapter = new warehouse24.warehouse24DataSetTableAdapters.ShipmentTableAdapter();
            this.textBoxTariff = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxShippmentName = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butEditShippment
            // 
            this.butEditShippment.BackColor = System.Drawing.Color.Transparent;
            this.butEditShippment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butEditShippment.FlatAppearance.BorderSize = 0;
            this.butEditShippment.Location = new System.Drawing.Point(717, 129);
            this.butEditShippment.Name = "butEditShippment";
            this.butEditShippment.Size = new System.Drawing.Size(110, 36);
            this.butEditShippment.TabIndex = 5;
            this.butEditShippment.Text = "Edit Shippment";
            this.butEditShippment.UseVisualStyleBackColor = false;
            this.butEditShippment.Click += new System.EventHandler(this.butShippment_Click);
            // 
            // butDeleteShippment
            // 
            this.butDeleteShippment.BackColor = System.Drawing.Color.Transparent;
            this.butDeleteShippment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butDeleteShippment.FlatAppearance.BorderSize = 0;
            this.butDeleteShippment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butDeleteShippment.Location = new System.Drawing.Point(717, 195);
            this.butDeleteShippment.Name = "butDeleteShippment";
            this.butDeleteShippment.Size = new System.Drawing.Size(110, 36);
            this.butDeleteShippment.TabIndex = 4;
            this.butDeleteShippment.Text = "Delete Shippment";
            this.butDeleteShippment.UseVisualStyleBackColor = false;
            this.butDeleteShippment.Click += new System.EventHandler(this.butDeletShippment_Click);
            // 
            // butAddShippment
            // 
            this.butAddShippment.BackColor = System.Drawing.Color.Transparent;
            this.butAddShippment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAddShippment.FlatAppearance.BorderSize = 0;
            this.butAddShippment.Location = new System.Drawing.Point(717, 65);
            this.butAddShippment.Name = "butAddShippment";
            this.butAddShippment.Size = new System.Drawing.Size(110, 33);
            this.butAddShippment.TabIndex = 3;
            this.butAddShippment.Text = "Add Shippment";
            this.butAddShippment.UseVisualStyleBackColor = false;
            this.butAddShippment.Click += new System.EventHandler(this.butAddShipment_Click);
            // 
            // labelSHIPMENT
            // 
            this.labelSHIPMENT.AutoSize = true;
            this.labelSHIPMENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSHIPMENT.Location = new System.Drawing.Point(12, 9);
            this.labelSHIPMENT.Name = "labelSHIPMENT";
            this.labelSHIPMENT.Size = new System.Drawing.Size(79, 13);
            this.labelSHIPMENT.TabIndex = 6;
            this.labelSHIPMENT.Text = "SHIPPMENT";
            // 
            // butBack
            // 
            this.butBack.BackColor = System.Drawing.Color.Transparent;
            this.butBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butBack.FlatAppearance.BorderSize = 0;
            this.butBack.Location = new System.Drawing.Point(16, 370);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(84, 25);
            this.butBack.TabIndex = 7;
            this.butBack.Text = "Back";
            this.butBack.UseVisualStyleBackColor = false;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // dateTimePickerTimeShipment
            // 
            this.dateTimePickerTimeShipment.Location = new System.Drawing.Point(119, 308);
            this.dateTimePickerTimeShipment.Name = "dateTimePickerTimeShipment";
            this.dateTimePickerTimeShipment.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerTimeShipment.TabIndex = 12;
            // 
            // labelTimeShipment
            // 
            this.labelTimeShipment.AutoSize = true;
            this.labelTimeShipment.Location = new System.Drawing.Point(13, 311);
            this.labelTimeShipment.Name = "labelTimeShipment";
            this.labelTimeShipment.Size = new System.Drawing.Size(77, 13);
            this.labelTimeShipment.TabIndex = 13;
            this.labelTimeShipment.Text = "Time Shipment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.idcomDataGridViewTextBoxColumn,
            this.tariffDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shipmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 251);
            this.dataGridView1.TabIndex = 14;
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
            // idcomDataGridViewTextBoxColumn
            // 
            this.idcomDataGridViewTextBoxColumn.DataPropertyName = "id_com";
            this.idcomDataGridViewTextBoxColumn.HeaderText = "id_com";
            this.idcomDataGridViewTextBoxColumn.Name = "idcomDataGridViewTextBoxColumn";
            // 
            // tariffDataGridViewTextBoxColumn
            // 
            this.tariffDataGridViewTextBoxColumn.DataPropertyName = "tariff";
            this.tariffDataGridViewTextBoxColumn.HeaderText = "tariff";
            this.tariffDataGridViewTextBoxColumn.Name = "tariffDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // shipmentBindingSource
            // 
            this.shipmentBindingSource.DataMember = "Shipment";
            this.shipmentBindingSource.DataSource = this.warehouse24DataSet;
            // 
            // warehouse24DataSet
            // 
            this.warehouse24DataSet.DataSetName = "warehouse24DataSet";
            this.warehouse24DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shipmentTableAdapter
            // 
            this.shipmentTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxTariff
            // 
            this.textBoxTariff.Location = new System.Drawing.Point(476, 337);
            this.textBoxTariff.Name = "textBoxTariff";
            this.textBoxTariff.Size = new System.Drawing.Size(169, 20);
            this.textBoxTariff.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(476, 363);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tariff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Shippment Name";
            // 
            // textBoxShippmentName
            // 
            this.textBoxShippmentName.Location = new System.Drawing.Point(476, 311);
            this.textBoxShippmentName.Name = "textBoxShippmentName";
            this.textBoxShippmentName.Size = new System.Drawing.Size(169, 20);
            this.textBoxShippmentName.TabIndex = 21;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(67, 344);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 23;
            this.labelId.Text = "Id";
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(119, 337);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownId.TabIndex = 24;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(856, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Read!!";
            // 
            // ShippmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 428);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.numericUpDownId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxShippmentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxTariff);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTimeShipment);
            this.Controls.Add(this.dateTimePickerTimeShipment);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.labelSHIPMENT);
            this.Controls.Add(this.butEditShippment);
            this.Controls.Add(this.butDeleteShippment);
            this.Controls.Add(this.butAddShippment);
            this.Name = "ShippmentForm";
            this.Text = "Shipment";
            this.Load += new System.EventHandler(this.Shipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butEditShippment;
        private System.Windows.Forms.Button butDeleteShippment;
        private System.Windows.Forms.Button butAddShippment;
        private System.Windows.Forms.Label labelSHIPMENT;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeShipment;
        private System.Windows.Forms.Label labelTimeShipment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private warehouse24DataSet warehouse24DataSet;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
        private warehouse24DataSetTableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxTariff;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxShippmentName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
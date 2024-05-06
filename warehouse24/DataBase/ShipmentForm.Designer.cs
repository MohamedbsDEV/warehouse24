namespace warehouse24.DataBase
{
    partial class ShipmentForm
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
            this.butShipment = new System.Windows.Forms.Button();
            this.butDeletShipment = new System.Windows.Forms.Button();
            this.butAddShipment = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // butShipment
            // 
            this.butShipment.BackColor = System.Drawing.Color.Transparent;
            this.butShipment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butShipment.FlatAppearance.BorderSize = 0;
            this.butShipment.Location = new System.Drawing.Point(719, 184);
            this.butShipment.Name = "butShipment";
            this.butShipment.Size = new System.Drawing.Size(110, 42);
            this.butShipment.TabIndex = 5;
            this.butShipment.Text = "Edit Shipment";
            this.butShipment.UseVisualStyleBackColor = false;
            // 
            // butDeletShipment
            // 
            this.butDeletShipment.BackColor = System.Drawing.Color.Transparent;
            this.butDeletShipment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butDeletShipment.FlatAppearance.BorderSize = 0;
            this.butDeletShipment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butDeletShipment.Location = new System.Drawing.Point(719, 254);
            this.butDeletShipment.Name = "butDeletShipment";
            this.butDeletShipment.Size = new System.Drawing.Size(110, 36);
            this.butDeletShipment.TabIndex = 4;
            this.butDeletShipment.Text = "Delete Shipment";
            this.butDeletShipment.UseVisualStyleBackColor = false;
            // 
            // butAddShipment
            // 
            this.butAddShipment.BackColor = System.Drawing.Color.Transparent;
            this.butAddShipment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAddShipment.FlatAppearance.BorderSize = 0;
            this.butAddShipment.Location = new System.Drawing.Point(719, 111);
            this.butAddShipment.Name = "butAddShipment";
            this.butAddShipment.Size = new System.Drawing.Size(110, 33);
            this.butAddShipment.TabIndex = 3;
            this.butAddShipment.Text = "Add Shipment";
            this.butAddShipment.UseVisualStyleBackColor = false;
            // 
            // labelSHIPMENT
            // 
            this.labelSHIPMENT.AutoSize = true;
            this.labelSHIPMENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSHIPMENT.Location = new System.Drawing.Point(12, 9);
            this.labelSHIPMENT.Name = "labelSHIPMENT";
            this.labelSHIPMENT.Size = new System.Drawing.Size(71, 13);
            this.labelSHIPMENT.TabIndex = 6;
            this.labelSHIPMENT.Text = "SHIPMENT";
            // 
            // butBack
            // 
            this.butBack.BackColor = System.Drawing.Color.Transparent;
            this.butBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butBack.FlatAppearance.BorderSize = 0;
            this.butBack.Location = new System.Drawing.Point(16, 381);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(75, 23);
            this.butBack.TabIndex = 7;
            this.butBack.Text = "Back";
            this.butBack.UseVisualStyleBackColor = false;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // dateTimePickerTimeShipment
            // 
            this.dateTimePickerTimeShipment.Location = new System.Drawing.Point(119, 313);
            this.dateTimePickerTimeShipment.Name = "dateTimePickerTimeShipment";
            this.dateTimePickerTimeShipment.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerTimeShipment.TabIndex = 12;
            // 
            // labelTimeShipment
            // 
            this.labelTimeShipment.AutoSize = true;
            this.labelTimeShipment.Location = new System.Drawing.Point(13, 320);
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
            this.textBoxTariff.Location = new System.Drawing.Point(481, 339);
            this.textBoxTariff.Name = "textBoxTariff";
            this.textBoxTariff.Size = new System.Drawing.Size(230, 20);
            this.textBoxTariff.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(481, 384);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 20);
            this.textBox2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tariff";
            // 
            // ShipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 428);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxTariff);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTimeShipment);
            this.Controls.Add(this.dateTimePickerTimeShipment);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.labelSHIPMENT);
            this.Controls.Add(this.butShipment);
            this.Controls.Add(this.butDeletShipment);
            this.Controls.Add(this.butAddShipment);
            this.Name = "ShipmentForm";
            this.Text = "Shipment";
            this.Load += new System.EventHandler(this.Shipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butShipment;
        private System.Windows.Forms.Button butDeletShipment;
        private System.Windows.Forms.Button butAddShipment;
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
    }
}
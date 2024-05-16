namespace warehouse24.Invoices
{
    partial class InvoiceForm
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
            this.labelInvoice = new System.Windows.Forms.Label();
            this.labelConsumerName = new System.Windows.Forms.Label();
            this.labelGoodsName = new System.Windows.Forms.Label();
            this.labelShippmentCompanyCost = new System.Windows.Forms.Label();
            this.textBoxConsumerName = new System.Windows.Forms.TextBox();
            this.comboBoxGoods = new System.Windows.Forms.ComboBox();
            this.numericUpDownShippCost = new System.Windows.Forms.NumericUpDown();
            this.labelShippmentTo = new System.Windows.Forms.Label();
            this.textBoxShippmentTo = new System.Windows.Forms.TextBox();
            this.labelShippmentTime = new System.Windows.Forms.Label();
            this.dateTimePickerTimeShippment = new System.Windows.Forms.DateTimePicker();
            this.butBack = new System.Windows.Forms.Button();
            this.butInvoice = new System.Windows.Forms.Button();
            this.labelGoodsCount = new System.Windows.Forms.Label();
            this.numericUpDownGoodsCount = new System.Windows.Forms.NumericUpDown();
            this.labelTariff = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxShippmentCom = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxFromWarhouse = new System.Windows.Forms.ComboBox();
            this.labelFromWarehouse = new System.Windows.Forms.Label();
            this.textBoxTypeOfInvoices = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShippCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoodsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInvoice
            // 
            this.labelInvoice.AutoSize = true;
            this.labelInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvoice.Location = new System.Drawing.Point(12, 9);
            this.labelInvoice.Name = "labelInvoice";
            this.labelInvoice.Size = new System.Drawing.Size(61, 18);
            this.labelInvoice.TabIndex = 0;
            this.labelInvoice.Text = "Invoice";
            // 
            // labelConsumerName
            // 
            this.labelConsumerName.AutoSize = true;
            this.labelConsumerName.Location = new System.Drawing.Point(23, 84);
            this.labelConsumerName.Name = "labelConsumerName";
            this.labelConsumerName.Size = new System.Drawing.Size(85, 13);
            this.labelConsumerName.TabIndex = 1;
            this.labelConsumerName.Text = "Consumer Name";
            // 
            // labelGoodsName
            // 
            this.labelGoodsName.AutoSize = true;
            this.labelGoodsName.Location = new System.Drawing.Point(23, 121);
            this.labelGoodsName.Name = "labelGoodsName";
            this.labelGoodsName.Size = new System.Drawing.Size(41, 13);
            this.labelGoodsName.TabIndex = 2;
            this.labelGoodsName.Text = "Goods ";
            // 
            // labelShippmentCompanyCost
            // 
            this.labelShippmentCompanyCost.AutoSize = true;
            this.labelShippmentCompanyCost.Location = new System.Drawing.Point(24, 255);
            this.labelShippmentCompanyCost.Name = "labelShippmentCompanyCost";
            this.labelShippmentCompanyCost.Size = new System.Drawing.Size(81, 13);
            this.labelShippmentCompanyCost.TabIndex = 5;
            this.labelShippmentCompanyCost.Text = "Shippment Cost";
            // 
            // textBoxConsumerName
            // 
            this.textBoxConsumerName.Location = new System.Drawing.Point(159, 77);
            this.textBoxConsumerName.Name = "textBoxConsumerName";
            this.textBoxConsumerName.Size = new System.Drawing.Size(269, 20);
            this.textBoxConsumerName.TabIndex = 6;
            // 
            // comboBoxGoods
            // 
            this.comboBoxGoods.FormattingEnabled = true;
            this.comboBoxGoods.Location = new System.Drawing.Point(159, 113);
            this.comboBoxGoods.Name = "comboBoxGoods";
            this.comboBoxGoods.Size = new System.Drawing.Size(269, 21);
            this.comboBoxGoods.TabIndex = 7;
            // 
            // numericUpDownShippCost
            // 
            this.numericUpDownShippCost.Location = new System.Drawing.Point(160, 253);
            this.numericUpDownShippCost.Name = "numericUpDownShippCost";
            this.numericUpDownShippCost.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownShippCost.TabIndex = 10;
            // 
            // labelShippmentTo
            // 
            this.labelShippmentTo.AutoSize = true;
            this.labelShippmentTo.Location = new System.Drawing.Point(24, 278);
            this.labelShippmentTo.Name = "labelShippmentTo";
            this.labelShippmentTo.Size = new System.Drawing.Size(73, 13);
            this.labelShippmentTo.TabIndex = 12;
            this.labelShippmentTo.Text = "Shippment To";
            // 
            // textBoxShippmentTo
            // 
            this.textBoxShippmentTo.Location = new System.Drawing.Point(160, 278);
            this.textBoxShippmentTo.Name = "textBoxShippmentTo";
            this.textBoxShippmentTo.Size = new System.Drawing.Size(174, 20);
            this.textBoxShippmentTo.TabIndex = 14;
            // 
            // labelShippmentTime
            // 
            this.labelShippmentTime.AutoSize = true;
            this.labelShippmentTime.Location = new System.Drawing.Point(28, 332);
            this.labelShippmentTime.Name = "labelShippmentTime";
            this.labelShippmentTime.Size = new System.Drawing.Size(86, 13);
            this.labelShippmentTime.TabIndex = 15;
            this.labelShippmentTime.Text = "Shippment  Time";
            // 
            // dateTimePickerTimeShippment
            // 
            this.dateTimePickerTimeShippment.Location = new System.Drawing.Point(159, 332);
            this.dateTimePickerTimeShippment.Name = "dateTimePickerTimeShippment";
            this.dateTimePickerTimeShippment.Size = new System.Drawing.Size(174, 20);
            this.dateTimePickerTimeShippment.TabIndex = 16;
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(19, 487);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(105, 23);
            this.butBack.TabIndex = 17;
            this.butBack.Text = "Back";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butInvoice
            // 
            this.butInvoice.Location = new System.Drawing.Point(648, 477);
            this.butInvoice.Name = "butInvoice";
            this.butInvoice.Size = new System.Drawing.Size(140, 61);
            this.butInvoice.TabIndex = 18;
            this.butInvoice.Text = "Invoice";
            this.butInvoice.UseVisualStyleBackColor = true;
            this.butInvoice.Click += new System.EventHandler(this.butInvoice_Click);
            // 
            // labelGoodsCount
            // 
            this.labelGoodsCount.AutoSize = true;
            this.labelGoodsCount.Location = new System.Drawing.Point(23, 150);
            this.labelGoodsCount.Name = "labelGoodsCount";
            this.labelGoodsCount.Size = new System.Drawing.Size(69, 13);
            this.labelGoodsCount.TabIndex = 3;
            this.labelGoodsCount.Text = "Goods Count";
            // 
            // numericUpDownGoodsCount
            // 
            this.numericUpDownGoodsCount.Location = new System.Drawing.Point(159, 150);
            this.numericUpDownGoodsCount.Name = "numericUpDownGoodsCount";
            this.numericUpDownGoodsCount.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownGoodsCount.TabIndex = 8;
            // 
            // labelTariff
            // 
            this.labelTariff.AutoSize = true;
            this.labelTariff.Location = new System.Drawing.Point(24, 309);
            this.labelTariff.Name = "labelTariff";
            this.labelTariff.Size = new System.Drawing.Size(31, 13);
            this.labelTariff.TabIndex = 21;
            this.labelTariff.Text = "Tariff";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Shippment Company";
            // 
            // comboBoxShippmentCom
            // 
            this.comboBoxShippmentCom.FormattingEnabled = true;
            this.comboBoxShippmentCom.Location = new System.Drawing.Point(159, 225);
            this.comboBoxShippmentCom.Name = "comboBoxShippmentCom";
            this.comboBoxShippmentCom.Size = new System.Drawing.Size(268, 21);
            this.comboBoxShippmentCom.TabIndex = 26;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(159, 306);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown1.TabIndex = 27;
            // 
            // comboBoxFromWarhouse
            // 
            this.comboBoxFromWarhouse.FormattingEnabled = true;
            this.comboBoxFromWarhouse.Location = new System.Drawing.Point(160, 184);
            this.comboBoxFromWarhouse.Name = "comboBoxFromWarhouse";
            this.comboBoxFromWarhouse.Size = new System.Drawing.Size(267, 21);
            this.comboBoxFromWarhouse.TabIndex = 29;
            // 
            // labelFromWarehouse
            // 
            this.labelFromWarehouse.AutoSize = true;
            this.labelFromWarehouse.Location = new System.Drawing.Point(24, 187);
            this.labelFromWarehouse.Name = "labelFromWarehouse";
            this.labelFromWarehouse.Size = new System.Drawing.Size(90, 13);
            this.labelFromWarehouse.TabIndex = 28;
            this.labelFromWarehouse.Text = "From WareHouse";
            // 
            // textBoxTypeOfInvoices
            // 
            this.textBoxTypeOfInvoices.Location = new System.Drawing.Point(159, 51);
            this.textBoxTypeOfInvoices.Name = "textBoxTypeOfInvoices";
            this.textBoxTypeOfInvoices.Size = new System.Drawing.Size(174, 20);
            this.textBoxTypeOfInvoices.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Type Of Invoices";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.textBoxTypeOfInvoices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFromWarhouse);
            this.Controls.Add(this.labelFromWarehouse);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBoxShippmentCom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTariff);
            this.Controls.Add(this.butInvoice);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.dateTimePickerTimeShippment);
            this.Controls.Add(this.labelShippmentTime);
            this.Controls.Add(this.textBoxShippmentTo);
            this.Controls.Add(this.labelShippmentTo);
            this.Controls.Add(this.numericUpDownShippCost);
            this.Controls.Add(this.numericUpDownGoodsCount);
            this.Controls.Add(this.comboBoxGoods);
            this.Controls.Add(this.textBoxConsumerName);
            this.Controls.Add(this.labelShippmentCompanyCost);
            this.Controls.Add(this.labelGoodsCount);
            this.Controls.Add(this.labelGoodsName);
            this.Controls.Add(this.labelConsumerName);
            this.Controls.Add(this.labelInvoice);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShippCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoodsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInvoice;
        private System.Windows.Forms.Label labelConsumerName;
        private System.Windows.Forms.Label labelGoodsName;
        private System.Windows.Forms.Label labelShippmentCompanyCost;
        private System.Windows.Forms.TextBox textBoxConsumerName;
        private System.Windows.Forms.ComboBox comboBoxGoods;
        private System.Windows.Forms.NumericUpDown numericUpDownShippCost;
        private System.Windows.Forms.Label labelShippmentTo;
        private System.Windows.Forms.TextBox textBoxShippmentTo;
        private System.Windows.Forms.Label labelShippmentTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeShippment;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butInvoice;
        private System.Windows.Forms.Label labelGoodsCount;
        private System.Windows.Forms.NumericUpDown numericUpDownGoodsCount;
        private System.Windows.Forms.Label labelTariff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxShippmentCom;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBoxFromWarhouse;
        private System.Windows.Forms.Label labelFromWarehouse;
        private System.Windows.Forms.TextBox textBoxTypeOfInvoices;
        private System.Windows.Forms.Label label2;
    }
}
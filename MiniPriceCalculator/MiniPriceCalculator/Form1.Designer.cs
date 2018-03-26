namespace MiniPriceCalculator
{
    partial class fMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.priceTablesDataSet = new MiniPriceCalculator.PriceTablesDataSet();
            this.basicPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basicPriceTableAdapter = new MiniPriceCalculator.PriceTablesDataSetTableAdapters.BasicPriceTableAdapter();
            this.sBasicPrice = new System.Windows.Forms.ComboBox();
            this.Quality = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.priceTablesDataSet1 = new MiniPriceCalculator.PriceTablesDataSet1();
            this.qualityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qualityTableAdapter = new MiniPriceCalculator.PriceTablesDataSet1TableAdapters.QualityTableAdapter();
            this.lDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceTablesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basicPriceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTablesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Price";
            // 
            // priceTablesDataSet
            // 
            this.priceTablesDataSet.DataSetName = "PriceTablesDataSet";
            this.priceTablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // basicPriceBindingSource
            // 
            this.basicPriceBindingSource.DataMember = "BasicPrice";
            this.basicPriceBindingSource.DataSource = this.priceTablesDataSet;
            // 
            // basicPriceTableAdapter
            // 
            this.basicPriceTableAdapter.ClearBeforeFill = true;
            // 
            // sBasicPrice
            // 
            this.sBasicPrice.DataSource = this.basicPriceBindingSource;
            this.sBasicPrice.DisplayMember = "PriceType";
            this.sBasicPrice.FormattingEnabled = true;
            this.sBasicPrice.Location = new System.Drawing.Point(16, 29);
            this.sBasicPrice.Name = "sBasicPrice";
            this.sBasicPrice.Size = new System.Drawing.Size(121, 21);
            this.sBasicPrice.TabIndex = 2;
            this.sBasicPrice.ValueMember = "PriceAmt";
            // 
            // Quality
            // 
            this.Quality.AutoSize = true;
            this.Quality.Location = new System.Drawing.Point(16, 57);
            this.Quality.Name = "Quality";
            this.Quality.Size = new System.Drawing.Size(39, 13);
            this.Quality.TabIndex = 3;
            this.Quality.Text = "Quality";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.qualityBindingSource;
            this.comboBox1.DisplayMember = "Level";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // priceTablesDataSet1
            // 
            this.priceTablesDataSet1.DataSetName = "PriceTablesDataSet1";
            this.priceTablesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qualityBindingSource
            // 
            this.qualityBindingSource.DataMember = "Quality";
            this.qualityBindingSource.DataSource = this.priceTablesDataSet1;
            // 
            // qualityTableAdapter
            // 
            this.qualityTableAdapter.ClearBeforeFill = true;
            // 
            // lDesc
            // 
            this.lDesc.AutoSize = true;
            this.lDesc.Location = new System.Drawing.Point(16, 102);
            this.lDesc.Name = "lDesc";
            this.lDesc.Size = new System.Drawing.Size(0, 13);
            this.lDesc.TabIndex = 5;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Quality);
            this.Controls.Add(this.sBasicPrice);
            this.Controls.Add(this.label1);
            this.Name = "fMain";
            this.Text = "Mini Painting Calculator";
            this.Load += new System.EventHandler(this.fMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceTablesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basicPriceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTablesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private PriceTablesDataSet priceTablesDataSet;
        private System.Windows.Forms.BindingSource basicPriceBindingSource;
        private PriceTablesDataSetTableAdapters.BasicPriceTableAdapter basicPriceTableAdapter;
        private System.Windows.Forms.ComboBox sBasicPrice;
        private System.Windows.Forms.Label Quality;
        private System.Windows.Forms.ComboBox comboBox1;
        private PriceTablesDataSet1 priceTablesDataSet1;
        private System.Windows.Forms.BindingSource qualityBindingSource;
        private PriceTablesDataSet1TableAdapters.QualityTableAdapter qualityTableAdapter;
        private System.Windows.Forms.Label lDesc;
    }
}


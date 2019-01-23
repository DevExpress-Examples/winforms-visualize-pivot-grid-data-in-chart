namespace XtraPivotGrid_ChartsIntegration {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.fieldSalesPerson1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new XtraPivotGrid_ChartsIntegration.nwindDataSet();
            this.salesPersonTableAdapter = new XtraPivotGrid_ChartsIntegration.nwindDataSetTableAdapters.SalesPersonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldSalesPerson1
            // 
            this.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSalesPerson1.AreaIndex = 0;
            this.fieldSalesPerson1.Caption = "Sales Person";
            this.fieldSalesPerson1.FieldName = "Sales Person";
            this.fieldSalesPerson1.Name = "fieldSalesPerson1";
            // 
            // fieldExtendedPrice1
            // 
            this.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice1.AreaIndex = 0;
            this.fieldExtendedPrice1.Caption = "Extended Price";
            this.fieldExtendedPrice1.FieldName = "Extended Price";
            this.fieldExtendedPrice1.Name = "fieldExtendedPrice1";
            // 
            // fieldOrderDate1
            // 
            this.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate1.AreaIndex = 1;
            this.fieldOrderDate1.Caption = "Order Date";
            this.fieldOrderDate1.FieldName = "OrderDate";
            this.fieldOrderDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderDate1.Name = "fieldOrderDate1";
            this.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1";
            // 
            // fieldCategoryName1
            // 
            this.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName1.AreaIndex = 0;
            this.fieldCategoryName1.Caption = "Category Name";
            this.fieldCategoryName1.FieldName = "CategoryName";
            this.fieldCategoryName1.Name = "fieldCategoryName1";
            // 
            // fieldProductName1
            // 
            this.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName1.AreaIndex = 1;
            this.fieldProductName1.Caption = "Product Name";
            this.fieldProductName1.FieldName = "ProductName";
            this.fieldProductName1.Name = "fieldProductName1";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.DataSource = this.salesPersonBindingSource;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProductName1,
            this.fieldCategoryName1,
            this.fieldOrderDate1,
            this.fieldExtendedPrice1,
            this.fieldSalesPerson1});
            this.pivotGridControl1.Location = new System.Drawing.Point(13, 13);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(825, 259);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.DataAdapter = this.salesPersonTableAdapter;
            this.chartControl1.DataSource = this.nwindDataSet.SalesPerson;
            this.chartControl1.Location = new System.Drawing.Point(13, 278);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartControl1.Size = new System.Drawing.Size(825, 284);
            this.chartControl1.TabIndex = 1;
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataMember = "SalesPerson";
            this.salesPersonBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesPersonTableAdapter
            // 
            this.salesPersonTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 574);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private XtraPivotGrid_ChartsIntegration.nwindDataSetTableAdapters.SalesPersonTableAdapter salesPersonTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}


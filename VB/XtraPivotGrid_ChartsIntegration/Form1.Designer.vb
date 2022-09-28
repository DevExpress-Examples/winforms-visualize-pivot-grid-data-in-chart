Imports Microsoft.VisualBasic
Imports System
Namespace XtraPivotGrid_ChartsIntegration
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pivotGridControl1.DataMember = "SalesPerson"
            Me.pivotGridControl1.DataSource = Me.SqlDataSource1
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductName, Me.fieldCategoryName, Me.fieldOrderDate, Me.fieldExtendedPrice})
            Me.pivotGridControl1.Location = New System.Drawing.Point(13, 13)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(825, 259)
            Me.pivotGridControl1.TabIndex = 0
            '
            'SqlDataSource1
            '
            Me.SqlDataSource1.ConnectionName = "nwind"
            Me.SqlDataSource1.Name = "SqlDataSource1"
            ColumnExpression1.ColumnName = "ProductName"
            Table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""303"" />"
            Table1.Name = "SalesPerson"
            ColumnExpression1.Table = Table1
            Column1.Expression = ColumnExpression1
            ColumnExpression2.ColumnName = "CategoryName"
            ColumnExpression2.Table = Table1
            Column2.Expression = ColumnExpression2
            ColumnExpression3.ColumnName = "OrderDate"
            ColumnExpression3.Table = Table1
            Column3.Expression = ColumnExpression3
            ColumnExpression4.ColumnName = "ExtendedPrice"
            ColumnExpression4.Table = Table1
            Column4.Expression = ColumnExpression4
            SelectQuery1.Columns.Add(Column1)
            SelectQuery1.Columns.Add(Column2)
            SelectQuery1.Columns.Add(Column3)
            SelectQuery1.Columns.Add(Column4)
            SelectQuery1.Name = "SalesPerson"
            SelectQuery1.Tables.Add(Table1)
            Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
            Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
            '
            'chartControl1
            '
            Me.chartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartControl1.Location = New System.Drawing.Point(13, 278)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel1
            Me.chartControl1.Size = New System.Drawing.Size(825, 284)
            Me.chartControl1.TabIndex = 1
            '
            'fieldProductName
            '
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 1
            Me.fieldProductName.Caption = "Product Name"
            DataSourceColumnBinding1.ColumnName = "ProductName"
            Me.fieldProductName.DataBinding = DataSourceColumnBinding1
            Me.fieldProductName.Name = "fieldProductName"
            '
            'fieldCategoryName
            '
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category Name"
            DataSourceColumnBinding2.ColumnName = "CategoryName"
            Me.fieldCategoryName.DataBinding = DataSourceColumnBinding2
            Me.fieldCategoryName.Name = "fieldCategoryName"
            '
            'fieldOrderDate
            '
            Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate.AreaIndex = 0
            Me.fieldOrderDate.Caption = "Order Date"
            DataSourceColumnBinding3.ColumnName = "OrderDate"
            DataSourceColumnBinding3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldOrderDate.DataBinding = DataSourceColumnBinding3
            Me.fieldOrderDate.Name = "fieldOrderDate"
            '
            'fieldExtendedPrice
            '
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Extended Price"
            DataSourceColumnBinding4.ColumnName = "ExtendedPrice"
            Me.fieldExtendedPrice.DataBinding = DataSourceColumnBinding4
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(850, 574)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Private chartControl1 As DevExpress.XtraCharts.ChartControl
        Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Friend WithEvents fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
        Friend WithEvents fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
        Friend WithEvents fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField
        Friend WithEvents fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace


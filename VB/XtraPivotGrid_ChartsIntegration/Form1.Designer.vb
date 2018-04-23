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
			Dim sideBySideBarSeriesLabel3 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.cbTransposeDataSource = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbTransposeDataSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' fieldYear
			' 
			Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldYear.AreaIndex = 0
			Me.fieldYear.Caption = "Year"
			Me.fieldYear.FieldName = "OrderDate"
			Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldYear.Name = "fieldYear"
			Me.fieldYear.UnboundFieldName = "fieldYear"
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldYear, Me.fieldQuantity, Me.fieldSalesPerson})
			Me.pivotGridControl1.Location = New System.Drawing.Point(12, 37)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsChartDataSource.SelectionOnly = False
			Me.pivotGridControl1.OptionsCustomization.AllowDrag = False
			Me.pivotGridControl1.OptionsCustomization.AllowFilter = False
			Me.pivotGridControl1.OptionsView.ShowColumnGrandTotals = False
			Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
			Me.pivotGridControl1.OptionsView.ShowRowGrandTotals = False
			Me.pivotGridControl1.Size = New System.Drawing.Size(347, 462)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 0
			Me.fieldQuantity.Caption = "Quantity"
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSalesPerson.AreaIndex = 0
			Me.fieldSalesPerson.Caption = "Sales Person"
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			' 
			' chartControl1
			' 
			Me.chartControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.chartControl1.Location = New System.Drawing.Point(365, 13)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			sideBySideBarSeriesLabel3.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel3
			Me.chartControl1.Size = New System.Drawing.Size(740, 486)
			Me.chartControl1.TabIndex = 1
			' 
			' cbTransposeDataSource
			' 
			Me.cbTransposeDataSource.Location = New System.Drawing.Point(12, 12)
			Me.cbTransposeDataSource.Name = "cbTransposeDataSource"
			Me.cbTransposeDataSource.Properties.Caption = "Transpose Data Source"
			Me.cbTransposeDataSource.Size = New System.Drawing.Size(141, 19)
			Me.cbTransposeDataSource.TabIndex = 2
'			Me.cbTransposeDataSource.CheckedChanged += New System.EventHandler(Me.cbTransposeDataSource_CheckedChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1117, 511)
			Me.Controls.Add(Me.cbTransposeDataSource)
			Me.Controls.Add(Me.chartControl1)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbTransposeDataSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField
		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private WithEvents cbTransposeDataSource As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace


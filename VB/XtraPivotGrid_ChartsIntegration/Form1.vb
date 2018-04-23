Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace XtraPivotGrid_ChartsIntegration
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			' Binds the pivot grid to data.
			pivotGridControl1.DataSource = _
				(New nwindDataSetTableAdapters.SalesPersonTableAdapter()).GetData()

			' Specifies that Series data member values are created based on columns.
			pivotGridControl1.OptionsChartDataSource.ProvideDataByColumns = True

			' Specifies that data binding settings are automatically adjusted 
			' while retrieving data from the pivot grid.
			chartControl1.AutoBindingSettingsEnabled = True

			' Sets the pivot grid as the chart's data source.
			chartControl1.DataSource = pivotGridControl1
		End Sub
		Private Sub cbTransposeDataSource_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
			Handles cbTransposeDataSource.CheckedChanged
			pivotGridControl1.OptionsChartDataSource.ProvideDataByColumns = _
				Not cbTransposeDataSource.Checked
		End Sub
	End Class
End Namespace
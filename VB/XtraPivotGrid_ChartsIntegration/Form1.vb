Imports System
Imports System.Windows.Forms

Namespace XtraPivotGrid_ChartsIntegration
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

			' Populates the pivot grid's data source with data.
			Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)

			' Sets the PivotGridControl as a data source for the ChartControl.
			chartControl1.DataSource = pivotGridControl1

			pivotGridControl1.Cells.Selection = New System.Drawing.Rectangle(0, 4, 3, 1)
		End Sub
	End Class
End Namespace

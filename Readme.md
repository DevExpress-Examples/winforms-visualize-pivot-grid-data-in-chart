# How to visualize pivot grid data via the XtraCharts Suite


<p>The following example shows how to bind a Chart Control to a Pivot Grid to visualize data.</p><p>To do this, the PivotGridControl instance is assigned to the ChartControl.DataSource property. </p>


<h3>Description</h3>

<p>By default, the ChartControl.AutoBindingSettingsEnabled property is set to true, so that binding settings are automatically adjusted, and no further customization is needed.  Once the Chart Control is bound to the XtraPivotGrid, pivot grid data is immediately displayed in the Chart.</p><p>The main form of this sample application contains the &#39;Transpose Data Source&#39; check box, which defines the pivot grid&#39;s PivotGridOptionsChartDataSource.ProvideDataByColumns property value. If the check box is checked, the property is set to false, and series are created based on pivot grid rows (instead of columns, which is default behavior).</p><br />


<br/>



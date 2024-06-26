<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582687/10.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2911)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraPivotGrid_ChartsIntegration/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_ChartsIntegration/Form1.vb))
<!-- default file list end -->
# How to visualize pivot grid data via the XtraCharts Suite


<p>The following example shows how to bind a Chart Control to a Pivot Grid to visualize data.</p><p>To do this, the PivotGridControl instance is assigned to the ChartControl.DataSource property. </p>


<h3>Description</h3>

<p>By default, the ChartControl.AutoBindingSettingsEnabled property is set to true, so that binding settings are automatically adjusted, and no further customization is needed.  Once the Chart Control is bound to the XtraPivotGrid, pivot grid data is immediately displayed in the Chart.</p><p>The main form of this sample application contains the &#39;Transpose Data Source&#39; check box, which defines the pivot grid&#39;s PivotGridOptionsChartDataSource.ProvideDataByColumns property value. If the check box is checked, the property is set to false, and series are created based on pivot grid rows (instead of columns, which is default behavior).</p><br />


<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-visualize-pivot-grid-data-in-chart&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-visualize-pivot-grid-data-in-chart&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

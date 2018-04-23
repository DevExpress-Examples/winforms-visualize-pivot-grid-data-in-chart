using System;
using System.Windows.Forms;

namespace XtraPivotGrid_ChartsIntegration {
    public partial class Form1 : Form     {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {

            // Binds the pivot grid to data.
            pivotGridControl1.DataSource =
                (new nwindDataSetTableAdapters.SalesPersonTableAdapter()).GetData();

            // Specifies that Series data member values are created based on columns.
            pivotGridControl1.OptionsChartDataSource.ProvideDataByColumns = true;

            // Specifies that data binding settings are automatically adjusted 
            // while retrieving data from the pivot grid.
            chartControl1.AutoBindingSettingsEnabled = true;

            // Sets the pivot grid as the chart's data source.
            chartControl1.DataSource = pivotGridControl1;
        }
        private void cbTransposeDataSource_CheckedChanged(object sender, EventArgs e) {
            pivotGridControl1.OptionsChartDataSource.ProvideDataByColumns =
                !cbTransposeDataSource.Checked;
        }
    }
}
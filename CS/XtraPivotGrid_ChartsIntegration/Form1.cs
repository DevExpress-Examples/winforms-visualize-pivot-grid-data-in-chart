using System;
using System.Windows.Forms;

namespace XtraPivotGrid_ChartsIntegration {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {

            // Populates the pivot grid's data source with data.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);

            // Sets the PivotGridControl as a data source for the ChartControl.
            chartControl1.DataSource = pivotGridControl1;
        }
    }
}

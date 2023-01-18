namespace BMICalculatorApp
{
    public partial class MainForm : Form
    {
        public enum MeasurementSystems { Metric, Imperial };
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalcBmi_Click(object sender, EventArgs e)
        {
            // Reset error msg text
            lblErrorMsg.Text = string.Empty;

            double height;
            double weight;
            if (!double.TryParse(txtHeight.Text, out height) || !double.TryParse(txtWeight.Text, out weight))
            {
                // provide an error msg & return
                txtResult.Text = string.Empty;
                txtStatus.Text = string.Empty;
                lblErrorMsg.Text = "You have entered and invalid number\nPlease try again";
                return;
            }
            

            double bmi = weight / (height * height);

            if(_currentMeasurementSystem == MeasurementSystems.Imperial) 
            {
                bmi *= 703.0;
            }
            txtResult.Text = $"{bmi:0.0}";
            
            // Call helper method
            txtStatus.Text = CalculateSummary(bmi);
        }

        // A method to determine the summary based on the MBI value:
        private static string CalculateSummary(double bmi)
        {
            if(bmi < 18.5)
            {
                return "Underweight";
            } else if(bmi >= 19.5 && bmi < 25.0)
            {
                return "Normal";
            } else if (bmi >= 25.0 && bmi < 30.0)
            {
                return "Overweight";
            } else
            {
                return "Obese";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set out error msg label to empty string:
            lblErrorMsg.Text = string.Empty;
        }

        // a private data field to store current measurement system:
        // and it defaults with metric
        private MeasurementSystems _currentMeasurementSystem = MeasurementSystems.Metric;

        private void HandleMeasurementSystemChange(object sender, EventArgs e)
        {
            // We also need to show units and change them accordingly
            // MessageBox.Show("It worked!");
            if(radioBtnMetric.Checked)
            {
                _currentMeasurementSystem = MeasurementSystems.Metric;
            } else
            {
                _currentMeasurementSystem = MeasurementSystems.Imperial;
            }
            
            // Clear all text boxes
            txtHeight.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtResult.Text = string.Empty;
            txtStatus.Text = string.Empty;

        }
    }
}
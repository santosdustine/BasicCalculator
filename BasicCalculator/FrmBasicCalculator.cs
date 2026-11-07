using System;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            BasicComputation computation = new BasicComputation();
            float num1 = float.Parse(txtboxNum1.Text);
            float num2 = float.Parse(txtboxNum2.Text);

           
            switch (cmbOperators.SelectedItem.ToString())
            {

                case "+":
                    lblAnswer.Text = computation.Add(num1, num2).ToString();
                    break;
                case "-":
                    lblAnswer.Text = computation.Subtract(num1, num2).ToString();
                    break;
                case "*":
                    lblAnswer.Text = computation.Multiply(num1, num2).ToString();
                    break;
                case "/":
                    try
                    {
                        lblAnswer.Text = computation.Divide(num1, num2).ToString();
                    }
                    catch (DivideByZeroException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    MessageBox.Show("Please select a valid operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }

        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            cmbOperators.Text = "+";
        }
    }
}

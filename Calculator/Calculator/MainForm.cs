namespace Calculator
{
    public partial class MainForm : Form
    {
        public string StoredOperation { get; set; }
        public decimal StoredNumber { get; set; }
        public MainForm()
        {
            StoredNumber = 0;
            StoredOperation = "";
            InitializeComponent();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Oemplus)
            {
                switch (StoredOperation)
                {
                    case "+":
                        StoredNumber += decimal.Parse(DisplayNumberTextBox.Text);
                        DisplayNumberTextBox.Text = StoredNumber.ToString("0.00");
                        Operation.Text = "";
                        break;
                    case "-":
                        StoredNumber -= decimal.Parse(DisplayNumberTextBox.Text);
                        DisplayNumberTextBox.Text = StoredNumber.ToString("0.00");
                        Operation.Text = "";
                        break;
                    case "/":
                        try
                        {
                            StoredNumber /= decimal.Parse(DisplayNumberTextBox.Text);
                            DisplayNumberTextBox.Text = StoredNumber.ToString("0.00");
                            Operation.Text = "";
                        }
                        catch (DivideByZeroException ex)
                        {
                            DisplayNumberTextBox.Text = "cannot divide by zero";
                            Operation.Text = "";
                        }
                        break;
                    case "*":
                        StoredNumber *= decimal.Parse(DisplayNumberTextBox.Text);
                        DisplayNumberTextBox.Text = StoredNumber.ToString("0.00");
                        Operation.Text = "";
                        break;
                    default:
                        break;
                }
            }
            // + = Oemplus, Shift (KeyData)
            // - = OemMinus
            // / = OemQuestion
            //* = D8, Shift (KeyData)
            string test = e.KeyData.ToString();
            if (e.KeyData.ToString() == "Oemplus, Shift")
            {
                AddButton_Click(sender, e);
            }
            if (e.KeyData.ToString() == "OemMinus")
            {
                SubtractButton_Click(sender, e);
            }
            if (e.KeyData.ToString() == "OemQuestion")
            {
                DivideButton_Click(sender, e);
            }
            if (e.KeyData.ToString() == "D8, Shift")
            {
                MultiplyButton_Click(sender, e);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //The contents of the number display are cleared, 
            //and the number within becomes the Stored Operand. 
            //The selected Operation becomes the Stored Operation.

            if (string.IsNullOrEmpty(DisplayNumberTextBox.Text))
            {
                Operation.Text = "+";
                StoredOperation = Operation.Text;
            }
            else
            {
                PerformThePreviousOperation();
                decimal output = 0;
                if (decimal.TryParse(DisplayNumberTextBox.Text, out output))
                {
                    Operation.Text = "+";
                    StoredOperation = Operation.Text;
                    StoredNumber = output;
                    DisplayNumberTextBox.Text = StoredNumber.ToString("0.00");

                }
                else
                {
                    DisplayNumberTextBox.Text = "Wrong Format";
                    DisplayNumberTextBox.SelectAll();
                }
            }

        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DisplayNumberTextBox.Text))
            {
                Operation.Text = "-";
                StoredOperation = Operation.Text;
            }
            else
            {
                PerformThePreviousOperation();
                decimal output = 0;
                if (decimal.TryParse(DisplayNumberTextBox.Text, out output))
                {
                    Operation.Text = "-";
                    StoredOperation = Operation.Text;
                    StoredNumber = output;
                    DisplayNumberTextBox.Text = StoredNumber.ToString("0.00");

                }
                else
                {
                    DisplayNumberTextBox.Text = "Wrong Format";
                    DisplayNumberTextBox.SelectAll();
                }
            }

        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DisplayNumberTextBox.Text))
            {
                Operation.Text = "/";
                StoredOperation = Operation.Text;
                Operation.Focus();
            }
            else
            {
                PerformThePreviousOperation();
                decimal output = 0;
                if (decimal.TryParse(DisplayNumberTextBox.Text, out output))
                {
                    Operation.Text = "/";
                    StoredOperation = Operation.Text;
                    StoredNumber = output;
                    DisplayNumberTextBox.Text = StoredNumber.ToString("0.00");

                }
                else
                {
                    DisplayNumberTextBox.Text = "Wrong Format";
                    DisplayNumberTextBox.SelectAll();
                }
            }

        }
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DisplayNumberTextBox.Text))
            {
                Operation.Text = "*";
                StoredOperation = Operation.Text;
            }
            else
            {
                PerformThePreviousOperation();
                decimal output = 0;
                if (decimal.TryParse(DisplayNumberTextBox.Text, out output))
                {
                    Operation.Text = "*";
                    StoredOperation = Operation.Text;
                    StoredNumber = output;
                    DisplayNumberTextBox.Text = StoredNumber.ToString("0.00");

                }
                else
                {
                    DisplayNumberTextBox.Text = "Wrong Format";
                    DisplayNumberTextBox.SelectAll();
                }
            }
        }

        private void BinaryButton_Click(object sender, EventArgs e)
        {

        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {

        }

        private void LocationalButton_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            Operation.Focus();
        }

        public void PerformThePreviousOperation()
        {
            switch (StoredOperation)
            {
                case "+":
                    decimal output = 0;
                    if (decimal.TryParse(DisplayNumberTextBox.Text, out output))
                    {
                        StoredNumber += output;
                        DisplayNumberTextBox.Text = StoredNumber.ToString("0.00");

                    }
                    else
                    {
                        DisplayNumberTextBox.Text = "Wrong Format";
                        DisplayNumberTextBox.SelectAll();
                    }
                    break;
                case "-":
                    if (decimal.TryParse(DisplayNumberTextBox.Text, out output))
                    {
                        StoredNumber += output;
                        DisplayNumberTextBox.Text = StoredNumber.ToString("0.00");

                    }
                    else
                    {
                        DisplayNumberTextBox.Text = "Wrong Format";
                        DisplayNumberTextBox.SelectAll();
                    }
                    break;
                case "/":
                    try
                    {
                        if (decimal.TryParse(DisplayNumberTextBox.Text, out output))
                        {
                            StoredNumber += output;
                            DisplayNumberTextBox.Text = StoredNumber.ToString("0.00");

                        }
                        else
                        {
                            DisplayNumberTextBox.Text = "Wrong Format";
                            DisplayNumberTextBox.SelectAll();
                        }
                    }
                    catch (DivideByZeroException ex)
                    {
                        DisplayNumberTextBox.Text = "cannot divide by zero";
                        Operation.Text = "";
                    }
                    break;
                case "*":
                    if (decimal.TryParse(DisplayNumberTextBox.Text, out output))
                    {
                        StoredNumber += output;
                        DisplayNumberTextBox.Text = StoredNumber.ToString("0.00");

                    }
                    else
                    {
                        DisplayNumberTextBox.Text = "Wrong Format";
                        DisplayNumberTextBox.SelectAll();
                    }
                    break;
                default:
                    break;
            }

        }
        private void DisplayNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
        }
    }
}
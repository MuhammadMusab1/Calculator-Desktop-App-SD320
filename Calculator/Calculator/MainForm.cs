namespace Calculator
{
    public partial class MainForm : Form
    {
        public string StoredOperation { get; set; }
        public double StoredNumber { get; set; }
        public MainForm()
        {
            StoredNumber = 0;
            StoredOperation = "";
            InitializeComponent();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {

        }

        private void DivideButton_Click(object sender, EventArgs e)
        {

        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {

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
    }
}
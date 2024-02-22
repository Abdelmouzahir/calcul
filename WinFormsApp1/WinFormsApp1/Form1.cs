namespace WinFormsApp1
{
    public partial class calculator : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (tbDisplayResult.Text == "0" || (isOperationPerformed))
            {
                tbDisplayResult.Clear();
            }

            isOperationPerformed = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!tbDisplayResult.Text.Contains("."))
                {
                    tbDisplayResult.Text += button.Text;
                }
            }
            else
            {
                tbDisplayResult.Text += button.Text;
            }
            //validation on decimals more than 1



        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            operationPerformed = button.Text;
            resultValue = Double.Parse(tbDisplayResult.Text);
            lbCurrentop.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            resultValue = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbDisplayResult.Text = "0";
            resultValue = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (operationPerformed == "+")
            {
                tbDisplayResult.Text = (resultValue + Double.Parse(tbDisplayResult.Text)).ToString();
            }
            else if (operationPerformed == "-")
            {
                tbDisplayResult.Text = (resultValue - Double.Parse(tbDisplayResult.Text)).ToString();
            }
            else if (operationPerformed == "X")
            {
                tbDisplayResult.Text = (resultValue * Double.Parse(tbDisplayResult.Text)).ToString();
            }
            else if (operationPerformed == "/")
            {
                tbDisplayResult.Text = (resultValue / Double.Parse(tbDisplayResult.Text)).ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(tbDisplayResult.Text.Length > 0)
            {
                tbDisplayResult.Text = tbDisplayResult.Text.Remove(tbDisplayResult.Text.Length - 1, 1);
            }
            if(tbDisplayResult.Text == "")
            {
                tbDisplayResult.Text = "0";
            }
        }
    }
}
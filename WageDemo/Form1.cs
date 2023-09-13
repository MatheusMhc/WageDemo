namespace WageDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNumHoursWorked_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /* Run the close method, to close the form */
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            int intNumHours = int.Parse(txtNumHoursWorked.Text);
            int intWage = int.Parse(txtHourWage.Text);

            int total = intNumHours * intWage;

            MessageBox.Show(total.ToString());
            /*
            --Double method
            double intNumHours = double.Parse(txtNumHoursWorked.Text);
            double intWage = double.Parse(txtHourWage.Text);

            double total = intNumHours * intWage;

            MessageBox.Show(total.ToString());
             */

        }
    }
}
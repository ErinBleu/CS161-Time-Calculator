namespace TimeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal seconds = 0;
            decimal minutes = 0;
            decimal hours = 0;
            decimal days = 0;

            try
            {
                if (seconds >= 60)
                {
                    minutesLabel.Text = seconds / 60;
                }
                if (seconds >= 3600)
                {
                    hoursLabel.Text = (seconds / 3600);

                }
            }
        }
    }
}

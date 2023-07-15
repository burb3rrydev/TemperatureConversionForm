namespace Activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbFarenheit.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbCelcius_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double tempCelcius = double.Parse(tbCelcius.Text);
            double tempFarenhiet = (tempCelcius * 1.8) + 32;
            lbFarenheit.Text = tempCelcius + "C is " + tempFarenhiet + "F";
        }
    }
}
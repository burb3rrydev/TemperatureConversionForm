using System;
using System.Windows.Forms;

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
            lbFarenheit.Text = ""; // Set the initial content of lbFarenheit label to an empty string
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double tempCelsius = double.Parse(tbCelcius.Text); // Get the Celsius temperature entered in the textbox and parse it to a double

                // Calculate the Fahrenheit temperature
                double tempFahrenheit = (tempCelsius * 1.8) + 32; // Convert Celsius to Fahrenheit

                // Format the output to three decimal places
                string formattedCelsius = tempCelsius.ToString("0.000"); // Format Celsius temperature to three decimal places
                string formattedFahrenheit = tempFahrenheit.ToString("0.000"); // Format Fahrenheit temperature to three decimal places

                lbFarenheit.Text = formattedCelsius + "°C is " + formattedFahrenheit + "°F"; // Display the result in the lbFarenheit label
            }
            catch (FormatException)
            {
                // Handle invalid input (non-numeric values)
                MessageBox.Show("Invalid input. Please enter a numeric value for Celsius temperature.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); // Show an error message in a dialog box
                tbCelcius.Text = ""; // Clear the invalid input in the textbox
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); // Show an error message in a dialog box
            }
        }
    }
}


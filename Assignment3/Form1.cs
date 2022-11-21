using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Visible = true;
                label4.Visible = true;

                double Weight, Height, Index;
                Weight = double.Parse(textBox1.Text);
                Height = double.Parse(textBox2.Text);

                Index = Weight / (Height * Height) * 703;

                string Status;
                if (Index < 18.5)
                {
                    Status = "Underweight";
                }
                else if (Index > 25.0)
                {
                    Status = "Overweight";
                }
                else
                {
                    Status = "Optimal";
                }


                label3.Text = "BMI: " + (Math.Round(Index, 2)).ToString();
                label4.Text = "Status: " + Status;
            }
            catch
            {
                label3.Visible = false;
                label4.Visible = true;
                label4.Text = "Wrong data entered!";
            }
            }
        }
    }
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Currency Converter";
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(Application.StartupPath, "C:\\Users\\redic\\CurrencyConverter\\CurrencyConverter\\Poppins\\Poppins-Black.ttf"));
            Font customFont = new Font(pfc.Families[0], 16f);
            Font textFont = new Font(pfc.Families[0], 10f);
            label1.Font = customFont;
            label3.Font = textFont;
            label2.Text = "Albanian LEK";
            label3.Text = "US Dollar";
            label2.Font=textFont;
            guna2TextBox1.PlaceholderText = "Enter";
            button1.Text = "Enter";
            //button1.Font = customFont;'

 

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(guna2TextBox1.Text))
            {
                try
                {
                    double valueLek = Convert.ToDouble(guna2TextBox1.Text);
                    double valueUsd = valueLek * 0.01085;
                    guna2TextBox2.Text = valueUsd.ToString("0.00000");

                }

                catch(FormatException) {
                    MessageBox.Show("The program only accepts numbers, do not enter strings/chars", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Value cannot be empty, please put something", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        }
    }

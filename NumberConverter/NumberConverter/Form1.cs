using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ArabicButton_Click(object sender, EventArgs e)
        {

            try
            {
                string converter;

                converter = arabictoroman.inttoroman(int.Parse(textBox1.Text));

                label3.Text = converter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            


   

        private void RomanButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                int converter;

                converter = RomantoArabic.romantoint(textBox1.Text.ToUpper());

                label3.Text = converter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}


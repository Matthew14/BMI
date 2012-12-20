using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BodyMassIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            double feet, inches, weight;
            try
            {
                name = nametxt.Text;
            }
            catch
            {
                name = "";
            }
            try
            {
                feet = Convert.ToDouble(feetTxt.Text); 
            }
            catch
            {
                feet = 0.0;
            }
            try
            {
                inches = Convert.ToDouble(inchesTxt.Text);
            }
            catch
            {
                inches = 0.0;
            }
            try
            {
                weight = Convert.ToDouble(weighttxt.Text);
            }
            catch
            {
                weight = 0.0;
            }

            BMI person = new BMI(name, feet, inches, weight);

            MessageBox.Show(person.toString());
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void inchesTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void feetTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void weighttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inchesTxt.Clear();
            feetTxt.Clear();
            weighttxt.Clear();
            nametxt.Clear();
        }
    }
}

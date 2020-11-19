using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slumpat_Tal_Grafiskt
{
    public partial class Form1 : Form
    {
        int tries = 0;
        int rng = 0;
        int tal = 0; 

        public Form1()
        {
            InitializeComponent();
            Random rd = new Random();
            rng = rd.Next(1, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gissa_Click(object sender, EventArgs e)
        {
            tal = Convert.ToInt32(Input.Text);
            tries++;
            Försök.Text = "Antal gissningar " + tries;

            if (tal < rng)
                high_low.Text = ("För lågt");

            else if (tal > rng)

                high_low.Text = "För högt";

            else 
                high_low.Text = "Rätt";
        }

        private void high_low_Click(object sender, EventArgs e)
        {

        }

        private void Försök_Click(object sender, EventArgs e)
        {

        }
    }
}

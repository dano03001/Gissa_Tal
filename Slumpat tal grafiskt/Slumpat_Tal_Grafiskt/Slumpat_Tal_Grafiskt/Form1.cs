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
            rng = rd.Next(1,100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

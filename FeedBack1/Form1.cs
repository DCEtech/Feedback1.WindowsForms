using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBack1
{
    public partial class Form1 : Form
    {
        Boolean alternar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (alternar)
            {
                label1.Text = "SIGO CAMBIANDO";
                textBox1.Text = "SIGO CAMBIANDO";

            }
            else
            {
                label1.Text = "HE CAMBIADO";
                textBox1.Text = "HE CAMBIADO";
            }
            alternar = !alternar;

            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                label2.Text = "TEXTO MODIFICADO";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

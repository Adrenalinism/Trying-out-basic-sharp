using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "I am the greatest programmer in the world.";
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "actually im not :(";
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            if (radioButton2.Checked == true) 
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}

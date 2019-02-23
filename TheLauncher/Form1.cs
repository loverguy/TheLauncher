using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button26_Click(object sender, EventArgs e) => home1.BringToFront();


        private void button9_Click(object sender, EventArgs e)
        {
          
        }

        private void button8_Click(object sender, EventArgs e) => website1.BringToFront();

        private void button6_Click(object sender, EventArgs e) => twitch1.BringToFront();
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priklad10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cislo1 = Convert.ToInt32(textBox1.Text);
            int cislo2 = Convert.ToInt32(textBox2.Text);
            label1.Text = (cislo1 + cislo2).ToString();
            label2.Text = (cislo1 - cislo2).ToString();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Edit(object sender, EventArgs e)
        {
          
  
           MessageBox.Show("Error");

        }

        private void AddUser(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
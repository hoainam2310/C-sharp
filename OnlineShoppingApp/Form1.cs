﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShoppingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_search_Click(object sender, EventArgs e)
        {
            txb_search.Text = "";
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIngressos
{
    public partial class inicial : Form
    {
        public inicial()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new LoginUsuario().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoginDev().Show();
            this.Hide();
        }
    }
}

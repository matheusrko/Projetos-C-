﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }

        private void Cursos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    if (formAberto is Form1)
                    {
                        formAberto.Show();
                        break;
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

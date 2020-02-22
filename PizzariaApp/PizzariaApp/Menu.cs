using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }       

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.Image = PizzariaApp.Properties.Resources.alhoOleo;
            }
            if (radioButton2.Checked)
            {
                pictureBox1.Image = PizzariaApp.Properties.Resources.pizzaCalabresa;
            }
            if (radioButton3.Checked)
            {
                pictureBox1.Image = PizzariaApp.Properties.Resources.margherita;
            }
            if (radioButton4.Checked)
            {
                pictureBox1.Image = PizzariaApp.Properties.Resources.pepperoni;
            }
            if (radioButton5.Checked)
            {
                pictureBox1.Image = PizzariaApp.Properties.Resources.quatroQueijos;
            }
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = PizzariaApp.Properties.Resources.vinho;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = PizzariaApp.Properties.Resources.cerveja;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                
                pictureBox1.Image = PizzariaApp.Properties.Resources.copoSuco;
                
            }
            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox1.Image = PizzariaApp.Properties.Resources.jarraSuco;
            }
        }
    }
}

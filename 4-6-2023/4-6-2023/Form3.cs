using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_6_2023
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void formFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFud formfud = new FormFud();
            formfud.Dock= DockStyle.Fill;
            formfud.TopLevel = false;
            this.panel1.Controls.Add(formfud);
            formfud.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

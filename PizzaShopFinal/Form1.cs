using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShopFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //label3.Text = listBox1.GetItemText(listBox1.SelectedItem);
        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 n = new Form2();
            n.Show();
        }
    }
}

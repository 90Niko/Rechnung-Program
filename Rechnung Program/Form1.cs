using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechnung_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int amount = int.Parse(comboBoxAmount.SelectedItem.ToString());
            double price =double.Parse (textBoxPreis.Text);
            string name = textBoxName.Text;

            richTextBox1.Text = "Hallo,Du hast das ausgewählt :" + amount + "," + price + "," + name;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFruit.Text == "")
            {
                MessageBox.Show("Please enter a fruit", "ERROR");
                return;
            }
            lstShop.Items.Add(txtFruit.Text);
            txtFruit.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstShop.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to move to cart", "ERROR");
                return;
            }
            String selected = lstShop.SelectedItem.ToString();
            lstShop.Items.Remove(selected);
            lstCart.Items.Add(selected);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to return to shop", "ERROR");
                return;
            }
            String selected = lstCart.SelectedItem.ToString();
            lstCart.Items.Remove(selected);
            lstShop.Items.Add(selected);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
                int shopCount = lstShop.Items.Count;
                int cartCount = lstCart.Items.Count;
                MessageBox.Show("Shop: " + shopCount + "\nCart: " + cartCount, "ITEM COUNT");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            for (int i = lstCart.Items.Count; i > 0; i--)
            {
                lstShop.Items.Add(lstCart.Items[i-1]);
                lstCart.Items.RemoveAt(i-1);
            }
        }
    }
}

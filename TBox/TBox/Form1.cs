using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ValueBox.Text))
            {
                if (List_Box.Items.Contains(char.ToUpper(ValueBox.Text[0]) + ValueBox.Text.Substring(1)))
                {
                    MessageBox.Show("This value already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    List_Box.Items.Add(char.ToUpper(ValueBox.Text[0]) + ValueBox.Text.Substring(1));
                }
            }
            else
            {
                MessageBox.Show("Invalid value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ValueBox.Clear();
            ValueBox.Focus();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            List_Box.Items.Clear();
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            List_Box.Items.Remove(List_Box.SelectedItem);
        }
    }
}

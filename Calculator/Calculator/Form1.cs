using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         

        private void Button1_Click(object sender, EventArgs e)
        {

            string pattern = @"^\d+(\s*[+\-*/]\s*\d+)+$";
            Match valid = Regex.Match(textBox1.Text, pattern);
            //var Valid = Regex.Match(textBox1.Text, RexExp, RegexOptions.IgnoreCase);
            if (valid.Success)
            {
                var result = new DataTable().Compute(textBox1.Text, null);
                textBox2.Text = result.ToString();
            }
            else
            {
                textBox2.Text = "Wrong math expression";
            }
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

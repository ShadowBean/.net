using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text)|| string.IsNullOrWhiteSpace(textBox2.Text)|| string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Nie wszystkie pola zostały wypełnione","UWAGA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                Person P = new Person { Imie = textBox1.Text, Nazwisko = textBox2.Text, Adres = textBox3.Text };
                TableOfPersons.Datas.Add(P);
            }
            
        }

        private void Show_Click(object sender, EventArgs e)
        {
            Form2 settingsForm = new Form2();
            settingsForm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRconnect
{
    public partial class Form2new : Form
    {
        public static Form1 form1 = new Form1();
        public Form2new()
        {
            InitializeComponent();
        }

        private void Form2new_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Transactie(transactieDatum, transactieNaam, transactieBedrag, transactiePersoon) VALUES('{textBox2.Text}', '{textBox1.Text}', '{textBox3.Text}', 'Tibe');";
            form1.querySql(query);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Transactie(transactieDatum, transactieNaam, transactieBedrag, transactiePersoon) VALUES('{textBox2.Text}', '{textBox1.Text}', '{(Convert.ToDouble(textBox3.Text)-(2* Convert.ToDouble(textBox3.Text))).ToString("0.00")}', 'Tibe');";
            form1.querySql(query);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Transactie(transactieDatum, transactieNaam, transactieBedrag, transactiePersoon) VALUES('{textBox2.Text}', '{textBox1.Text}', '{textBox3.Text}', 'Roel');";
            form1.querySql(query);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Transactie(transactieDatum, transactieNaam, transactieBedrag, transactiePersoon) VALUES('{textBox2.Text}', '{textBox1.Text}', '{(Convert.ToDouble(textBox3.Text) - (2 * Convert.ToDouble(textBox3.Text))).ToString("0.00")}', 'Roel');";
            form1.querySql(query);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Transactie(transactieDatum, transactieNaam, transactieBedrag, transactiePersoon) VALUES('{textBox2.Text}', '{textBox1.Text}', '{textBox3.Text}', 'Tibe');";
            form1.querySql(query);
            query = $"INSERT INTO Transactie(transactieDatum, transactieNaam, transactieBedrag, transactiePersoon) VALUES('{textBox2.Text}', '{textBox1.Text}', '{textBox3.Text}', 'Roel');";
            form1.querySql(query);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Transactie(transactieDatum, transactieNaam, transactieBedrag, transactiePersoon) VALUES('{textBox2.Text}', '{textBox1.Text}', '{(Convert.ToDouble(textBox3.Text) - (2 * Convert.ToDouble(textBox3.Text))).ToString("0.00")}', 'Tibe');";
            form1.querySql(query);
            query = $"INSERT INTO Transactie(transactieDatum, transactieNaam, transactieBedrag, transactiePersoon) VALUES('{textBox2.Text}', '{textBox1.Text}', '{(Convert.ToDouble(textBox3.Text) - (2 * Convert.ToDouble(textBox3.Text))).ToString("0.00")}', 'Roel');";
            form1.querySql(query);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            this.Hide();
        }
    }
}

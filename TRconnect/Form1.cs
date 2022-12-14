using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRconnect
{
    public partial class Form1 : Form
    {
        private Form2new form2 = new Form2new();
        private SQLiteConnection con = new SQLiteConnection(@"data source=C:\databases\TRconnect.db");
        public Form1()
        {
            InitializeComponent();
        }

        private void openCon()
        {
            con.Open();
        }
        private void closeCon()
        {
            con.Close();
        }

        public void querySql(string query = "SELECT transactieDatum as Datum, transactieNaam as Naam, transactieBedrag as Bedrag, transactiePersoon as Persoon FROM Transactie;")
        {
            openCon();
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            if(query == "SELECT transactieDatum as Datum, transactieNaam as Naam, transactieBedrag as Bedrag, transactiePersoon as Persoon FROM Transactie;")
            {
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                outputDisplay.DataSource = dt;

                query = "SELECT SUM(transactieBedrag) as 'TR-connect' FROM Transactie;";
                cmd = new SQLiteCommand(query, con);
                dt = new DataTable();
                adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                query = "SELECT SUM(transactieBedrag) as 'Tibe' FROM Transactie WHERE transactiePersoon = 'Tibe' ;";
                cmd = new SQLiteCommand(query, con);
                dt = new DataTable();
                adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
                query = "SELECT SUM(transactieBedrag) as 'Roel' FROM Transactie WHERE transactiePersoon = 'Roel' ;";
                cmd = new SQLiteCommand(query, con);
                dt = new DataTable();
                adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView3.DataSource = dt;
            }
            else
            {

                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);
            }

            closeCon();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            querySql();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
    }
}

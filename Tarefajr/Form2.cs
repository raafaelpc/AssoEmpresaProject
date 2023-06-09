using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefajr
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Persist Security Info=False;Trusted_Connection=True;database=db_teste; server=(local)");

        private void button1_Click(object sender, EventArgs e)
        {
            int status = 1;
            string nome = textBox1.Text, cpf = textBox2.Text;
            DateTime datadenascimento = DateTime.Parse(dateTimePicker1.Text);
            con.Open();
            SqlCommand c = new SqlCommand("exec InsertAssociados '" + nome + "','" + cpf + "','" + datadenascimento + "','" + status + "'", con);
            c.ExecuteNonQuery();
            GetAllAssociados();
            MessageBox.Show("Cadastrado com sucesso");
        }

        void GetAllAssociados()
        {
            SqlCommand c = new SqlCommand("exec GetAllAssociados", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllAssociados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int status = 1;
            string nome = textBox3.Text, cnpj = textBox4.Text;
            string cnpjnumbers = Regex.Replace(cnpj, "[^0-9]", "");
            con.Open();
            SqlCommand c = new SqlCommand("exec InsertEmpresas '" + nome + "','" + cnpjnumbers + "','" + status + "'", con);
            c.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Cadastrado com sucesso");
        }
    }
}

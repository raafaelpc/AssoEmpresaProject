using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;

namespace Tarefajr
{
    public partial class Form1 : Form
    {
        Thread nt;
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Persist Security Info=False;Trusted_Connection=True;database=db_teste; server=(local)");
        private void button1_Click(object sender, EventArgs e)// BUTTON PARA PESQUISAR ASSOCIADOS
        {
            int id;
            bool result = Int32.TryParse(textBox5.Text, out id);
            if (!result)
                id = 0;
            string nome = textBox1.Text, cpf = textBox2.Text;

            if (id == 0 && nome.Trim() == "" && cpf.Trim() == "")
            {
                GetAllAssociados();
            }
            else
            {
                GetAssociadosByFilter(id, nome, cpf);
            }

        }

        void GetAssociadosByFilter(int id, string nome, string cpf)
        {
            SqlCommand c = new SqlCommand("exec GetAssociadosByFilter '" + id + "','" + nome + "','" + cpf + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void GetAllAssociados() //GET PARA PEGAR TODAS OS ASSOCIADOS E IMPRIMIR NA TABELA
        {
            SqlCommand c = new SqlCommand("exec GetAllAssociados", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void GetAllEmpresas() //GET PARA PEGAR TODAS AS EMPRESAS E IMPRIMIR NA TABELA
        {
            SqlCommand c = new SqlCommand("exec GetAllEmpresas", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e) //CARREGANDO AS TABELAS AO INICIAR
        {
            GetAllAssociados();
            GetAllEmpresas();
            GetAllAssociadosEmpresas();
        }

        private void button2_Click(object sender, EventArgs e) //ABRIR FORM CADASTRO
        {
            nt = new Thread(CadastroForm);
            nt.Start();
        }

        private void CadastroForm(object? obj)
        {
            Application.Run(new Form2());
        }

        private void button3_Click(object sender, EventArgs e) //ABRIR FORM EDIT
        {
            nt = new Thread(EditForm);
            nt.Start();
        }

        private void EditForm(object? obj)
        {
            Application.Run(new Form3());
        }

        private void button4_Click(object sender, EventArgs e) //BUTTON PARA PESQUISAR AS EMPRESAS
        {
            int id;
            bool result = Int32.TryParse(textBox4.Text, out id);
            if (!result)
                id = 0;
            string nome = textBox6.Text, cnpj = textBox3.Text;
            string cnpjnumbers = Regex.Replace(cnpj, "[^0-9]", "");

            if (id == 0 && nome == "" && cnpjnumbers == "")
            {
                GetAllEmpresas();
            }
            else
            {
                GetEmpresasByFilter(id, nome, cnpjnumbers);
            }

        }

        void GetEmpresasByFilter(int id, string nome, string cnpjnumbers)
        {
            SqlCommand c = new SqlCommand("exec GetEmpresasByFilter '" + id + "','" + nome + "','" + cnpjnumbers + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetAllAssociadosEmpresas();
        }


        void GetAllAssociadosEmpresas()
        {
            SqlCommand c = new SqlCommand("exec GetAllAssociadosEmpresas", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id;
            bool result = Int32.TryParse(textBox7.Text, out id);
            if (!result)
                id = 0;
            if (id == 0)
            {
                GetAllAssociadosEmpresas();
            }
            else
            {
                GetAllAssociadosEmpresasByIdAssociado(id);
            }

        }

        void GetAllAssociadosEmpresasByIdAssociado(int id)
        {
            SqlCommand c = new SqlCommand("exec GetAllAssociadosEmpresasByIdAssociado'" + id + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView3.DataSource = dt;
        }
        void GetAllAssociadosEmpresasByIdEmpresa(int id)
        {
            SqlCommand c = new SqlCommand("exec GetAllAssociadosEmpresasByIdEmpresa'" + id + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id;
            bool result = Int32.TryParse(textBox8.Text, out id);
            if (!result)
                id = 0;
            if (id == 0)
            {
                GetAllAssociadosEmpresas();
            }
            else
            {
                GetAllAssociadosEmpresasByIdEmpresa(id);
            }
        }
    }
}
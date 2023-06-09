using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tarefajr
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Persist Security Info=False;Trusted_Connection=True;database=db_teste; server=(local)");

        private void button1_Click(object sender, EventArgs e) //BUTTON PROCURAR ASSOCIADO
        {
            int id;
            bool result = Int32.TryParse(textBox1.Text, out id);
            if (!result)
                id = 0;
            GetAssociadosById(id);

        }

        void GetAssociadosById(int id)
        {
            try
            {
                SqlCommand c = new SqlCommand("exec GetAssociadosById '" + id + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                textBox3.Text = dt.Rows[0].ItemArray[1].ToString();
                textBox4.Text = dt.Rows[0].ItemArray[2].ToString();
                dateTimePicker1.Text = dt.Rows[0].ItemArray[3].ToString();
                if (dt.Rows[0].ItemArray[5].ToString() == "1")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;


            }
            catch
            {
                MessageBox.Show("Adicione um id do associado valido");
            }
        }

        private void button3_Click(object sender, EventArgs e) //BUTTON PARA ATUALIZAR
        {
            int id, status, statusassociadoempresa = 1;
            bool result = Int32.TryParse(textBox1.Text, out id);
            if (!result)
                id = 0;

            if (radioButton1.Checked = true)
                status = 1;
            else
                status = 0;

            string nome = textBox3.Text, cpf = textBox4.Text;

            DateTime datadenascimento = DateTime.Parse(dateTimePicker1.Text);
            UpdateAssociado(id, nome, cpf, datadenascimento, status);

            if (textBox5.Text != "")
            {
                int idempresa;
                bool result2 = Int32.TryParse(textBox5.Text, out idempresa);
                if (!result2)
                    idempresa = 0;
                VinculandoAssociado(id, idempresa, statusassociadoempresa);
            }

        }

        private void VinculandoAssociado(int idassociado, int idempresa, int statusassociadoempresa)
        {
            con.Open();
            SqlCommand c = new SqlCommand("exec InsertAssociadoEmpresa '" + idassociado + "','" + idempresa + "','" + statusassociadoempresa + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Vinculado com sucesso");
            con.Close();
        }

        private void UpdateAssociado(int id, string nome, string cpf, DateTime datadenascimento, int status)
        {
            try
            {
                con.Open();
                SqlCommand c = new SqlCommand("exec UpdateAssociados '" + id + "','" + nome + "','" + cpf + "','" + datadenascimento + "','" + status + "'", con);
                c.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Atualizado com sucesso");

            }
            catch
            {
                MessageBox.Show("Falha na atualização");
            }
        }

        private void button4_Click(object sender, EventArgs e) //BUTTON PARA ATUALIZAR TAB EMPRESA
        {
            int id;
            bool result = Int32.TryParse(textBox2.Text, out id);
            if (!result)
                id = 0;
            GetEmpresasById(id);
        }
        void GetEmpresasById(int id)
        {
            try
            {
                SqlCommand c = new SqlCommand("exec GetEmpresasById '" + id + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                textBox6.Text = dt.Rows[0].ItemArray[1].ToString();
                textBox7.Text = dt.Rows[0].ItemArray[2].ToString();
                if (dt.Rows[0].ItemArray[4].ToString() == "1")
                    radioButton4.Checked = true;
                else
                    radioButton3.Checked = true;


            }
            catch
            {
                MessageBox.Show("Adicione um id da empresa valido");
            }
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int id;
                bool result = Int32.TryParse(textBox5.Text, out id);
                if (!result)
                    id = 0;

                SqlCommand c = new SqlCommand("exec GetAssociadosById '" + id + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                textBox9.Text = dt.Rows[0].ItemArray[1].ToString();
            }
            catch
            {
                MessageBox.Show("Adicione um id da associado valido");
            }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int id;
                bool result = Int32.TryParse(textBox8.Text, out id);
                if (!result)
                    id = 0;

                SqlCommand c = new SqlCommand("exec GetEmpresasById '" + id + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                textBox10.Text = dt.Rows[0].ItemArray[1].ToString();
            }
            catch
            {
                MessageBox.Show("Adicione um id da empresa valido");
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int idassociado, status = 1;
            bool result = Int32.TryParse(textBox5.Text, out idassociado);
            if (!result)
                idassociado = 0;

            int idempresa;
            bool result2 = Int32.TryParse(textBox8.Text, out idempresa);
            if (!result2)
                idempresa = 0;

            con.Open();
            SqlCommand c = new SqlCommand("exec InsertAssociadoEmpresa '" + idassociado + "','" + idempresa + "','" + status + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Vinculado com sucesso");
            con.Close();
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                int id;
                bool result = Int32.TryParse(textBox5.Text, out id);
                if (!result)
                    id = 0;

                SqlCommand c = new SqlCommand("exec GetEmpresasById '" + id + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                textBox9.Text = dt.Rows[0].ItemArray[1].ToString();
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e) //BUTTON ATUALIZAR EMPRESA
        {
            int id, status, statusassociadoempresa = 1;
            bool result = Int32.TryParse(textBox2.Text, out id);
            if (!result)
                id = 0;

            if (radioButton4.Checked = true)
                status = 1;
            else
                status = 0;

            string nome = textBox6.Text, cnpj = textBox7.Text;

            UpdateEmpresa(id, nome, cnpj, status);

            if (textBox10.Text != "")
            {
                int idassociado;
                bool result2 = Int32.TryParse(textBox1.Text, out idassociado);
                if (!result2)
                    idassociado = 0;
                VinculandoEmpresa(idassociado, id, statusassociadoempresa);
            }

        }

        private void VinculandoEmpresa(int idassociado, int idempresa, int statusassociadoempresa)
        {
            con.Open();
            SqlCommand c = new SqlCommand("exec InsertAssociadoEmpresa '" + idassociado + "','" + idempresa + "','" + statusassociadoempresa + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Vinculado com sucesso");
            con.Close();
        }

        private void UpdateEmpresa(int id, string nome, string cnpj, int status)
        {
            try
            {
                con.Open();
                SqlCommand c = new SqlCommand("exec UpdateEmpresas '" + id + "','" + nome + "','" + cnpj + "','" + status + "'", con);
                c.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Atualizado com sucesso");

            }
            catch
            {
                MessageBox.Show("Falha na atualização");
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int id;
                bool result = Int32.TryParse(textBox5.Text, out id);
                if (!result)
                    id = 0;

                SqlCommand c = new SqlCommand("exec GetAssociadosById '" + id + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                textBox8.Text = dt.Rows[0].ItemArray[1].ToString();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e) //BOTAO DE DELETAR ABA ASSOCIADO
        {
            int id, status = 0;
            bool result = Int32.TryParse(textBox1.Text, out id);
            if (!result)
                id = 0;

            string nome = textBox3.Text, cpf = textBox4.Text;
            DateTime datadenascimento = DateTime.Parse(dateTimePicker1.Text);

            UpdateAssociado(id, nome, cpf, datadenascimento, status);

            UpdateVinculoAssociado(id, status);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            int id, status = 0;
            bool result = Int32.TryParse(textBox2.Text, out id);
            if (!result)
                id = 0;

            string nome = textBox6.Text, cnpj = textBox7.Text;

            UpdateEmpresa(id, nome, cnpj, status);
            UpdateVinculoEmpresa(id, status);
        }

        private void UpdateVinculoEmpresa(int id, int status)
        {
            con.Open();
            SqlCommand c = new SqlCommand("exec UpdateAssociadosIdempresaByIdEmpresa '" + id + "','" + status + "'", con);
            c.ExecuteNonQuery();
            con.Close();
        }

        private void UpdateVinculoAssociado(int id, int status)
        {
            con.Open();
            SqlCommand c = new SqlCommand("exec UpdateAssociadosIdempresaByIdAssociado '" + id + "','" + status + "'", con);
            c.ExecuteNonQuery();
            con.Close();
        }
    }
}

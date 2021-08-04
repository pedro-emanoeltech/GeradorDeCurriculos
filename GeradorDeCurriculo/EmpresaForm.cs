using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeradorDeCurriculo.Dados.DAL;
using GeradorDeCurriculo.Dados.Mapeamento;

namespace GeradorDeCurriculo
{
    public partial class EmpresaForm : Form
    {
        Empresa CadEmpresa = null;
        Usuario UsuarioGravar = null;
        public EmpresaForm()
        {
            InitializeComponent();
            Application.DoEvents();

            this.Text = "Nova Empresa";
            IDEmpresatextBox.Text = "Automatico";
            IDEmpresatextBox.Enabled = false;
            CadEmpresa = new Empresa();
            UsuarioGravar = new Usuario();

        }

        public EmpresaForm(int id)
        {
            InitializeComponent();
            Application.DoEvents();
            this.Text = "Alterando Dados da Empresa";
            
            CadEmpresa = new EmpresaDAO().Buscar(id);
            IDEmpresatextBox.Enabled = false;

            IDEmpresatextBox.Text = CadEmpresa.ID.ToString().Trim();
            NomeEmpresatextBox.Text = CadEmpresa.Nome.ToString().Trim();
            CNPJEmpresatextBox.Text = CadEmpresa.CNPJ.ToString().Trim();
            SetorEmpresatextBox.Text = CadEmpresa.Setor.ToString().Trim();
            EnderecoEmpresatextBox.Text = CadEmpresa.Endereco.ToString().Trim();
            NumeroEmpresatextBox.Text = CadEmpresa.Numero.ToString().Trim();
            BairroEmpresatextBox.Text = CadEmpresa.Bairro.ToString().Trim();
            CidadeEmpresatextBox.Text = CadEmpresa.Cidade.ToString().Trim();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            

        }

        private void Excluirbutton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TelacurriculoForm_Load(object sender, EventArgs e)
        {

        }

        public void IDalterar( )
        {
            

        }


        private void ListarCurriculodataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarCurriculodataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void CidadeEmpresatextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dadosPessoaisBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FecharEmpresaButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GravarEmpresabutton_Click(object sender, EventArgs e)
        {
           
            CadEmpresa.Nome = NomeEmpresatextBox.Text.Trim();
            CadEmpresa.CNPJ = CNPJEmpresatextBox.Text.Trim();
             CadEmpresa.Setor = SetorEmpresatextBox.Text.Trim();
             CadEmpresa.Endereco = EnderecoEmpresatextBox.Text.Trim();
           CadEmpresa.Numero = NumeroEmpresatextBox.Text.Trim();
           CadEmpresa.Bairro = BairroEmpresatextBox.Text.Trim();
             CadEmpresa.Cidade = CidadeEmpresatextBox.Text.Trim();
            CadEmpresa.IDUsuario = Ponte.UsuarioLogado.ID;
            MessageBox.Show(Ponte.UsuarioLogado.ID.ToString());

            var gravar = new EmpresaDAO().Salvar(CadEmpresa);

            
            if (gravar == 0)
            {
                MessageBox.Show("Erro ao Gravar!");

            }

            else
            {
                
                MessageBox.Show("Registro Gravado !");
                
            }


            


        }
    }
}

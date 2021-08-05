using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeradorDeCurriculo.Dados.Mapeamento;
using GeradorDeCurriculo.Dados.DAL;

namespace GeradorDeCurriculo
{
    public partial class UsuarioForm : Form
    {
        Usuario usuarios = null;


        public UsuarioForm()
        {
            InitializeComponent();
            Application.DoEvents();
            NovoUsuario();
        }

        public UsuarioForm(int id)
        {
            InitializeComponent();
            Application.DoEvents();
            EditarUsuario(id);
        }

        private void TelacurriculoForm_Load(object sender, EventArgs e)
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UsuarioFecharbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExcluirUsuarioButton_Click(object sender, EventArgs e)
        {

        }

        private void IDUsuariotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GravarUsuariobutton_Click(object sender, EventArgs e)
        {
            ValidarTipoUsuario();
            GravarUsuario();

        }

        private void AtivoUsuariocheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        void NovoUsuario()
        {
            this.Text = "Criando Usuario";
            IDUsuariotextBox.Text = "Automatico";
            IDUsuariotextBox.Enabled = false;
            ExcluirUsuarioButton.Enabled = false;
            AtivoUsuariocheckBox.Checked = true;
        }

        void EditarUsuario(int id)
        {
            this.Text = "Alteraçao Usuario";
            usuarios = new UsuarioDAO().Buscar(id);
            IDUsuariotextBox.Enabled = false;
            IDUsuariotextBox.Text = usuarios.ID.ToString();
            NomeUsuariotextBox.Text = usuarios.Nome.ToString();
            LoginUsuariotextBox.Text = usuarios.Login.ToString();
            SenhaUsuariotextBox.Text = usuarios.Senha.ToString();
            AtivoUsuariocheckBox.Checked = usuarios.Ativo;
            EmpresaUsuariocheckBox.Checked = usuarios.AcessoEmpresa;
            CandidatoUsuariocheckBox.Checked = usuarios.AcessoCurriculo;
        }

        void ValidarTipoUsuario()
        {
            if (EmpresaUsuariocheckBox.Checked == true || CandidatoUsuariocheckBox.Checked == true)
            {

            }
     
            else
            {
                MessageBox.Show("Selecione um Tipo de Usuario! ", "Tipo de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (EmpresaUsuariocheckBox.Checked == true && CandidatoUsuariocheckBox.Checked == true)
            {
                MessageBox.Show("Marque apenas uma Opçao: EMPRESA ou Candidato !", "Tipo de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        void GravarUsuario()
        {
            Usuario Usuario = new Usuario();
            Usuario.Nome = NomeUsuariotextBox.Text.Trim();
            Usuario.Ativo = AtivoUsuariocheckBox.Checked;
            Usuario.Login = LoginUsuariotextBox.Text.Trim();
            Usuario.Senha = SenhaUsuariotextBox.Text.Trim();
            Usuario.AcessoEmpresa = EmpresaUsuariocheckBox.Checked;
            Usuario.AcessoCurriculo = CandidatoUsuariocheckBox.Checked;

            var gravar = new UsuarioDAO().Salvar(Usuario);

            if (gravar == 0)
                MessageBox.Show("Erro ao Gravar!");
            else
                MessageBox.Show("Registro Gravado !", "Cadastro Confirmado !");
            Close();

        }
    }
}

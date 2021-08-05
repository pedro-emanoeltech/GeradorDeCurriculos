using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using GeradorDeCurriculo.Dados.DAL;
using GeradorDeCurriculo.Dados.Mapeamento;

namespace GeradorDeCurriculo
{
    public partial class IncialForm : Form
    {
        public IncialForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void curriculoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ConsultaCurriculoForm telacurriculo = new ConsultaCurriculoForm();
            telacurriculo.MdiParent = this;
            telacurriculo.Show();
            telacurriculo.WindowState = FormWindowState.Maximized;
        }

        private void TelaInicalForm_Load(object sender, EventArgs e)
        {

        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarEmpresa();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarUsuario();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Ponte.UsuarioLogado.ToString();

        }

        void NovoUsuario()
        {
            Ponte.UsuarioLogado = null;
            Ponte.Empresa = null;
            Ponte.Candidato = null;
        }

        void ValidarUsuario()
        {
            if (Ponte.UsuarioLogado == null)
            {
                EntrarTelaLoginButton.Text = "ENTRAR";
                curriculoToolStripMenuItem.Enabled = false;
                empresaToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = false;
                GerarCurriculoStripButton1.Enabled = false;
                ConsultaVagasButton.Enabled = false;
                toolStripStatusLabel2.Text = "Usuario Nao Logado !";

            }
            else
            {
                EntrarTelaLoginButton.Text = "SAIR";
                curriculoToolStripMenuItem.Enabled = Ponte.UsuarioLogado.AcessoCurriculo;
                empresaToolStripMenuItem.Enabled = Ponte.UsuarioLogado.AcessoEmpresa;
                usuariosToolStripMenuItem.Enabled = true;
                GerarCurriculoStripButton1.Enabled = true;
                ConsultaVagasButton.Enabled = true;
                toolStripStatusLabel2.Text = "Usuario: " + Ponte.UsuarioLogado.Nome;
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            NovoUsuario();
            ValidarUsuario();
            new LoginForm().ShowDialog();
            ValidarUsuario();

        }

        private void TelaInicalForm_Shown(object sender, EventArgs e)
        {
            NovoUsuario();
            ValidarUsuario();
            new LoginForm().ShowDialog();
            ValidarUsuario();
        }

        private void ConsultaVagasButton_Click(object sender, EventArgs e)
        {
            AcessoConsultaVagas();

        }

        void EditarEmpresa()
        {
            Empresa dados = null;

            int usuariologado = Ponte.UsuarioLogado.ID;
            dados = new EmpresaDAO().Rastreio(usuariologado);

            if (dados != null)
            {
                EmpresaForm empresa = new EmpresaForm(dados.ID);
                empresa.MdiParent = this;
                empresa.Show();
                empresa.WindowState = FormWindowState.Maximized;
            }
            else
            {
                EmpresaForm empresa = new EmpresaForm();
                empresa.MdiParent = this;
                empresa.Show();
                empresa.WindowState = FormWindowState.Maximized;
            }
        }

        void EditarUsuario()
        {
            int id = Ponte.UsuarioLogado.ID;

            UsuarioForm editarusuario = new UsuarioForm(id);
            editarusuario.MdiParent = this;
            editarusuario.Show();
            editarusuario.WindowState = FormWindowState.Maximized;
        }

        void AcessoConsultaVagas()
        {
            // verificiando se o usuario tem acesso ao curriculo,  se sim é candidato
            bool tipologado = Ponte.UsuarioLogado.AcessoCurriculo;
            int idUsuario = Ponte.UsuarioLogado.ID;

            if (tipologado == true)
            {
                //Tipo Candidato
               
                var exite = new DadosPessoaisDAO().exite(idUsuario);

                if (exite != null)
                {
                    //Registrando dadospessoais em metodo global
                    RegistrarDadosPessoais(exite.ID);

                    //abrindo tela de Vagas
                    ConsultaVagaForm ConsultaVagas = new ConsultaVagaForm();
                    ConsultaVagas.MdiParent = this;
                    ConsultaVagas.Show();
                    ConsultaVagas.WindowState = FormWindowState.Maximized;

                }
                else
                {
                    MessageBox.Show("Cadastre Primeiro o Curriculo \n Para Acessar a Tela de Vagas ", "Pendente Curriculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            else
            {
                //Tipo Empresa
                
                var exite = new EmpresaDAO().Rastreio(idUsuario);


                if (exite != null)
                {
                    // Registrando empresa em metodo global
                    RegistrarEmpresa(exite.ID);


                    ConsultaVagaForm ConsultaVagas = new ConsultaVagaForm();
                    ConsultaVagas.MdiParent = this;
                    ConsultaVagas.Show();
                    ConsultaVagas.WindowState = FormWindowState.Maximized;

                }
                else
                {
                    MessageBox.Show("Cadastre Primeiro os Dados da Empresa \n Para Acessar a Tela de Vagas ", "Pendente Empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
        }

        void RegistrarDadosPessoais(int id)
        {
            DadosPessoais validardadospessoais = null;
            validardadospessoais = new DadosPessoaisDAO().Buscar(id);
            Ponte.Candidato = validardadospessoais;
        }
        void RegistrarEmpresa(int id)
        {
            Empresa validarempresa = null;
            validarempresa = new EmpresaDAO().Buscar(id);
            Ponte.Empresa = validarempresa;
        }
    }
}

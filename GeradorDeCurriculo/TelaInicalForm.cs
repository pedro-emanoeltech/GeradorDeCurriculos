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
    public partial class TelaInicalForm : Form
    {
        public TelaInicalForm()
        {
            InitializeComponent();
          
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void eXPERIÊNCIAPROFISSIONALToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void curriculoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TelacurriculoForm telacurriculo = new TelacurriculoForm();
            telacurriculo.MdiParent = this;
            telacurriculo.Show();
            telacurriculo.WindowState = FormWindowState.Maximized;
        }

        private void TelaInicalForm_Load(object sender, EventArgs e)
        {

        }


        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            int existe = Ponte.UsuarioLogado.ID;
            

            Empresa dados = null;
            dados = new EmpresaDAO().Rastreio(existe);
           
            


            if (dados != null)
            {

                TelaEmpresaForm empresa = new TelaEmpresaForm(dados.ID);
                empresa.MdiParent = this;
                empresa.Show();
                empresa.WindowState = FormWindowState.Maximized;

            }
            else
            {
                TelaEmpresaForm empresa = new TelaEmpresaForm();
                empresa.MdiParent = this;
                empresa.Show();
                empresa.WindowState = FormWindowState.Maximized;
            }



        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           int id =  Ponte.UsuarioLogado.ID;
            
           UsuariosEditarForm editarusuario= new UsuariosEditarForm(id);
            editarusuario.MdiParent = this;
            editarusuario.Show();
            editarusuario.WindowState = FormWindowState.Maximized;
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Ponte.UsuarioLogado.ToString();
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
                toolStripStatusLabel2.Text = "Usuario:"+Ponte.UsuarioLogado.Nome;
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Ponte.UsuarioLogado = null;
            Ponte.Empresa = null;
            Ponte.Candidato = null;
            ValidarUsuario();
            new LoginForm().ShowDialog();
            ValidarUsuario();

        }

        private void TelaInicalForm_Shown(object sender, EventArgs e)
        {
            Ponte.UsuarioLogado = null;
            Ponte.Empresa = null;
            Ponte.Candidato = null;
            ValidarUsuario();
            new LoginForm().ShowDialog();
            ValidarUsuario();
        }

        private void ConsultaVagasButton_Click(object sender, EventArgs e)
        {
            
          
            bool tipologado = Ponte.UsuarioLogado.AcessoCurriculo;
            int idUsuario = Ponte.UsuarioLogado.ID;


            if (tipologado == true)
            {
                DadosPessoais Validardadospessoais = null;
                var exite = new DadosPessoaisDAO().exite(idUsuario);
                


                if (exite != null)
                {
                    Validardadospessoais = new DadosPessoaisDAO().Buscar(exite.ID);

                    Ponte.Candidato = Validardadospessoais;

                    TelaConsultaVagas ConsultaVagas = new TelaConsultaVagas();

                    ConsultaVagas.MdiParent = this;
                    ConsultaVagas.Show();
                    ConsultaVagas.WindowState = FormWindowState.Maximized;

                }
                else
                {
                    MessageBox.Show("Cadastre Primeiro o Curriculo \n Para Acessar a Tela de Vagas ", "Pendente Curriculo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                
            }
            else
            {

                Empresa Validarempresa = null;
                var exite = new EmpresaDAO().Rastreio(idUsuario);
                

                if (exite != null)
                {
                    Validarempresa = new EmpresaDAO().Buscar(exite.ID);
                    Ponte.Empresa = Validarempresa;

                    TelaConsultaVagas ConsultaVagas = new TelaConsultaVagas();
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
    }
}

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
    public partial class VagaEditarForm : Form
    {


        Vagas vagas = null;
        Empresa Empresavaga = null;
        public VagaEditarForm()
        {
            InitializeComponent();
            Application.DoEvents();

            this.Text = "Nova Vaga";
            IDDadosPessoaistextBox.Text = "Automático";
            IDDadosPessoaistextBox.Enabled = false;
            ExcluirVagaButton.Enabled = false;
            vagas = new Vagas();
            Candidatarbutton.Enabled = false;
            EmpresaVagatextBox.Enabled = false;
            SetorEmpresaVagatextBox.Enabled = false;
            CidadeEmpresatextBox.Enabled = false;
            IDEmpresaVagatextBox.Enabled = false;
            Empresavaga = Ponte.Empresa;





        }

        public VagaEditarForm(int id)
        {
            InitializeComponent();
            Application.DoEvents();

            bool tipologado = Ponte.UsuarioLogado.AcessoCurriculo;
            int idUsuario = Ponte.UsuarioLogado.ID;


            if (tipologado == true)
            {
                ExcluirVagaButton.Enabled = false;
                this.Text = "Visualizando Vaga";

                EmpresaVagatextBox.Enabled = false;
                SetorEmpresaVagatextBox.Enabled = false;
                CidadeEmpresatextBox.Enabled = false;
                IDEmpresaVagatextBox.Enabled = false;
                
                GravarVagabutton.Enabled = false;
                IDDadosPessoaistextBox.Enabled = false;
                TituloVagatextBox.Enabled = false;
                DescricaoVagatextBox.Enabled = false;
                CidadeVagatextBox.Enabled = false;
                TipoVagatextBox.Enabled = false;
                SalarioVagatextBox.Enabled = false;
                RequisitosVagatextBox.Enabled = false;
                AtividadeVagatextBox.Enabled = false;
               

                IDEmpresaVagatextBox.Enabled = false;
                EmpresaVagatextBox.Enabled = false;
                SetorEmpresaVagatextBox.Enabled = false;
                CidadeEmpresatextBox.Enabled = false;
                



                vagas = new VagasDAO().Buscar(id);
                IDDadosPessoaistextBox.Enabled = false;
                ExcluirVagaButton.Enabled = true;

                IDDadosPessoaistextBox.Text = vagas.ID.ToString().Trim();
                TituloVagatextBox.Text = vagas.TituloVaga.ToString().Trim();
                DescricaoVagatextBox.Text = vagas.Descricao.ToString().Trim();
                CidadeVagatextBox.Text = vagas.Cidade.ToString().Trim();
                TipoVagatextBox.Text = vagas.TipoVaga.ToString().Trim();
                SalarioVagatextBox.Text = vagas.Salario.ToString().Trim();
                RequisitosVagatextBox.Text = vagas.Requisitos.ToString().Trim();
                AtividadeVagatextBox.Text = vagas.Atividade.ToString().Trim();


                Empresavaga = new EmpresaDAO().Buscar(Convert.ToInt32(vagas.IDEmpresa));

                //empresa 
                IDEmpresaVagatextBox.Text = Empresavaga.ID.ToString().Trim();
                EmpresaVagatextBox.Text = Empresavaga.Nome.ToString().Trim();
                SetorEmpresaVagatextBox.Text = Empresavaga.Setor.ToString().Trim();
                CidadeEmpresatextBox.Text = Empresavaga.Cidade.ToString().Trim();

                ExcluirVagaButton.Enabled = false;


            }
            else
            {

                EmpresaVagatextBox.Enabled = false;
                SetorEmpresaVagatextBox.Enabled = false;
                CidadeEmpresatextBox.Enabled = false;
                IDEmpresaVagatextBox.Enabled = false;
                


                this.Text = "Alteraçao Curriculo";

                vagas = new VagasDAO().Buscar(id);
                IDDadosPessoaistextBox.Enabled = false;
                ExcluirVagaButton.Enabled = true;

                IDDadosPessoaistextBox.Text = vagas.ID.ToString().Trim();
                TituloVagatextBox.Text = vagas.TituloVaga.ToString().Trim();
                DescricaoVagatextBox.Text = vagas.Descricao.ToString().Trim();
                CidadeVagatextBox.Text = vagas.Cidade.ToString().Trim();
                TipoVagatextBox.Text = vagas.TipoVaga.ToString().Trim();
                SalarioVagatextBox.Text = vagas.Salario.ToString().Trim();
                RequisitosVagatextBox.Text = vagas.Requisitos.ToString().Trim();
                AtividadeVagatextBox.Text = vagas.Atividade.ToString().Trim();


                Empresavaga = new EmpresaDAO().Buscar(Convert.ToInt32(vagas.IDEmpresa));

                //empresa 
                IDEmpresaVagatextBox.Text = Empresavaga.ID.ToString().Trim();
                EmpresaVagatextBox.Text = Empresavaga.Nome.ToString().Trim();
                SetorEmpresaVagatextBox.Text = Empresavaga.Setor.ToString().Trim();
                CidadeEmpresatextBox.Text = Empresavaga.Cidade.ToString().Trim();


            }





        }

      


        private void tabelasdecontrole(int index) {

            GeraltabControl.SelectedIndex = index;

        }

         public void BuscarExperienciaProfissional(int id)
        {
            
            var Listar= new ExperienciaProfissionalDAO().Listar(id);

            CandidatosdataGridView.DataSource = Listar;

        }


        public void Buscarformacao(int id)
        {

            

        }

        private void CurriculoEditarForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void DadosPessoaisbutton_Click(object sender, EventArgs e)
        {
            tabelasdecontrole(0);
            

        }

        private void ExperienciaProfissionalbutton_Click(object sender, EventArgs e)
        {
           
           tabelasdecontrole(1);
           

           

          
            bool tipologado = Ponte.UsuarioLogado.AcessoCurriculo;
            int idUsuario = Ponte.UsuarioLogado.ID;


            if (tipologado == true)
            {

                int idvaga = Convert.ToInt32(IDDadosPessoaistextBox.Text);
                vagas = new Vagas();
                vagas = new VagasDAO().Buscar(idvaga);
                var Listar = new CandidaturasDAO().ListarCandidato(idvaga, Ponte.Candidato.ID);
                

                CandidatosdataGridView.DataSource = Listar;

                AprovadocheckBox.Enabled = false;
                InstrucaoVagatextBox.Enabled = false;
                GravarVagaCandidaturabutton.Enabled = false;
                IDdadospessoaisVagatextBox.Enabled = false;
                NomeDadosPessoaisVagatextBox.Enabled = false;
                TelefoneDadospessoaistextBox.Enabled = false;
                NomeVagatextBox.Enabled = false;
                DataCadastroTimePicker.Enabled = false;
                //controle
                CanditatarSalvarbutton.Enabled = true;
                DeletarCandidaturabutton.Enabled = false;
                

                

                

                 var candidatura = new CandidaturasDAO().Buscar(idvaga, Ponte.Candidato.ID);

                NomeVagatextBox.Text = vagas.TituloVaga.ToString().Trim();

                IDdadospessoaisVagatextBox.Text = Ponte.Candidato.ID.ToString().Trim();
                NomeDadosPessoaisVagatextBox.Text = Ponte.Candidato.Nome.ToString().Trim();
                TelefoneDadospessoaistextBox.Text = Ponte.Candidato.Telefone.ToString().Trim();



                if (Listar.Count>0)
                {

                    
                    CanditatarSalvarbutton.Enabled = false;
                    DeletarCandidaturabutton.Enabled = true;
                    AprovadocheckBox.Checked = candidatura.Situacao;
                    InstrucaoVagatextBox.Text = Convert.ToString(candidatura.instrucoes);
                    DataCadastroTimePicker.Value = candidatura.DataCadastro.Date;





                }
                else
                {
                    CanditatarSalvarbutton.Enabled = true;
                    DeletarCandidaturabutton.Enabled = false;



                }




            }
            else
            {
                
                DeletarCandidaturabutton.Enabled = false;
                CanditatarSalvarbutton.Enabled = false;
                IDdadospessoaisVagatextBox.Enabled = false;
                NomeDadosPessoaisVagatextBox.Enabled = false;
                TelefoneDadospessoaistextBox.Enabled = false;
                NomeVagatextBox.Enabled = false;
                DataCadastroTimePicker.Enabled = false;
                BuscarCurriculobutton.Enabled = false;


                int id = Convert.ToInt32(IDDadosPessoaistextBox.Text);
                var Listar = new CandidaturasDAO().Listar(id);


                CandidatosdataGridView.DataSource = Listar;

            }


        }

        private void Formacaobutton_Click(object sender, EventArgs e)
        {
            

        }

        private void Usuariobutton_Click(object sender, EventArgs e)
        {
            tabelasdecontrole(3);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

           
           
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormacaotabPage_Click(object sender, EventArgs e)
        {

        }

        private void StatusEditarLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExcluirDadosPessoaisButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Excluir a Vaga :\n Será deletado todo Registro vinculado ao Cadastro: " + vagas.TituloVaga + "?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(IDDadosPessoaistextBox.Text);
                var vagas = new VagasDAO().Excluir(id);
                if (vagas)
                {

                    MessageBox.Show("Excluido Com sucesso");
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Excluir ");
                }
            }
        }
        private void EditarExperienciaProfissionalbutton_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void ExperienciaprofdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditarFormacaobutton_Click(object sender, EventArgs e)
        {
           
        }

        private void DeletarExperienciaProfissionalbutton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja Realmente Excluir sua Candidatura? \n para vaga de"+ NomeVagatextBox.Text.ToString()+"!!", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(IDdadospessoaisVagatextBox.Text);
           
                var candidaturas= new CandidaturasDAO().Excluir(id);
                if (candidaturas)
                {

                    MessageBox.Show("Excluido Com sucesso");
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Excluir ");
                }




            }
        }

        private void DeletarFormacaoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void GravarDadosPessoaisbutton_Click(object sender, EventArgs e)
        {

         
            
            vagas.TituloVaga= TituloVagatextBox.Text.Trim();
            vagas.Descricao = DescricaoVagatextBox.Text.Trim();
            vagas.Cidade= CidadeVagatextBox.Text.Trim();
            vagas.TipoVaga= TipoVagatextBox.Text.Trim();
            vagas.Salario = Convert.ToDecimal( SalarioVagatextBox.Text.Trim());
            vagas.Requisitos = RequisitosVagatextBox.Text.Trim();
            vagas.Atividade = AtividadeVagatextBox.Text.Trim();


           


           
            var gravar = new VagasDAO().Salvar(vagas);


            if (gravar == 0)
            {
                MessageBox.Show("Erro ao Gravar!");

            }

            else
            {


                MessageBox.Show("Registro Gravado !");
                Close();
            }



        }

        private void GravarExperienciaProfissionalbutton_Click(object sender, EventArgs e)
        {

            

        }

        private void CargoExperienciaProfissionaltextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void ExperienciaProfissionaltabPage_Click(object sender, EventArgs e)
        {

        }

        private void NovoExpProfissionalbutton_Click(object sender, EventArgs e)
        {
          

        }

        private void IDexpProfissionaltextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NovoFormacaobutton_Click(object sender, EventArgs e)
        {

           

        }

        private void DadosPessoaistabPage_Click(object sender, EventArgs e)
        {

        }

        private void BuscarCurriculobutton_Click(object sender, EventArgs e)
        {
           
                new CurriculoEditarForm(Convert.ToInt32(IDdadospessoaisVagatextBox.Text)).ShowDialog();

          
            
        }

        private void CanditatarSalvarbutton_Click(object sender, EventArgs e)
        {
            Candidaturas candidaturas = new Candidaturas();
           
            int idvaga = Convert.ToInt32(IDDadosPessoaistextBox.Text);
            int iddadospessoais = Convert.ToInt32(IDDadosPessoaistextBox.Text);

            candidaturas.IDDadosPessoais = iddadospessoais;
            candidaturas.IDVaga = idvaga;
            candidaturas.DataCadastro = Convert.ToDateTime(DataCadastroTimePicker.Value.Date);
            candidaturas.CurriculoNome = NomeVagatextBox.Text.ToString().Trim();

            var gravar = new CandidaturasDAO().Salvar(candidaturas);

            if (gravar == 0)
                MessageBox.Show("Erro ao Gravar!");
            else
                MessageBox.Show("Candidatura Confirmada!");
            tabelasdecontrole(0);



        }
    }
}

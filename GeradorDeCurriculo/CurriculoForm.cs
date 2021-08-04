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
    public partial class CurriculoForm : Form
    {

        DadosPessoais dadospessoais = null;
                 // se tipologado Verdadeiro usuario é Candidato
        bool tipologado = Ponte.UsuarioLogado.AcessoCurriculo;
        int idUsuario = Ponte.UsuarioLogado.ID;

        public CurriculoForm()
        {
            InitializeComponent();
            Application.DoEvents();

            this.Text = "Novo Curriculo";
            IDDadosPessoaistextBox.Text = "Automático";

            IDDadosPessoaistextBox.Enabled = false;
            ExcluirDadosPessoaisButton.Enabled = false;
            ExperienciaProfissionalbutton.Enabled = false;
            Formacaobutton.Enabled = false;
            Candidaturas.Enabled = false;
            ExcluirDadosPessoaisButton.Enabled = false;
            DataNascimentodateTimePicker.Text = ("");
            dadospessoais = new DadosPessoais();

        }

        public CurriculoForm(int id)
        {
            InitializeComponent();
            Application.DoEvents();

            this.Text = "Alteraçao Curriculo";


            dadospessoais = new DadosPessoaisDAO().Buscar(id);

           


            if (tipologado == true)
            {

                IDDadosPessoaistextBox.Text = dadospessoais.ID.ToString();
                IDDadosPessoaistextBox.Enabled = false;
                NomeDadosPessoaistextBox.Text = dadospessoais.Nome.ToString();

                DataNascimentodateTimePicker.Value = dadospessoais.DataNascimento.Date;
                NacionalidadeDadosPessoaistextBox.Text = dadospessoais.Nacionalidade.ToString();
                TelefoneDadosPessoaistextBox.Text = dadospessoais.Telefone.ToString();
                EnderecoDadosPessoaistextBox.Text = dadospessoais.Endereco.ToString();
                BairroDadosPessoaistextBox.Text = dadospessoais.Bairro.ToString();
                CidadeDadosPessoaistextBox.Text = dadospessoais.Cidade.ToString();


                ExcluirDadosPessoaisButton.Enabled = true;

            }
            else
            {
                IDDadosPessoaistextBox.Text = dadospessoais.ID.ToString();
                IDDadosPessoaistextBox.Enabled = false;
                NomeDadosPessoaistextBox.Text = dadospessoais.Nome.ToString();

                DataNascimentodateTimePicker.Value = dadospessoais.DataNascimento.Date;
                NacionalidadeDadosPessoaistextBox.Text = dadospessoais.Nacionalidade.ToString();
                TelefoneDadosPessoaistextBox.Text = dadospessoais.Telefone.ToString();
                EnderecoDadosPessoaistextBox.Text = dadospessoais.Endereco.ToString();
                BairroDadosPessoaistextBox.Text = dadospessoais.Bairro.ToString();
                CidadeDadosPessoaistextBox.Text = dadospessoais.Cidade.ToString();

                IDDadosPessoaistextBox.Enabled = false;
                IDDadosPessoaistextBox.Enabled = false;
                NomeDadosPessoaistextBox.Enabled = false;
                DataNascimentodateTimePicker.Enabled = false;
                NacionalidadeDadosPessoaistextBox.Enabled = false;
                TelefoneDadosPessoaistextBox.Enabled = false;
                EnderecoDadosPessoaistextBox.Enabled = false;
                BairroDadosPessoaistextBox.Enabled = false;
                CidadeDadosPessoaistextBox.Enabled = false;

                ExcluirDadosPessoaisButton.Enabled = false;
                GravarDadosPessoaisbutton.Enabled = false;
                Candidaturas.Enabled = false;


            }
            
        }

      


        private void tabelasdecontrole(int index) {

            GeraltabControl.SelectedIndex = index;

        }

         public void BuscarExperienciaProfissional(int id)
        {
            
            var Listar= new ExperienciaProfissionalDAO().Listar(id);

            ExperienciaprofdataGridView.DataSource = Listar;

        }


        public void Buscarformacao(int id)
        {

            var Listar = new FormacaoDAO().Listar(id);

            FormacaoGridView.DataSource = Listar;

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
            if (tipologado == true)
            {
                int id = Convert.ToInt32(IDDadosPessoaistextBox.Text);
                BuscarExperienciaProfissional(id);
                IDexpProfissionaltextBox.Enabled = false;
                IDexpProfissionaltextBox.Text = "0";

            }
            else
            {
                int id = Convert.ToInt32(IDDadosPessoaistextBox.Text);
                BuscarExperienciaProfissional(id);
                IDexpProfissionaltextBox.Enabled = false;
                NomeEmpresaExperienciaProfissionaltextBox.Enabled = false;
                AtividadeExperienciaProfissionaltextBox.Enabled = false;
                SalarioExperienciaProfissionaltextBox.Enabled = false;
                DescricaoExperienciaProfissionaltextBox.Enabled = false;
                GravarExperienciaProfissionalbutton.Enabled = false;
                DeletarExperienciaProfissionalbutton.Enabled = false;
                NovoExpProfissionalbutton.Enabled = false;
                EditarExperienciaProfissionalbutton.Text = "Visualizar";


            }



        }

        private void Formacaobutton_Click(object sender, EventArgs e)
        {
            if (tipologado == true)
            {
                tabelasdecontrole(2);
                int id = Convert.ToInt32(IDDadosPessoaistextBox.Text);
                Buscarformacao(id);
                IDFormacaotextBox.Enabled = false;
                IDFormacaotextBox.Text = "0";
            }
            else
            {
                tabelasdecontrole(2);
                int id = Convert.ToInt32(IDDadosPessoaistextBox.Text);
                Buscarformacao(id);
                IDFormacaotextBox.Enabled = false;
                NivelFormacaoformacaotextBox.Enabled = false;
                DescricaoformacaotextBox.Enabled = false;
                InicioformacaodateTimePicker.Enabled = false;
                ConclusaodateTimePicker.Enabled = false;
                StatusFormacaotextBox.Enabled = false;
                Gravarformacaobutton.Enabled = false;
                DeletarFormacaoButton.Enabled = false;
                NovoFormacaobutton.Enabled = false;
                EditarFormacaobutton.Text = "Visualisar";

            }

        }

        private void Usuariobutton_Click(object sender, EventArgs e)
        {
            tabelasdecontrole(3);


            if (tipologado == true)
            {
                int id = Convert.ToInt32(IDDadosPessoaistextBox.Text);

                //informaçoes da experiencia profissional lista
                ExperienciaProfissionalDAO ExperienciaProfissional = new ExperienciaProfissionalDAO();    
                var ListarExperienciaProfissional = ExperienciaProfissional.Listar(id);
                QtExperienciaProfissionallabel.Text = "" + ListarExperienciaProfissional.Count();
                QtExperienciaProfissionallistDataGridView.DataSource = ListarExperienciaProfissional;

                //informaçoes de formaçao lista
                FormacaoDAO formacao = new FormacaoDAO();
                var ListarFormacao = formacao.Listar(id);
                Formacaolabel.Text = "" + ListarFormacao.Count();
                QtFormacaoGridView.DataSource = ListarFormacao;


                //informaçoes de candidaturas cadastradas pelo Candidato






            }
            else
            {


            }


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

           
            Formacao formacao = new Formacao();
            int id = Convert.ToInt32(IDDadosPessoaistextBox.Text);

            formacao.ID = Convert.ToInt32(IDFormacaotextBox.Text.Trim());
            formacao.IDDadosPessoais = id;
            formacao.Curso = CursoformacaotextBox.Text.Trim();
            formacao.Descricao = DescricaoformacaotextBox.Text.Trim();
            formacao.Status = StatusFormacaotextBox.Text.Trim(); 
            formacao.FormacaoNivel = NivelFormacaoformacaotextBox.Text.Trim();

            formacao.Inicio = Convert.ToDateTime(InicioformacaodateTimePicker.Value.Date);
            formacao.Termino= Convert.ToDateTime(ConclusaodateTimePicker.Value.Date);




            var gravar = new FormacaoDAO().Salvar(formacao);
            if (gravar == 0)
                MessageBox.Show("Erro ao Gravar!");
            else
                MessageBox.Show("Registro Gravado !");



            Buscarformacao(id);
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
            if (MessageBox.Show("Deseja Realmente Excluir o Curriculo? Será deletado todo Registro vinculado ao Cadastro: " + dadospessoais.Nome + "?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(IDDadosPessoaistextBox.Text);
                new FormacaoDAO().ExcluirVinculo(id);
                new ExperienciaProfissionalDAO().ExcluirVinculo(id);
                var apagarDadosPessoais = new DadosPessoaisDAO().Excluir(id);
                if(apagarDadosPessoais)
                {
                    
                    MessageBox.Show("Excluido Com sucesso");
                    tabelasdecontrole(0);
                }
                else
                {
                    MessageBox.Show("Erro ao Excluir ");
                }




            }
        }

        private void EditarExperienciaProfissionalbutton_Click(object sender, EventArgs e)
        {
            int ID = 0;
            try
            {
                ID = Convert.ToInt32(ExperienciaprofdataGridView.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value);

            }
            catch
            {
                MessageBox.Show("Selecione a Experiencia Profissional para Alterar");

            }
            if (ID > 0)
            {

                ExperienciaProfissionalDAO ExperienciaProfissional = new ExperienciaProfissionalDAO();


                NomeEmpresaExperienciaProfissionaltextBox.Text = ExperienciaProfissional.Buscar(ID).Empresa.ToString();
                CargoExperienciaProfissionaltextBox.Text = ExperienciaProfissional.Buscar(ID).Cargo.ToString();
                AtividadeExperienciaProfissionaltextBox.Text = ExperienciaProfissional.Buscar(ID).Segmento.ToString();
                DescricaoExperienciaProfissionaltextBox.Text = ExperienciaProfissional.Buscar(ID).Descricao.ToString();
                SalarioExperienciaProfissionaltextBox.Text = ExperienciaProfissional.Buscar(ID).Salario.ToString("N2");
                IDexpProfissionaltextBox.Text = ExperienciaProfissional.Buscar(ID).ID.ToString();

            }
            
            
        }

        private void ExperienciaprofdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditarFormacaobutton_Click(object sender, EventArgs e)
        {
            int ID = 0;
            try
            {
                ID = Convert.ToInt32(FormacaoGridView.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn1"].Value);
              

            }
            catch
            {
                MessageBox.Show("Selecione a Formaçao para Editar");

            }

            if (ID > 0)
            {

                FormacaoDAO Formacao = new FormacaoDAO();

                CursoformacaotextBox.Text = Formacao.Buscar(ID).Curso.ToString();
                
                DescricaoformacaotextBox.Text = Convert.ToString(Formacao.Buscar(ID).Descricao);
                NivelFormacaoformacaotextBox.Text = Formacao.Buscar(ID).FormacaoNivel.ToString();
                InicioformacaodateTimePicker.Text = Formacao.Buscar(ID).Inicio.ToString();
                ConclusaodateTimePicker.Text = Formacao.Buscar(ID).Termino.ToString();
                StatusFormacaotextBox.Text = Formacao.Buscar(ID).Status.ToString();
                IDFormacaotextBox.Text = Formacao.Buscar(ID).ID.ToString();


            }
        }

        private void DeletarExperienciaProfissionalbutton_Click(object sender, EventArgs e)
        {
            ExperienciaProfissionalDAO ExpProfissional = new ExperienciaProfissionalDAO();
            int ID = 0;
            try
            {
                ID = Convert.ToInt32(ExperienciaprofdataGridView.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value);

            }
            catch
            {
                MessageBox.Show("Selecione a Experiencia Profissional para Excluir");

            }

            if (MessageBox.Show("Deseja Realmente Excluir a Experiencia Profissional:" + ExpProfissional.Buscar(ID).Cargo.ToString(), "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



               var valido =  ExpProfissional.Excluir(ID);
                if (valido)
                {

                    MessageBox.Show("Excluido Com sucesso");
                    int Iddadospessoais = Convert.ToInt32(IDDadosPessoaistextBox.Text);
                    BuscarExperienciaProfissional(Iddadospessoais);
                }
                else
                {
                    MessageBox.Show("Erro ao Excluir ");
                }

            }
        }

        private void DeletarFormacaoButton_Click(object sender, EventArgs e)
        {
            FormacaoDAO formacao = new FormacaoDAO();
            int ID = 0;
            
            try
            {
                ID = Convert.ToInt32(FormacaoGridView.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn1"].Value);


            }
            catch
            {
                MessageBox.Show("Selecione a Formaçao para Editar");

            }

            if (MessageBox.Show("Deseja Realmente Excluir a Formação:" + formacao.Buscar(ID).Curso.ToString(), "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                var valido = formacao.Excluir(ID);
                if (valido)
                {

                    MessageBox.Show("Excluido Com sucesso");
                    int id = Convert.ToInt32(IDDadosPessoaistextBox.Text);
                    Buscarformacao(id);

                }
                else
                {
                    MessageBox.Show("Erro ao Excluir ");
                }

            }
        }

        private void GravarDadosPessoaisbutton_Click(object sender, EventArgs e)
        {

            dadospessoais.Nome = NomeDadosPessoaistextBox.Text.Trim();
            dadospessoais.Endereco = EnderecoDadosPessoaistextBox.Text.Trim();
            dadospessoais.Bairro = BairroDadosPessoaistextBox.Text.Trim();
            dadospessoais.Cidade = CidadeDadosPessoaistextBox.Text.Trim();
            dadospessoais.Nacionalidade = NacionalidadeDadosPessoaistextBox.Text.Trim();
            dadospessoais.Telefone = TelefoneDadosPessoaistextBox.Text.Trim();
            if (DataNascimentodateTimePicker.Text == "")
            {
                MessageBox.Show("Selecione a Data de Nascimento", "Seleçao de Data de Nascimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dadospessoais.DataNascimento = Convert.ToDateTime(DataNascimentodateTimePicker.Value.Date);

            dadospessoais.IDUsuario = Ponte.UsuarioLogado.ID;

            

            var gravar = new DadosPessoaisDAO().Salvar(dadospessoais);
            

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

            ExperienciaProfissional experienciaprofissional = new ExperienciaProfissional();
            int id = Convert.ToInt32(IDDadosPessoaistextBox.Text);

            experienciaprofissional.Empresa = NomeEmpresaExperienciaProfissionaltextBox.Text.Trim();
            experienciaprofissional.Segmento = AtividadeExperienciaProfissionaltextBox.Text.Trim();
            experienciaprofissional.Descricao = DescricaoExperienciaProfissionaltextBox.Text.Trim();
            experienciaprofissional.Cargo = CargoExperienciaProfissionaltextBox.Text.Trim();
            experienciaprofissional.Salario = Convert.ToDecimal(SalarioExperienciaProfissionaltextBox.Text.Trim());
            experienciaprofissional.ID = Convert.ToInt32(IDexpProfissionaltextBox.Text.Trim());
            experienciaprofissional.IDDadosPessoais = id;


            var gravar = new ExperienciaProfissionalDAO().Salvar(experienciaprofissional);
            if (gravar == 0)
                MessageBox.Show("Erro ao Gravar!");
            else
                MessageBox.Show("Registro Gravado !");


            
            BuscarExperienciaProfissional(id);

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
            NomeEmpresaExperienciaProfissionaltextBox.Text = "";
            CargoExperienciaProfissionaltextBox.Text = "";
            AtividadeExperienciaProfissionaltextBox.Text = "";
            DescricaoExperienciaProfissionaltextBox.Text = "";
            SalarioExperienciaProfissionaltextBox.Text = "";
            IDexpProfissionaltextBox.Text = "0";

        }

        private void IDexpProfissionaltextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NovoFormacaobutton_Click(object sender, EventArgs e)
        {

            CursoformacaotextBox.Text = "";
;            DescricaoformacaotextBox.Text = "";
            NivelFormacaoformacaotextBox.Text = "";
            InicioformacaodateTimePicker.Text = "";
            ConclusaodateTimePicker.Text = "";
            StatusFormacaotextBox.Text = "";
            IDFormacaotextBox.Text = "0";

        }

        private void DadosPessoaistabPage_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void NacionalidadeDadosPessoaistextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnderecoDadosPessoaistextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void formacaoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

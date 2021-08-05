using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Referencia 
using GeradorDeCurriculo.Dados.DAL;

namespace GeradorDeCurriculo
{
    public partial class ConsultaCurriculoForm : Form
    {
        public ConsultaCurriculoForm()
        {
            InitializeComponent();
            Application.DoEvents();
            VerificarExistenciaCurriculo();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            ListarCurriculo();

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

        private void Alterarbutton_Click(object sender, EventArgs e)
        {
            EditarCurriculo();

        }

        private void Incluirbutton_Click(object sender, EventArgs e)
        { 
            new CurriculoForm().ShowDialog();
            ListarCurriculo();

        }

        private void ListarCurriculodataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void ListarCurriculo()
        {
            StatusBuscalabel.Text = "Buscando....";
            //atualizar label antes de rodar todo o codigo
            Application.DoEvents();

            int iddadospessoais = Ponte.UsuarioLogado.ID;
            var lista = new DadosPessoaisDAO().Listar(iddadospessoais);
            Alterarbutton.Enabled = lista.Count > 0;
            StatusBuscalabel.Text = "Registros Encontrados:" + lista.Count;
            Application.DoEvents();

            ListarCurriculodataGridView.DataSource = lista;
        }

        void VerificarExistenciaCurriculo()
        {
            // verificar se ja possui curriculo
            int idUsuario = Ponte.UsuarioLogado.ID;
            var exite = new DadosPessoaisDAO().exite(idUsuario);
            if (exite != null)
            {
                Incluirbutton.Enabled = false;
            }
        }

        void EditarCurriculo()
        {
            int id = 0;
            try
            {
                id = Convert.ToInt32(ListarCurriculodataGridView.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value);
            }
            catch
            {
                MessageBox.Show("Selecione o Curriculo para Alterar");

            }
            if (id > 0)
            {
                new CurriculoForm(id).ShowDialog();
                ListarCurriculo();

            }
        }
    }
}

using GeradorDeCurriculo.Dados.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeCurriculo
{
    public partial class ConsultaVagaForm : Form
    {
        bool tipologado = Ponte.UsuarioLogado.AcessoCurriculo;
        int idUsuario = Ponte.UsuarioLogado.ID;
        public ConsultaVagaForm()
        {
            InitializeComponent();
            Application.DoEvents();

            
          


            if (tipologado == true)
            {
                Incluirbutton.Enabled = false;
                Alterarbutton.Text = "Candidatar";

            }
          
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buscarButton_Click(object sender, EventArgs e)
        {

            Listar();

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

        void Listar()
        {

            StatusBuscalabel.Text = "Buscando....";
            //atualizar label antes de rodar todo o codigo
            Application.DoEvents();


            bool tipologado = Ponte.UsuarioLogado.AcessoCurriculo;
            

            if (tipologado==true) {

                var lista = new VagasDAO().Listar(PesquisatextBox.Text);
                Alterarbutton.Enabled = lista.Count > 0;
                StatusBuscalabel.Text = "Registros Encontrados:" + lista.Count;
                Application.DoEvents();
                ListarVagasGridView.DataSource = lista;
            }
            else
            {
                var lista = new VagasDAO().ListarEmpresa(Ponte.Empresa.ID);
                Alterarbutton.Enabled = lista.Count > 0;
                StatusBuscalabel.Text = "Registros Encontrados:" + lista.Count;
                Application.DoEvents();
                ListarVagasGridView.DataSource = lista;

            }





            
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

        private void Alterarbutton_Click(object sender, EventArgs e)
        {
            

            int id = 0;
            try
            {
                id = Convert.ToInt32(ListarVagasGridView.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value);

            }
            catch
            {
                MessageBox.Show("Selecione a Vaga para Abrir");

            }
            if (id > 0)
            {

                new VagaForm(id).ShowDialog();
                Listar();
            }
            
        }

        private void Incluirbutton_Click(object sender, EventArgs e)
        {
            new VagaForm().ShowDialog();
            Listar();
        }

        private void ListarCurriculodataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

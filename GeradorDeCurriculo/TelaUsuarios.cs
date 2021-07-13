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
    public partial class TelaUsuarios : Form
    {
        public TelaUsuarios()
        {
            InitializeComponent();
            Application.DoEvents();
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

            var lista = new UsuariosDAO().Listar(PesquisatextBox.Text);
            Alterarbutton.Enabled = lista.Count > 0;
            StatusBuscalabel.Text = "Registros Encontrados:" + lista.Count;
            Application.DoEvents();

            ListarUsuariosGridView.DataSource = lista;
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
        
            
            
        }

        private void Incluirbutton_Click(object sender, EventArgs e)
        {
           

        }

        private void ListarCurriculodataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

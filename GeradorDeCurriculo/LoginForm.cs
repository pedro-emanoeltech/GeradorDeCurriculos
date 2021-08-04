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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }

        private void LoginUsuariotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SenhaUsuariotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UsuarioFecharbutton_Click(object sender, EventArgs e)
        {
            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FecharLoginbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void EntrarLoginbutton_Click(object sender, EventArgs e)
        {
            
            var usuario = new UsuarioDAO().EntrarLogin(LogintextBox.Text.Trim(), SenhaloginetextBox.Text.Trim());


            if (usuario == null)
            {
                MessageBox.Show("Usuario ou Senha Incorreta \n Caso nao tenha login e senha tente se cadastrar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (usuario.Ativo == false)
                {
                    MessageBox.Show("Usuario Inativo! Procure o Responsavel ", "Login Inativo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }


                Ponte.UsuarioLogado = usuario;
                Close();
            }
        }

        private void Cadastrarloginbutton_Click(object sender, EventArgs e)
        {
            new UsuarioForm().ShowDialog();
        }
    }
}

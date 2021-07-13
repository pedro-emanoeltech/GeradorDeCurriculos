
namespace GeradorDeCurriculo
{
    partial class UsuarioListarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TelacurriculoForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "TelacurriculoForm";
            this.Load += new System.EventHandler(this.TelacurriculoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListarCurriculodataGridView;
        private System.Windows.Forms.Panel radapepanel;
        private System.Windows.Forms.Label listarcurriculoslabel;
        private System.Windows.Forms.TextBox PesquisatextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button Incluirbutton;
        private System.Windows.Forms.Button Excluirbutton;
        private System.Windows.Forms.Button Alterarbutton;
        private System.Windows.Forms.Panel botoesPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNacimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dadosPessoaisBindingSource;
        private System.Windows.Forms.Button Fecharbutton;
    }
}
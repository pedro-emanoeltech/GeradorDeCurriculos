
namespace GeradorDeCurriculo
{
    partial class TelaUsuarios
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
            this.components = new System.ComponentModel.Container();
            this.radapepanel = new System.Windows.Forms.Panel();
            this.StatusBuscalabel = new System.Windows.Forms.Label();
            this.Alterarbutton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.listarcurriculoslabel = new System.Windows.Forms.Label();
            this.PesquisatextBox = new System.Windows.Forms.TextBox();
            this.botoesPanel = new System.Windows.Forms.Panel();
            this.Fecharbutton = new System.Windows.Forms.Button();
            this.ListarUsuariosGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.acessoCurriculoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.acessoEmpresaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radapepanel.SuspendLayout();
            this.botoesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListarUsuariosGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radapepanel
            // 
            this.radapepanel.Controls.Add(this.StatusBuscalabel);
            this.radapepanel.Controls.Add(this.Alterarbutton);
            this.radapepanel.Controls.Add(this.BuscarButton);
            this.radapepanel.Controls.Add(this.listarcurriculoslabel);
            this.radapepanel.Controls.Add(this.PesquisatextBox);
            this.radapepanel.Controls.Add(this.botoesPanel);
            this.radapepanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radapepanel.Location = new System.Drawing.Point(0, 380);
            this.radapepanel.Name = "radapepanel";
            this.radapepanel.Size = new System.Drawing.Size(905, 51);
            this.radapepanel.TabIndex = 1;
            // 
            // StatusBuscalabel
            // 
            this.StatusBuscalabel.AutoSize = true;
            this.StatusBuscalabel.Location = new System.Drawing.Point(105, 3);
            this.StatusBuscalabel.Name = "StatusBuscalabel";
            this.StatusBuscalabel.Size = new System.Drawing.Size(19, 13);
            this.StatusBuscalabel.TabIndex = 8;
            this.StatusBuscalabel.Text = "....";
            this.StatusBuscalabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Alterarbutton
            // 
            this.Alterarbutton.Location = new System.Drawing.Point(495, 15);
            this.Alterarbutton.Name = "Alterarbutton";
            this.Alterarbutton.Size = new System.Drawing.Size(66, 25);
            this.Alterarbutton.TabIndex = 4;
            this.Alterarbutton.Text = "Alterar";
            this.Alterarbutton.UseVisualStyleBackColor = true;
            this.Alterarbutton.Click += new System.EventHandler(this.Alterarbutton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(270, 15);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(66, 25);
            this.BuscarButton.TabIndex = 3;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // listarcurriculoslabel
            // 
            this.listarcurriculoslabel.AutoSize = true;
            this.listarcurriculoslabel.Location = new System.Drawing.Point(9, 3);
            this.listarcurriculoslabel.Name = "listarcurriculoslabel";
            this.listarcurriculoslabel.Size = new System.Drawing.Size(100, 13);
            this.listarcurriculoslabel.TabIndex = 1;
            this.listarcurriculoslabel.Text = "Pesquisar Curriculo:";
            this.listarcurriculoslabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PesquisatextBox
            // 
            this.PesquisatextBox.Location = new System.Drawing.Point(12, 19);
            this.PesquisatextBox.Name = "PesquisatextBox";
            this.PesquisatextBox.Size = new System.Drawing.Size(252, 20);
            this.PesquisatextBox.TabIndex = 0;
            this.PesquisatextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // botoesPanel
            // 
            this.botoesPanel.Controls.Add(this.Fecharbutton);
            this.botoesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.botoesPanel.Location = new System.Drawing.Point(567, 0);
            this.botoesPanel.Name = "botoesPanel";
            this.botoesPanel.Size = new System.Drawing.Size(338, 51);
            this.botoesPanel.TabIndex = 7;
            // 
            // Fecharbutton
            // 
            this.Fecharbutton.Location = new System.Drawing.Point(162, 14);
            this.Fecharbutton.Name = "Fecharbutton";
            this.Fecharbutton.Size = new System.Drawing.Size(66, 25);
            this.Fecharbutton.TabIndex = 6;
            this.Fecharbutton.Text = "Fechar";
            this.Fecharbutton.UseVisualStyleBackColor = true;
            this.Fecharbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListarUsuariosGridView
            // 
            this.ListarUsuariosGridView.AllowUserToAddRows = false;
            this.ListarUsuariosGridView.AllowUserToDeleteRows = false;
            this.ListarUsuariosGridView.AutoGenerateColumns = false;
            this.ListarUsuariosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListarUsuariosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.acessoCurriculoDataGridViewCheckBoxColumn,
            this.acessoEmpresaDataGridViewCheckBoxColumn});
            this.ListarUsuariosGridView.DataSource = this.usuariosBindingSource;
            this.ListarUsuariosGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListarUsuariosGridView.Location = new System.Drawing.Point(0, 0);
            this.ListarUsuariosGridView.Name = "ListarUsuariosGridView";
            this.ListarUsuariosGridView.ReadOnly = true;
            this.ListarUsuariosGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListarUsuariosGridView.Size = new System.Drawing.Size(905, 380);
            this.ListarUsuariosGridView.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // acessoCurriculoDataGridViewCheckBoxColumn
            // 
            this.acessoCurriculoDataGridViewCheckBoxColumn.DataPropertyName = "AcessoCurriculo";
            this.acessoCurriculoDataGridViewCheckBoxColumn.HeaderText = "Candidato";
            this.acessoCurriculoDataGridViewCheckBoxColumn.Name = "acessoCurriculoDataGridViewCheckBoxColumn";
            this.acessoCurriculoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // acessoEmpresaDataGridViewCheckBoxColumn
            // 
            this.acessoEmpresaDataGridViewCheckBoxColumn.DataPropertyName = "AcessoEmpresa";
            this.acessoEmpresaDataGridViewCheckBoxColumn.HeaderText = "Empresa";
            this.acessoEmpresaDataGridViewCheckBoxColumn.Name = "acessoEmpresaDataGridViewCheckBoxColumn";
            this.acessoEmpresaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(GeradorDeCurriculo.Dados.Mapeamento.Usuarios);
            // 
            // TelaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 431);
            this.Controls.Add(this.ListarUsuariosGridView);
            this.Controls.Add(this.radapepanel);
            this.Name = "TelaUsuarios";
            this.Text = "Consulta Usuarios";
            this.Load += new System.EventHandler(this.TelacurriculoForm_Load);
            this.radapepanel.ResumeLayout(false);
            this.radapepanel.PerformLayout();
            this.botoesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListarUsuariosGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel radapepanel;
        private System.Windows.Forms.Label listarcurriculoslabel;
        private System.Windows.Forms.TextBox PesquisatextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button Alterarbutton;
        private System.Windows.Forms.Panel botoesPanel;
        private System.Windows.Forms.Button Fecharbutton;
        private System.Windows.Forms.Label StatusBuscalabel;
        private System.Windows.Forms.DataGridView ListarUsuariosGridView;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acessoCurriculoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acessoEmpresaDataGridViewCheckBoxColumn;
    }
}
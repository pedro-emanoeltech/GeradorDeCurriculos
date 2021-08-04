
namespace GeradorDeCurriculo
{
    partial class ConsultaCurriculoForm
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
            this.ListarCurriculodataGridView = new System.Windows.Forms.DataGridView();
            this.radapepanel = new System.Windows.Forms.Panel();
            this.StatusBuscalabel = new System.Windows.Forms.Label();
            this.Incluirbutton = new System.Windows.Forms.Button();
            this.Alterarbutton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.listarcurriculoslabel = new System.Windows.Forms.Label();
            this.PesquisatextBox = new System.Windows.Forms.TextBox();
            this.botoesPanel = new System.Windows.Forms.Panel();
            this.Fecharbutton = new System.Windows.Forms.Button();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosPessoaisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dadosPessoaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ListarCurriculodataGridView)).BeginInit();
            this.radapepanel.SuspendLayout();
            this.botoesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosPessoaisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosPessoaisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListarCurriculodataGridView
            // 
            this.ListarCurriculodataGridView.AllowUserToAddRows = false;
            this.ListarCurriculodataGridView.AllowUserToDeleteRows = false;
            this.ListarCurriculodataGridView.AutoGenerateColumns = false;
            this.ListarCurriculodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListarCurriculodataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.DataNascimento,
            this.nomeDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.nacionalidadeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.ListarCurriculodataGridView.DataSource = this.dadosPessoaisBindingSource1;
            this.ListarCurriculodataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListarCurriculodataGridView.Location = new System.Drawing.Point(0, 0);
            this.ListarCurriculodataGridView.Name = "ListarCurriculodataGridView";
            this.ListarCurriculodataGridView.ReadOnly = true;
            this.ListarCurriculodataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListarCurriculodataGridView.Size = new System.Drawing.Size(905, 431);
            this.ListarCurriculodataGridView.TabIndex = 0;
            this.ListarCurriculodataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListarCurriculodataGridView_CellContentClick);
            // 
            // radapepanel
            // 
            this.radapepanel.Controls.Add(this.StatusBuscalabel);
            this.radapepanel.Controls.Add(this.Incluirbutton);
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
            // Incluirbutton
            // 
            this.Incluirbutton.Location = new System.Drawing.Point(413, 14);
            this.Incluirbutton.Name = "Incluirbutton";
            this.Incluirbutton.Size = new System.Drawing.Size(66, 25);
            this.Incluirbutton.TabIndex = 6;
            this.Incluirbutton.Text = "Incluir";
            this.Incluirbutton.UseVisualStyleBackColor = true;
            this.Incluirbutton.Click += new System.EventHandler(this.Incluirbutton_Click);
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
            // DataNascimento
            // 
            this.DataNascimento.DataPropertyName = "DataNascimento";
            this.DataNascimento.HeaderText = "DataNascimento";
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.ReadOnly = true;
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
            this.nomeDataGridViewTextBoxColumn.Width = 250;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoDataGridViewTextBoxColumn.Width = 150;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            this.nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            this.nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            this.nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            this.nacionalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dadosPessoaisBindingSource1
            // 
            this.dadosPessoaisBindingSource1.DataSource = typeof(GeradorDeCurriculo.Dados.Mapeamento.DadosPessoais);
            // 
            // dadosPessoaisBindingSource
            // 
            this.dadosPessoaisBindingSource.DataSource = typeof(GeradorDeCurriculo.Dados.Mapeamento.DadosPessoais);
            // 
            // TelacurriculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 431);
            this.Controls.Add(this.radapepanel);
            this.Controls.Add(this.ListarCurriculodataGridView);
            this.Name = "TelacurriculoForm";
            this.Text = "Consulta Curriculo";
            this.Load += new System.EventHandler(this.TelacurriculoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListarCurriculodataGridView)).EndInit();
            this.radapepanel.ResumeLayout(false);
            this.radapepanel.PerformLayout();
            this.botoesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dadosPessoaisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosPessoaisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListarCurriculodataGridView;
        private System.Windows.Forms.Panel radapepanel;
        private System.Windows.Forms.Label listarcurriculoslabel;
        private System.Windows.Forms.TextBox PesquisatextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button Incluirbutton;
        private System.Windows.Forms.Button Alterarbutton;
        private System.Windows.Forms.Panel botoesPanel;
        private System.Windows.Forms.BindingSource dadosPessoaisBindingSource;
        private System.Windows.Forms.Button Fecharbutton;
        private System.Windows.Forms.Label StatusBuscalabel;
        private System.Windows.Forms.BindingSource dadosPessoaisBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
    }
}
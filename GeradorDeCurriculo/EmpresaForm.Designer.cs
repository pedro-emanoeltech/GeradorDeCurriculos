
namespace GeradorDeCurriculo
{
    partial class EmpresaForm
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
            this.IDEmpresatextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeEmpresatextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CNPJEmpresatextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SetorEmpresatextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CidadeEmpresatextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EnderecoEmpresatextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NumeroEmpresatextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BairroEmpresatextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.GravarEmpresabutton = new System.Windows.Forms.Button();
            this.FecharEmpresaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDEmpresatextBox
            // 
            this.IDEmpresatextBox.Location = new System.Drawing.Point(12, 31);
            this.IDEmpresatextBox.Name = "IDEmpresatextBox";
            this.IDEmpresatextBox.Size = new System.Drawing.Size(52, 20);
            this.IDEmpresatextBox.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(21, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Empresa:";
            // 
            // NomeEmpresatextBox
            // 
            this.NomeEmpresatextBox.Location = new System.Drawing.Point(91, 31);
            this.NomeEmpresatextBox.Name = "NomeEmpresatextBox";
            this.NomeEmpresatextBox.Size = new System.Drawing.Size(517, 20);
            this.NomeEmpresatextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CNPJ:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CNPJEmpresatextBox
            // 
            this.CNPJEmpresatextBox.Location = new System.Drawing.Point(12, 82);
            this.CNPJEmpresatextBox.Name = "CNPJEmpresatextBox";
            this.CNPJEmpresatextBox.Size = new System.Drawing.Size(205, 20);
            this.CNPJEmpresatextBox.TabIndex = 6;
            this.CNPJEmpresatextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Setor:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SetorEmpresatextBox
            // 
            this.SetorEmpresatextBox.Location = new System.Drawing.Point(297, 82);
            this.SetorEmpresatextBox.Name = "SetorEmpresatextBox";
            this.SetorEmpresatextBox.Size = new System.Drawing.Size(224, 20);
            this.SetorEmpresatextBox.TabIndex = 8;
            this.SetorEmpresatextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cidade:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CidadeEmpresatextBox
            // 
            this.CidadeEmpresatextBox.Location = new System.Drawing.Point(248, 240);
            this.CidadeEmpresatextBox.Name = "CidadeEmpresatextBox";
            this.CidadeEmpresatextBox.Size = new System.Drawing.Size(181, 20);
            this.CidadeEmpresatextBox.TabIndex = 10;
            this.CidadeEmpresatextBox.TextChanged += new System.EventHandler(this.CidadeEmpresatextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Endereço";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // EnderecoEmpresatextBox
            // 
            this.EnderecoEmpresatextBox.Location = new System.Drawing.Point(9, 170);
            this.EnderecoEmpresatextBox.Name = "EnderecoEmpresatextBox";
            this.EnderecoEmpresatextBox.Size = new System.Drawing.Size(372, 20);
            this.EnderecoEmpresatextBox.TabIndex = 12;
            this.EnderecoEmpresatextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Numero:";
            // 
            // NumeroEmpresatextBox
            // 
            this.NumeroEmpresatextBox.Location = new System.Drawing.Point(410, 170);
            this.NumeroEmpresatextBox.Name = "NumeroEmpresatextBox";
            this.NumeroEmpresatextBox.Size = new System.Drawing.Size(148, 20);
            this.NumeroEmpresatextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bairro:";
            // 
            // BairroEmpresatextBox
            // 
            this.BairroEmpresatextBox.Location = new System.Drawing.Point(9, 240);
            this.BairroEmpresatextBox.Name = "BairroEmpresatextBox";
            this.BairroEmpresatextBox.Size = new System.Drawing.Size(224, 20);
            this.BairroEmpresatextBox.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(643, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "_________________________________________________________________________________" +
    "_________________________";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // GravarEmpresabutton
            // 
            this.GravarEmpresabutton.Location = new System.Drawing.Point(470, 221);
            this.GravarEmpresabutton.Name = "GravarEmpresabutton";
            this.GravarEmpresabutton.Size = new System.Drawing.Size(88, 42);
            this.GravarEmpresabutton.TabIndex = 20;
            this.GravarEmpresabutton.Text = "Gravar";
            this.GravarEmpresabutton.UseVisualStyleBackColor = true;
            this.GravarEmpresabutton.Click += new System.EventHandler(this.GravarEmpresabutton_Click);
            // 
            // FecharEmpresaButton
            // 
            this.FecharEmpresaButton.Location = new System.Drawing.Point(589, 221);
            this.FecharEmpresaButton.Name = "FecharEmpresaButton";
            this.FecharEmpresaButton.Size = new System.Drawing.Size(81, 42);
            this.FecharEmpresaButton.TabIndex = 21;
            this.FecharEmpresaButton.Text = "Fechar";
            this.FecharEmpresaButton.UseVisualStyleBackColor = true;
            this.FecharEmpresaButton.Click += new System.EventHandler(this.FecharEmpresaButton_Click);
            // 
            // TelaEmpresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 285);
            this.Controls.Add(this.FecharEmpresaButton);
            this.Controls.Add(this.GravarEmpresabutton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BairroEmpresatextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumeroEmpresatextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EnderecoEmpresatextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CidadeEmpresatextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SetorEmpresatextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CNPJEmpresatextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeEmpresatextBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.IDEmpresatextBox);
            this.Name = "TelaEmpresaForm";
            this.Text = "Cadastro Empresa";
            this.Load += new System.EventHandler(this.TelacurriculoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IDEmpresatextBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeEmpresatextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CNPJEmpresatextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SetorEmpresatextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CidadeEmpresatextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EnderecoEmpresatextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NumeroEmpresatextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BairroEmpresatextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button GravarEmpresabutton;
        private System.Windows.Forms.Button FecharEmpresaButton;
    }
}
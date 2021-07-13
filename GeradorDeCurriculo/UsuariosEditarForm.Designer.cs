
namespace GeradorDeCurriculo
{
    partial class UsuariosEditarForm
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
            this.IDUsuariotextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeUsuariotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginUsuariotextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SenhaUsuariotextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ExcluirUsuarioButton = new System.Windows.Forms.Button();
            this.GravarUsuariobutton = new System.Windows.Forms.Button();
            this.UsuarioFecharbutton = new System.Windows.Forms.Button();
            this.AtivoUsuariocheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CandidatoUsuariocheckBox = new System.Windows.Forms.CheckBox();
            this.EmpresaUsuariocheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDUsuariotextBox
            // 
            this.IDUsuariotextBox.Location = new System.Drawing.Point(12, 31);
            this.IDUsuariotextBox.Name = "IDUsuariotextBox";
            this.IDUsuariotextBox.Size = new System.Drawing.Size(52, 20);
            this.IDUsuariotextBox.TabIndex = 2;
            this.IDUsuariotextBox.TextChanged += new System.EventHandler(this.IDUsuariotextBox_TextChanged);
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
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Do Usuario";
            // 
            // NomeUsuariotextBox
            // 
            this.NomeUsuariotextBox.Location = new System.Drawing.Point(91, 31);
            this.NomeUsuariotextBox.Name = "NomeUsuariotextBox";
            this.NomeUsuariotextBox.Size = new System.Drawing.Size(517, 20);
            this.NomeUsuariotextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LoginUsuariotextBox
            // 
            this.LoginUsuariotextBox.Location = new System.Drawing.Point(46, 82);
            this.LoginUsuariotextBox.Name = "LoginUsuariotextBox";
            this.LoginUsuariotextBox.Size = new System.Drawing.Size(172, 20);
            this.LoginUsuariotextBox.TabIndex = 6;
            this.LoginUsuariotextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Senha:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SenhaUsuariotextBox
            // 
            this.SenhaUsuariotextBox.Location = new System.Drawing.Point(243, 82);
            this.SenhaUsuariotextBox.Name = "SenhaUsuariotextBox";
            this.SenhaUsuariotextBox.PasswordChar = '#';
            this.SenhaUsuariotextBox.Size = new System.Drawing.Size(224, 20);
            this.SenhaUsuariotextBox.TabIndex = 8;
            this.SenhaUsuariotextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
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
            // ExcluirUsuarioButton
            // 
            this.ExcluirUsuarioButton.Location = new System.Drawing.Point(537, 162);
            this.ExcluirUsuarioButton.Name = "ExcluirUsuarioButton";
            this.ExcluirUsuarioButton.Size = new System.Drawing.Size(81, 42);
            this.ExcluirUsuarioButton.TabIndex = 21;
            this.ExcluirUsuarioButton.Text = "Excluir";
            this.ExcluirUsuarioButton.UseVisualStyleBackColor = true;
            this.ExcluirUsuarioButton.Click += new System.EventHandler(this.ExcluirUsuarioButton_Click);
            // 
            // GravarUsuariobutton
            // 
            this.GravarUsuariobutton.Location = new System.Drawing.Point(298, 162);
            this.GravarUsuariobutton.Name = "GravarUsuariobutton";
            this.GravarUsuariobutton.Size = new System.Drawing.Size(88, 42);
            this.GravarUsuariobutton.TabIndex = 20;
            this.GravarUsuariobutton.Text = "Gravar";
            this.GravarUsuariobutton.UseVisualStyleBackColor = true;
            this.GravarUsuariobutton.Click += new System.EventHandler(this.GravarUsuariobutton_Click);
            // 
            // UsuarioFecharbutton
            // 
            this.UsuarioFecharbutton.Location = new System.Drawing.Point(424, 162);
            this.UsuarioFecharbutton.Name = "UsuarioFecharbutton";
            this.UsuarioFecharbutton.Size = new System.Drawing.Size(81, 42);
            this.UsuarioFecharbutton.TabIndex = 22;
            this.UsuarioFecharbutton.Text = "fechar";
            this.UsuarioFecharbutton.UseVisualStyleBackColor = true;
            this.UsuarioFecharbutton.Click += new System.EventHandler(this.UsuarioFecharbutton_Click);
            // 
            // AtivoUsuariocheckBox
            // 
            this.AtivoUsuariocheckBox.AutoSize = true;
            this.AtivoUsuariocheckBox.Location = new System.Drawing.Point(558, 12);
            this.AtivoUsuariocheckBox.Name = "AtivoUsuariocheckBox";
            this.AtivoUsuariocheckBox.Size = new System.Drawing.Size(50, 17);
            this.AtivoUsuariocheckBox.TabIndex = 24;
            this.AtivoUsuariocheckBox.Text = "Ativo";
            this.AtivoUsuariocheckBox.UseVisualStyleBackColor = true;
            this.AtivoUsuariocheckBox.CheckedChanged += new System.EventHandler(this.AtivoUsuariocheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CandidatoUsuariocheckBox);
            this.groupBox1.Controls.Add(this.EmpresaUsuariocheckBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 58);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CandidatoUsuariocheckBox
            // 
            this.CandidatoUsuariocheckBox.AutoSize = true;
            this.CandidatoUsuariocheckBox.Location = new System.Drawing.Point(102, 19);
            this.CandidatoUsuariocheckBox.Name = "CandidatoUsuariocheckBox";
            this.CandidatoUsuariocheckBox.Size = new System.Drawing.Size(74, 17);
            this.CandidatoUsuariocheckBox.TabIndex = 26;
            this.CandidatoUsuariocheckBox.Text = "Candidato";
            this.CandidatoUsuariocheckBox.UseVisualStyleBackColor = true;
            // 
            // EmpresaUsuariocheckBox
            // 
            this.EmpresaUsuariocheckBox.AutoSize = true;
            this.EmpresaUsuariocheckBox.Location = new System.Drawing.Point(6, 19);
            this.EmpresaUsuariocheckBox.Name = "EmpresaUsuariocheckBox";
            this.EmpresaUsuariocheckBox.Size = new System.Drawing.Size(67, 17);
            this.EmpresaUsuariocheckBox.TabIndex = 25;
            this.EmpresaUsuariocheckBox.Text = "Empresa";
            this.EmpresaUsuariocheckBox.UseVisualStyleBackColor = true;
            // 
            // UsuariosEditarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 213);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AtivoUsuariocheckBox);
            this.Controls.Add(this.UsuarioFecharbutton);
            this.Controls.Add(this.ExcluirUsuarioButton);
            this.Controls.Add(this.GravarUsuariobutton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SenhaUsuariotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginUsuariotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeUsuariotextBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.IDUsuariotextBox);
            this.Name = "UsuariosEditarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.TelacurriculoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IDUsuariotextBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeUsuariotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginUsuariotextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SenhaUsuariotextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ExcluirUsuarioButton;
        private System.Windows.Forms.Button GravarUsuariobutton;
        private System.Windows.Forms.Button UsuarioFecharbutton;
        private System.Windows.Forms.CheckBox AtivoUsuariocheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CandidatoUsuariocheckBox;
        private System.Windows.Forms.CheckBox EmpresaUsuariocheckBox;
    }
}
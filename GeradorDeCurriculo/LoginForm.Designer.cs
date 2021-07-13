
namespace GeradorDeCurriculo
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label4 = new System.Windows.Forms.Label();
            this.SenhaloginetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.FecharLoginbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cadastrarloginbutton = new System.Windows.Forms.Button();
            this.EntrarLoginbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Senha:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SenhaloginetextBox
            // 
            this.SenhaloginetextBox.Location = new System.Drawing.Point(179, 87);
            this.SenhaloginetextBox.Name = "SenhaloginetextBox";
            this.SenhaloginetextBox.PasswordChar = '*';
            this.SenhaloginetextBox.Size = new System.Drawing.Size(157, 20);
            this.SenhaloginetextBox.TabIndex = 1;
            this.SenhaloginetextBox.TextChanged += new System.EventHandler(this.SenhaUsuariotextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Login:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LogintextBox
            // 
            this.LogintextBox.Location = new System.Drawing.Point(179, 34);
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(198, 20);
            this.LogintextBox.TabIndex = 0;
            this.LogintextBox.TextChanged += new System.EventHandler(this.LoginUsuariotextBox_TextChanged);
            // 
            // FecharLoginbutton
            // 
            this.FecharLoginbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FecharLoginbutton.Location = new System.Drawing.Point(380, 147);
            this.FecharLoginbutton.Name = "FecharLoginbutton";
            this.FecharLoginbutton.Size = new System.Drawing.Size(64, 25);
            this.FecharLoginbutton.TabIndex = 4;
            this.FecharLoginbutton.Text = "Sair";
            this.FecharLoginbutton.UseVisualStyleBackColor = true;
            this.FecharLoginbutton.Click += new System.EventHandler(this.FecharLoginbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Cadastrarloginbutton
            // 
            this.Cadastrarloginbutton.Location = new System.Drawing.Point(285, 147);
            this.Cadastrarloginbutton.Name = "Cadastrarloginbutton";
            this.Cadastrarloginbutton.Size = new System.Drawing.Size(64, 25);
            this.Cadastrarloginbutton.TabIndex = 3;
            this.Cadastrarloginbutton.Text = "Cadastrar";
            this.Cadastrarloginbutton.UseVisualStyleBackColor = true;
            this.Cadastrarloginbutton.Click += new System.EventHandler(this.Cadastrarloginbutton_Click);
            // 
            // EntrarLoginbutton
            // 
            this.EntrarLoginbutton.Location = new System.Drawing.Point(182, 147);
            this.EntrarLoginbutton.Name = "EntrarLoginbutton";
            this.EntrarLoginbutton.Size = new System.Drawing.Size(75, 23);
            this.EntrarLoginbutton.TabIndex = 30;
            this.EntrarLoginbutton.Text = "Entrar";
            this.EntrarLoginbutton.UseVisualStyleBackColor = true;
            this.EntrarLoginbutton.Click += new System.EventHandler(this.EntrarLoginbutton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.FecharLoginbutton;
            this.ClientSize = new System.Drawing.Size(470, 186);
            this.Controls.Add(this.EntrarLoginbutton);
            this.Controls.Add(this.Cadastrarloginbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FecharLoginbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SenhaloginetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LogintextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN : Gerador de Curriculos";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SenhaloginetextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LogintextBox;
        private System.Windows.Forms.Button FecharLoginbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Cadastrarloginbutton;
        private System.Windows.Forms.Button EntrarLoginbutton;
    }
}
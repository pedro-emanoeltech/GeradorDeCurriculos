
namespace GeradorDeCurriculo
{
    partial class IncialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncialForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.EntrarTelaLoginButton = new System.Windows.Forms.ToolStripButton();
            this.GerarCurriculoStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ConsultaVagasButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curriculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statustoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Usuariologadolabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntrarTelaLoginButton,
            this.GerarCurriculoStripButton1,
            this.ConsultaVagasButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(933, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // EntrarTelaLoginButton
            // 
            this.EntrarTelaLoginButton.Image = ((System.Drawing.Image)(resources.GetObject("EntrarTelaLoginButton.Image")));
            this.EntrarTelaLoginButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EntrarTelaLoginButton.Name = "EntrarTelaLoginButton";
            this.EntrarTelaLoginButton.Size = new System.Drawing.Size(42, 35);
            this.EntrarTelaLoginButton.Text = "Entrar";
            this.EntrarTelaLoginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EntrarTelaLoginButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // GerarCurriculoStripButton1
            // 
            this.GerarCurriculoStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("GerarCurriculoStripButton1.Image")));
            this.GerarCurriculoStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GerarCurriculoStripButton1.Name = "GerarCurriculoStripButton1";
            this.GerarCurriculoStripButton1.Size = new System.Drawing.Size(91, 35);
            this.GerarCurriculoStripButton1.Text = "Gerar Curriculo";
            this.GerarCurriculoStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GerarCurriculoStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ConsultaVagasButton
            // 
            this.ConsultaVagasButton.Image = ((System.Drawing.Image)(resources.GetObject("ConsultaVagasButton.Image")));
            this.ConsultaVagasButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConsultaVagasButton.Name = "ConsultaVagasButton";
            this.ConsultaVagasButton.Size = new System.Drawing.Size(41, 35);
            this.ConsultaVagasButton.Text = "Vagas";
            this.ConsultaVagasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ConsultaVagasButton.Click += new System.EventHandler(this.ConsultaVagasButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curriculoToolStripMenuItem,
            this.empresaToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // curriculoToolStripMenuItem
            // 
            this.curriculoToolStripMenuItem.Name = "curriculoToolStripMenuItem";
            this.curriculoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.curriculoToolStripMenuItem.Text = "Curriculo";
            this.curriculoToolStripMenuItem.Click += new System.EventHandler(this.curriculoToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statustoolStripStatusLabel,
            this.toolStripStatusLabel1,
            this.Usuariologadolabel,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(933, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statustoolStripStatusLabel
            // 
            this.statustoolStripStatusLabel.Name = "statustoolStripStatusLabel";
            this.statustoolStripStatusLabel.Size = new System.Drawing.Size(76, 17);
            this.statustoolStripStatusLabel.Text = "Status: Ativo ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Usuariologadolabel
            // 
            this.Usuariologadolabel.Name = "Usuariologadolabel";
            this.Usuariologadolabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // TelaInicalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 466);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "TelaInicalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador De Currículo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaInicalForm_Load);
            this.Shown += new System.EventHandler(this.TelaInicalForm_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton GerarCurriculoStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statustoolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem curriculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ConsultaVagasButton;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Usuariologadolabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripButton EntrarTelaLoginButton;
    }
}


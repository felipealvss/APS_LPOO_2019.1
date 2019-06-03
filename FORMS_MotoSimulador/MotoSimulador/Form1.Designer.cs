namespace MotoSimulador
{
    partial class FormMotoSimulador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMotoSimulador));
            this.groupBoxMoto = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.botaoGeraMoto = new System.Windows.Forms.Button();
            this.comboBoxModelo = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.botao_marchaSobe = new System.Windows.Forms.Button();
            this.botao_neutro = new System.Windows.Forms.Button();
            this.Botao_marchaDesce = new System.Windows.Forms.Button();
            this.groupBoxMarcha = new System.Windows.Forms.GroupBox();
            this.labelMarcha = new System.Windows.Forms.Label();
            this.botaoLigar = new System.Windows.Forms.Button();
            this.botaoDesligar = new System.Windows.Forms.Button();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBoxMoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxMarcha.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMoto
            // 
            this.groupBoxMoto.Controls.Add(this.pictureBox1);
            this.groupBoxMoto.Controls.Add(this.labelModelo);
            this.groupBoxMoto.Controls.Add(this.labelMarca);
            this.groupBoxMoto.Controls.Add(this.botaoGeraMoto);
            this.groupBoxMoto.Controls.Add(this.comboBoxModelo);
            this.groupBoxMoto.Controls.Add(this.comboBoxMarca);
            resources.ApplyResources(this.groupBoxMoto, "groupBoxMoto");
            this.groupBoxMoto.Name = "groupBoxMoto";
            this.groupBoxMoto.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // labelModelo
            // 
            resources.ApplyResources(this.labelModelo, "labelModelo");
            this.labelModelo.Name = "labelModelo";
            // 
            // labelMarca
            // 
            resources.ApplyResources(this.labelMarca, "labelMarca");
            this.labelMarca.Name = "labelMarca";
            // 
            // botaoGeraMoto
            // 
            resources.ApplyResources(this.botaoGeraMoto, "botaoGeraMoto");
            this.botaoGeraMoto.Name = "botaoGeraMoto";
            this.botaoGeraMoto.UseVisualStyleBackColor = true;
            this.botaoGeraMoto.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBoxModelo
            // 
            this.comboBoxModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModelo.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxModelo, "comboBoxModelo");
            this.comboBoxModelo.Name = "comboBoxModelo";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Items.AddRange(new object[] {
            resources.GetString("comboBoxMarca.Items"),
            resources.GetString("comboBoxMarca.Items1"),
            resources.GetString("comboBoxMarca.Items2"),
            resources.GetString("comboBoxMarca.Items3"),
            resources.GetString("comboBoxMarca.Items4")});
            resources.ApplyResources(this.comboBoxMarca, "comboBoxMarca");
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMarca_SelectedIndexChanged);
            // 
            // botao_marchaSobe
            // 
            resources.ApplyResources(this.botao_marchaSobe, "botao_marchaSobe");
            this.botao_marchaSobe.Name = "botao_marchaSobe";
            this.botao_marchaSobe.UseVisualStyleBackColor = true;
            this.botao_marchaSobe.Click += new System.EventHandler(this.Botao_marchaSobe_Click);
            // 
            // botao_neutro
            // 
            resources.ApplyResources(this.botao_neutro, "botao_neutro");
            this.botao_neutro.Name = "botao_neutro";
            this.botao_neutro.UseVisualStyleBackColor = true;
            this.botao_neutro.Click += new System.EventHandler(this.Botao_neutro_Click);
            // 
            // Botao_marchaDesce
            // 
            resources.ApplyResources(this.Botao_marchaDesce, "Botao_marchaDesce");
            this.Botao_marchaDesce.Name = "Botao_marchaDesce";
            this.Botao_marchaDesce.UseVisualStyleBackColor = true;
            this.Botao_marchaDesce.Click += new System.EventHandler(this.Botao_marchaDesce_Click);
            // 
            // groupBoxMarcha
            // 
            this.groupBoxMarcha.Controls.Add(this.labelMarcha);
            resources.ApplyResources(this.groupBoxMarcha, "groupBoxMarcha");
            this.groupBoxMarcha.Name = "groupBoxMarcha";
            this.groupBoxMarcha.TabStop = false;
            // 
            // labelMarcha
            // 
            resources.ApplyResources(this.labelMarcha, "labelMarcha");
            this.labelMarcha.Name = "labelMarcha";
            // 
            // botaoLigar
            // 
            resources.ApplyResources(this.botaoLigar, "botaoLigar");
            this.botaoLigar.Name = "botaoLigar";
            this.botaoLigar.UseVisualStyleBackColor = true;
            this.botaoLigar.Click += new System.EventHandler(this.BotaoLigar_Click);
            // 
            // botaoDesligar
            // 
            resources.ApplyResources(this.botaoDesligar, "botaoDesligar");
            this.botaoDesligar.Name = "botaoDesligar";
            this.botaoDesligar.UseVisualStyleBackColor = true;
            this.botaoDesligar.Click += new System.EventHandler(this.BotaoDesligar_Click);
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.labelStatus);
            resources.ApplyResources(this.groupBoxStatus, "groupBoxStatus");
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.TabStop = false;
            // 
            // labelStatus
            // 
            resources.ApplyResources(this.labelStatus, "labelStatus");
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Name = "labelStatus";
            // 
            // FormMotoSimulador
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.botaoDesligar);
            this.Controls.Add(this.botaoLigar);
            this.Controls.Add(this.groupBoxMarcha);
            this.Controls.Add(this.Botao_marchaDesce);
            this.Controls.Add(this.botao_neutro);
            this.Controls.Add(this.botao_marchaSobe);
            this.Controls.Add(this.groupBoxMoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMotoSimulador";
            this.groupBoxMoto.ResumeLayout(false);
            this.groupBoxMoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxMarcha.ResumeLayout(false);
            this.groupBoxMarcha.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMoto;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Button botaoGeraMoto;
        private System.Windows.Forms.ComboBox comboBoxModelo;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Button botao_marchaSobe;
        private System.Windows.Forms.Button botao_neutro;
        private System.Windows.Forms.Button Botao_marchaDesce;
        private System.Windows.Forms.GroupBox groupBoxMarcha;
        private System.Windows.Forms.Label labelMarcha;
        private System.Windows.Forms.Button botaoLigar;
        private System.Windows.Forms.Button botaoDesligar;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


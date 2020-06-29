namespace ImageResizer.TesteVisual
{
    partial class FrmPrincipal
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
            this.lblContador = new System.Windows.Forms.Label();
            this.btnSelecionarImagens = new System.Windows.Forms.Button();
            this.btnRedimensionar = new System.Windows.Forms.Button();
            this.txbAltura = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbLargura = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbPorcentagem = new System.Windows.Forms.NumericUpDown();
            this.objSalvaImagens = new System.Windows.Forms.FolderBrowserDialog();
            this.objSelecionaImagens = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txbAltura)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbLargura)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbPorcentagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContador
            // 
            this.lblContador.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(0, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(409, 32);
            this.lblContador.TabIndex = 0;
            this.lblContador.Text = "0 imagens";
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelecionarImagens
            // 
            this.btnSelecionarImagens.Location = new System.Drawing.Point(12, 89);
            this.btnSelecionarImagens.Name = "btnSelecionarImagens";
            this.btnSelecionarImagens.Size = new System.Drawing.Size(99, 34);
            this.btnSelecionarImagens.TabIndex = 1;
            this.btnSelecionarImagens.Text = "Selecionar Imagens";
            this.btnSelecionarImagens.UseVisualStyleBackColor = true;
            this.btnSelecionarImagens.Click += new System.EventHandler(this.BtnSelecionarImagens_Click);
            // 
            // btnRedimensionar
            // 
            this.btnRedimensionar.Location = new System.Drawing.Point(117, 89);
            this.btnRedimensionar.Name = "btnRedimensionar";
            this.btnRedimensionar.Size = new System.Drawing.Size(280, 34);
            this.btnRedimensionar.TabIndex = 2;
            this.btnRedimensionar.Text = "Redimensionar e Salvar";
            this.btnRedimensionar.UseVisualStyleBackColor = true;
            this.btnRedimensionar.Click += new System.EventHandler(this.btnRedimensionar_Click);
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(183, 19);
            this.txbAltura.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(81, 20);
            this.txbAltura.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbLargura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbAltura);
            this.groupBox1.Location = new System.Drawing.Point(127, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medidas exatas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Largura:";
            // 
            // txbLargura
            // 
            this.txbLargura.Location = new System.Drawing.Point(62, 19);
            this.txbLargura.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txbLargura.Name = "txbLargura";
            this.txbLargura.Size = new System.Drawing.Size(72, 20);
            this.txbLargura.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Altura:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbPorcentagem);
            this.groupBox2.Location = new System.Drawing.Point(12, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 48);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Porcentagem";
            // 
            // txbPorcentagem
            // 
            this.txbPorcentagem.Location = new System.Drawing.Point(6, 19);
            this.txbPorcentagem.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txbPorcentagem.Name = "txbPorcentagem";
            this.txbPorcentagem.Size = new System.Drawing.Size(97, 20);
            this.txbPorcentagem.TabIndex = 7;
            // 
            // objSelecionaImagens
            // 
            this.objSelecionaImagens.Filter = "Imagens|*.jpg;*.png";
            this.objSelecionaImagens.Multiselect = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 135);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRedimensionar);
            this.Controls.Add(this.btnSelecionarImagens);
            this.Controls.Add(this.lblContador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageResizer";
            ((System.ComponentModel.ISupportInitialize)(this.txbAltura)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbLargura)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txbPorcentagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnSelecionarImagens;
        private System.Windows.Forms.Button btnRedimensionar;
        private System.Windows.Forms.NumericUpDown txbAltura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txbLargura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown txbPorcentagem;
        private System.Windows.Forms.FolderBrowserDialog objSalvaImagens;
        private System.Windows.Forms.OpenFileDialog objSelecionaImagens;
    }
}


namespace IconMaker.TesteVisual
{
    partial class Form1
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
            this.lblContadorImagens = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbTamanhoIcones = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionarImagem = new System.Windows.Forms.Button();
            this.btnConverterImagens = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.objSelecionarImagens = new System.Windows.Forms.OpenFileDialog();
            this.objSalvaImagens = new System.Windows.Forms.FolderBrowserDialog();
            this.btnConverter2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbTamanhoIcones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContadorImagens
            // 
            this.lblContadorImagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorImagens.Location = new System.Drawing.Point(12, 9);
            this.lblContadorImagens.Name = "lblContadorImagens";
            this.lblContadorImagens.Size = new System.Drawing.Size(358, 23);
            this.lblContadorImagens.TabIndex = 0;
            this.lblContadorImagens.Text = "0 imagens selecionadas";
            this.lblContadorImagens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbTamanhoIcones);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 45);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tamanho dos icones";
            // 
            // txbTamanhoIcones
            // 
            this.txbTamanhoIcones.Location = new System.Drawing.Point(6, 19);
            this.txbTamanhoIcones.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.txbTamanhoIcones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txbTamanhoIcones.Name = "txbTamanhoIcones";
            this.txbTamanhoIcones.Size = new System.Drawing.Size(109, 20);
            this.txbTamanhoIcones.TabIndex = 2;
            this.txbTamanhoIcones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdicionarImagem
            // 
            this.btnAdicionarImagem.Location = new System.Drawing.Point(142, 67);
            this.btnAdicionarImagem.Name = "btnAdicionarImagem";
            this.btnAdicionarImagem.Size = new System.Drawing.Size(238, 23);
            this.btnAdicionarImagem.TabIndex = 2;
            this.btnAdicionarImagem.Text = "Adicionar Imagem";
            this.btnAdicionarImagem.UseVisualStyleBackColor = true;
            this.btnAdicionarImagem.Click += new System.EventHandler(this.BtnAdicionarImagem_Click);
            // 
            // btnConverterImagens
            // 
            this.btnConverterImagens.Enabled = false;
            this.btnConverterImagens.Location = new System.Drawing.Point(142, 35);
            this.btnConverterImagens.Name = "btnConverterImagens";
            this.btnConverterImagens.Size = new System.Drawing.Size(79, 26);
            this.btnConverterImagens.TabIndex = 3;
            this.btnConverterImagens.Text = "Converter 1";
            this.btnConverterImagens.UseVisualStyleBackColor = true;
            this.btnConverterImagens.Click += new System.EventHandler(this.BtnConverterImagens_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(311, 35);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(69, 26);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // objSelecionarImagens
            // 
            this.objSelecionarImagens.Filter = "Imagens|*.jpg;*.png;*.jpeg";
            this.objSelecionarImagens.Multiselect = true;
            // 
            // btnConverter2
            // 
            this.btnConverter2.Enabled = false;
            this.btnConverter2.Location = new System.Drawing.Point(227, 35);
            this.btnConverter2.Name = "btnConverter2";
            this.btnConverter2.Size = new System.Drawing.Size(78, 26);
            this.btnConverter2.TabIndex = 5;
            this.btnConverter2.Text = "Converter 2";
            this.btnConverter2.UseVisualStyleBackColor = true;
            this.btnConverter2.Click += new System.EventHandler(this.BtnConverter2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 102);
            this.Controls.Add(this.btnConverter2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConverterImagens);
            this.Controls.Add(this.btnAdicionarImagem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblContadorImagens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IconMaker";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txbTamanhoIcones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblContadorImagens;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txbTamanhoIcones;
        private System.Windows.Forms.Button btnAdicionarImagem;
        private System.Windows.Forms.Button btnConverterImagens;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.OpenFileDialog objSelecionarImagens;
        private System.Windows.Forms.FolderBrowserDialog objSalvaImagens;
        private System.Windows.Forms.Button btnConverter2;
    }
}


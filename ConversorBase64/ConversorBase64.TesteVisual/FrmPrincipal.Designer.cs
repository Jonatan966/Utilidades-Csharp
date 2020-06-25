namespace ConversorBase64.TesteVisual
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
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            this.txbBase64 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.btnConverterTexto = new System.Windows.Forms.Button();
            this.objSelecionaImagem = new System.Windows.Forms.OpenFileDialog();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.objSalvaTexto = new System.Windows.Forms.SaveFileDialog();
            this.btnConvImgParaArquivo = new System.Windows.Forms.Button();
            this.btnConvImgParaTexto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImagem
            // 
            this.pbxImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImagem.Location = new System.Drawing.Point(10, 30);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(193, 164);
            this.pbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagem.TabIndex = 0;
            this.pbxImagem.TabStop = false;
            // 
            // txbBase64
            // 
            this.txbBase64.Location = new System.Drawing.Point(209, 30);
            this.txbBase64.MaxLength = 250000;
            this.txbBase64.Multiline = true;
            this.txbBase64.Name = "txbBase64";
            this.txbBase64.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbBase64.Size = new System.Drawing.Size(215, 164);
            this.txbBase64.TabIndex = 1;
            this.txbBase64.TextChanged += new System.EventHandler(this.TxbBase64_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto em Base64";
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.Location = new System.Drawing.Point(10, 200);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(172, 28);
            this.btnSelecionarImagem.TabIndex = 4;
            this.btnSelecionarImagem.Text = "Selecionar Imagem";
            this.btnSelecionarImagem.UseVisualStyleBackColor = true;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.BtnSelecionarImagem_Click);
            // 
            // btnConverterTexto
            // 
            this.btnConverterTexto.Enabled = false;
            this.btnConverterTexto.Location = new System.Drawing.Point(188, 200);
            this.btnConverterTexto.Name = "btnConverterTexto";
            this.btnConverterTexto.Size = new System.Drawing.Size(153, 28);
            this.btnConverterTexto.TabIndex = 5;
            this.btnConverterTexto.Text = "Converter texto para Imagem";
            this.btnConverterTexto.UseVisualStyleBackColor = true;
            this.btnConverterTexto.Click += new System.EventHandler(this.BtnConverterTexto_Click);
            // 
            // objSelecionaImagem
            // 
            this.objSelecionaImagem.Filter = "Imagens|*.png;*.jpg";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(347, 200);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 28);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // objSalvaTexto
            // 
            this.objSalvaTexto.Filter = "Arquivos de Texto|*.txt";
            // 
            // btnConvImgParaArquivo
            // 
            this.btnConvImgParaArquivo.Enabled = false;
            this.btnConvImgParaArquivo.Location = new System.Drawing.Point(10, 234);
            this.btnConvImgParaArquivo.Name = "btnConvImgParaArquivo";
            this.btnConvImgParaArquivo.Size = new System.Drawing.Size(231, 28);
            this.btnConvImgParaArquivo.TabIndex = 8;
            this.btnConvImgParaArquivo.Text = "Converter imagem para um arquivo de texto";
            this.btnConvImgParaArquivo.UseVisualStyleBackColor = true;
            this.btnConvImgParaArquivo.Click += new System.EventHandler(this.BtnConvImgParaArquivo_Click);
            // 
            // btnConvImgParaTexto
            // 
            this.btnConvImgParaTexto.Enabled = false;
            this.btnConvImgParaTexto.Location = new System.Drawing.Point(247, 234);
            this.btnConvImgParaTexto.Name = "btnConvImgParaTexto";
            this.btnConvImgParaTexto.Size = new System.Drawing.Size(175, 28);
            this.btnConvImgParaTexto.TabIndex = 9;
            this.btnConvImgParaTexto.Text = "Converter imagem para texto";
            this.btnConvImgParaTexto.UseVisualStyleBackColor = true;
            this.btnConvImgParaTexto.Click += new System.EventHandler(this.BtnConvImgParaTexto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 274);
            this.Controls.Add(this.btnConvImgParaTexto);
            this.Controls.Add(this.btnConvImgParaArquivo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConverterTexto);
            this.Controls.Add(this.btnSelecionarImagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbBase64);
            this.Controls.Add(this.pbxImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConversorBase64";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImagem;
        private System.Windows.Forms.TextBox txbBase64;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelecionarImagem;
        private System.Windows.Forms.Button btnConverterTexto;
        private System.Windows.Forms.OpenFileDialog objSelecionaImagem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.SaveFileDialog objSalvaTexto;
        private System.Windows.Forms.Button btnConvImgParaArquivo;
        private System.Windows.Forms.Button btnConvImgParaTexto;
    }
}


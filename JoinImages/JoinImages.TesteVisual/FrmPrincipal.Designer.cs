namespace JoinImages.TesteVisual
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
            this.pbxResultado = new System.Windows.Forms.PictureBox();
            this.btnSelectImages = new System.Windows.Forms.Button();
            this.lblImagens = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreateHorizontalGrid = new System.Windows.Forms.Button();
            this.btnCreateVerticalGrid = new System.Windows.Forms.Button();
            this.btnCreateDynamicGrid = new System.Windows.Forms.Button();
            this.objSelectImages = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxResultado
            // 
            this.pbxResultado.Location = new System.Drawing.Point(12, 35);
            this.pbxResultado.Name = "pbxResultado";
            this.pbxResultado.Size = new System.Drawing.Size(346, 184);
            this.pbxResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxResultado.TabIndex = 0;
            this.pbxResultado.TabStop = false;
            // 
            // btnSelectImages
            // 
            this.btnSelectImages.Location = new System.Drawing.Point(12, 225);
            this.btnSelectImages.Name = "btnSelectImages";
            this.btnSelectImages.Size = new System.Drawing.Size(263, 27);
            this.btnSelectImages.TabIndex = 1;
            this.btnSelectImages.Text = "Selecionar Imagens";
            this.btnSelectImages.UseVisualStyleBackColor = true;
            this.btnSelectImages.Click += new System.EventHandler(this.BtnSelectImages_Click);
            // 
            // lblImagens
            // 
            this.lblImagens.AutoSize = true;
            this.lblImagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagens.Location = new System.Drawing.Point(129, 9);
            this.lblImagens.Name = "lblImagens";
            this.lblImagens.Size = new System.Drawing.Size(82, 20);
            this.lblImagens.TabIndex = 2;
            this.lblImagens.Text = "0 imagens";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(281, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 27);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnCreateHorizontalGrid
            // 
            this.btnCreateHorizontalGrid.Location = new System.Drawing.Point(241, 258);
            this.btnCreateHorizontalGrid.Name = "btnCreateHorizontalGrid";
            this.btnCreateHorizontalGrid.Size = new System.Drawing.Size(117, 27);
            this.btnCreateHorizontalGrid.TabIndex = 4;
            this.btnCreateHorizontalGrid.Text = "Gerar grid horizontal";
            this.btnCreateHorizontalGrid.UseVisualStyleBackColor = true;
            this.btnCreateHorizontalGrid.Click += new System.EventHandler(this.BtnCreateHorizontalGrid_Click);
            // 
            // btnCreateVerticalGrid
            // 
            this.btnCreateVerticalGrid.Location = new System.Drawing.Point(133, 258);
            this.btnCreateVerticalGrid.Name = "btnCreateVerticalGrid";
            this.btnCreateVerticalGrid.Size = new System.Drawing.Size(102, 27);
            this.btnCreateVerticalGrid.TabIndex = 5;
            this.btnCreateVerticalGrid.Text = "Gerar grid vertical";
            this.btnCreateVerticalGrid.UseVisualStyleBackColor = true;
            this.btnCreateVerticalGrid.Click += new System.EventHandler(this.BtnCreateVerticalGrid_Click);
            // 
            // btnCreateDynamicGrid
            // 
            this.btnCreateDynamicGrid.Location = new System.Drawing.Point(12, 258);
            this.btnCreateDynamicGrid.Name = "btnCreateDynamicGrid";
            this.btnCreateDynamicGrid.Size = new System.Drawing.Size(115, 27);
            this.btnCreateDynamicGrid.TabIndex = 6;
            this.btnCreateDynamicGrid.Text = "Gerar grid dinâmico";
            this.btnCreateDynamicGrid.UseVisualStyleBackColor = true;
            this.btnCreateDynamicGrid.Click += new System.EventHandler(this.BtnCreateDynamicGrid_Click);
            // 
            // objSelectImages
            // 
            this.objSelectImages.Filter = "Imagens|*.jpg;*.jpeg;*.png";
            this.objSelectImages.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 297);
            this.Controls.Add(this.btnCreateDynamicGrid);
            this.Controls.Add(this.btnCreateVerticalGrid);
            this.Controls.Add(this.btnCreateHorizontalGrid);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblImagens);
            this.Controls.Add(this.btnSelectImages);
            this.Controls.Add(this.pbxResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxResultado;
        private System.Windows.Forms.Button btnSelectImages;
        private System.Windows.Forms.Label lblImagens;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreateHorizontalGrid;
        private System.Windows.Forms.Button btnCreateVerticalGrid;
        private System.Windows.Forms.Button btnCreateDynamicGrid;
        private System.Windows.Forms.OpenFileDialog objSelectImages;
    }
}


namespace AcademiaHelper
{
    partial class frmPaineis
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
            this.pnlEsquerdo = new System.Windows.Forms.Panel();
            this.pnlDireito = new System.Windows.Forms.Panel();
            this.btnMudaAmarelo = new System.Windows.Forms.Button();
            this.btnMudaAzul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlEsquerdo
            // 
            this.pnlEsquerdo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEsquerdo.Location = new System.Drawing.Point(12, 225);
            this.pnlEsquerdo.Name = "pnlEsquerdo";
            this.pnlEsquerdo.Size = new System.Drawing.Size(404, 323);
            this.pnlEsquerdo.TabIndex = 0;
            // 
            // pnlDireito
            // 
            this.pnlDireito.Location = new System.Drawing.Point(518, 225);
            this.pnlDireito.Name = "pnlDireito";
            this.pnlDireito.Size = new System.Drawing.Size(404, 323);
            this.pnlDireito.TabIndex = 1;
            // 
            // btnMudaAmarelo
            // 
            this.btnMudaAmarelo.Location = new System.Drawing.Point(332, 96);
            this.btnMudaAmarelo.Name = "btnMudaAmarelo";
            this.btnMudaAmarelo.Size = new System.Drawing.Size(96, 68);
            this.btnMudaAmarelo.TabIndex = 2;
            this.btnMudaAmarelo.Text = "Mudar Amarelo";
            this.btnMudaAmarelo.UseVisualStyleBackColor = true;
            this.btnMudaAmarelo.Click += new System.EventHandler(this.btnMudaAmarelo_Click);
            // 
            // btnMudaAzul
            // 
            this.btnMudaAzul.Location = new System.Drawing.Point(506, 96);
            this.btnMudaAzul.Name = "btnMudaAzul";
            this.btnMudaAzul.Size = new System.Drawing.Size(96, 68);
            this.btnMudaAzul.TabIndex = 3;
            this.btnMudaAzul.Text = "Mudar Azul";
            this.btnMudaAzul.UseVisualStyleBackColor = true;
            this.btnMudaAzul.Click += new System.EventHandler(this.btnMudaAzul_Click);
            // 
            // frmPaineis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 560);
            this.Controls.Add(this.btnMudaAzul);
            this.Controls.Add(this.btnMudaAmarelo);
            this.Controls.Add(this.pnlDireito);
            this.Controls.Add(this.pnlEsquerdo);
            this.Name = "frmPaineis";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEsquerdo;
        private System.Windows.Forms.Panel pnlDireito;
        private System.Windows.Forms.Button btnMudaAmarelo;
        private System.Windows.Forms.Button btnMudaAzul;
    }
}


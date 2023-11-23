namespace AcademiaHelper
{
    partial class MoneyConverter
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
            this.txtValorEntrada = new System.Windows.Forms.TextBox();
            this.cmbMoeda = new System.Windows.Forms.ComboBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblValorConvertido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Location = new System.Drawing.Point(12, 67);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Size = new System.Drawing.Size(331, 26);
            this.txtValorEntrada.TabIndex = 1;
            this.txtValorEntrada.Text = "0";
            this.txtValorEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbMoeda
            // 
            this.cmbMoeda.FormattingEnabled = true;
            this.cmbMoeda.Items.AddRange(new object[] {
            "Real",
            "Euro"});
            this.cmbMoeda.Location = new System.Drawing.Point(12, 123);
            this.cmbMoeda.Name = "cmbMoeda";
            this.cmbMoeda.Size = new System.Drawing.Size(331, 28);
            this.cmbMoeda.TabIndex = 2;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(132, 177);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(95, 50);
            this.btnConverter.TabIndex = 3;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblValorConvertido
            // 
            this.lblValorConvertido.AutoSize = true;
            this.lblValorConvertido.Location = new System.Drawing.Point(179, 309);
            this.lblValorConvertido.Name = "lblValorConvertido";
            this.lblValorConvertido.Size = new System.Drawing.Size(0, 20);
            this.lblValorConvertido.TabIndex = 4;
            this.lblValorConvertido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Moeda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Conversor para Dolar";
            // 
            // MoneyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 425);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValorConvertido);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.cmbMoeda);
            this.Controls.Add(this.txtValorEntrada);
            this.Name = "MoneyConverter";
            this.Text = "MoneyConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorEntrada;
        private System.Windows.Forms.ComboBox cmbMoeda;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblValorConvertido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
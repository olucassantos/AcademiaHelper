using AcademiaHelper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaHelper
{
    public partial class CalculadoraImc : Form
    {
        private decimal imc = 0;

        public CalculadoraImc()
        {
            InitializeComponent();
        }

        // Executa quando o formulário carrega
        private void CalculadoraImc_Load(object sender, EventArgs e)
        {
            // Marca o campo sexo no item 3
            cmbSexo.SelectedIndex = 2;
        }

        // Calcula o IMC da pessoa
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal peso = numPeso.Value;
            decimal altura = numAltura.Value;

            imc = peso / (altura * altura);

            MostrarTabelaComparacao();
        }

        // Mostra a tabela de comparação
        private void MostrarTabelaComparacao()
        {
            // Caso o IMC seja 0, não faz nada.
            if (imc ==  0)
                return;

            Image imagemTabela;

            if (imc < 18.5m)
            {
                // Abaixo do peso
                imagemTabela = Resources.tile000;
            } 
            else if (imc < 25)
            {
                // Normal
                imagemTabela = Resources.tile001;
            } 
            else if (imc < 30)
            {
                // Sobrepeso
                imagemTabela = Resources.tile002;
            }
            else if (imc < 35)
            {
                // Obesidade Grau I
                imagemTabela = Resources.tile003;
            }
            else if (imc < 40)
            {
                // Obesidade Grau II
                imagemTabela = Resources.tile004;
            }
            else
            {
                // Obesidade Grau III
                imagemTabela = Resources.tile005;
            }

            // Coloca a imagem no PictureBox
            imgTabela.Image = imagemTabela;
            imgTabela.Visible = true;
            // Muda o tamanho do formulário
            this.Width = 500;

            // Coloca o resultado na Legenda 
            txtResultado.Text = imc.ToString("#.##");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            imc = 0;
            txtResultado.Text = "";
            imgTabela.Visible = false;
            numAltura.Value = 0;
            numPeso.Value = 0;
            cmbSexo.SelectedIndex = 2;

            this.Width = 305;
        }
    }
}

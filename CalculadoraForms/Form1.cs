using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CalculadoraForms
{
    

    
    public partial class Form1 : Form
    {
        //tratando duplicidade de operador;
        string duplicidade = " ";
    

        DataTable dt = new DataTable();

        int numero1;
        string ultimoOp;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbTela.Clear();
        }
        private void Operador_Click(object sender, EventArgs e)
        {
            // Obter o botão que está chamando o evento
            var botao = (Button)sender;
             string tratamento = botao.Text.ToString();
         
 if(tratamento == "÷" || tratamento == "x" || tratamento == "+" || tratamento == "-")
            {
                tratamento = "";
            }
            else
            {
                txbTela.Text += tratamento;
            }

        }
        private void Numero_Click(object sender, EventArgs e)
        {
            // Obter o botão que está chamando o evento
            var botao = (Button)sender;
            txbTela.Text += botao.Text;
            
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
         string tratada = txbTela.Text.Replace("x","*").Replace("÷", "/");
            var v = dt.Compute(tratada," ");
            txbTela.Text = v .ToString();
        }
    }
}

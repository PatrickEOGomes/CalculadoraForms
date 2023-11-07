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
            int verificacao = 0;
             string confirmacao = txbTela.Text;
           var confirmacao2= confirmacao.ToList();
           ;
            int i = confirmacao.Count();
            if (i > 0)
            {
                string tratamento = confirmacao2[confirmacao2.Count - 1].ToString();
                if (tratamento == "÷" || tratamento == "x" || tratamento == "+" || tratamento == "-")
                {
                    verificacao += 1;
                }
                else
                {
                    if (verificacao <= 1)
                    {
                        txbTela.Text += botao.Text;
                    }

                }

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
            string confirmacao = txbTela.Text;
            var confirmacao2 = confirmacao.ToList();
            if (txbTela.Text != "")
            {
                string tratamento = confirmacao2[confirmacao2.Count - 1].ToString();

                if (tratamento != "÷" && tratamento != "x" && tratamento != "+" && tratamento != "-")
                {
                    string tratada = txbTela.Text.Replace("x", "*").Replace("÷", "/");
                    var v = dt.Compute(tratada, " ");
                    txbTela.Text = v.ToString();

                }
            }
            
        }
    }
}

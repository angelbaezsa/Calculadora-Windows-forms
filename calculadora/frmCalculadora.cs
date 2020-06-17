using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica_Calculadora;

namespace calculadora
{
    public partial class frmCalculadora : Form
    {

        Operaciones operador = new Operaciones();

        public frmCalculadora()
        {
            InitializeComponent();

            
            



        }
             
        
    

             
        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = Convert.ToInt32(txtNumero1.Text);
                int numero2 = Convert.ToInt32(txtNumero2.Text);
                int resultado = operador.Sumar(numero1, numero2);
                txtResultado.Text = Convert.ToString(resultado);
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Insertar numeros", "Advertencia");
                throw;
            }
        }
        
        private void btnRestar_Click(Object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtNumero1.Text);
            int numero2 = Convert.ToInt32(txtNumero2.Text);

            int resultado = operador.Restar(numero1, numero2);
            txtResultado.Text = Convert.ToString(resultado);

        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtNumero1.Text);
            int numero2 = Convert.ToInt32(txtNumero2.Text);
            int resultado = operador.Multiplicar(numero1, numero2);
            txtResultado.Text = Convert.ToString(resultado);

        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtNumero1.Text);
            int numero2 = Convert.ToInt32(txtNumero2.Text);

            float resultado = operador.Dividir(numero1, numero2);
            txtResultado.Text = Convert.ToString(resultado);
        }
    }
}

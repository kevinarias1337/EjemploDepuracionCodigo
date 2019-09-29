using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDepuracionCodigo
{
    public partial class Form1 : Form
    {
        FuncionesRelleno funcionesRelleno = new FuncionesRelleno();
        FuncionesFibonacci funcionesFibonacci = new FuncionesFibonacci();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrellenar_Click(object sender, EventArgs e)
        {
            lvnumeros.Clear();
            funcionesRelleno.setNumero(int.Parse(txtnumero.Text));
            foreach (int valores in funcionesRelleno.rellenar())
            {
                lvnumeros.Items.Add(valores.ToString());
            }              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvnumeros2.Clear();
            funcionesFibonacci.setNumero(int.Parse(txtnumero.Text));
            foreach(int valores in funcionesFibonacci.fibonacci())
            {
                lvnumeros2.Items.Add(valores.ToString());  
            }           
            }
        }
    }


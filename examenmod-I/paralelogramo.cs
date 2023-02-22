using figurageometrica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenmod_I
{
    public partial class paralelogramo : Form
    {
        List<string> lista_de_palabras;
        Stack<int> pila_numeros;
        public paralelogramo()
        {
            InitializeComponent();
            lista_de_palabras = new List<string>();
            pila_numeros = new Stack<int>();
        }

        private void btnfigura_Click(object sender, EventArgs e)
        {
            inicio ventanainicio = new inicio();
            ventanainicio.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            double ladoa, ladob;
            double area, perimetro;
            //Entrada de datos
            ladoa = Convert.ToDouble(txtladoa.Text);
            ladob = Convert.ToDouble(txtladob.Text);
            //Proceso
            //Evaluamos si es un cuadrado o un rectángulo
            if (ladoa == ladob)
            {
                MessageBox.Show("Los lados son iguales, debes colocar lados diferentes");
                txtladoa.Clear();
                txtladob.Clear();
                lblarea.Text = "";
               
                pbxparalelogramo.Visible = false;

            }
            else
            {

                pbxparalelogramo.Visible = true;
                //Calcular el área y el perímetro

                

                area = ladoa * ladob;
                
                //Salida de la Información
                lblarea.Text = Convert.ToString(area);
                lista_de_palabras.Add(txtladoa.Text);
                lista_de_palabras.Add(txtladob.Text);

            }
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            txtpila.Text = "";
            //Necesito mostrar el/los elementos de la lista
            foreach (string val_auxiliar in lista_de_palabras)
            {
                txtpila.Text += val_auxiliar + "\n";
            }
        }
    }
}

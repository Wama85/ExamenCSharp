using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace examenmod_I
{
    public partial class rectangulo : Form

    {
        List<string> lista_de_palabras;
        Stack<int> pila_numeros;
        public rectangulo()
        {
            InitializeComponent();
            lista_de_palabras = new List<string>();
            pila_numeros = new Stack<int>();// Last In, First Out (LIFO)
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
                lblarea.Text="";
                lblperimetro.Text = "";
                pxrectangulo.Visible = false;

            }
            else
            {

                pxrectangulo.Visible = true;
                //Calcular el área y el perímetro
                area = ladoa * ladob;
                perimetro = 2 * (ladoa + ladob);
                //Salida de la Información
                lblarea.Text = Convert.ToString(area);
                lblperimetro.Text = Convert.ToString(perimetro);
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

        private void ltvsalida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

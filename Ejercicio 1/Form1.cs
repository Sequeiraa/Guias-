using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {

                String nombre;
                Double descuentos, salario, sueldoLiquido;

                nombre = txtnombre.Text;
                salario = Convert.ToDouble(txtsalario.Text);

                if (rbtn1.Checked == true)
                {
                    descuentos = (salario * 20) / 100;
                    sueldoLiquido = salario - descuentos;
                    MessageBox.Show("Bienvenido " + nombre);
                    MessageBox.Show("\nUsted es " + rbtn1.Text);
                    MessageBox.Show("\nSu sueldo sin descuento es de " + salario);
                    MessageBox.Show("\nEl descuento es de " + descuentos);
                    MessageBox.Show("\nSu salario liquido es de " + sueldoLiquido);

                }
                if (rbtn2.Checked == true)
                {
                    descuentos = (salario * 15) / 100;
                    sueldoLiquido = salario - descuentos;
                    MessageBox.Show("Bienvenido " + nombre);
                    MessageBox.Show("\nUsted es " + rbtn2.Text);
                    MessageBox.Show("\nSu sueldo sin descuento es de " + salario);
                    MessageBox.Show("\nEl descuento es de " + descuentos);
                    MessageBox.Show("\nSu salario liquido es de " + sueldoLiquido);
                }
                if(rbtn3.Checked == true)
                {
                    descuentos = (salario * 5) / 100;
                    sueldoLiquido = salario - descuentos;
                    MessageBox.Show("Bienvenido " + nombre);
                    MessageBox.Show("\nUsted es " + rbtn3.Text);
                    MessageBox.Show("\nSu sueldo sin descuento es de " + salario);
                    MessageBox.Show("\nEl descuento es de " + descuentos);
                    MessageBox.Show("\nSu salario liquido es de " + sueldoLiquido);
                }
                if (rbtn1.Checked == false && rbtn2.Checked == false && rbtn3.Checked == false)
                {
                    MessageBox.Show("Debe estar marcada una casilla");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("No se aceptan campos de texto vacíos.");
            }
        }
    }
}

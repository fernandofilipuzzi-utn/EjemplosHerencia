using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class FormPrincipal : Form
    {
        A nuevo;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nuevo != null)
            {
                nuevo.CrearValor(); //ultimo punto del polimorfismo

                Pintar();
            }
        }

        private void Pintar()
        {
            listBox1.Items.Clear();

            if (nuevo is A)
            {
                //C y B es un A , así que imprimira todo lo heredado por A
                listBox1.Items.Add($"{nuevo.Valor}");
                listBox1.Items.Add($"{nuevo.AtributoA}");
            }

            if (nuevo is B)
            {
                //C es un B , así que imprimira todo lo heredado por B
                B b = nuevo as B;
                listBox1.Items.Add($"{b.AtributoB}");
            }

            if (nuevo is C)
            {
                C c = nuevo as C;
                listBox1.Items.Add($"{c.AtributoC}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                nuevo = new A();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                nuevo = new B();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                nuevo = new C();
            }
        }
    }
}

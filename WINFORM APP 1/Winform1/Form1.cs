using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform1
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int errores = 0;
            if (textApellido.Text == "")
            {
                colorRojo(textApellido);
                errores++;
            }

            if (textNombre.Text == "")
            {
                colorRojo(textNombre);
                errores++;
            }

            if (textEdad.Text == "")
            {
                colorRojo(textEdad);
                errores++;
            }
            if (textDirec.Text == "")
            {
                colorRojo(textDirec);
                errores++;
            }
            if(errores == 0)
            {
                textRes.Text = "Apellido y Nombre: " + textApellido.Text + " " + textNombre.Text + "\r\n";
                textRes.Text += "Edad: " + textEdad.Text + "\r\n";
                textRes.Text += "Dirección: " + textDirec.Text;
            }
            else
            errorProvider1.SetError(labelResul, "Campos incompletos");
    
        }

       

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            colorOriginal(textNombre);
        }

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void colorOriginal (TextBox txt)
        {
            txt.BackColor = System.Drawing.SystemColors.Control;
        }

        private void colorRojo (TextBox txt)
        {
            txt.BackColor = Color.Red;
        }
        private void textApellido_TextChanged(object sender, EventArgs e)
        {
            colorOriginal(textApellido);
        }

        private void textEdad_TextChanged(object sender, EventArgs e)
        {
            colorOriginal(textEdad);
        }

        private void textDirec_TextChanged(object sender, EventArgs e)
        {
            colorOriginal(textDirec);
        }

      
    }

}

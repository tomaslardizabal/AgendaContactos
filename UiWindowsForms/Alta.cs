using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiWindowsForms
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtApellido.Text  != "" && txtNumTel.Text != "" 
                    && txtCarac.Text != "" && Negocio.Contacto.TelefonoValido(txtNumTel.Text)
                    && Negocio.Contacto.CaracteristicaValida(txtCarac.Text))
                {
                    Entidades.Contacto contacto = new Entidades.Contacto();
                    contacto.Nombre = txtNombre.Text;
                    contacto.Apellido = txtApellido.Text;
                    contacto.NumTelefono = txtNumTel.Text;
                    contacto.Caracteristica = txtCarac.Text;
                    contacto.Direccion = txtDireccion.Text;
                    contacto.FechaAlta = DateTime.Now;
                    Negocio.Contacto.AgregarContacto(contacto);
                    this.Close();
                }
                else
                {
                    string campoVacio = "";
                    if (txtNombre.Text == "") campoVacio = "El nombre es obligatorio.";
                    else if (txtApellido.Text == "") campoVacio = "El apellido es obligatorio.";
                    else if (txtNumTel.Text == "") campoVacio = "El número de teléfono es obligatorio.";
                    else if (Negocio.Contacto.TelefonoValido(txtNumTel.Text) == false) campoVacio = "Formato de teléfono no válido";
                    else if (txtCarac.Text == "") campoVacio = "La característica es obligatoria.";
                    else if (Negocio.Contacto.CaracteristicaValida(txtCarac.Text) == false) campoVacio = "Formato de característica no válido.";
                    MessageBox.Show(campoVacio);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

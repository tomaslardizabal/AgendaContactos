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
    public partial class Modifica : Form
    {
        public Modifica(Entidades.Contacto contacto)
        {
            InitializeComponent();
            txtId.Text = contacto.Id.ToString();
            txtNombre.Text = contacto.Nombre;
            txtApellido.Text = contacto.Apellido;
            txtDireccion.Text = contacto.Direccion;
            txtNumTel.Text = contacto.NumTelefono;
            txtCarac.Text = contacto.Caracteristica;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                Entidades.Contacto contactoModificado = Negocio.Contacto.GetContacto(id);
                if (txtNombre.Text != "" && txtApellido.Text  != "" && txtNumTel.Text != "" && txtCarac.Text != "")
                {
                    contactoModificado.Nombre = txtNombre.Text;
                    contactoModificado.Apellido = txtApellido.Text;
                    contactoModificado.Direccion = txtDireccion.Text;
                    contactoModificado.Caracteristica = txtCarac.Text;
                    contactoModificado.NumTelefono = txtNumTel.Text;
                    Negocio.Contacto.ModificarContacto(contactoModificado);
                    this.Close();
                }
                else
                {
                    string campoVacio = "";
                    if (txtNombre.Text == "") campoVacio = "El nombre es obligatorio.";
                    else if (txtApellido.Text == "") campoVacio = "El apellido es obligatorio.";
                    else if (txtNumTel.Text == "") campoVacio = "El número de teléfono es obligatorio.";
                    else if (txtCarac.Text == "") campoVacio = "La característica es obligatoria.";
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

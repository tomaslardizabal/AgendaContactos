using Negocio;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UiWindowsForms
{
    public partial class Form1 : Form
    {
        int id;
        public Form1()
        {
            InitializeComponent();
        }
        private void CargarTabla()
        {
            dgvContactos.DataSource = Negocio.Contacto.GetContactos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Alta alta = new Alta();
            alta.Show(this);
            CargarTabla();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvContactos.SelectedRows[0].Cells["Id"].Value);
                Negocio.Contacto.EliminarContacto(Negocio.Contacto.GetContacto(id));
                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvContactos.SelectedRows[0].Cells["Id"].Value);
                Entidades.Contacto contacto = Negocio.Contacto.GetContacto(id);
                if (contacto != null)
                {
                    Modifica modifica = new Modifica(contacto);
                    modifica.Show(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            CargarTabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvContactos.DataSource = Negocio.Contacto.ContactosPorNombre(txtBuscar.Text);
        }
    }
}
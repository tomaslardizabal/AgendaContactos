using Datos;


namespace Negocio
{
    public class Contacto
    {
        public static List<Entidades.Contacto> GetContactos() => 
            Datos.Contacto.GetContactos();
        public static void AgregarContacto(Entidades.Contacto contacto)
        {
            Datos.Contacto.AgregarContacto(contacto);
        }
        public static void EliminarContacto(Entidades.Contacto contacto)
        {
            Datos.Contacto.EliminarContacto(contacto);
        }
        public static void ModificarContacto(Entidades.Contacto contactoModificado)
        {
            Datos.Contacto.ModificarContacto(contactoModificado);
        }
        public static Entidades.Contacto GetContacto(int id)
        {
            return Datos.Contacto.GetContacto(id);
        }
        public static List<Entidades.Contacto> ContactosPorNombre(string nombre)
        {
            return Datos.Contacto.ContactosPorNombre(nombre);
        }
        public static bool TelefonoValido(string tel)
        {
            return Datos.Contacto.TelefonoValido(tel);
        }
        public static bool CaracteristicaValida(string carac)
        {
            return Datos.Contacto.CaracteristicaValida(carac);
        }
    }
}
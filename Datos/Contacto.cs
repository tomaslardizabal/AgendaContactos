using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System;

namespace Datos
{
    public class Contacto
    {

        public static List<Entidades.Contacto> GetContactos()
        {
            using (var context = Context.CreateContext())
            {
                return context.contactos.ToList();
            }
        }
        public static void AgregarContacto(Entidades.Contacto contacto)
        {
            using(var context = Context.CreateContext())
            {
                context.contactos.Add(contacto);
                context.SaveChanges();
            }
        }
        public static void EliminarContacto(Entidades.Contacto contacto)
        {
            using( var context = Context.CreateContext())
            {
                context.contactos.Remove(contacto);
                context.SaveChanges();
            }
        }
        public static void ModificarContacto(Entidades.Contacto contactoModificado)
        {
            using( var context = Context.CreateContext())
            {
                context.contactos.Update(contactoModificado);
                context.SaveChanges();
            }
        }

        public static Entidades.Contacto GetContacto(int id)
        {
            using( var context = Context.CreateContext())
            {
                var contacto = context.contactos.FirstOrDefault(c => c.Id == id);
                return contacto;
            }
        }
        public static List<Entidades.Contacto> ContactosPorNombre(string nombre)
        {
            using ( var context = Context.CreateContext())
            {
                return context.contactos.Where(c => c.Nombre.Contains(nombre)).ToList();
            }
        }
        public static bool TelefonoValido(string tel)
        {
            if ( int.TryParse(tel, out int result) == false || tel.Length < 6) return false;
            else return true;
        }
        public static bool CaracteristicaValida(string carac)
        {
            if (int.TryParse(carac, out int result) == false || carac.Length < 4) return false;
            else return true;
        }
    }
}
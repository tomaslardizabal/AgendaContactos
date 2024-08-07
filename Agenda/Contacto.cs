using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entidades
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        public string NumTelefono { get; set; }        
        public string Caracteristica { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }        
        public string Direccion { get; set; }       
        public DateTime FechaAlta { get; set; }

        public Contacto( string tel, string carac, string nom, string ape, string dire, DateTime fec)
        {
            //Id = id;
            NumTelefono = tel;
            Caracteristica = carac;
            Nombre = nom;
            Apellido = ape;
            Direccion = dire;
            FechaAlta = fec;
        }     
        public Contacto() { }
    }
}
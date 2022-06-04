using System;
using System.ComponentModel.DataAnnotations;

namespace TEJADA_T3.Models
{
    public class Historia
    {
        public int Codigo { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime FechaRegistro { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Mascota { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal Tamano { get; set; }
        public string DatosParticulares { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Dueno { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string DuenoDireccion { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [EmailAddress(ErrorMessage = "El campo no es una dirección de correo electrónico válida")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int IdSexo { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int IdRaza { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int IdEspecie { get; set; }
        public Sexo Sexo { get; set; }
        public Especie Especie { get; set; }
        public Raza Raza { get; set; }
    }
}

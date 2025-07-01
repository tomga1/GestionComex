using System.ComponentModel.DataAnnotations;

namespace GestionComex.DTOs
{
    public class ClienteEditDTO
    {
        public int Id { get; set; }
        public string CUIT { get; set; }

        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [RegularExpression(@"^\+?\d{7,15}$", ErrorMessage = "El teléfono debe tener solo números entre 7 y 15 digitos. Puede empezar con +")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria")]
        public string? Direccion { get; set; }
        public bool Activo { get; set; }


    }
}

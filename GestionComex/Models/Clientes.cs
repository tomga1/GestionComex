using System.ComponentModel.DataAnnotations;

namespace GestionComex.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El CUIT es obligatorio")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "El CUIT solo debe contener 11 números")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "El CUIT solo debe contener 11 números")]
        public string CUIT { get; set; }

        
        [Display(Name = "Razón Social")]
        public string RazonSocial { get; set; }  // Será de solo lectura en la vista (se puede asignar desde otro sistema)

        [Required(ErrorMessage = "El telefono es obligatorio")]
        [RegularExpression(@"^\+?\d{7,15}$", ErrorMessage = "El teléfono debe tener solo números entre 7 y 15 digitos. Puede empezar con +")]
        public string Telefono { get; set; }


        [Required(ErrorMessage = "La dirección es obligatoria")]
        [StringLength(200, ErrorMessage = "La dirección no puede superar los 200 caracteres")]
        public string? Direccion { get; set; }


        [Required]
        [Display(Name = "Activo")]
        public bool Activo { get; set; }
    }
}

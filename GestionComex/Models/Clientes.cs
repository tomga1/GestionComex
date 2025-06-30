using System.ComponentModel.DataAnnotations;

namespace GestionComex.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El CUIT es obligatorio")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "El CUIT debe tener 11 caracteres")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "El CUIT debe contener sólo números")]
        public string CUIT { get; set; }

        
        [Display(Name = "Razón Social")]
        public string RazonSocial { get; set; }  // Será de solo lectura en la vista (se puede asignar desde otro sistema)


        [Phone(ErrorMessage = "Teléfono inválido")]
        public string Telefono { get; set; }


        [StringLength(200, ErrorMessage = "La dirección no puede superar los 200 caracteres")]
        public string? Direccion { get; set; }


        [Required]
        [Display(Name = "Activo")]
        public bool Activo { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace SourcingManager.Models
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(120)]
        public string Nombre { get; set; }
        
        [Display(Name = "RUC / NIT")]
        [Required]
        [StringLength(20)]
        public string RucONit { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string? Email { get; set; }

        [Display(Name = "Teléfono")]
        [Phone]
        public string? Telefono { get; set; }

        [Display(Name = "Dirección")]
        public string? Direccion { get; set; }

        [Display(Name = "Categoría")]
        [Required(ErrorMessage = "Selecciona una categoría")]
        public int CategoriaProveedorId { get; set; }
        
        [Display(Name = "Categoría")]
        public CategoriaProveedor? CategoriaProveedor { get; set; }

    }
}
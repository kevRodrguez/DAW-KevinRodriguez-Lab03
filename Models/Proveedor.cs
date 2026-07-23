using System.ComponentModel.DataAnnotations;

namespace SourcingManager.Models
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(120)]
        public string Nombre { get; set; }
        
        [Required]
        [StringLength(20)]
        public string RucONit { get; set; }

        [EmailAddress(ErrorMessage = "Email inválido")]
        public string? Email { get; set; }

        [Phone]
        public string? Telefono { get; set; }

        public string? Direccion { get; set; }

        [Required(ErrorMessage = "Selecciona una categoría")]
        public int CategoriaProveedorId { get; set; }
        
        public CategoriaProveedor? CategoriaProveedor { get; set; }

    }
}
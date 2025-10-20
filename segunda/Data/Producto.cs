using System.ComponentModel.DataAnnotations;

namespace segunda.Data // <--- ESTA LÍNEA ES LA CLAVE
{
    public class Producto
    {
        [Range(1, int.MaxValue, ErrorMessage = "Debe ser entero positivo mayor a 0")]
        public int Inventario { get; set; }

        [Required(ErrorMessage = "El nombre no debe ser vacío")]
        [StringLength(200, ErrorMessage = "El nombre tiene una longitud máxima de 200 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Debe seleccionar departamento")]
        public string? Departamento { get; set; }
    }
}
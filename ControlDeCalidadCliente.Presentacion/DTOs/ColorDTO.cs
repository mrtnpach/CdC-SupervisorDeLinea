using System.ComponentModel.DataAnnotations;

namespace ControlDeCalidadCliente.Presentacion.DTOs
{
    public class ColorDTO
    {
        public ColorDTO() { }

        [Required] public string? Codigo { get; set; }
        [Required] public string? Descripcion { get; set; }
    }
}

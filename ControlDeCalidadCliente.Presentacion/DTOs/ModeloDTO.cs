using System.ComponentModel.DataAnnotations;

namespace ControlDeCalidadCliente.Presentacion.DTOs
{
    public class ModeloDTO
    {
        [Required] public string? SKU { get; set; }
        [Required] public string? Denominacion { get; set; }
        [Required] public int LimiteInferiorReproceso { get; set; }
        [Required] public int LimiteSuperiorReproceso { get; set; }
        [Required] public int LimiteInferiorObservado { get; set; }
        [Required] public int LimiteSuperiorObservado { get; set; }
    }
}

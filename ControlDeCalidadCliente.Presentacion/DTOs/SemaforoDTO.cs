using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControlDeCalidadCliente.Presentacion.DTOs
{
    public class SemaforoDTO
    {
        public int Linea { get; set; }
        // Enums podrian resolver esto:
        public string ColorSemaforoObservado { get; set; }
        public string ColorSemaforoReproceso { get; set; }
        public List<string> TopReproceso { get; set; }
        public List<string> TopObservado { get; set; }
    }
}
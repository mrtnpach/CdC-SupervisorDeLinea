using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion.DTOs
{
    public class ModeloDTO
    {
        public string SKU { get; set; }
        public string Denominacion { get; set; }
        public int LimiteInferiorReproceso { get; set; }
        public int LimiteSuperiorReproceso { get; set; }
        public int LimiteInferiorObservado { get; set; }
        public int LimiteSuperiorObservado { get; set; }
    }
}

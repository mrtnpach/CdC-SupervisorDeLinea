using ControlDeCalidadCliente.Presentacion.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion.Contratos
{
    public interface ISemaforoVista : IVista
    {
        void ActualizarListas(List<string> topObservado, List<string> topReproceso);
        void ActualizarSemaforos(string colorObservado, string colorReproceso);
    }
}

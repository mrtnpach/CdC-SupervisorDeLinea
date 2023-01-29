using ControlDeCalidadCliente.Presentacion.Tareas;
using ControlDeCalidadCliente.Presentacion.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion.Presentadores
{
    public interface IPresentador
    {
        ITarea Tarea { get; set; }
        IVista Vista { get; set; }
    }
}

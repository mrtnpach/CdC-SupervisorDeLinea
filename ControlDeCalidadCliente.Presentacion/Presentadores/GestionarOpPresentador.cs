using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Tareas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion.Presentadores
{
    public class GestionarOpPresentador
        : PresentadorBase<GestionarOpTarea, IGestionarOpVista>
    {
        public GestionarOpPresentador(IGestionarOpVista vista) : base(vista)
        {

        }
    }
}

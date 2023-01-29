using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion.Tareas
{
    public class AutenticacionTarea : TareaBase
    {
        public override void Iniciar(IVista vistaPadre = null)
        {
            NavegarA<AutenticacionPresentador>();
        }
    }
}

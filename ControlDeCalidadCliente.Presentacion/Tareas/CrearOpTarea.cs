using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion.Tareas
{
    public class CrearOpTarea : TareaBase
    {
        public override void Iniciar(IVista vistaPadre = null)
        {
            VistaPadre = vistaPadre;
            NavegarA<CrearOpPresentador>(esHijo: true, esDialogo: false);
        }
    }
}

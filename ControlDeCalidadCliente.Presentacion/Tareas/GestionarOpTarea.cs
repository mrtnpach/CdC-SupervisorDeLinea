using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion.Tareas
{
    public class GestionarOpTarea : TareaBase
    {
        public override void Iniciar(IVista vistaPadre = null)
        {
            VistaPadre = vistaPadre;
            NavegarA<GestionarOpPresentador>(esHijo: true, esDialogo: false);
        }
    }
}

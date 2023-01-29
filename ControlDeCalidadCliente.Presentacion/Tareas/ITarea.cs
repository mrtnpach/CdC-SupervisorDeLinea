using ControlDeCalidadCliente.Presentacion.Presentadores;
using ControlDeCalidadCliente.Presentacion.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion.Tareas
{
    public interface ITarea
    {
        IVista VistaPadre { get; set; }

        void Iniciar(IVista vistaPadre = null);
        void NavegarA<TPresentador>(bool esHijo = false, bool esDialogo = false) 
            where TPresentador : IPresentador;
    }
}

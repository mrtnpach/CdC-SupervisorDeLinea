using ControlDeCalidadCliente.Presentacion.Tareas;
using ControlDeCalidadCliente.Presentacion.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion.Presentadores
{
    public class PresentadorBase<TTarea, TIVista> : IPresentador<TTarea, TIVista>
        where TTarea : class, ITarea
        where TIVista : class, IVista
    {
        public PresentadorBase(TIVista vista)
        {
            Vista = vista;
            Vista.Presentador = this;
        }

        public virtual TTarea Tarea { get; set; }
        public virtual TIVista Vista { get; set; }

        ITarea IPresentador.Tarea { get { return Tarea; } set { Tarea = value as TTarea; } }
        IVista IPresentador.Vista { get { return Vista; } set { Vista = value as TIVista; } }
    }
}

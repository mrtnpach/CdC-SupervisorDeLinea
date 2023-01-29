using ControlDeCalidadCliente.Presentacion.Presentadores;
using ControlDeCalidadCliente.Presentacion.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion.Tareas
{
    public abstract class TareaBase : ITarea
    {
        public IVista VistaPadre { get; set; }

        public abstract void Iniciar(IVista vistaPadre = null);

        public void NavegarA<TPresentador>(bool esHijo = false, bool esDialogo = false) 
            where TPresentador : IPresentador
        {
            TPresentador presentador = IoC.Factoria.Instancia.Crear<TPresentador>();
            presentador.Tarea = this;
            if(esDialogo)
            {
                presentador.Vista.MostrarComoDialogo();
            }
            else
            {
                presentador.Vista.Mostrar(VistaPadre);
            }
        }
    }
}

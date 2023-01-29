using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Presentadores;
using ControlDeCalidadCliente.Presentacion.Tareas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion
{
    internal class AdministradorDeTareas
    {
        private static volatile AdministradorDeTareas _instancia;
        private static readonly object _syncLock = new object();

        private AdministradorDeTareas()
        {

        }

        public static AdministradorDeTareas Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    lock (_syncLock)
                    {
                        _instancia = new AdministradorDeTareas();
                    }
                }
                return _instancia;
            }
        }

        public void Iniciar<TTarea>(IVista vistaPadre = null)
            where TTarea : ITarea
        {
            TTarea tarea = IoC.Factoria.Instancia.Crear<TTarea>();
            tarea.Iniciar(vistaPadre);
        }

        public void IniciarAplicacion()
        {
            Iniciar<AutenticacionTarea>();
        }
    }
}

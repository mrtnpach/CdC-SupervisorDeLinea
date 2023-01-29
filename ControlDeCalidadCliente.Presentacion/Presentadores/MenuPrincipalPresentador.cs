using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Tareas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion.Presentadores
{
    public class MenuPrincipalPresentador 
        : PresentadorBase<MenuPrincipalTarea, IMenuPrincipalVista>
    {
        public MenuPrincipalPresentador(IMenuPrincipalVista vista) : base(vista)
        {

        }

        public void IniciarCreacionDeOp()
        {
            AdministradorDeTareas.Instancia.Iniciar<CrearOpTarea>(Vista);
        }
    }
}

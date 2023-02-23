using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Sesiones;
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

        public void IniciarGestionDeOp()
        {
            AdministradorDeTareas.Instancia.Iniciar<GestionarOpTarea>(Vista);
        }

        public async void CerrarSesion()
        {
            try
            {
                string token = Sesion.Instancia.Datos.Token;
                string uri = $"api/Autenticacion/CerrarSesion?token={token}";
                await ClienteHttp.Cliente.Instancia.ModificarAsync(uri);
            }
            catch (Exception exc)
            {
                Vista.MostrarMensaje("Atencion", exc.Message);
            }
        }
    }
}

using ControlDeCalidadCliente.Presentacion.ClienteHttp;
using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.DTOs;
using ControlDeCalidadCliente.Presentacion.Sesiones;
using ControlDeCalidadCliente.Presentacion.Tareas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion.Presentadores
{
    public class AutenticacionPresentador : PresentadorBase<AutenticacionTarea, IAutenticacionVista>
    {
        public AutenticacionPresentador(IAutenticacionVista vista) 
            : base(vista)
        {

        }

        public async void AutenticarUsuario(string correo, string password)
        {
            try
            {
                // Se puede aumentar el scope para optimizar
                string uri = $"api/Autenticacion?correo={correo}&password={password}";

                // No es aparente la logica de rechazo, seria mejor mostrarla aqui.
                // La sesion no inicia solo si el metodo GetAsync lanza una excepcion
                EmpleadoDTO empleado = await Cliente.Instancia.GetAsync<EmpleadoDTO>(uri);
                Sesion.Instancia.Iniciar(empleado);

                AdministradorDeTareas.Instancia.Iniciar<MenuPrincipalTarea>();

                Vista.CerrarVentana();
            }
            catch (Exception exc)
            {
                Vista.MostrarMensaje("Atencion", exc.Message);
            }
        }
    }
}

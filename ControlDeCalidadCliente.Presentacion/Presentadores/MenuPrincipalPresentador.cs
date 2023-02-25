using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Sesiones;
using ControlDeCalidadCliente.Presentacion.Tareas;
using ControlDeCalidadCliente.Presentacion.ClienteHttp;
using System;

namespace ControlDeCalidadCliente.Presentacion.Presentadores
{
    public class MenuPrincipalPresentador 
        : PresentadorBase<MenuPrincipalTarea, IMenuPrincipalVista>
    {
        public MenuPrincipalPresentador(IMenuPrincipalVista vista) : base(vista)
        {
            SuscribirASemaforo();
        }

        public void IniciarCreacionDeOp()
        {
            AdministradorDeTareas.Instancia.Iniciar<CrearOpTarea>(Vista);
            Cliente.Instancia.Semaforo.EnviarMensaje("Hola");
        }

        public void IniciarGestionDeOp()
        {
            // Hago esto porque el VS no me deja agregar la nueva opcion en el menu,
            // despues lo saco
            //AdministradorDeTareas.Instancia.Iniciar<GestionarOpTarea>(Vista);
            AdministradorDeTareas.Instancia.Iniciar<SemaforoTarea>(Vista);
        }

        public void MostrarSemaforo()
        {
            AdministradorDeTareas.Instancia.Iniciar<SemaforoTarea>(Vista);
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

        // Metodos de prueba
        private async void SuscribirASemaforo()
        {
            try
            {
                await Cliente.Instancia.Semaforo.SuscribirAAlertas("AlertaLimiteInferior", MostrarAlertaInferior);
                await Cliente.Instancia.Semaforo.SuscribirAAlertas("AlertaLimiteSuperior", MostrarAlertaSuperior);
                await Cliente.Instancia.Semaforo.SuscribirAMensajes(MostrarMensaje);
            }
            catch (Exception exc)
            {
                Vista.MostrarMensaje("Alerta", exc.Message);
            }
        }

        public void MostrarAlertaInferior(string linea, string numero, string tipo)
        {
            Vista.MostrarMensaje(
                "Alerta", $"La orden {numero} sobre la linea {linea} alcanzo su limite de {tipo}");
        }

        public void MostrarAlertaSuperior(string linea, string numero, string tipo)
        {
            Vista.MostrarMensaje(
                "Alerta", $"La orden {numero} sobre la linea {linea} alcanzo su limite superior de {tipo}");
        }

        public void MostrarMensaje(string mensaje)
        {
            Vista.MostrarMensaje("Funciona", mensaje);
        }
    }
}

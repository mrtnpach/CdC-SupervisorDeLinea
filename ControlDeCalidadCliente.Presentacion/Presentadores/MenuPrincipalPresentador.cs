using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Sesiones;
using ControlDeCalidadCliente.Presentacion.Tareas;
using ControlDeCalidadCliente.Presentacion.ClienteHttp;
using System;
using ControlDeCalidadCliente.Presentacion.DTOs;
using System.Threading.Tasks;

namespace ControlDeCalidadCliente.Presentacion.Presentadores
{
    public class MenuPrincipalPresentador 
        : PresentadorBase<MenuPrincipalTarea, IMenuPrincipalVista>
    {
        public MenuPrincipalPresentador(IMenuPrincipalVista vista) : base(vista)
        {
            ObtenerDatosDeOrden();
            SuscribirASemaforo();
        }

        public void IniciarCreacionDeOp()
        {
            AdministradorDeTareas.Instancia.Iniciar<CrearOpTarea>(Vista);
        }

        public void IniciarGestionDeOp()
        {
            AdministradorDeTareas.Instancia.Iniciar<GestionarOpTarea>(Vista);
        }

        public void MostrarSemaforo()
        {
            AdministradorDeTareas.Instancia.Iniciar<SemaforoTarea>(Vista);
        }

        private async Task ObtenerDatosDeOrden()
        {
            try
            {
                string token = Sesion.Instancia.Datos.Token;
                string uri = $"api/Ordenes/MiOp/{Uri.EscapeDataString(token)}";
                OrdenDTO op = await Cliente.Instancia.GetAsync<OrdenDTO>(uri);
                if (op != null)
                {
                    string linea = op.Linea.Numero.ToString();
                    string numOp = op.Numero;
                    await Cliente.Instancia.Semaforo.UnirseALinea(linea, numOp);
                }
            }
            catch (Exception)
            {

            }
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

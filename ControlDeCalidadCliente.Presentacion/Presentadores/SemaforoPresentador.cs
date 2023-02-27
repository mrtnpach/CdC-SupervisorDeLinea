using ControlDeCalidadCliente.Presentacion.ClienteHttp;
using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.DTOs;
using ControlDeCalidadCliente.Presentacion.Sesiones;
using ControlDeCalidadCliente.Presentacion.Tareas;
using System;
using System.Threading.Tasks;

namespace ControlDeCalidadCliente.Presentacion.Presentadores
{
    public class SemaforoPresentador
        : PresentadorBase<SemaforoTarea, ISemaforoVista>
    {
        private OrdenDTO _orden;

        public SemaforoPresentador(ISemaforoVista vista) : base(vista)
        {
            Inicializar();
            //Suscribir a la actualizacion de la lista
        }

        private async void Inicializar()
        {
            await ObtenerOrdenAsociada();
            await Cliente.Instancia.Semaforo.SuscribirADatosEnLinea(ActualizarDatos);
        }

        private async Task ObtenerOrdenAsociada()
        {
            // Bloques try-catch en el presentador del menu seria mas simple
            try
            {
                string token = Sesion.Instancia.Datos.Token;
                string uri = $"api/Ordenes/MiOp/{Uri.EscapeDataString(token)}";
                OrdenDTO orden = await Cliente.Instancia.GetAsync<OrdenDTO>(uri);
                _orden = orden;               
            }
            catch (NullReferenceException)
            {
                Vista.MostrarMensaje("Atencion", "Hubo un problema al mostrar los datos.");
                Vista.Cerrar();
            }
            catch (Exception)
            {
                Vista.MostrarMensaje("Atencion", "No tiene una Orden de Produccion asociada.");
                Vista.Cerrar();
            }
        }

        public void ActualizarDatos(SemaforoDTO semaforoDTO)
        {
            Vista.ActualizarListas(semaforoDTO.TopObservado, semaforoDTO.TopReproceso);
            Vista.ActualizarSemaforos(semaforoDTO.ColorSemaforoObservado, semaforoDTO.ColorSemaforoReproceso);
        }
    }
}

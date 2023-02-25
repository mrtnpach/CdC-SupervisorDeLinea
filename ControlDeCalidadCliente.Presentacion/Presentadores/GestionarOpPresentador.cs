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
    public class GestionarOpPresentador
        : PresentadorBase<GestionarOpTarea, IGestionarOpVista>
    {
        private OrdenDTO _orden;

        public GestionarOpPresentador(IGestionarOpVista vista) : base(vista)
        {
            ObtenerOrdenAsociada();
        }

        private async void ObtenerOrdenAsociada()
        {
            // Bloques try-catch en el presentador del menu seria mas simple
            try
            {
                string token = Sesion.Instancia.Datos.Token;
                string uri = $"api/Ordenes/MiOp/{Uri.EscapeDataString(token)}";
                OrdenDTO orden = await Cliente.Instancia.GetAsync<OrdenDTO>(uri);
                Vista.MostrarDatos(
                    orden.Numero, orden.SupervisorDeLinea.Nombre, 
                    orden.Linea.Numero, orden.Modelo.Denominacion, 
                    orden.Color.Descripcion, orden.Estado
                    );
                _orden = orden;
                MostrarOpciones();

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

        private void MostrarOpciones()
        {
            // Si esta finalizada, no se deberia mostrar
            switch(_orden.Estado)
            {
                case "Iniciada":
                    Vista.OcultarBotones();
                    Vista.MostrarBotonPausa();
                    Vista.MostrarBotonFinalizar();
                    break;
                case "Pausada":
                    Vista.OcultarBotones();
                    Vista.MostrarBotonReanudar();
                    Vista.MostrarBotonFinalizar();
                    break;
                case "Finalizada":
                    Vista.OcultarBotones();
                    break;
            }
        }

        public async void Reanudar()
        {
            try
            {
                string token = Sesion.Instancia.Datos.Token;
                string uri = $"api/Ordenes/ReanudarOp?numOP={_orden.Numero}&token={token}";
                await Cliente.Instancia.ModificarAsync(uri);

                // Mostrar datos actualizados
                ObtenerOrdenAsociada();
            }
            catch (Exception exc)
            {
                Vista.MostrarMensaje("Atencion", exc.Message);
            }
        }

        public async void Pausar()
        {
            try
            {
                string token = Sesion.Instancia.Datos.Token;
                string uri = $"api/Ordenes/PausarOp?numOP={_orden.Numero}&token={token}";
                await Cliente.Instancia.ModificarAsync(uri);

                // Mostrar datos actualizados
                ObtenerOrdenAsociada();
            }
            catch (Exception exc)
            {
                Vista.MostrarMensaje("Atencion", exc.Message);
            }
        }

        public async void Finalizar()
        {
            try
            {
                string token = Sesion.Instancia.Datos.Token;
                string uri = $"api/Ordenes/FinalizarOp?numOP={_orden.Numero}&token={token}";
                await Cliente.Instancia.ModificarAsync(uri);

                // Pedir confirmacion
                // Al finalizar la op, esta se nullifica en el supervisor de linea
                // por lo que al buscar los datos de nuevo, se hace una referencia nula
                bool opcion = Vista.PedirConfirmacion("Finalizar Orden", "¿Desea finalizar la orden de produccion?");
                if (opcion)
                {
                    string linea = _orden.Linea.Numero.ToString();
                    await Cliente.Instancia.Semaforo.AbandonarLinea(linea);
                    Vista.MostrarMensaje("Operacion Exitosa", $"La Orden {_orden.Numero} finalizo exitosamente.");
                    Vista.Cerrar();
                }
            }
            catch (Exception exc)
            {
                Vista.MostrarMensaje("Atencion", exc.Message);
            }
        }
    }
}

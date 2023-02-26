using ControlDeCalidadCliente.Presentacion.ClienteHttp;
using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.DTOs;
using ControlDeCalidadCliente.Presentacion.Tareas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion.Presentadores
{
    public class CrearOpPresentador 
        : PresentadorBase<CrearOpTarea, ICrearOpVista>
    {
        public CrearOpPresentador(ICrearOpVista vista) : base(vista)
        {
            ObtenerModelosYColores();
        }

        public List<ModeloDTO> Modelos { get; set; }
        public List<ColorDTO> Colores { get; set; }
        public List<LineaDeTrabajoDTO> Lineas { get; set; }

        private async void ObtenerModelosYColores()
        {
            try
            {
                // Idealmente habria una sola llamada a la API para traer todo
                Lineas = await Cliente.Instancia.GetTodoAsync<LineaDeTrabajoDTO>("api/Lineas/ObtenerLineas");
                Vista.PoblarComboBoxLineas();
                Modelos = await Cliente.Instancia.GetTodoAsync<ModeloDTO>("api/Modelos/ObtenerModelos");
                Vista.PoblarComboBoxModelos();
                Colores = await Cliente.Instancia.GetTodoAsync<ColorDTO>("api/Colores/ObtenerColores");
                Vista.PoblarComboBoxColores();
            }
            catch (Exception exc)
            {
                Vista.MostrarMensaje("Atencion", exc.Message);
            }
        }

        public async void CrearOp(string numeroOp, string sku, string codigo, string numeroDeLinea) // Mas numero de linea
        {
            try
            {
                string token = Sesiones.Sesion.Instancia.Datos.Token;

                // Podria sacarse del combobox
                //string numeroDeLinea = ConfigurationManager.AppSettings.Get("NumeroDeLinea");

                string uri = $"api/Ordenes/CrearOP?numOP={numeroOp}&sku={sku}&codColor={codigo}&numLinea={numeroDeLinea}&token={token}";
                await Cliente.Instancia.AgregarAsync(uri);
                await Cliente.Instancia.Semaforo.UnirseALinea(numeroDeLinea, numeroOp);


                Vista.MostrarMensaje("Operacion Exitosa", $"Orden de produccion {numeroOp} creada e iniciada.");
            }
            catch (Exception exc)
            {
                Vista.MostrarMensaje("Atencion", exc.Message);
            }
        }
    }
}

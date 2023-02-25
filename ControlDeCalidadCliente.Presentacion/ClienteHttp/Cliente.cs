using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace ControlDeCalidadCliente.Presentacion.ClienteHttp
{
    public class Cliente
    {
        private HttpClient _cliente;
        public ClienteSemaforo Semaforo {get; private set;}

        #region Singleton
        private static volatile Cliente _instancia;
        private static readonly object _syncLock = new object();

        private Cliente()
        {
            Configurar();
            Semaforo = new ClienteSemaforo();
        }

        public static Cliente Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    lock (_syncLock)
                    {
                        _instancia = new Cliente();
                    }
                }
                return _instancia;
            }
        }
        #endregion Singleton

        private void Configurar()
        {
            string uriBase = ConfigurationManager.ConnectionStrings["ControlDeCalidad"].ConnectionString;
            _cliente = new HttpClient();
            _cliente.BaseAddress = new Uri(uriBase);

            // Pide al servidor que mande datos como JSON
            _cliente.DefaultRequestHeaders.Accept.Clear();
            _cliente.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #region Operaciones REST
        public async Task<List<T>> GetTodoAsync<T>(string path)
        {
            List<T> items = new List<T>();
            HttpResponseMessage response = await _cliente.GetAsync(_cliente.BaseAddress + path);
            if (response.IsSuccessStatusCode)
            {
                IEnumerable<T> resultado = await response.Content.ReadAsAsync<IEnumerable<T>>();
                items = resultado.ToList();
                return items;
            }
            else
            {
                string mensaje = await response.Content.ReadAsStringAsync();
                throw new Exception(mensaje);
            }
        }

        public async Task<T> GetAsync<T>(string path)
        {
            T item;
            HttpResponseMessage response = await _cliente.GetAsync(_cliente.BaseAddress + path);
            if (response.IsSuccessStatusCode)
            {
                item = await response.Content.ReadAsAsync<T>();
                return item;
            }
            else
            {
                string mensaje = await response.Content.ReadAsStringAsync();
                throw new Exception(mensaje);
            }
        }

        public async Task EliminarAsync(string path)
        {
            HttpResponseMessage response = await _cliente.DeleteAsync(_cliente.BaseAddress + path);
            if (!response.IsSuccessStatusCode)
            {
                string mensaje = await response.Content.ReadAsStringAsync();
                throw new Exception(mensaje);
            }
        }

        public async Task AgregarAsync(string path)
        {
            HttpResponseMessage response = await _cliente.PostAsync(_cliente.BaseAddress + path, null);
            if (!response.IsSuccessStatusCode)
            {
                string mensaje = await response.Content.ReadAsStringAsync();
                throw new Exception(mensaje);
            }
        }

        public async Task ModificarAsync(string path)
        {
            HttpResponseMessage response = await _cliente.PutAsync(_cliente.BaseAddress + path, null);
            if (!response.IsSuccessStatusCode)
            {
                string mensaje = await response.Content.ReadAsStringAsync();
                throw new Exception(mensaje);
            }
        }
        #endregion Operaciones REST
    }
}

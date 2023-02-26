using ControlDeCalidadCliente.Presentacion.DTOs;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace ControlDeCalidadCliente.Presentacion.ClienteHttp
{
    public class ClienteSemaforo
    {
        private HubConnection _hubConnection;
        public ClienteSemaforo()
        {
            Inicializar();
        }
        private async void Inicializar()
        {
            string uri = ConfigurationManager.ConnectionStrings["Semaforo"].ConnectionString;
            _hubConnection = new HubConnectionBuilder()
                .WithUrl(new Uri(uri))
                .Build();

            await _hubConnection.StartAsync();
        }

        public async Task UnirseALinea(string linea, string numOp)
        {
            if(_hubConnection.State == HubConnectionState.Disconnected)
                await _hubConnection.StartAsync();

            await _hubConnection.InvokeAsync("UnirseALinea", linea, numOp);
        }

        public async Task AbandonarLinea(string linea)
        {
            if (_hubConnection.State == HubConnectionState.Disconnected)
                await _hubConnection.StartAsync();

            await _hubConnection.InvokeAsync("AbandonarLinea", linea);
        }

        // Se podria unir todos los parametros en SemaforoDTO
        public async Task SuscribirAAlertas(string metodoAlerta, Action<string, string, string> metodoCliente)
        {
            _hubConnection.On(metodoAlerta, metodoCliente);

            if (_hubConnection.State == HubConnectionState.Disconnected)
                await _hubConnection.StartAsync();
        }

        public async Task SuscribirADatosEnLinea(Action<SemaforoDTO> metodoCliente)
        {
            _hubConnection.On("ActualizarSemaforo", metodoCliente);

            if (_hubConnection.State == HubConnectionState.Disconnected)
                await _hubConnection.StartAsync();
        }

        //
        // Pruebas: 
        //
        public async Task SuscribirAMensajes(Action<string> handler)
        {
            _hubConnection.On("NuevoMensaje", handler);
            
            if (_hubConnection.State == HubConnectionState.Disconnected)
                await _hubConnection.StartAsync();
        }

        public async Task EnviarMensaje(string mensaje)
        {
            if (_hubConnection.State == HubConnectionState.Disconnected)
                await _hubConnection.StartAsync();

            await _hubConnection.SendAsync("NuevoMensaje", mensaje);
        }
    }
}

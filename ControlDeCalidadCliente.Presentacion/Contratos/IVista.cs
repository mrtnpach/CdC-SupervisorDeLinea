using ControlDeCalidadCliente.Presentacion.Presentadores;

namespace ControlDeCalidadCliente.Presentacion.Contratos
{
    public interface IVista
    {
        IPresentador Presentador { get; set; }

        void Mostrar(IVista vistaPadre);
        void MostrarComoDialogo();
        void MostrarMensaje(string titulo, string mensaje);
        bool PedirConfirmacion(string titulo, string mensaje);
        void Cerrar();
    }
}

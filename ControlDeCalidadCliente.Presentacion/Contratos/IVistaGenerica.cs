using ControlDeCalidadCliente.Presentacion.Presentadores;

namespace ControlDeCalidadCliente.Presentacion.Contratos
{
    public interface IVista<TPresentador> : IVista
        where TPresentador : IPresentador
    {
        new TPresentador Presentador { get; set; }
    }
}

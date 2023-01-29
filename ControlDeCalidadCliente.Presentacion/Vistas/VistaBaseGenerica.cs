using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Presentadores;

namespace ControlDeCalidadCliente.Presentacion.Vistas
{
    public class VistaBaseGenerica<TPresentador> : VistaBase, IVista<TPresentador>
        where TPresentador : class, IPresentador
    {
        public new TPresentador Presentador { get; set; }

        IPresentador IVista.Presentador
        {
            get { return Presentador; }
            set { Presentador = value as TPresentador; }
        }
    }
}

using ControlDeCalidadCliente.Presentacion.Tareas;
using ControlDeCalidadCliente.Presentacion.Contratos;

namespace ControlDeCalidadCliente.Presentacion.Presentadores
{
    public interface IPresentador<TTarea, TIVista> : IPresentador
        where TTarea : ITarea
        where TIVista : IVista
    {
        new TTarea Tarea { get; set; }
        new TIVista Vista { get; set; }
    }
}

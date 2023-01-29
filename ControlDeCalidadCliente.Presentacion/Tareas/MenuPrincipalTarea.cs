using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Presentadores;

namespace ControlDeCalidadCliente.Presentacion.Tareas
{
    public class MenuPrincipalTarea : TareaBase
    {
        public override void Iniciar(IVista vistaPadre = null)
        {
            NavegarA<MenuPrincipalPresentador>();
        }
    }
}

using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Vistas;
using Unity;

namespace ControlDeCalidadCliente.Presentacion.IoC
{
    public class Factoria
    {
        private UnityContainer _contenedor;

        private static volatile Factoria _instancia;
        private static readonly object _syncLock = new object();

        private Factoria() 
        {
            _contenedor = new UnityContainer();
            Configurar();
        }

        public static Factoria Instancia
        {
            get
            {
                if(_instancia == null)
                {
                    lock (_syncLock)
                    {
                        _instancia = new Factoria();
                    }
                }
                return _instancia;
            }
        }

        private void Configurar()
        {
            _contenedor.RegisterType<IAutenticacionVista, AutenticacionVista>();
            _contenedor.RegisterType<IMenuPrincipalVista, MenuPrincipalVista>();
            _contenedor.RegisterType<ICrearOpVista, CrearOPVista>();
            _contenedor.RegisterType<IGestionarOpVista, GestionarOpVista>();
            _contenedor.RegisterType<ISemaforoVista, SemaforoVista>();
        }

        public T Crear<T>()
        {
            return _contenedor.Resolve<T>();
        }
    }
}

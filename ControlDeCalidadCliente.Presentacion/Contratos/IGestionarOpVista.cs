using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion.Contratos
{
    public interface IGestionarOpVista : IVista
    {
        void MostrarDatos(string numero, string supervisor, 
            int linea, string modelo, string color, string estado);
        void MostrarBotonReanudar();
        void MostrarBotonPausa();
        void MostrarBotonFinalizar();
        void OcultarBotones();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion.Contratos
{
    public interface ICrearOpVista : IVista
    {
        void PoblarComboBoxLineas();
        void PoblarComboBoxModelos();
        void PoblarComboBoxColores();
    }
}

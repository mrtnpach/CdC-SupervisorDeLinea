using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlDeCalidadCliente.Presentacion.Vistas
{
    public partial class SemaforoVista : SemaforoVistaConPresentador, ISemaforoVista
    {
        public SemaforoVista()
        {
            InitializeComponent();
        }

    }
    public class SemaforoVistaConPresentador : VistaBaseGenerica<SemaforoPresentador> { }
}

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
    public partial class MenuPrincipalVista : MenuPrincipalVistaConPresentador, IMenuPrincipalVista
    {
        public MenuPrincipalVista()
        {
            InitializeComponent();
        }

        private void crearOrdernDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentador.IniciarCreacionDeOp();
        }
    }

    public class MenuPrincipalVistaConPresentador : VistaBaseGenerica<MenuPrincipalPresentador> { }
}


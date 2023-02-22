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

        private void gestionarOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentador.IniciarGestionDeOp();
        }
    }

    public class MenuPrincipalVistaConPresentador : VistaBaseGenerica<MenuPrincipalPresentador> { }
}


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

        private void gestionarOPToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Presentador.IniciarGestionDeOp();
        }

        private void MenuPrincipalVista_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarSesion();
        }

        private void CerrarSesion()
        {
            Presentador.CerrarSesion();
        }
    }

    public class MenuPrincipalVistaConPresentador : VistaBaseGenerica<MenuPrincipalPresentador> { }
}


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
    public partial class AutenticacionVista : AutenticacionVistaConPresentador, IAutenticacionVista
    {
        public AutenticacionVista()
        {
            InitializeComponent();
        }

        private void iniciarSesionButton_Click(object sender, EventArgs e)
        {
            IniciarSesionButtonOnClick();
        }

        private void IniciarSesionButtonOnClick()
        {
            Presentador.AutenticarUsuario(usuarioTextBox.Text, passwordTextBox.Text);
        }

        public void CerrarVentana()
        {
            // Close cierra todo
            Hide();
        }
    }

    public class AutenticacionVistaConPresentador : VistaBaseGenerica<AutenticacionPresentador> { }
}

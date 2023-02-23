using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Presentadores;
using System.Windows.Forms;

namespace ControlDeCalidadCliente.Presentacion.Vistas
{
    public class VistaBase : Form, IVista
    {
        public IPresentador Presentador { get; set; }

        public void Mostrar(IVista vistaPadre)
        {
            if(vistaPadre != null)
                this.MdiParent = vistaPadre as Form;

            Show();
        }

        public void MostrarComoDialogo()
        {
            ShowDialog();
        }

        public void MostrarMensaje(string titulo, string mensaje)
        {
            MessageBox.Show(mensaje, titulo);
        }

        public void Cerrar()
        {
            Close();
        }

        public bool PedirConfirmacion(string titulo, string mensaje)
        {
            DialogResult opcion = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo);
            return opcion == DialogResult.Yes;
        }
    }
}

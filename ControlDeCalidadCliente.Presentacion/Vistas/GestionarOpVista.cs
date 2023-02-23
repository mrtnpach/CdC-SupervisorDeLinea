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
    public partial class GestionarOpVista : GestionarOpVistaConPresentador, IGestionarOpVista
    {
        public GestionarOpVista()
        {
            InitializeComponent();
            OcultarBotones();
        }

        public void OcultarBotones()
        {
            reanudarButton.Visible = false;
            pausarButton.Visible = false;
            finalizarButton.Visible = false;
        }

        public void MostrarBotonFinalizar()
        {
            finalizarButton.Visible = true;
        }

        public void MostrarBotonPausa()
        {
            pausarButton.Visible = true;
        }

        public void MostrarBotonReanudar()
        {
            reanudarButton.Visible = true;
        }

        public void MostrarDatos(string numero, string supervisor, int linea, string modelo, string color, string estado)
        {
            numeroLabel.Text = $"Numero de Orden: {numero}";
            supervisorLabel.Text = $"Supervisor de Linea: {supervisor}";
            lineaLabel.Text = $"Linea de Trabajo: {linea}";
            modeloLabel.Text = $"Modelo: {modelo}";
            colorLabel.Text = $"Color: {color}";
            estadoLabel.Text = $"Estado: {estado}";
        }

        private void reanudarButton_Click(object sender, EventArgs e)
        {
            Presentador.Reanudar();
        }

        private void pausarButton_Click(object sender, EventArgs e)
        {
            Presentador.Pausar();
        }

        private void finalizarButton_Click(object sender, EventArgs e)
        {
            Presentador.Finalizar();
        }
    }

    public class GestionarOpVistaConPresentador : VistaBaseGenerica<GestionarOpPresentador> { }
}

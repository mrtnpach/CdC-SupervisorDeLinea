using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public void ActualizarListas(List<string> topObservado, List<string> topReproceso)
        {
            // Hay problemas de hilos al actualizar los datos
            if (InvokeRequired) 
                BeginInvoke((Action)(() => { MostrarDefectos(topObservado, topReproceso); }));
            else 
                MostrarDefectos(topObservado, topReproceso);        
        }

        public void ActualizarSemaforos(string colorObservado, string colorReproceso)
        {
            if (InvokeRequired)
                BeginInvoke((Action)(() => { MostrarColores(colorObservado, colorReproceso); }));
            else
                MostrarColores(colorObservado, colorReproceso);
        }

        private void MostrarColores(string colorObservado, string colorReproceso)
        {
            CambiarColorObservado(colorObservado);
            CambiarColorReproceso(colorReproceso);
        }

        // Mucho codigo duplicado
        private void CambiarColorReproceso(string colorReproceso)
        {
            switch (colorReproceso)
            {
                case "Verde":
                    semaforoReproceso.BackColor = Color.Green; 
                    break;
                case "Amarillo":
                    semaforoReproceso.BackColor = Color.Yellow;
                    break;
                case "Rojo":
                    semaforoReproceso.BackColor = Color.Red;
                    break;
            }
        }

        private void CambiarColorObservado(string colorObservado)
        {
            switch (colorObservado)
            {
                case "Verde":
                    semaforoObservado.BackColor = Color.Green;
                    break;
                case "Amarillo":
                    semaforoObservado.BackColor = Color.Yellow;
                    break;
                case "Rojo":
                    semaforoObservado.BackColor = Color.Red;
                    break;
            }
        }

        public void MostrarDefectos(List<string> topObservado, List<string> topReproceso)
        {
            observadosListView.Items.Clear();
            reprocesoListView.Items.Clear();
            AgregarDefectosDeObservado(topObservado);
            AgregarDefectosDeReproceso(topReproceso);
            // Actualizar colores
        }

        private void AgregarDefectosDeObservado(List<string> topObservado)
        {
            foreach (string defecto in topObservado)
            {
                observadosListView.Items.Add(defecto);
            }
        }

        private void AgregarDefectosDeReproceso(List<string> topReproceso)
        {
            foreach (string defecto in topReproceso)
            {
                reprocesoListView.Items.Add(defecto);
            }
        }
    }
    public class SemaforoVistaConPresentador : VistaBaseGenerica<SemaforoPresentador> { }
}

using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.Drawing;

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
                    label1.BackColor = Color.Green;
                    break;
                case "Amarillo":
                    label1.BackColor = Color.Yellow;
                    break;
                case "Rojo":
                    label1.BackColor = Color.Red;
                    break;
            }
        }

        private void CambiarColorObservado(string colorObservado)
        {
            switch (colorObservado)
            {
                case "Verde":
                    label1.BackColor = Color.Green;
                    break;
                case "Amarillo":
                    label1.BackColor = Color.Yellow;
                    break;
                case "Rojo":
                    label1.BackColor = Color.Red;
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
                // Hace un push, los deja al reves
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

using ControlDeCalidadCliente.Presentacion.Contratos;
using ControlDeCalidadCliente.Presentacion.Presentadores;
using System;

namespace ControlDeCalidadCliente.Presentacion.Vistas
{
    public partial class CrearOPVista : CrearOPVistaConPresentador, ICrearOpVista
    {
        public CrearOPVista()
        {
            InitializeComponent();
        }

        public void PoblarComboBoxColores()
        {
            coloresComboBox.DataSource = Presentador.Colores;
            coloresComboBox.DisplayMember = "Descripcion";
            coloresComboBox.ValueMember = "Codigo";
        }

        public void PoblarComboBoxLineas()
        {
            lineasComboBox.DataSource = Presentador.Lineas;
            lineasComboBox.DisplayMember = "Numero";
            lineasComboBox.ValueMember = "Numero";
        }

        public void PoblarComboBoxModelos()
        {
            modelosComboBox.DataSource = Presentador.Modelos;
            modelosComboBox.DisplayMember = "Denominacion";
            modelosComboBox.ValueMember = "SKU";
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            string numOP = numOpTextBox.Text;
            // Por ahora queda desprolijo.
            string numLinea = lineasComboBox.SelectedValue.ToString();
            string sku = modelosComboBox.SelectedValue.ToString();
            string codigo = coloresComboBox.SelectedValue.ToString();
            Presentador.CrearOp(numOP, sku, codigo, numLinea);
        }
    }

    public class CrearOPVistaConPresentador : VistaBaseGenerica<CrearOpPresentador> { }
}

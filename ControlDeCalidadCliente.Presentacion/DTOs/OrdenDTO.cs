using System.ComponentModel.DataAnnotations;

namespace ControlDeCalidadCliente.Presentacion.DTOs
{
    public class OrdenDTO
    {
        public OrdenDTO()
        {

        }

        // Hay campos que no se requieren para la creacion
        // pero si para la consulta. Usar distintos DTOs?
        [Required] public string Numero { get; set; }

        // Al no transferir el DTO de color y modelo, se expone la id.
        // Quizas sea mejor solo pasar los campos relevantes de cada uno?
        [Required] public ColorDTO Color { get; set; }
        [Required] public ModeloDTO Modelo { get; set; }

        [Required] public EmpleadoDTO SupervisorDeLinea { get; set; }
        [Required] public LineaDeTrabajoDTO Linea { get; set; }

        [Required] public string Estado { get; set; }

    }
}

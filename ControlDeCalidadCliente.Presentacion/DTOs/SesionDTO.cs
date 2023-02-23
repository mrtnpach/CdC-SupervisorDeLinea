using System.ComponentModel.DataAnnotations;

namespace ControlDeCalidadCliente.Presentacion.DTOs
{
    public class SesionDTO
    {
        public string Token { get; set; }
        public EmpleadoDTO Empleado { get; set;}
    }
}

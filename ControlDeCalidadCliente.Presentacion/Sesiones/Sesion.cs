using ControlDeCalidadCliente.Presentacion.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDeCalidadCliente.Presentacion.Sesiones
{
    internal class Sesion
    {
        private static Sesion _instancia;
        private bool _iniciada = false;

        private Sesion() { }

        public static Sesion Instancia
        {
            get
            {
                if(_instancia == null)
                {
                    _instancia = new Sesion();
                }
                return _instancia;
            }
        }

        // Esto o un EmpleadoDTO
        public string Nombre { get;  private set;}
        public string Apellido { get; private set; }
        public string CorreoElectronico { get; private set;}
        public int DNI { get; private set;}

        public void Iniciar(EmpleadoDTO empleado)
        {
            if(!_iniciada)
            {
                Nombre = empleado.Nombre;
                Apellido = empleado.Apellido;
                CorreoElectronico = empleado.CorreoElectronico;
                DNI = empleado.DNI;
                _iniciada = true;
            }
        }
    }
}

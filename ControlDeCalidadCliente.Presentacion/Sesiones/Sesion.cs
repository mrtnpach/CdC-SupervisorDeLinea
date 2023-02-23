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
        public SesionDTO Datos { get; private set; }

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

        public void Iniciar(SesionDTO datos)
        {
            if(!_iniciada)
            {
                Datos = datos;
            }
        }
    }
}

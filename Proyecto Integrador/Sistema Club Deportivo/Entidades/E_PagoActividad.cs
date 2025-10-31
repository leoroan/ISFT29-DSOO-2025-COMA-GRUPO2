using ClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_PagoActividad
    {
        // Campos privados
        private int idPagoActividad;
        private int carnetTemporal;
        private float precio;
        private bool estado;
        private int nroActividad;

        // Constructor
        public E_PagoActividad(int idPagoActividad, int nroActividad, int carnetTemporal,float precio, bool estado)
        {
            IdPagoActividad = idPagoActividad;
            NroActividad= nroActividad;
            CarnetTemporal = carnetTemporal;
            Precio = precio;
            Estado = estado;
        }

        // Propiedades
        public int IdPagoActividad
        {
            get { return idPagoActividad; }
            set { idPagoActividad = value; }
        }
        public int NroActividad
        {
            get { return nroActividad; }
            set { nroActividad = value; }
        }
        public int CarnetTemporal
        {
            get { return carnetTemporal; }
            set { carnetTemporal = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

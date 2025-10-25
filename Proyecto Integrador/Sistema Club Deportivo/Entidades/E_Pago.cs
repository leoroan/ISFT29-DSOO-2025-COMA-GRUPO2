using ClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_Pago
    {
        public int IdPago { get; set; }
        public int CarnetNumero { get; set; }
        public int TipoPersona { get; set; }
        public float Precio { get; set; }
        public DateTime Fecha { get; set; }
        public int MedioPago { get; set; }
        public E_Actividad? Actividad { get; set; }

    }
}

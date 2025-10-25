using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Entidades
{
    public class E_Pago
    {
        public int Id { get; set; }
        public int IdInscripcion { get; set; }
        public float Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}

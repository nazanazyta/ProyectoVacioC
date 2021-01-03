using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoVacio.Models
{
    public class Hospital
    {
        public int HospitalCod { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public int NumCama { get; set; }
    }
}

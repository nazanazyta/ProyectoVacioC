using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ProyectoVacio.Models;

namespace ProyectoVacio.Data
{
    public class HospitalContext
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public HospitalContext()
        {
            String cadena = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=True";
            
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<Hospital> GetHospitales()
        {
            
            List<Hospital> hospitales = new List<Hospital>();

        }
    }
}

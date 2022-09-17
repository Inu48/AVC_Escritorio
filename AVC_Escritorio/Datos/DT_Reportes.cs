using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVC_Escritorio.Models;

namespace AVC_Escritorio.Datos
{
    internal class DT_Reportes
    {
        public List<V_Usuarios> Vista_Usuarios()
        {
            List<V_Usuarios> objLista = new List<V_Usuarios>();

            using (SqlConnection oconexcion = new SqlConnection("Server=(localdb)\\MSSQLLocalDB; Integrated Security=SSPI;Database=AVC_DB"))
            {
                string query = "select * from V_Usuarios";
                SqlCommand cmd = new SqlCommand(query, oconexcion);

                oconexcion.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objLista.Add(new V_Usuarios()
                        {
                            ID = int.Parse(dr["ID"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Rol = dr["Rol"].ToString(),
                            Correo = dr["Correo"].ToString()
                        });
                    }
                }
            }

            return objLista;
        }

        public List<V_Productos> Vista_Productos()
        {
            List<V_Productos> objLista = new List<V_Productos>();

            using (SqlConnection oconexcion = new SqlConnection("Server=(localdb)\\MSSQLLocalDB; Integrated Security=SSPI;Database=AVC_DB"))
            {
                string query = "select * from V_Productos";
                SqlCommand cmd = new SqlCommand(query, oconexcion);

                oconexcion.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objLista.Add(new V_Productos()
                        {
                            ID = int.Parse(dr["ID"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Clave = dr["Clave"].ToString(),
                            Cantidad = int.Parse(dr["Cantidad"].ToString())
                        });
                    }
                }
            }

            return objLista;
        }

    }
}

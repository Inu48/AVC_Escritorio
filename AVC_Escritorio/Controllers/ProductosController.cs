using AVC_Escritorio.Datos;
using AVC_Escritorio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVC_Escritorio.Controllers
{
    internal class ProductosController
    {
        DT_Reportes dT_Reportes = new DT_Reportes();

        public List<V_Productos> ConsultarProductos()
        {
            List<V_Productos> productos = dT_Reportes.Vista_Productos();
            return productos;

        }

        public void AgregarProducto(Productos producto)
        {
            using (AVC_DBEntities db = new AVC_DBEntities())
            {
                db.Productos.Add(producto);
                db.SaveChanges();
            }
        }

        public void AgregarExistencias(Productos productos, int? existencias)
        {
            using (AVC_DBEntities db = new AVC_DBEntities())
            {
                existencias += productos.Cantidad;
                productos.Cantidad = existencias;
                db.Entry(productos).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}

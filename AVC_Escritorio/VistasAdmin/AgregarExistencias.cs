using AVC_Escritorio.Controllers;
using AVC_Escritorio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVC_Escritorio.VistasAdmin
{
    public partial class AgregarExistencias : Form
    {
        ProductosController pc = new ProductosController();

        private Productos productos;

        public AgregarExistencias()
        {
            InitializeComponent();
        }
        public AgregarExistencias(int id)
        {
            InitializeComponent();
            BuscarProducto(id);
        }

        private void btnNuevasExistencias_Click(object sender, EventArgs e)
        {

            int existencias = int.Parse(txtCantidadNueva.Value.ToString());
            NuevasExistencias(existencias);
            this.Close();
        }
        private void BuscarProducto(int id)
        {
            using (AVC_DBEntities db = new AVC_DBEntities())
            {
                 productos = db.Productos.Where(p => p.ProductoId == id).FirstOrDefault();
                lbNombreProducto.Text = productos.Nombre;
                lbCantidadProducto.Text = "Cantidad disponible: " + productos.Cantidad; 
            }
            
        }
        private void NuevasExistencias(int? existencias)
        {
            pc.AgregarExistencias(productos,existencias);
        }
    }
}

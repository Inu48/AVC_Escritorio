using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVC_Escritorio.Datos;
using AVC_Escritorio.Models;
using AVC_Escritorio.Controllers;
using System.ComponentModel.DataAnnotations;
using AVC_Escritorio.VistasAdmin;

namespace AVC_Escritorio
{
    public partial class AVCMain : Form
    {
        UsuariosController uc = new UsuariosController();
        ProductosController pc = new ProductosController();

        public AVCMain()
        {
            InitializeComponent();
            
        }


        private void AVCMain_Load(object sender, EventArgs e)
        {
            CargarListaRoles();
            ConsultarUsuarios();
            ConsultarProductos();

        }
        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
            GuardarUsuario();
        }
        private void btnCancelarUser_Click(object sender, EventArgs e)
        {
            LimpiarFormularioUsuario();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            LimpiarFormularioProducto();
        }

        private void tblProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            if (tblProductos.Columns[e.ColumnIndex].Name == "AgregarExistencias")
            {
                id = int.Parse(tblProductos.CurrentRow.Cells["ID"].Value.ToString());
                AgregarExistencias ae = new AgregarExistencias(id);
                ae.ShowDialog();
                ConsultarProductos();
            }
        }

        #region HELPER
        private void ConsultarUsuarios()
        {
            List<V_Usuarios> usuarios = uc.ConsultarUsuarios();
            tblUsuarios.DataSource = usuarios;
        }

        private void ConsultarProductos()
        {
            List<V_Productos> productos = pc.ConsultarProductos();
            tblProductos.DataSource = productos;
            tblProductos.Columns["ID"].DisplayIndex = 0;
            tblProductos.Columns["Nombre"].DisplayIndex = 1;
            tblProductos.Columns["Clave"].DisplayIndex = 2;
            tblProductos.Columns["Cantidad"].DisplayIndex = 3;
            tblProductos.Columns["AgregarExistencias"].DisplayIndex = 4;
        }

        private void CargarListaRoles()
        {
            List <Roles> roles = uc.CargarRolesUsuario();
            cbRolesUser.DataSource = roles;
            cbRolesUser.ValueMember = "RolId";
            cbRolesUser.DisplayMember = "Nombre";
            
        }

        private void LimpiarFormularioUsuario()
        {
            txtNombreUser.Text = "";
            txtEmailUser.Text = "";
            txtPasswordUser.Text = "";
        }
        private void LimpiarFormularioProducto()
        {
            txtNombreProducto.Text = "";
            txtClaveProducto.Text = "";
        }

        private void GuardarProducto()
        {


            if (txtNombreProducto.Text == "" || txtNombreProducto.Text == " ")
            {
                MessageBox.Show("El campo Nombre esta vacio, favor de llenarlo");
            }
            else if (txtClaveProducto.Text == "" || txtClaveProducto.Text == " ")
            {
                MessageBox.Show("El campo Clave esta vacio, favor de llenarlo.");
            }
            else
            {
                Productos productos = new Productos();
                productos.Nombre = txtNombreProducto.Text;
                productos.ClaveProducto = txtClaveProducto.Text;
                productos.Cantidad = int.Parse(txtCantidad.Value.ToString());

                pc.AgregarProducto(productos);
                LimpiarFormularioProducto();
                ConsultarProductos();
            }
        }

        private void GuardarUsuario()
        {

            
            if (txtNombreUser.Text == "" || txtNombreUser.Text == " ")
            {
                MessageBox.Show("El campo Nombre esta vacio, favor de llenarlo");
            }
            else if (txtEmailUser.Text == "" || txtEmailUser.Text == " ")
            {
                MessageBox.Show("El campo E-Mail esta vacio, favor de llenarlo.");
            }
            else if (txtPasswordUser.Text == "" || txtPasswordUser.Text == " ")
            {
                MessageBox.Show("El campo Password esta vacio, favor de llenarlo.");
            }
            else if (!ValidarCorreo(txtEmailUser.Text))
            {
                MessageBox.Show("Coloca un correo electronico valido.");
                
            }
            else
            {
                Usuarios usuario = new Usuarios();
                Roles rol = cbRolesUser.SelectedItem as Roles;
                string sPass = Encrypt.GetSHA256(txtPasswordUser.Text.Trim());


                usuario.Nombre = txtNombreUser.Text;
                usuario.RolId = rol.RolId;
                usuario.Email = txtEmailUser.Text;
                usuario.Password = sPass;

                uc.AgregarUsuario(usuario);
                LimpiarFormularioUsuario();
                ConsultarUsuarios();
            }
        }

        public bool ValidarCorreo(string email)
        {
            if (email == null)
            {
                return false;
            }
            if (new EmailAddressAttribute().IsValid(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion

        private void tblProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        
    }
}

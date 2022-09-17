using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVC_Escritorio.Datos;
using AVC_Escritorio.Models;

namespace AVC_Escritorio.Controllers
{
    internal class UsuariosController
    {
        DT_Reportes dT_Reportes = new DT_Reportes();

        public List<V_Usuarios> ConsultarUsuarios()
        {
            List<V_Usuarios> usuarios = dT_Reportes.Vista_Usuarios();
            return usuarios;

        }
        public List<Roles> CargarRolesUsuario()
        {
            using (AVC_DBEntities db = new AVC_DBEntities())
            {
                List<Roles> roles = new List<Roles>();
                return roles = db.Roles.ToList();
            }
        }
        public void AgregarUsuario(Usuarios usuario)
        {
            using (AVC_DBEntities db = new AVC_DBEntities())
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
            }
        }
    }
}

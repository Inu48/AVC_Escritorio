using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVC_Escritorio.Models;

namespace AVC_Escritorio
{
    public partial class Login : Form
    {
        public static string userName;
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtCorreo.Text;
            string sPass = Encrypt.GetSHA256(txtPassword.Text.Trim());


            using (AVC_DBEntities db = new AVC_DBEntities())
            {
                Usuarios usuario = db.Usuarios.Where(u => u.Email == email && u.Password == sPass).FirstOrDefault();

                if (usuario != null)
                {
                    if (usuario.RolId == 1)
                    {
                        userName = usuario.Nombre;
                        this.Hide();
                        AVCMain frm = new AVCMain();
                        frm.FormClosed += (s, args) => this.Close();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Este usuario no es Adminstrador, intente con otra cuenta.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado, intente de nuevo.");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

using proyectoBase.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoBase
{
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario (txtbNombreDeUsuario.Text, txtbContraseña.Text);
            //  MessageBox.Show("Bienvenido " +usu.NombreDeUsuario);
            //string usuarioCorrecto = "Santiago";
            // string contraseñaCorrecta = "2003caisanti";
            if (txtbNombreDeUsuario.Text.Equals(usuarioCorrecto) && txtbContraseña.Text.Equals(contraseñaCorrecta))
            {
                // Nombre y Contraseña correctos
                Principal ventana = new Principal(usu);
                ventana.Show();
                this.Hide();
            }
            else
            {
                // Nombre y Contraseña incorrectos
                MessageBox.Show("El usuario y/o la contraseña no son válidos.");
            }
        }

        private void txtbContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbNombreDeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginUser_Load(object sender, EventArgs e)
        {

        }
    }
}

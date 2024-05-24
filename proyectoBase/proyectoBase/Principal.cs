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
    public partial class Principal : Form
    {
        public Principal(Usuario usu )
        {
            InitializeComponent();
            lblBienvenida.Text = "Bienvenido/a " + usu.NombreDeUsuario;
            lblBienvenida.Visible = true;

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void altaPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaPersona ventana = new AltaPersona();
            ventana.Show();
        }
    }
}

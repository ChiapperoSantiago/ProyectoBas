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
    public partial class AltaPersona : Form
    {
        public AltaPersona()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoDeDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AltaPersona_Load(object sender, EventArgs e)
        {
            limpiarCampos();
            txtbCantidadHijos.Enabled = false;
            cbCarrera.Items.Add("Ing. en Sistemas");
            cbCarrera.Items.Add("Ing. Industrial");
            cbCarrera.Items.Add("Ing. Civil");
            cbCarrera.Items.Add("Ing. Química");
            cbCarrera.Items.Add("Ing. Electrónica");
            cbCarrera.Items.Add("Ing. Eléctrica");
            cbCarrera.Items.Add("Ing. Mecánica");

            cbTipoDeDocumento.Items.Add("DNI");
            cbTipoDeDocumento.Items.Add("Pasaporte");
            cbTipoDeDocumento.Items.Add("Libreta univeristaria");
            cbTipoDeDocumento.Items.Add("Tarjeta de residencia");
        }

        private void btnRegistrarPersona_Click(object sender, EventArgs e)
        {
            string datosPersona = "";

            string nombre = txtbName.Text;
            string apellido = txtbApellido.Text;
            string fechaNacimiento = txtbFechaNacimiento.Text;
            string sexo = "";
            if (rdioMasculino.Checked)
            {
                sexo = "Masculino";
            }
            if (rdioFemenino.Checked)
            {
                sexo = "Femenino";
            }
            if (rdOtro.Checked)
            {
                sexo = "Otro";
            }

            string TipoDocumento = cbTipoDeDocumento.GetItemText(cbTipoDeDocumento.SelectedItem);
            string nroDocumento = txtbNdoc.Text;
            string calle = txtbCalle.Text;
            string nroCasa = txtbNroCasa.Text;
            string soltero = "";
            string casado = "";
            string conHijos = "";
            string cantidadHijos = "";

            if (chkSoltero.Checked)
            {
                soltero = "Soltero";
            }
            if (chkCasado.Checked)
            {
                casado = "Casado";
            }
            if (chkHijos.Checked)
            {
                conHijos = "Con Hijos";
                cantidadHijos = txtbCantidadHijos.Text;
            }
            string carrera = cbCarrera.GetItemText(cbCarrera.SelectedItem);

            bool tieneApellido = false;
            bool tieneNombre = false;
            bool tieneDocumento = false;
            bool existeEnLaGrilla = false;


            if (txtbName.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre, por favor");
                txtbName.Focus();
            }
            else tieneNombre = true;
            if (txtbApellido.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un Apellido, por favor");
                txtbApellido.Focus();
            }
            else tieneApellido = true;

            if (txtbNdoc.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un número de documento, por favor");
                txtbNdoc.Focus();
            }
            else tieneDocumento = true;

            existeEnLaGrilla = existeEnGrilla(nroDocumento);
            if (existeEnLaGrilla == true)
            {
                MessageBox.Show("Este documento ya se encuentra registrado. Por favor ingrese nuevamente");
            }
            if (tieneNombre == true && tieneApellido == true && tieneDocumento == true && existeEnLaGrilla == false)
            {
                Persona per = new Persona(nombre, apellido, nroDocumento);
                AgregarPersona(per);
            }
            
            
        }
        private void AgregarPersona(Persona per)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaDocumento = new DataGridViewTextBoxCell();
            celdaDocumento.Value = per.DocumentoDePersona;
            fila.Cells.Add(celdaDocumento);

            DataGridViewTextBoxCell celdaApellido = new DataGridViewTextBoxCell();
            celdaApellido.Value = per.ApellidoDePersona;
            fila.Cells.Add(celdaApellido);

            DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
            celdaNombre.Value = per.NombreDePersona;
            fila.Cells.Add(celdaNombre);

            gdrPersona.Rows.Add(fila);
            limpiarCampos();
            txtbName.Focus();

        }
        private void chkHijos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHijos.Checked)
            {
                txtbCantidadHijos.Enabled = true;
            }
            else
            {
                txtbCantidadHijos.Enabled = false;
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtbName.Text = "";
            txtbApellido.Text = "";
            txtbFechaNacimiento.Text = "";
            rdioMasculino.Checked = true;
            txtbNdoc.Text = "";
            txtbCalle.Text = "";
            txtbNroCasa.Text = "";
            chkSoltero.Checked = false;  
            chkCasado.Checked = false;
            chkHijos.Checked = false;   

            
        }

        private bool existeEnGrilla(string criterioABuscar)
        {
            bool resultado = false;
            for (int i = 0; i < gdrPersona.Rows.Count; i++)
            {
                if (gdrPersona.Rows[i].Cells["Documento"].Value.Equals((criterioABuscar)))
                {
                    resultado = true;
                    break;

                }
            }
            return resultado;
        }
    }
}

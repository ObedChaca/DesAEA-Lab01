using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesAEA_Lab01_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtCodigo.Text);
            string nom = txtNombre.Text;
            string dni = txtDni.Text;
            string ape = txtApellido.Text;
            string dir = txtDireccion.Text;
            string tel = txtTelefono.Text;
            string ema = txtEmail.Text;
            string fec = txtFecha.Text;
            string dep = cboDepartamento.Text;
            string car = cboCargo.Text;

            dgvUsuarios.Rows.Add(cod, dni, nom, ape, dir, tel, ema, fec, dep);
            txtNombre.Text = "";
            txtDni.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtFecha.Text = "";
            cboDepartamento.Text = "Seleccionar";
            cboCargo.Text = "Seleccionar";
            txtCodigo.Text = Convert.ToString(cod + 1);
        }
    }
}

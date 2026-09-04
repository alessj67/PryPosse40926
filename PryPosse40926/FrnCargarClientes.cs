using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPosse40926
{
    public partial class FrnCargarClientes : Form
    {
        public FrnCargarClientes()
        {
            InitializeComponent();
        }
        clsArchivoClientes ArchC = new clsArchivoClientes();

        //void ControlCajas()
        //{
        //    if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDeuda.Text != "" && txtLimite.Text != "")
        //    {
        //        btnCargar.Enabled = true;
        //    }
        //    else
        //    { 
        //        btnCargar.Enabled = false;
        //    }
        //}
        private void btnCargar_Click(object sender, EventArgs e)
        {
            ArchC.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text, txtLimite.Text);
            MessageBox.Show("joya");
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDeuda.Text = "";
            txtLimite.Text = "";
        }

        private void FrnCargarClientes_Load(object sender, EventArgs e)
        {
            //btnCargar.Enabled = false;
        }
    }
}

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
    public partial class FrmDeudores : Form
    {
        public FrmDeudores()
        {
            InitializeComponent();
        }
        clsArchivoClientes x = new clsArchivoClientes();
        private void btnListar_Click(object sender, EventArgs e)
        {
            x.ListarDeudores(dgvGrilla);
            lblTotalD.Text = x.Tdeuda().ToString();
            lblCant.Text = x.CantidadDeudores().ToString();
            lblPromD.Text = x.PromedioDeudores().ToString();
        }
    }
}

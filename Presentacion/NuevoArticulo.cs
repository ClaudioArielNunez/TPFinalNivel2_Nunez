using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class NuevoArticulo : Form
    {
        public NuevoArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo artNuevo = new Articulo();
            
            try
            {
                artNuevo.Codigo = txtCodigo.Text;
                artNuevo.
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class NuevaCategoria : Form
    {
        List<Categoria> listaCategorias = new List<Categoria>();
        public NuevaCategoria()
        {
            InitializeComponent();
        }

        private void NuevaCategoria_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }
        private void cargarCategorias()
        {
            try
            {
                NegocioCategoria categorias = new NegocioCategoria();
                listaCategorias = categorias.listar();
                dgvCategorias.DataSource = listaCategorias;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}

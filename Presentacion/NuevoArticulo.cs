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
            NegocioArticulo negocio = new NegocioArticulo();
            try
            {
                artNuevo.Codigo = txtCodigo.Text;
                artNuevo.Nombre = txtNombre.Text;
                artNuevo.Descripcion = txtDescr.Text;
                artNuevo.Precio = decimal.Parse(txtPrecio.Text);
                artNuevo.Marca = (Marca)cmbMarca.SelectedItem;
                artNuevo.Categoria = (Categoria)cmbCateg.SelectedItem;
                artNuevo.ImagenUrl = txtUrlimg.Text;

                negocio.agregar(artNuevo);
                MessageBox.Show("Agregado con exito");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void NuevoArticulo_Load(object sender, EventArgs e)
        {
            NegocioMarca marca = new NegocioMarca();
            NegocioCategoria cat = new NegocioCategoria();
            
            try
            {
                cmbMarca.DataSource = marca.listar();
                cmbMarca.ValueMember = "Id";
                cmbMarca.DisplayMember = "Descripcion"; 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
            
            try
            {                 
                cmbCateg.DataSource = cat.listar();
                cmbCateg.ValueMember = "Id";
                cmbCateg.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error "+ ex.ToString());                
            }
        }
    }
}

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
        private Articulo articulo = null;
        public NuevoArticulo()
        {
            InitializeComponent();
        }
        public NuevoArticulo(Articulo artxModificar)
        {
            InitializeComponent();
            this.articulo = artxModificar;
            Text = "Modificar Artículo";
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            NegocioArticulo negocio = new NegocioArticulo();
            try
            {
                if(articulo == null)
                {
                    articulo = new Articulo();
                }

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescr.Text;
                articulo.Precio = Convert.ToDecimal(txtPrecio.Text);//
                articulo.Marca = (Marca)cmbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cmbCateg.SelectedItem;
                articulo.ImagenUrl = txtUrlimg.Text;

                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado con exito!");
                }
                else
                {//si el producto no existe => Agregar //probar if(articulo.Id == 0 && existe)
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado con exito");
                }
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
                    cmbMarca.ValueMember = "Id1";
                    cmbMarca.DisplayMember = "Descripcion1";

                    cmbCateg.DataSource = cat.listar();
                    cmbCateg.ValueMember = "Id1";
                    cmbCateg.DisplayMember = "Descripcion1";

                    
                    if (articulo != null)
                    {
                        txtCodigo.Text = articulo.Codigo;
                        txtNombre.Text = articulo.Nombre;
                        txtDescr.Text = articulo.Descripcion;
                        txtPrecio.Text = articulo.Precio.ToString("0.00");
                        cmbMarca.SelectedValue = articulo.Marca.Id1;
                        cmbCateg.SelectedValue = articulo.Categoria.Id1;
                        cargarImagen(articulo.ImagenUrl);
                        txtUrlimg.Text = articulo.ImagenUrl;
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.ToString());
                }                                     
        }

        private void txtUrlimg_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlimg.Text);
        }
        private void cargarImagen(string img)
        {
            try
            {
                pbxArticulo.Load(img);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://trolleymate.co.uk/assets/img/error_404.jpeg");

            }
        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openArchivo = new OpenFileDialog();
            openArchivo.Filter = "jpg|*jpg;|png|*.png";
            if(openArchivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlimg.Text = openArchivo.FileName;
                cargarImagen(txtUrlimg.Text);
            }
        }
    }
}

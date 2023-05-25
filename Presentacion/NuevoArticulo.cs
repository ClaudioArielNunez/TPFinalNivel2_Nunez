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
using static System.Net.Mime.MediaTypeNames;

namespace Presentacion
{
    public partial class NuevoArticulo : Form
    {
        private List<Articulo> listaArticulos;//------

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
            NegocioArticulo nuevaLista = new NegocioArticulo();
            
            NegocioArticulo negocio = new NegocioArticulo();
            try
            {
                listaArticulos = nuevaLista.listar();

                if(articulo == null)
                {
                    articulo = new Articulo();
                }

                if (validarCamposObligatorios())
                {
                    return;
                }
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescr.Text;             
                
                articulo.Precio = Convert.ToDecimal(txtPrecio.Text);       //         
                articulo.Marca = (Marca)cmbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cmbCateg.SelectedItem;
                articulo.ImagenUrl = txtUrlimg.Text;
                

                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado con exito!");
                }
                else
                {
                    bool existe = negocio.chequearSiExiste(listaArticulos, articulo);
                    if (!existe)
                    {
                        negocio.agregar(articulo);
                        MessageBox.Show("Agregado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Este producto ya existe en la lista");
                    }
                    
                    
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
                        txtPrecio.Text = Convert.ToString(articulo.Precio);//ToString("0.00")
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

        //-------------------------
        private bool validarNumeros(string cadenaNum)
        {
            foreach (char num in cadenaNum)
            {
                if (char.IsLetter(num) || num == '.') //Así me acepta los decimales con coma
                {
                    return true;
                }
            }
            return false;

        }
        public bool validarCamposObligatorios()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Digite el código");
                return true;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Escriba el nombre del producto");
                return true;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Ingrese el precio del producto");
                return true;
            }
            if (validarNumeros(txtPrecio.Text))
            {
                MessageBox.Show("Solo números y en caso de usar decimales,utilizar coma (,) por favor");
                return true;
            }            

            return false;
        }               
               
                                
    }

}

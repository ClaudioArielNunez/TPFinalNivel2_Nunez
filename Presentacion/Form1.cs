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
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();            
            cmbCampo.Items.Add("Código");
            cmbCampo.Items.Add("Nombre");
            cmbCampo.Items.Add("Descripción");
            cmbCampo.Items.Add("Precio");
                     
        }
        private void columnaDecimales()
        {
            dgvListaArt.Columns["Precio"].DefaultCellStyle.Format = "0.00";
        }
        private void ocultarColumnas()
        {
            dgvListaArt.Columns["id"].Visible = false;
            dgvListaArt.Columns["imagenUrl"].Visible = false;
        }
        private void cargar()
        {
            try
            {
                NegocioArticulo negocio = new NegocioArticulo();

                listaArticulos = negocio.listar();
                dgvListaArt.DataSource = listaArticulos;                
                ocultarColumnas();                
                cargarImagen(listaArticulos[0].ImagenUrl);
                columnaDecimales();   
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error "+ ex.ToString());
            }
        }

        private void dgvListaArt_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListaArt.CurrentRow != null)
            {
                Articulo select = (Articulo)dgvListaArt.CurrentRow.DataBoundItem;                
                cargarImagen(select.ImagenUrl);                
                cargarDatos(select);
            }
        }
        //--------------------CARGAR LABELS
        private void cargarDatos(Articulo art)
        {
            lblNombreSelec.Text = "Nombre: "+art.Nombre;            
            lblDescSelec.Text = "Descripción: "+art.Descripcion;            
            lblMarcaSelec.Text = "Marca: "+art.Marca;
            lblPrecioSelec.Text = "Precio: "+art.Precio.ToString("0.00");            
        }

        //--------------------

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoArticulo nuevoArticulo = new NuevoArticulo();
            nuevoArticulo.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo select;
            select = (Articulo)dgvListaArt.CurrentRow.DataBoundItem;
            NuevoArticulo modificar = new NuevoArticulo(select);
            modificar.ShowDialog();
            cargar();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NegocioArticulo negocio = new NegocioArticulo();
            Articulo select;
            try
            {
                DialogResult consulta = MessageBox.Show("Eliminas este producto?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (consulta == DialogResult.Yes)
                {
                    select = (Articulo)dgvListaArt.CurrentRow.DataBoundItem;
                    negocio.eliminar(select.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.ToString());
            }

        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltro;
            string filtro = txtFiltroRapido.Text;
                        

            if(filtro.Length >= 3)
            {
                listaFiltro = listaArticulos.FindAll(x => x.Marca.Descripcion1.ToUpper().Contains(txtFiltroRapido.Text.ToUpper())
                                                       || x.Categoria.Descripcion1.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()));

            }
            else
            {
                listaFiltro = listaArticulos;
            }

            dgvListaArt.DataSource = null;
            dgvListaArt.DataSource = listaFiltro;
            ocultarColumnas();
        }
        

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string eleccion = cmbCampo.SelectedItem.ToString();

            if (eleccion == "Precio")
            {
                cmbCriterio.Items.Clear();
                txtFiltroAvanz.Text = "";
                cmbCriterio.Items.Add("Mayor a ");
                cmbCriterio.Items.Add("Menor a ");
                cmbCriterio.Items.Add("Igual a ");
                cargar();
            }
            else
            {
                cmbCriterio.Items.Clear();
                txtFiltroAvanz.Text = "";
                cmbCriterio.Items.Add("Comienza con ");
                cmbCriterio.Items.Add("Termina con ");
                cmbCriterio.Items.Add("Contiene ");
                cargar();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            NegocioArticulo negocio = new NegocioArticulo();
            
            try
            {
                if (validarFiltro())
                {
                    return;
                }

                string campo = cmbCampo.SelectedItem.ToString();
                string criterio = cmbCriterio.SelectedItem.ToString();
                string filtroAv = txtFiltroAvanz.Text;

                dgvListaArt.DataSource = negocio.filtrarLista(campo, criterio, filtroAv);
                //columnaDecimales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void btnAgMarca_Click(object sender, EventArgs e)
        {
            NuevaMarca nuevaMarca = new NuevaMarca();
            nuevaMarca.ShowDialog();

        }

        private void btnAgCat_Click(object sender, EventArgs e)
        {
            NuevaCategoria nuevaCategoria = new NuevaCategoria();
            nuevaCategoria.ShowDialog();
        }

        
        //Validaciones
        private bool validarFiltro()
        {
            if(cmbCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Debe ingresar un campo");
                return true;
            }
            if (cmbCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Debe ingresar un criterio");
                return true;
            }
            if (cmbCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanz.Text))
                {
                    MessageBox.Show("Debe ingresar un precio");
                    return true;
                }
                if (validarNumeros(txtFiltroAvanz.Text))
                {
                    MessageBox.Show("Sólo puedes ingresar números y el caracter usado para decimales es '.' (punto)");
                    return true;
                }
            }
            return false;
        }
        private bool validarNumeros(string cadenaNum)
        {
            foreach (char num in cadenaNum)
            {
                if (char.IsLetter(num) || (num == ','))
                {
                    return true;
                }
            }
            return false;
        }

        
    }
}

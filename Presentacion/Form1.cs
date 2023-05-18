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
                //pbxArticulo.Load(listaArticulos[0].ImagenUrl);
                ocultarColumnas();
                //dgvListaArt.Columns["id"].Visible = false;
                //dgvListaArt.Columns["imagenUrl"].Visible = false;
                cargarImagen(listaArticulos[0].ImagenUrl);

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
            }
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
                listaFiltro = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()));
            }
            else
            {
                listaFiltro = listaArticulos;
            }

            dgvListaArt.DataSource = null;
            dgvListaArt.DataSource = listaFiltro;
            ocultarColumnas();
        }
    }
}

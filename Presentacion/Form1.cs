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
        private void cargar()
        {
            try
            {
                NegocioArticulo negocio = new NegocioArticulo();

                listaArticulos = negocio.listar();
                dgvListaArt.DataSource = listaArticulos;
                //pbxArticulo.Load(listaArticulos[0].ImagenUrl);
                dgvListaArt.Columns["id"].Visible = false;
                dgvListaArt.Columns["imagenUrl"].Visible = false;
                cargarImagen(listaArticulos[0].ImagenUrl);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error "+ ex.ToString());
            }
        }

        private void dgvListaArt_SelectionChanged(object sender, EventArgs e)
        {
            
            Articulo select = (Articulo)dgvListaArt.CurrentRow.DataBoundItem;
            //pbxArticulo.Load(select.ImagenUrl);
            cargarImagen(select.ImagenUrl);
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
    }
}

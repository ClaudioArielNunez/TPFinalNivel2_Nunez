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
            try
            {
                NegocioArticulo negocio = new NegocioArticulo();
                listaArticulos = negocio.listar();
                dgvListaArt.DataSource = listaArticulos;
                //pbxArticulo.Load(listaArticulos[0].ImagenUrl);
                cargarImagen(listaArticulos[0].ImagenUrl);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
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
                //pbxArticulo.Load("https://www.qonexalifecare.com/wp-content/themes/twentythirteen/images/no.jpg");

            }
        }
    }
}

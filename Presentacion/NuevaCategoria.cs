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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            NegocioCategoria negocio = new NegocioCategoria();

            try
            {
                if(negocio.validarCampos(txtCateg.Text))
                {
                    MessageBox.Show("Debe ingresar una categoría");
                    return;
                }
                if (negocio.validarLetras(txtCateg.Text))
                {
                    MessageBox.Show("Ingrese letras, por favor");
                    txtCateg.Text = "";
                    return;
                }
                categoria.Descripcion1 = txtCateg.Text;
                bool existe = negocio.chequear(listaCategorias, categoria.Descripcion1);
                if (!existe)
                {
                    negocio.agregarCat(categoria);
                    MessageBox.Show("Categoría agregada con exito");
                    cargarCategorias();
                }
                else
                {
                    MessageBox.Show("La categoría ya existe"); ;
                }
                txtCateg.Text = "";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            NegocioCategoria negocio = new NegocioCategoria();
            Categoria categPorBorrar;
            try
            {
                DialogResult consulta = MessageBox.Show("Eliminas esta categoría?","Eliminando",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(consulta == DialogResult.OK)
                {
                    categPorBorrar = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    negocio.eliminarCat(categPorBorrar);
                    cargarCategorias();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

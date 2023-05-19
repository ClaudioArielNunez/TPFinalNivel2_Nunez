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
    public partial class NuevaMarca : Form
    {
        List<Marca> listaMarcas = new List<Marca>();    
        public NuevaMarca()
        {
            InitializeComponent();
        }

        private void NuevaMarca_Load(object sender, EventArgs e)
        {
            cargarMarcas();
        }

        private void cargarMarcas()
        {
            try
            {
                NegocioMarca marcas = new NegocioMarca();

                listaMarcas = marcas.listar();
                dgvMarcas.DataSource = listaMarcas;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void btnAgregarNew_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            NegocioMarca negocio = new NegocioMarca();
               
            try
            {          
                marca.Descripcion1 = txtMarcAgr.Text;                            
                
                bool existe = negocio.chequear(listaMarcas,marca.Descripcion1);
                if (!existe)
                {
                    negocio.agregarMarca(marca);
                    MessageBox.Show("Marca agregada con exito");
                    cargarMarcas();
                }
                else
                {
                    MessageBox.Show("La marca ya existe");
                }
                
                txtMarcAgr.Text = "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NegocioMarca negocio = new NegocioMarca();
            Marca marcaAborrar;

            try
            {
                DialogResult consulta = MessageBox.Show("Eliminas esta marca?","Eliminando", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if(consulta == DialogResult.OK)
                {
                    marcaAborrar = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminarMarca(marcaAborrar);
                    cargarMarcas();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

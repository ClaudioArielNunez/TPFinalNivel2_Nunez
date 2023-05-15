using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NegocioMarca
    {
        public List<Marca> listar()
        {
            List<Marca> listaMarcas = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from MARCAS");
                datos.leerTabla();

                while (datos.Lector.Read())
                {
                    Marca art = new Marca();
                    art.Id1 = (int)datos.Lector["Id"];
                    art.Descripcion1 = (string)datos.Lector["Descripcion"];
                    listaMarcas.Add(art);
                }
                return listaMarcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrar();
            }

        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Net;

namespace Negocio
{
    public class NegocioCategoria
    {
        public List<Categoria> listar()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                datos.leerTabla();

                while (datos.Lector.Read())
                {
                    Categoria art = new Categoria();
                    art.Id1 = (int)datos.Lector["Id"];
                    art.Descripcion1 = (string)datos.Lector["Descripcion"];
                    listaCategorias.Add(art);
                    
                }
                return listaCategorias;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using Datos;

namespace Negocio
{
    public class NegocioArticulo
    {       

        public List<Articulo> listar()
        {
            List<Articulo> listaArticulos = new List<Articulo>();        
                        
            AccesoDatos datos = new AccesoDatos();         

            try
            {
                datos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion,ImagenUrl,M.Descripcion as Marca,C.Descripcion as Categoria, Precio FROM ARTICULOS A , MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id");
                datos.leerTabla();

                while (datos.Lector.Read()) 
                {
                    Articulo aux = new Articulo();
                    aux.Categoria = new Categoria();
                    aux.Marca = new Marca();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Marca.Descripcion1 = (string)datos.Lector["Marca"];
                    aux.Categoria.Descripcion1 = (string)datos.Lector["Categoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    listaArticulos.Add(aux);
                }
                return listaArticulos;
               
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

        public void agregar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio, ImagenUrl, IdMarca, IdCategoria) values('"+ art.Codigo+"','"+art.Nombre+"','"+art.Descripcion+"',"+art.Precio+",@ImagenUrl, @IdMarca, @IdCategoria)");
                datos.setearParametros("@ImagenUrl", art.ImagenUrl);
                datos.setearParametros("@IdMarca", art.Marca.Id1);
                datos.setearParametros("@IdCategoria", art.Categoria.Id1);

                datos.ejecutarAccion();
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

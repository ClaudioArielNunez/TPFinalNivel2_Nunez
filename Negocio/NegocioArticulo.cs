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
            
            SqlDataReader lector;
            //SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            
            //instanciamos clase Datos
            AccesoDatos conectar = new AccesoDatos();  
            

            try
            {
                //conexion.ConnectionString = "server =.\\SQLEXPRESS; database = CATALOGO_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;//comando de SQL de tipo texto
                comando.CommandText = "SELECT A.Id, Codigo, Nombre, A.Descripcion,ImagenUrl,M.Descripcion as Marca,C.Descripcion as Categoria, Precio FROM ARTICULOS A , MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id"; //establece instruccion de SQL
                //comando.Connection = conexion;
                comando.Connection = conectar.abrir();

                //conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {                    
                    Articulo aux = new Articulo();
                    aux.Categoria = new Categoria();
                    aux.Marca = new Marca(); 
                    aux.Id = (int)lector["id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.ImagenUrl = (string)lector["ImagenUrl"];
                    aux.Marca.Descripcion1 = (string)lector["Marca"];
                    aux.Categoria.Descripcion1 = (string)lector["Categoria"];
                    aux.Precio = (decimal)lector["Precio"];    

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
                //conexion.Close();
                conectar.cerrar();
                
            }

        }    
             



    }
}

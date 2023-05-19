﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Text.RegularExpressions;

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
        public bool chequear(List<Marca> lista, string marca)
        {
            bool existe = false;
            foreach (var Marca in lista)
            {
                if(Marca.Descripcion1.ToUpper() == marca.ToUpper())
                {
                    existe = true;
                }
            }
            return existe;
        }                  
        public void agregarMarca(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            
            
                try
                {
                    datos.setearConsulta("insert into MARCAS(Descripcion) values('" + marca.Descripcion1 + "')");
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
        public void eliminarMarca(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Delete from Marcas where Id = " + marca.Id1);
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

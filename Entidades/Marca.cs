using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Marca
    {
        private int Id;
        private string Descripcion;

        public int Id1 { get => Id; set => Id = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }

        //Sobreescribimos metodo
        public override string ToString()
        {
            return Descripcion1;
        }
    }
}

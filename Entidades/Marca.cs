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

        public override string ToString()
        {
            return Descripcion;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.DAL;
using Examen.BE;

namespace Examen.BL
{
  public   class ExamenBL
    {

        private ExamenDAL ExamenDAL = new ExamenDAL();

        public List<Producto> ListarProductos(string nombre)

        {
            
            return ExamenDAL.ListarProductos(nombre);

        }
    }
}

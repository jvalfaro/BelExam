using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.BE;
using Examen.BL;
using Examen.Contract;


namespace Examen.Implementation
{
    public class ExamenService : IExamenService
    {

        ExamenBL ExamenBL = new ExamenBL();
        public List<Producto> ListarProductos(string nombre)
        {
            return ExamenBL.ListarProductos(nombre);
        }
    }
}

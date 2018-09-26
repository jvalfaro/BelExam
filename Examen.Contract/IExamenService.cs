using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Examen.BE;

namespace Examen.Contract
{
    [ServiceContract]
    public interface IExamenService
    {
        [OperationContract]
        List<Producto> ListarProductos(string nombre);
    }
}

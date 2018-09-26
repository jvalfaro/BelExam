using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using CONTOSO.BL;
using Examen.BE;
using Examen.ServiceReference1;

namespace Examen.Controllers
{
    public class HomeController : Controller
    {
        ExamenServiceClient rpc = new ExamenServiceClient();
        public ActionResult Index(string nombre)


        {

            if (nombre!= null)
            {
                List<Examen.BE.Producto> listado = new List<Examen.BE.Producto>();
                listado = rpc.ListarProductos(nombre).ToList();
                return View(listado);
            }
            else
             {
                List<Producto> Producto = new List<Producto>();
                return View(Producto);
            }
        }
    }
}
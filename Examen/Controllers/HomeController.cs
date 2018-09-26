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
        //private CustomerBL customerBL = new CustomerBL();
        public ActionResult Buscar(string nombre)
        //public async Task<ActionResult> Index()
        {
            //return View(await customerBL.Listar());
            //return View(customerBL.Listar());
            List<Examen.BE.Producto> listado = new List<Examen.BE.Producto>();
            listado = rpc.ListarProductos(nombre).ToList();
            return View(listado);
        }

        public ActionResult Index()
        //public async Task<ActionResult> Index()
        {
            List<Producto> Producto = new List<Producto>();
            return View(Producto);
        }
    }
}
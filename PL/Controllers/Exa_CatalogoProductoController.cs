using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class Exa_CatalogoProductoController : Controller
    {
        // GET: Exa_CatalogoProducto
        public ActionResult GetAll()
        {
            Proyecto_ENT.Result result = new Proyecto_ENT.Result();
            Proyecto_ENT.Exa_CatalogoProducto exa_CatalogoProducto = new Proyecto_ENT.Exa_CatalogoProducto();
            Exa_CatalogoProductoServiceReference.Exa_CatalogoProductoClient exa_Catalogo = new Exa_CatalogoProductoServiceReference.Exa_CatalogoProductoClient();
            result = exa_Catalogo.GetAll();
            if (result.Correct)
            {
                exa_CatalogoProducto.Exa_CatalogoProductos = result.Objects;
                return View(exa_CatalogoProducto);

            }
            else
            {
                return View(exa_CatalogoProducto);

            }

        }
        [HttpGet]
        public ActionResult Form()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Form(Proyecto_ENT.Exa_CatalogoProducto exa_CatalogoProducto)
        {
            Proyecto_ENT.Result result = new Proyecto_ENT.Result();
            if (exa_CatalogoProducto.IdProducto == 0)
            {
                Exa_CatalogoProductoServiceReference.Exa_CatalogoProductoClient exa_Catalogo = new Exa_CatalogoProductoServiceReference.Exa_CatalogoProductoClient();
                result = exa_Catalogo.Add(exa_CatalogoProducto);
                

                if (result.Correct)
                {
                    ViewBag.Message = "Registrado con éxito";
                    return View("Modal");
                }
                else
                {
                    ViewBag.Message = "ocurrio problema";
                    return View("Modal");
                }

            }

            return View();
        }
    }
}
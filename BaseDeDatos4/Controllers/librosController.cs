using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseDeDatos4.Models;
using BaseDeDatos4.Models.ViwModels;

namespace BaseDeDatos4.Controllers
{
    public class librosController : Controller
    {
        // GET: libros
        public ActionResult Index()
        {
            List<ListTablaViwModels> lst;
            using ( libreria3Entities db = new libreria3Entities())
            {
                lst = (from d in db.libros
                            select new ListTablaViwModels
                            {
                                precio_venta = d.precio_venta,

                                nombre = d.nombre,
                                id_libro = d.id_libro,
                                //precio_compra = d.precio_compra,
                                //num_pag = d.num_pag,
                            }).ToList();
            }

            return View(lst);
        }
    }
}
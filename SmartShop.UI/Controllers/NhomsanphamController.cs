using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartShop.Utilities;

namespace SmartShop.UI.Controllers
{
    public class NhomsanphamController : Controller
    {
        //
        // GET: /Nhomsanpham/

        public ActionResult Index(string catId)
        {
            CatGroupProductModel model = new CatGroupProductModel();
            model.ObjCategory = ProductCatSvr.GetById(catId.StringToInt32());
            return View(model);
        }

    }
}

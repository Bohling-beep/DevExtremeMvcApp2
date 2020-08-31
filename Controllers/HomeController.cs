using DevExtremeMvcApp2.Models;

using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace DevExtremeMvcApp2.Controllers {
    public class HomeController : Controller {

        FuhrparkContextEntities context = new FuhrparkContextEntities();
        public ActionResult Index()
        {

            var data = context.Database.SqlQuery<GetIndexUebersicht_Result>("GetIndexUebersicht").ToList();
            return View(data);
        }

        public ActionResult Create()

        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@id",0),
                new SqlParameter("@Kennzeichen",0),
                new SqlParameter("@Marke",0),
                new SqlParameter("@Modell",0),
                new SqlParameter("@Fahrzeughalter",0),
                new SqlParameter("@Niederlassung",0),
                new SqlParameter("@Kraftstoff",0),
                new SqlParameter("@Neuwagen",0),
                new SqlParameter("@Status",0),
                new SqlParameter("@testID",0),

            };
            var insert = context.Database.SqlQuery<GetIndexUebersicht_Result>("InsertIntoIndexUebersicht");
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCPlantilla.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mostrar()
        {
            return View();
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(int idVideo, string titulo, int reproducciones, string url, string creador)
        {
            //guardar los datos a SQL server
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            parametros.Add(new SqlParameter("@url", url));
            parametros.Add(new SqlParameter("@creador", creador));

            BaseHelper.ejecutarSentencia("INSERT INTO Video "
                                         + "VALUES(@idVideo,@titulo,"
                                         + "@reproducciones,@url, @creador)",
                                         CommandType.Text,
                                         parametros);

            return View("Mensaje");
        }

        public ActionResult Eliminar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Eliminar(int idVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));

            BaseHelper.ejecutarSentencia("DELETE FROM Video WHERE idVideo = @idVideo", CommandType.Text, parametros);

            return View("Mensaje");
        }

        public ActionResult Modificar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Modificar(int idVideo, string titulo, int reproducciones, string url, string creador)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            parametros.Add(new SqlParameter("@url", url));
            parametros.Add(new SqlParameter("@creador", creador));

            BaseHelper.ejecutarSentencia("UPDATE Video SET titulo='Prueba41' WHERE idVideo=5;", CommandType.Text, parametros);

            return View("Mensaje");
        }

    }
}

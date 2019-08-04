using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcmoviesgalleryapp.Models;
namespace mvcmoviesgalleryapp.Controllers
{
    public class moviesController : Controller
    {//create DAL class object
        movieDAL obj = new movieDAL();
        public ActionResult create()
        {
            return View();
        }
        public ActionResult store(moviemodel m)
        {//para m[movieid and moviename] will receive data from create view
           // HttpPostedFileBase hb = Request.Files["fu1"];
            //httppostedfilebase is similar to fileupload control of asp.net
            //this provides props and methods similar to fileupload control[filename,contenttype,saveas,..]
            m.moviefile = m.movieid + ".mp4";
           //string path = Server.MapPath("/videos/") + m.movieid + ".mp4";
           //hb.SaveAs(path);//saving user uploaded video file on the server into videos folder
           obj.addmovie(m);//calling DAL method to insert movie info into db table
           return View("index");
        }
        public ActionResult display()
        {
            List<moviemodel> ms = obj.getmovies();
            return View(ms);
        }
        public ActionResult delete(string id)
        {//para id will receive movieid from index view delete hyperlink
            obj.deletemovie(id);
            System.IO.File.Delete(Server.MapPath("/videos/") + id + ".mp4");
; return View("display", obj.getmovies());//calling display view by sending List collection with movies info available after deletion
        }






        // GET: movies
        public ActionResult Index()
        {
            return View();
        }
    }
}
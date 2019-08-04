using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using mvcwebapiserverapp.Models;
using System.Web.Http.Cors;
namespace mvcwebapiserverapp.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class inventoryController : ApiController
    {//create dbcontext object
        mvcbatch27Entities obj = new mvcbatch27Entities();
        public List<product> getprods()
        {//read header token submitted by client app
            string token = System.Web.HttpContext.Current.Request.Headers.Get("mytoken");
            if (token == "xyz123")
                //valid token
                return obj.products.ToList();
            else
                //invalid token
                return null;
        }









        public product getprod(string id)
        {
            var p = obj.products.Find(id);
            return p;
        }
        public string postproduct(product p)
        {
            try
            {
                obj.products.Add(p);
                obj.SaveChanges();
                return "rec added";
            }
            catch(Exception ee)
            {
                return "duplicate";
            }
        }
        public void putproduct(product p)
        {
            obj.Entry(p).State = System.Data.Entity.EntityState.Modified;
            obj.SaveChanges();
        }
        
        public void deleteproduct(string id)
        {
            var p = obj.products.Find(id);
            obj.products.Remove(p);
            obj.SaveChanges();
        }
    }




}

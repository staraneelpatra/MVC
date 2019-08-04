using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using mvcbankapp.Models;
namespace mvcbankapp.Controllers
{
    public class demoController : Controller
    {
        // GET: demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult manips(customermodel c,string command)
        {//1st para c will receive customer info[textboxes data]
         //2nd para command will receive user selected submit button value[search|save],para name should be same as submit name
            SqlConnection cn = new SqlConnection("user id=sa;password=123;database=mvcbatch27;data source=peers-pc\\sqlexpress");
            SqlCommand cmd = new SqlCommand();
            switch(command)
            {
                case "search":
                    cmd.CommandText = "select * from customer where accno=" + c.accno;
                    cmd.Connection = cn;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        ViewBag.accno = dr["accno"].ToString();
                        ViewBag.accname = dr["accname"].ToString();
                        ViewBag.accbal = dr["accbal"].ToString();
                    }
                    else
                        ViewBag.msg = "accno not found";
                    dr.Close();
                    cn.Close();
                    break;
                case "save":
                    cmd.CommandText = "insert into customer values(@accno,@accname,@accbal)";
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@accno", c.accno);
                    cmd.Parameters.AddWithValue("@accname", c.accname);
                    cmd.Parameters.AddWithValue("@accbal", c.accbal);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    ViewBag.msg = "customer info saved";
                    break;
            }//closing switch
            return View("index");
        }








    }
}
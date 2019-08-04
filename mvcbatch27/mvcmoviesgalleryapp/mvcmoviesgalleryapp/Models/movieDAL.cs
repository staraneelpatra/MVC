using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace mvcmoviesgalleryapp.Models
{
    public class movieDAL
    {
        SqlConnection cn = new SqlConnection("user id=sa;password=123;database=mvcbatch21;data source=peers-pc");
        SqlCommand cmd = new SqlCommand();
        public void addmovie(moviemodel m)
        {//para m will receive movie info from controller action
            cmd.CommandText = "insert into movies values(@mid,@mname,@mfile)";
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@mid", m.movieid);
            cmd.Parameters.AddWithValue("@mname", m.moviename);
            cmd.Parameters.AddWithValue("@mfile", m.moviefile);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
       }
        public List<moviemodel> getmovies()
        {
            List<moviemodel> obj = new List<moviemodel>();
            cmd.CommandText = "select * from movies";
            cmd.Connection = cn;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                moviemodel m = new moviemodel();
                m.movieid = dr["movieid"].ToString();
                m.moviename = dr["moviename"].ToString();
                m.moviefile = dr["moviefile"].ToString();
                obj.Add(m);
                //converting movies table recs into moviemodel objects and storing into list
            }
            dr.Close();
            cn.Close();
            return (obj);//returning collection of movies to controller action
       }
        public void deletemovie(string mid)
        {//para mid will receive movieid from controller action
            cmd.CommandText = "delete from movies where movieid=@mid1";
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@mid1", mid);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
       }
  }







}
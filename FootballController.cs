using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using footballcode.Models;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;

namespace footballcode.Controllers
{
    public class FootballController : Controller
    {
        // GET: Football
        FootBallContext Context = new FootBallContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Insert(string teamname1, string teamname2, string status, string winteam, int points)
        {
            SqlConnection con = new SqlConnection("data source = Ranjith; database = football; integrated security=SSPI");
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Execute pro_name @TeamName1,@TeamName2,@Status,@WinTeam,@Points";
            cmd.Parameters.Add("@TeamName1", SqlDbType.VarChar, 50).Value = teamname1;
            cmd.Parameters.Add("@TeamName2", SqlDbType.VarChar, 50).Value = teamname2;
            cmd.Parameters.Add("@Status", SqlDbType.VarChar, 50).Value = status;
            cmd.Parameters.Add("@WinTeam", SqlDbType.VarChar, 50).Value = winteam;
            cmd.Parameters.Add("@Points", SqlDbType.Int, 4).Value = points;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
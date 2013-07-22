using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCA.DB;
using MVCA.Models;
using System.Data.SqlClient;
using System.Configuration;


namespace MVCA.Models
{
    public class manager
    {
        //private timesheetEntities tms = new timesheet();

        public void Add(timesheet  sheet)
        {
            //string sql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            //SqlConnection  connObj=new SqlConnection ();
           
//connObj.Open();
//SqlCommand comm = new SqlCommand(“insert into student(name,email,comment) values(@name,@email,@comment)”, connObj);

//comm.Parameters.Add(“@name”, SqlDbType.VarChar , 50).Value =model .Name ;
//comm.Parameters.Add(“@email”, SqlDbType.VarChar, 50).Value = model.Comment;
//comm.Parameters.Add(“@comment”, SqlDbType.VarChar, 50).Value = model.Email;

//int result = comm.ExecuteNonQuery();
//if (result != 0)
//Response.Write(” added”);
//else
//Response.Write(“Error”);

//return View();
           // DB.entry sysUser = new DB.entry();
            //sysUser.id = sheet.id;
           // sysUser.task = sheet.task;
            //sysUser.time = sheet.time;
            //sysUser.personname = sheet.personname;
           

            //tms.AddToSysUsers(sysUser);
           // tms.SaveChanges();
        }

        
    }
}
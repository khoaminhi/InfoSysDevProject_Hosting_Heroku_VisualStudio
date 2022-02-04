using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace DiChoThue.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly IConfiguration _configuration;
        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        //Get: /Login
        [HttpPost]
        public JsonResult Post(Entity.Login shipper)
        {
            string query = @"select MaShipper, Hoten, Email
                            from Shipper 
                            where Email = @Email
                            and MatKhau = @Matkhau and TrangThai !=0";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand MyCommand = new SqlCommand(query, myCon))
                {
                    MyCommand.Parameters.AddWithValue("@Email", shipper.Email);
                    MyCommand.Parameters.AddWithValue("@Matkhau", shipper.Matkhau);
                    myReader = MyCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            if (table != null && table.Rows.Count > 0)
            {
                return new JsonResult(table);
            }
            else return new JsonResult(table);
        }
    }
}

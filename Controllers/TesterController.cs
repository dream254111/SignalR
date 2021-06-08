using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace signalr2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesterController : ControllerBase
    {
        string connString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.254.111.51)(PORT=1523))(CONNECT_DATA=(SERVICE_NAME=meadb)));User Id=meainf;Password=meainf123;";

        public TesterController()
        {

        }

        [HttpGet]
        public IActionResult TestGet()
        {
            string result = string.Empty;

            try
            {
                using (OracleConnection conn = new OracleConnection(connString))
                {
                    
                }

                result = "Success";
            }
            catch (Exception ex)
            {
                result = "Failure - " + ex.InnerException?.Message ?? ex.Message;
            }

            return Ok("Status: " + result);
        }
    }
}

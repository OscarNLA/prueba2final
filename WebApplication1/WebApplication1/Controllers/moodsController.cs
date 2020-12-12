using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/operaciones")]
    public class moodsController : ApiController
    {
        [HttpGet]
        [Route("{number:int}")]
        public mood Operations(int number)
        {
            mood model = new mood();
            model.numero = number;

            if (number < 0)
                model.mensaje = "ERROR";

            if (number == 0)
                model.mensaje = "Realizado por okar";

            if (number > 0)
                model.mensaje = "Usted ingreso el numero " + number.ToString();

            return model;
        }
    }
}

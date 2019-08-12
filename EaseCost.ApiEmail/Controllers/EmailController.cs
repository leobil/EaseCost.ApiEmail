using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EaseCost.ApiEmail.Models;
using EaseCost.ApiEmail.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EaseCost.ApiEmail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        //[Authorize]
        [HttpPost]
        public IActionResult AddEmail([FromServices] EmailRespository toEmailRepository,
                                      [FromBody] Email toEmail)
        {
            if (string.IsNullOrWhiteSpace(toEmail.email))
            {
                return this.Conflict(new Error { message = "Ops. Algo deu errado! Este e-mail não é válido. :(", errorCode = 409 });
            }

            if (toEmailRepository.AddEmail(toEmail.email))
            {
                return this.Ok("Oba. Cadastro foi realizado com sucesso! :)");

            }
            else
            {
                return this.Conflict(new Error { message = "Ops. Algo deu errado! :(", errorCode = 409 });
            }

        }
    }
}
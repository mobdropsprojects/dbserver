using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DBServer.Application;
using DBServer.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DBServer.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : Controller
    {
        LancamentoApplication lancamentoApp = new LancamentoApplication();


        /// <summary>
        /// Operation debit/credit
        /// </summary>
        /// <param name="lancamento"></param>
        /// <returns></returns>
        [HttpPost("Transferencia")]
        //[ValidateAntiForgeryToken]
        public ActionResult Transferencia(Lancamentos lancamento)
        {
            ResponseContract<Lancamentos> response = new ResponseContract<Lancamentos>();
            try
            {
                response.Data = lancamentoApp.Transferencia(lancamento);
                response.StatusCode = 200;
                return Ok(response);
            }
            catch (Exception ex)
            {
                //Felipe: Tratei como bad request como exemplo
                response.IsSuccess = false;
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                response.error = ex.Message;
                return BadRequest(response);
            }
        }

    }
}
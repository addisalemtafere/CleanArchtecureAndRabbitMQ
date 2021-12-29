using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiroRabbit.Transfer.Application.Interfaces;
using MiroRabbit.Transfer.Domain.Model;

namespace MiroRabbit.Transfer.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> GetTransferLogs()
        {
            return Ok(_transferService.GetTransferLogs());
        }
    }
}
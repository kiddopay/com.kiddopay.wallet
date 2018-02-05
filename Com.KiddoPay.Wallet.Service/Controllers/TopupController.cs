using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.ServiceBus;
using System.Text;
using Com.KiddoPay.Domains.Wallet.Messages;
using Newtonsoft.Json;
using Com.KiddoPay.Wallet.Business;

namespace Com.KiddoPay.Wallet.Service.Controllers
{
    [Route("api/[controller]")]
    public class TopUpController : Controller
    {
        // POST api/values
        [HttpPost]
        public Task Post([FromBody]decimal value)
        {
            TopUpFacade topUpFacade = new TopUpFacade();
            return topUpFacade.TopUpAsync("tris.setiawan", 100000);
        }

    }
}

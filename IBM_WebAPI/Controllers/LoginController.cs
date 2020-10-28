using IBM_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using UnitOfWork;

namespace IBM_WebAPI.Controllers
{
    public class LoginController : ApiController
    {
        GenericUnitOfWork _unitOfWork;

        public async Task<IHttpActionResult> CreateData([FromBody]LoginModel loginModel)
        {
            _unitOfWork = new GenericUnitOfWork();

            if (ModelState.IsValid)
            {
                await LoginModel.CreateAccount(loginModel, _unitOfWork);
                return Ok();
            }

            return BadRequest("Invalid data.");
        }
    }
}

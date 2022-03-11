using login_core_apis.business;
using login_core_apis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace login_core_apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    { public readonly IloginBusiness loginBusiness;
        public loginController(IloginBusiness _loginBusiness)
        {
            loginBusiness = _loginBusiness;
        }
        [HttpGet("")]
        public Task<IEnumerable<login>> GetLogins()
        {
            return loginBusiness.Getlogins();
        }

        [HttpGet("{loginId}")]
        public Task<login> GetLogin(int loginId)
        {
            return loginBusiness.Getlogin(loginId);
        }


        [HttpPost("")]
        public Task<int> Addlogins(login Login)
        {
            return loginBusiness.Addlogins(Login);
        }

    }
}
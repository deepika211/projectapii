using login_core_apis.Models;
using login_core_apis.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login_core_apis.business
{
    public class loginBusiness : IloginBusiness
    {
        public readonly IloginRepository loginRepository;
        public loginBusiness(IloginRepository _loginRepository)
        {
            loginRepository = _loginRepository;
        }
        public Task<int> Addlogins(login Login)
        {
            return loginRepository.Addlogins(Login);
        }

        public Task<int> Deletelogins(int loginId)
        {
            return loginRepository.Deletelogins(loginId);
        }

        public Task<login> Getlogin(int loginId)
        {
            return loginRepository.Getlogin(loginId);
        }

        public Task<IEnumerable<login>> Getlogins()
        {
            return loginRepository.Getlogins();
        }

        public Task<int> Updatelogins(login Login)
        {
            return loginRepository.Addlogins(Login);
        }
    }
}

using login_core_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login_core_apis.business
{
   public interface IloginBusiness
    {
        public Task<IEnumerable<login>> Getlogins();
        public Task<login> Getlogin(int loginId);
        public Task<int> Addlogins(login Login);
        public Task<int> Updatelogins(login Login);
        public Task<int> Deletelogins(int loginId);
    }
}

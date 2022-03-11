using login_core_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login_core_apis.business
{
   public interface IteacherBusiness
    {
        public Task<bool> Addteacher(Teacher teacher);
        public Task<bool> Updateteacher(Teacher teacher);
        public Task<bool> Deleteteacher(int tid);

        public List<Teacher> Getteachers(int bId);
        public Task<Teacher> Getteacher(int tid);
    }
}

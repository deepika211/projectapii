using login_core_apis.DataMode;
using login_core_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login_core_apis.Repository
{
   public interface IteacherRepository
    {
        public Task<int> Addteacher(Teacher teacher);
        public Task<int> Updateteacher(Teacher teacher);
        public Task<int> Deleteteacher(int tid);
        public List<Teacher> Getteachers(int bId);
        public Task<teacherDataModel> Getteacher(int tid);
    }
}

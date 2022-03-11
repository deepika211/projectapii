using login_core_apis.Models;
using login_core_apis.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login_core_apis.business
{
    public class teacherBusiness:IteacherBusiness
    {
        public readonly IteacherRepository teacherRepository;
        public teacherBusiness(IteacherRepository _teacherRepository)
        {
            teacherRepository = _teacherRepository;
        }
        public async Task<bool> Addteacher(Teacher teacher)
        {
            var result = await teacherRepository.Addteacher(teacher);
            return result>0;
        }

        public List<Teacher> Getteachers(int bId)
        {
            /* var result = teacherRepository.Getteachers(bId);
             List<Teacher> teacherList = new List<Teacher>();
             foreach (var p in result)
             {
                 teacherList.Add(new Teacher()
                 {
                     tid = p.tid,
                     tname = p.tname,

                      bId = new BOOK() { bId = p.bId, bName = p.bName }
                 });
             }*/
            List<Teacher> teacherList = teacherRepository.Getteachers(bId);
            return teacherList;
        }
    
        public async Task<Teacher> Getteacher(int tid)
        {
            var p = await teacherRepository.Getteacher(tid);
            return new Teacher()
            {
                tid = p.tid,
                tname = p.tname,
                bId = new BOOK() { bId = p.bId, bName = p.bName }
            };
            }
        public async Task<bool>Updateteacher(Teacher teacher)
        {
            var result = await teacherRepository.Updateteacher(teacher);
            return result > 0;
        }

        public async Task<bool>Deleteteacher(int tid)
        {
            var result = await teacherRepository.Deleteteacher(tid);
            return result > 0;
        }

       
    }
}

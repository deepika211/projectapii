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
    public class teacherController : ControllerBase
    {
        public readonly IteacherBusiness teacherBusiness;
        public teacherController(IteacherBusiness _teacherBusiness)
        {
            teacherBusiness = _teacherBusiness;
        }
        [HttpGet("")]
        public Task<Teacher> Getteacher(int tid)
        {
            return teacherBusiness.Getteacher(tid);
        }

        [HttpGet("{bId}")]
        public List<Teacher> Getteachers(int bId)
        {
            return teacherBusiness.Getteachers(bId);
        }


       [HttpPost("")]
        public Task<int> Addteacher(Teacher teacher)
        {
            return teacherBusiness.Addteacher(teacher);
        }

    
}
}

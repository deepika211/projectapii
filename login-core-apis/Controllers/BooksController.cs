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
    public class BooksController : ControllerBase
    {   public readonly IBookBusiness BOOKBusiness;
        public BooksController(IBookBusiness _BOOKBusiness)
        {
            BOOKBusiness = _BOOKBusiness;
        }
        [HttpGet("")]
        public Task<IEnumerable<BOOK>> GetBooks()
        {
            return BOOKBusiness.GetBooks();
        }

        [HttpGet("{bId}")]
        public Task<BOOK> GetBook(int bId)
        {
            return BOOKBusiness.GetBook(bId);
        }
        [HttpPost("")]
        public Task<int> AddBook(BOOK book)
        {
            return BOOKBusiness.AddBook(book);
        }
    }
    }

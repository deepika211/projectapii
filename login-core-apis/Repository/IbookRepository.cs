using login_core_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login_core_apis.Repository
{
    public interface IbookRepository
    {
        public Task<int> AddBook(BOOK book);
        public Task<int> UpdateBook(BOOK book);
        public Task<int> DeleteBook(int bId);
        public Task<IEnumerable<BOOK>> GetBooks();
        public Task<BOOK> GetBook(int bId);

    }
}

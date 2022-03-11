using login_core_apis.Models;
using login_core_apis.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login_core_apis.business
{
    public class BOOKBusiness : IBookBusiness
    {
        public readonly IbookRepository bookRepository;
        public BOOKBusiness(IbookRepository _bookRepository)
        {
            bookRepository = _bookRepository;
        }

        public Task<int> AddBook(BOOK book)
        {
            return bookRepository.AddBook(book);
        }

        
        public Task<int> DeleteBook(int bId)
        {
            return bookRepository.DeleteBook(bId);
        }

        public Task<BOOK> GetBook(int bId)
        {
            return bookRepository.GetBook(bId);
        }

        public Task<IEnumerable<BOOK>> GetBooks()
        {
            return bookRepository.GetBooks();
        }

        public Task<int> UpdateBook(BOOK book)
        {
            return bookRepository.UpdateBook(book);
        }

        
    }
}

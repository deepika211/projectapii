using Dapper;
using login_core_apis.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace login_core_apis.Repository
{
    public class bookRepository : IbookRepository
    {
        public readonly string connectionString;
        public bookRepository(string _connectionString)
        {
            connectionString = _connectionString;
        }

        public async Task<int> AddBook(BOOK book)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                return await con.ExecuteAsync("sp_AddBook", new
                {   book.bId,
                    book.bName,
                    book.category,
                    book.NoOfCopies
                }, null, null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }
        public async Task<int> DeleteBook(int bId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                return await con.ExecuteAsync("sp_DeleteBook", new
                {
                    bId
                }, null, null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }



        public async Task<BOOK> GetBook(int bId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                return await con.QueryFirstOrDefaultAsync<BOOK>("sp_GetBook", new
                {
                    bId
                }, null, null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }
        public async Task<IEnumerable<BOOK>> GetBooks()
        {
            dynamic bId = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                return await con.QueryAsync<BOOK>("sp_GetBook", new
                {
                    bId
                }, null, null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }

        public async Task<int> UpdateBook(BOOK book)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                return await con.ExecuteAsync("sp_UpdateBook", new
                {
                    book.bName,
                    book.category,
                    book.NoOfCopies
                }, null, null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }
    }
}
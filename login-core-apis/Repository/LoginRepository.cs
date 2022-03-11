using login_core_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace login_core_apis.Repository
{
    public class LoginRepository : IloginRepository
    {
        public readonly string connectionString;
        public  LoginRepository(string _connectionString)
        {
            connectionString = _connectionString;
        }
        public async Task<int> Addlogins(login Login)
        {
            using(SqlConnection con=new SqlConnection(connectionString))
            {
                return await con.ExecuteAsync("sp_AddLogin", new
                { 
                    Login.username,
                  Login.password
                }, null, null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }

        public async Task<int> Deletelogins(int loginId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                return await con.ExecuteAsync("sp_deleteLogin", new
                {
                    loginId
                }, null, null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }

      

        public async Task<login> Getlogin(int loginId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                return await con.QueryFirstOrDefaultAsync<login>("sp_GetLogins", new
                {loginId
                }, null, null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }

        public async Task<IEnumerable<login>>Getlogins()
        {
           dynamic loginId = null;
                using (SqlConnection con = new SqlConnection(connectionString))
            {
                return await con.QueryAsync<login>("sp_GetLogins",new { loginId
                }, null, null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }

      public async Task<int> Updatelogins(login Login)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                return await con.ExecuteAsync("sp_UpdateLogin", new
                {
                    Login.username,
                    Login.password
                }, null, null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }
    }
}

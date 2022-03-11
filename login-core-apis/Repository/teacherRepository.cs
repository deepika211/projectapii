using Dapper;
using login_core_apis.DataMode;
using login_core_apis.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace login_core_apis.Repository
{
    public class teacherRepository : IteacherRepository
    {
        public readonly string connectionString;
        public teacherRepository(string _connectionString)
        {
            connectionString = _connectionString;
        }

        public async Task<int> Addteacher(Teacher teacher)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                return await con.ExecuteAsync("sp_Addteacher", new
                {
                    teacher.tname,
                    teacher.bId
                }, null, null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }

        public async Task<int> Deleteteacher(int tid)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                return await con.ExecuteAsync("sp_Deleteteacher", new
                {
                    tid
                }, null, null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }

        public async Task<teacherDataModel> Getteacher(int tid)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                return await con.QueryFirstOrDefaultAsync<teacherDataModel>("sp_Getteacher", new
                {
                   tid
                }, null, null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }

        private IDbConnection dbCon = null;

        String readNutritionString = "SELECT * FROM teacher n join [user] u on n.userId=u.userId WHERE n.userId={0}";
        String readItemsString = "select * from items where id={0}";
        public List<Teacher> Getteachers(int bId)
        {
            using (dbCon = new SqlConnection(connectionString))
            {
                IEnumerable<Teacher> teacherList = dbCon.Query<Teacher>(String.Format(readNutritionString, bId));
                List<Teacher> teachers =teacherList.AsList();
                return teachers;
            }
        }

        /*public async Task<IEnumerable<teacherDataModel>> Getteachers(int bId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                return await con.QueryAsync<teacherDataModel>("sp_Getteacher", new
                {
                            bId
                }, null, null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }*/

        public async Task<int> Updateteacher(Teacher teacher)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                return await con.ExecuteAsync("sp_Getteacher", new
                {
                    teacher.tname,
                    bId=teacher.tid

                }, null, null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }
    }
}

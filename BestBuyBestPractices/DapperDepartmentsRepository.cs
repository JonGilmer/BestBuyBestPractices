using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace BestBuyBestPractices
{
    public class DapperDepartmentsRepository : IDepartmentsRepository
    {
        private readonly IDbConnection _conn;

        public DapperDepartmentsRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<departments> GetAllDepartments()
        {
            return _conn.Query<departments>("SELECT * FROM departments;");
        }
    }
}

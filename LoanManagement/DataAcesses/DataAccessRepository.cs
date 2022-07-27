using LoanManagement.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagement.DataAcesses
{
    public class DataAccessRepository : IDataAccessRepository
    {
        SalaryManagerDBContext _dbCtx;
        public DataAccessRepository()
        {
            _dbCtx = new SalaryManagerDBContext();
        }
        public List<UserInfoes> getAllUsers()
        {
            return _dbCtx.UserInfoes.ToList();
        }
        public UserInfoes getUserById(Guid id)
        {
            return _dbCtx.UserInfoes.Where(user => user.Id == id).FirstOrDefault();
        }
    }
}

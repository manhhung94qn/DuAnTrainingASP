using DataAccess.Models;
using DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(GasStationDBContext dbContext) : base(dbContext)
        {
        }

        public User GetUserByEmail(string _email, string _pass)
        {
            return _dbContext.User.Where(x => x.Email == _email && x.Password == _pass).FirstOrDefault();
        }
    }
}

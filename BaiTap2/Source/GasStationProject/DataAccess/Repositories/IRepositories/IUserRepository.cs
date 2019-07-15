using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.IRepositories
{
    public interface IUserRepository: IRepositoryBase<User>
    {
        User GetUserByEmail(string _email, string _pass);
    }
}

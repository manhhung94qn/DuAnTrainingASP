
using DataAccess.Models;
using DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GasStationRepository : RepositoryBase<GasStation>, IGasStationRepository
    {
        public GasStationRepository(GasStationDBContext dbContext) : base(dbContext)
        {
        }

        public List<GasStation> GetGasStationsByLocal(long local)
        {
            return _dbContext.GasStation.Where(m => m.District == local).ToList();
        }
        
        public bool isNameExist(string name) {
            int i = _dbContext.GasStation.Where(x => x.GasStationName.ToLower() == name.ToLower()).Count();
            return i > 0 ? true : false;
        }
    }
}

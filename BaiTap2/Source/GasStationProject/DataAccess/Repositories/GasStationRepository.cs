
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
    }
}

using DataAccess.Models;
using DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GasStationGasTypeRepository : RepositoryBase<GasStationGasType>, IGasStationGasTypeRepository
    {
        public GasStationGasTypeRepository(GasStationDBContext dbContext) : base(dbContext)
        {
            
        }

        public List<GasStationGasType> findByGasStationId(long Id)
        {
            return _dbContext.GasStationGasType.Where(x => x.GasStationId == Id).ToList();
        }
    }
}

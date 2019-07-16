using DataAccess.Models;
using DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    class DistrictRepository: RepositoryBase<M_District>, IDistrictRepository
    {
        public DistrictRepository(GasStationDBContext dbContext) : base(dbContext)
        {
        }

    }
}

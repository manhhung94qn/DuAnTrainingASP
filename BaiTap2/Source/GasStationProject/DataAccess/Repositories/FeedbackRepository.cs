using DataAccess.Models;
using DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class FeedbackRepository: RepositoryBase<Models.GasStationFeedback>, IFeedbackRepository
    {
        public FeedbackRepository(GasStationDBContext dbContext) : base(dbContext)
        {
        }
    }
}

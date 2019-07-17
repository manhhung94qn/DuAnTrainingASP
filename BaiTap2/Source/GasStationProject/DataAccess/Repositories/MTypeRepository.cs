using DataAccess.Models;
using DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class MTypeRepository: RepositoryBase<M_Type>, IMTpyeRepository
    {
        public MTypeRepository(GasStationDBContext dbContext) : base(dbContext)
        {
        }
        

        public string getTypeText(string typeCode, int typeType)
        {
            var mtype = _dbContext.M_Type.Where(m => m.TypeCode == typeCode && m.TypeType == typeType).FirstOrDefault();
            if(mtype != null)
            {
                return mtype.TypeText;
            }
            return "";
        }
    }
}

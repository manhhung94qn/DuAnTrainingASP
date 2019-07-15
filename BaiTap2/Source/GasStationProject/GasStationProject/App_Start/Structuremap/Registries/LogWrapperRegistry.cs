using DataAccess.Repositories;
using DataAccess.Repositories.IRepositories;
using log4net;
using GasStationProject.App_Core.LogWrapper;
using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using StructureMap.Web.Pipeline;
using System;
using System.Linq;
using System.Web;

namespace Structuremap.Registries
{
    public class LogWrapperRegistry : Registry
    {
        public LogWrapperRegistry()
        {
            For<ILogWrapper>().Use(context => new LogWrapper(context.ParentType));

        }
    }
}
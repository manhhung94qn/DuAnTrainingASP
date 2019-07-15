using DataAccess.Models;
using DataAccess.UnitOfWork;
using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using StructureMap.Web;
using StructureMap.Web.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Structuremap.Registries
{
    public class DbContextRegistry : Registry
    {
        public DbContextRegistry()
        {
            For<GasStationDBContext>().HybridHttpOrThreadLocalScoped().Use(() => new GasStationDBContext());
            For<IUnitOfWork>().Use<UnitOfWork>();
        }

    }
}
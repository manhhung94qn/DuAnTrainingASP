using DataAccess.Repositories;
using DataAccess.Repositories.IRepositories;
using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using StructureMap.Web.Pipeline;
using System;
using System.Linq;
using System.Web;

namespace Structuremap.Registries
{
    public class RepositoryRegistry : Registry
    {
        public RepositoryRegistry()
        {
            For<IGasStationRepository>().Use<GasStationRepository>();

        }
    }
}
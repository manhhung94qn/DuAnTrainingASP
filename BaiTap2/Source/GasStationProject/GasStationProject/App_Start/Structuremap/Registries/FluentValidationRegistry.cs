using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using StructureMap;

namespace Structuremap.Registries
{
    public class FluentValidationRegistry : Registry
    {
        public FluentValidationRegistry()
        {
            Scan(x=>
                {
                       x.TheCallingAssembly();
                       x.WithDefaultConventions();
                       x.ConnectImplementationsToTypesClosing(typeof (AbstractValidator<>));
                   }
            );
        }
    }
}
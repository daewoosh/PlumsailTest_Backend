using Autofac;
using MediatR;
using Plumsail.CommonLib;
using Plumsail.DAL;
using Plumsail.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plumsail.Web.Core
{
    public class CoreAutofacModule : AutofacModuleBase
    {
        protected override void Load(ContainerBuilder builder)
        {
            AddModule(new DomainAutofacModule());
            AddModule(new DalAutofacModule());

            builder
                  .RegisterType<Mediator>()
                  .As<IMediator>()
                  .InstancePerLifetimeScope();

            builder.Register<ServiceFactory>(context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });


            base.Load(builder);
            RegisterModules(builder);
        }
    }
}

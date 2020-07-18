﻿using Nancy;
using Nancy.TinyIoc;
using neurUL.Common.Http;
using ei8.Avatar.Application;
using ei8.Avatar.Domain.Model;
using ei8.Avatar.Port.Adapter.IO.Persistence.IdentityAccess;
using ei8.Avatar.Port.Adapter.IO.Process.Services;

namespace ei8.Avatar.Port.Adapter.In.Api
{
    public class CustomBootstrapper : DefaultNancyBootstrapper
    {
        public CustomBootstrapper()
        {
        }

        protected override void ConfigureRequestContainer(TinyIoCContainer container, NancyContext context)
        {
            base.ConfigureRequestContainer(container, context);

            container.Register<IRequestProvider, RequestProvider>();
            container.Register<IResourceRepository, ResourceRepository>();
            container.Register<ISettingsService, SettingsService>();
            container.Register<IResourceApplicationService, ResourceApplicationService>();
        }
    }
}

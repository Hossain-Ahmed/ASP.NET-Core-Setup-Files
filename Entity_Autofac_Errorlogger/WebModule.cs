﻿using Autofac;
using Foundation.Contexts;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFile.Models;

namespace AoutoFac

{
    public class WebModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public WebModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<>().As<>()
            //    .InstancePerLifetimeScope();


            builder.RegisterType<ShopingContext>()
               .WithParameter("connectionString", _connectionString)
               .WithParameter("migrationAssemblyName", _migrationAssemblyName)
               .InstancePerLifetimeScope();

           builder.RegisterType<IndexModel>().AsSelf();            
           base.Load(builder);
            
        }
    }
}

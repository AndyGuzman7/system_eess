using Autofac;
using EESSSYSTEM.Data.DataSource.Remote;
using EESSSYSTEM.Data.RepositoryImpl;
using EESSSYSTEM.Domain.Repository;
using EESSSYSTEM.Domain.Usecases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESSSYSTEM
{
    public class DependencyInjector
    {
        private static Autofac.IContainer container;

        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MemberDataSourcerRemote>().As<MemberDataSourcerRemote>().SingleInstance();

            builder.RegisterType<MemberRepositoryImpl>().As<IMemberRepository>().SingleInstance();

            builder.RegisterType<GetAllMembersUseCase>().As<GetAllMembersUseCase>().SingleInstance();



            container = builder.Build();
        }

        public static T GetInstance<T>()
        {
            return container.Resolve<T>();
        }
    }
}

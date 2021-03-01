using Autofac;
using AutoMapper;
using DesafioKPMG.Application;
using DesafioKPMG.Application.Interfaces;
using DesafioKPMG.Application.Mapper;
using DesafioKPMG.Domain.Core.Interfaces.Repository;
using DesafioKPMG.Domain.Core.Interfaces.Services;
using DesafioKPMG.Domain.Services;
using DesafioKPMG.Infra.Data.Repositorys;

namespace DesafioKPMG.CrossCutting.Ioc
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceGameResult>().As<IApplicationServiceGameResult>();
            builder.RegisterType<GameResultService>().As<IGameResultService>();
            builder.RegisterType<GameResultRepository>().As<IGameResultRepository>();

            builder.RegisterType<ApplicationServiceLeaderboard>().As<IApplicationServiceLeaderboard>();
            builder.RegisterType<LeaderboardService>().As<ILeaderboardService>();
            builder.RegisterType<LeaderboardRepository>().As<ILeaderboardRepository>();

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelMappingGameResult());
                cfg.AddProfile(new ModelToDtoMappingGameResult());

                cfg.AddProfile(new DtoToModelMappingLeaderboard());
                cfg.AddProfile(new ModelToDtoMappingLeaderboard());


            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }

        #endregion IOC
    }

}

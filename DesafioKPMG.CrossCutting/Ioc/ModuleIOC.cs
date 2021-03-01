using Autofac;


namespace DesafioKPMG.CrossCutting.Ioc
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
             ConfigurationIOC.Load(builder);
        }
    }
}

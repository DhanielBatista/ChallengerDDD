using Application;
using Application.Interfaces;
using Domain.Core.Interfaces.Services;
using Autofac;

namespace Infracstruture.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<AlbumsApplicationService>().As<IAlbumsApplicationService>();
            builder.RegisterType<MusicsApplicationService>().As<IMusicApplicationService>();
            builder.RegisterType<SingersApplicationService>().As<ISingersApplicationService>();
            builder.RegisterType<ServiceAlbum>().As<IServiceAlbums>();



            #endregion
        }
    }
}

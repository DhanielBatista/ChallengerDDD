using Domain.Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class ServiceAlbum : ServiceBase<Albums>, IServiceAlbums
    {
        private readonly IAlbumsRepository albumsRepository;

        public ServiceAlbum(IAlbumsRepository albunsRepository) : base(albunsRepository)
        {
            this.albumsRepository = albunsRepository;
        }
    }
}

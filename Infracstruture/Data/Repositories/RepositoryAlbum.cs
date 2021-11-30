using Domain.Core.Interfaces.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infracstruture.Data.Repositories
{
    public class RepositoryAlbum
    {
        public class RepositortAlbum : RepositoryBase<Albums>, IAlbumsRepository
        {
            private readonly SqlContext sqlContext;

            public RepositortAlbum(SqlContext sqlContext) : base(sqlContext)
            {
                this.sqlContext = sqlContext;
            }

        }
    }
}

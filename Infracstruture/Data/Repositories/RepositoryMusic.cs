using Domain.Core.Interfaces.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infracstruture.Data.Repositories
{
    public class RepositoryMusic : RepositoryBase<Musics>,IMusicRepository
    {
        private readonly SqlContext sqlContext;

        public RepositoryMusic(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using WiProLocadora.Domain.Entity;
using WiProLocadora.Domain.UseCases.Repository;
using WiProLocadora.Infrastructure.Data.SQLServer;

namespace WiProLocadora.Infrastructure.Repository
{
    public class FilmeElencoRepository: BaseRepository<FilmeElencoEntity>, IFilmeElencoRepository
    {
        private readonly SQLServerDataContext sqlServerDataContext;

        public FilmeElencoRepository(SQLServerDataContext sqlServerDataContext)
            : base(sqlServerDataContext)
        {
            this.sqlServerDataContext = sqlServerDataContext;
        }
    }
}

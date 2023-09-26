﻿using Acme.BookStore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace Acme.BookStore.Authors
{
    public class EfCoreAuthorRepository : EfCoreRepository<BookStoreDbContext, Author, Guid>, IAuthorRepository
    {
        public EfCoreAuthorRepository(IDbContextProvider<BookStoreDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }


        public  async Task<Author> FindByNameAsync(string name)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.FirstOrDefaultAsync(author => author.Name == name);
        }

        public async Task<List<Author>> GetListAsync(int skipCount, int maxresultCount, string sorting, string filter = null)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.WhereIf(!filter.IsNullOrWhiteSpace(), author => author.Name.Contains(filter))
                .OrderBy(sorting)
                .Skip(skipCount)
                .Take(maxresultCount)
                .ToListAsync();
        }
    }
}
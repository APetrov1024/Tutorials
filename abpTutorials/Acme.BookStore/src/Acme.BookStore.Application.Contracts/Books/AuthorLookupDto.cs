using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Books
{
    public class AuthorLookupDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace EventosAPI.Models;

public partial class DbLivroContext : DbContext
{
    public DbLivroContext()
    {
    }

    public DbLivroContext(DbContextOptions<Microsoft.EntityFrameworkCore.DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Livro> Livro { get; set; }

   
}

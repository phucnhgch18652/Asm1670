using System;
using Asm.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TheNew1.Models;

namespace TheNew1.Data
{
    public class FPTBookDbContext : DbContext
    {
        public FPTBookDbContext(DbContextOptions<FPTBookDbContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<CategoryReq> CategoryReqs { get; set; }
    }
}

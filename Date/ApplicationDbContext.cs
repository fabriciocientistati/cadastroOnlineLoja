
using CadastroPrimoMoveis.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CadastroPrimoMoveis.Date
{     
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
            base(options)
        {
        }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}

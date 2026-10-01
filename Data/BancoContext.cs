using Contact_systems_in_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Contact_systems_in_MVC.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext ( DbContextOptions <BancoContext> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }


    }
}


using DDD3.Domain.Entities;
using System.Data.Entity;

namespace DDD3.Infra.Data.Context
{

    public class DDDModeloContext : DbContext
    {
        public DDDModeloContext() 
            : base("ProjetoModeloDDDTres")
        {

        }
        public DbSet<Cliente> Clientes {  get; set; }
    }
}

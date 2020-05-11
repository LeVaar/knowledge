using System.Data.Entity;

namespace FinalProject.ViewModel
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("default"){}
        public DbSet<Disease> Diseases { get; set; }
    }
}
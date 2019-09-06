

using DAL.DTO;
using Service.Models;
using System.Data.Entity;

namespace DAL
{
    public class StoreEntities : DbContext
    {
        public StoreEntities() : base("StoreEntities") { }

        public DbSet<UserModelDTO> Users { get; set; }
        

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new GadgetConfiguration());
            //modelBuilder.Configurations.Add(new CategoryConfiguration());
        }
    }
}

using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearAccount.BussinessEntities
{

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ClearAccountDbContext : DbContext
    {
        public ClearAccountDbContext() : base("ClearAccountDbContext")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        //private static string getConnectionStringName()
        //{
        //    ConnectionStringSettingsCollection connections = ConfigurationManager.ConnectionStrings;
        //    String CONNECTIONSTRING = String.Empty;

        //    if(connections.Count != 0)
        //    {
        //        foreach(ConnectionStringSettings connection in connections)
        //        {
        //            CONNECTIONSTRING = connection.Name;
        //        }
        //    }

        //    return CONNECTIONSTRING;
        //}

    }
}

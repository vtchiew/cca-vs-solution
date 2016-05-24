namespace CCA.Server.Models
{
    using Common.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CcaEntities : DbContext
    {
        // Your context has been configured to use a 'CcaEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CCA.Server.Models.CcaEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CcaEntities' 
        // connection string in the application configuration file.
        public CcaEntities()
            : base("name=CcaEntities")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<CcaUser> CcaUsers { get; set; }
    }

    
}
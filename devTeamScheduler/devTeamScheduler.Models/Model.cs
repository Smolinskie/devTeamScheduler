namespace devTeamScheduler.Models
{
    using MySql.Data.Entity;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Linq;

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Model : DbContext
    {
        // Your context has been configured to use a 'Model' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'devTeamScheduler.Models.Model' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model' 
        // connection string in the application configuration file.
        public Model()
            : base("name=Model")
        {
        }

        public Model(DbConnection conn) : base(conn, false) { }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Entry> Entries { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    public class User {
        [Key]
        public int UID { get; set; }
        [Required]
        public string fName { get; set; }
        [Required]
        public string lName { get; set; }
        [Required]
        public string uName { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string email { get; set; }
    }

    public class Task {
        [Key]
        public int TID { get; set; }
        [Required]
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string devBranch { get; set; }
        [Required]
        public DateTime dateCreated { get; set; }
        [Required]
        public DateTime dateDue { get; set; }
        [Required]
        public bool completed { get; set; }
        [Required]
        public int UID { get; set; }
    }

    public class Entry {       
        [Key]
        [Column(Order=1)]
        public int EID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int UID { get; set; }
        [Key]
        [Column(Order = 3)]
        public int TID { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public DateTime dateCreated { get; set; }
        [Required]
        public DateTime timeCreated { get; set; }
    }
}
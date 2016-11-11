namespace ContactBook
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ContactBoockContext : DbContext
    {
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactAdress> ContactAdresses { get; set; }
        public virtual DbSet<ContactTelephoneNumber> ContactTelephoneNumber { get; set; }
        public virtual DbSet<TelephoneType> TelephoneTypes { get; set; }
        public virtual DbSet<AdressType> AdressTypes { get; set; }

        // Your context has been configured to use a 'ContactBoockContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ContactBook.ContactBoockContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ContactBoockContext' 
        // connection string in the application configuration file.
        public ContactBoockContext()
            : base("name=ContactBoockContext")
        {
            
        }



        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
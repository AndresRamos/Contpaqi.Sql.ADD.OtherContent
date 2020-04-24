using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Contpaqi.Sql.ADD.OtherContent
{
    public class AddOtherContentDbContext : DbContext
    {
        protected AddOtherContentDbContext()
        {
        }

        protected AddOtherContentDbContext(DbCompiledModel model) : base(model)
        {
        }

        public AddOtherContentDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public AddOtherContentDbContext(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
        {
        }

        public AddOtherContentDbContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
        }

        public AddOtherContentDbContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
        {
        }

        public AddOtherContentDbContext(ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        public virtual DbSet<DocumentContent> DocumentContent { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocumentContent>()
                .Property(e => e.DocumentType)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentContent>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentContent>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentContent>()
                .Property(e => e.SubDirectory)
                .IsUnicode(false);
        }
    }
}
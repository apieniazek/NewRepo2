namespace WcfService2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Gry_model : DbContext
    {
        public Gry_model()
            : base("name=Gry_model")
        {
        }

        public virtual DbSet<Gatunek> Gatunek { get; set; }
        public virtual DbSet<Gry> Gry { get; set; }
        public virtual DbSet<Oceny> Oceny { get; set; }
        public virtual DbSet<Producent> Producent { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gatunek>()
                .Property(e => e.Nazwa)
                .IsFixedLength();

            modelBuilder.Entity<Gry>()
                .Property(e => e.Tytul)
                .IsFixedLength();

            modelBuilder.Entity<Gry>()
                .Property(e => e.Kraj)
                .IsFixedLength();

            modelBuilder.Entity<Producent>()
                .Property(e => e.Nazwa)
                .IsFixedLength();

            modelBuilder.Entity<Producent>()
                .Property(e => e.Zalozyciel)
                .IsFixedLength();
        }
    }
}

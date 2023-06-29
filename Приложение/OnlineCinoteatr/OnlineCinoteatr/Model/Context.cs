using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OnlineCinoteatr.Model
{
    public partial class Context : DbContext
    {
        public Context(string connectionString)
            : base(connectionString)
        {
        }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Builder> Builders { get; set; }
        public virtual DbSet<DeleteUser> DeleteUsers { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<FilmActor> FilmActors { get; set; }
        public virtual DbSet<FilmBuilder> FilmBuilders { get; set; }
        public virtual DbSet<FilmZhanr> FilmZhanrs { get; set; }
        public virtual DbSet<Podpiska> Podpiskas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserPodpiska> UserPodpiskas { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ViewsFilmsUser> ViewsFilmsUsers { get; set; }
        public virtual DbSet<Zhanr> Zhanrs { get; set; }
        public virtual DbSet<UsersView> UsersViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Actor>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Actor>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Actor>()
                .HasMany(e => e.FilmActors)
                .WithRequired(e => e.Actor)
                .HasForeignKey(e => e.ID_Actora);

            modelBuilder.Entity<Builder>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Builder>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Builder>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Builder>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Builder>()
                .Property(e => e.Post)
                .IsUnicode(false);

            modelBuilder.Entity<DeleteUser>()
                .Property(e => e.Users_Surname)
                .IsUnicode(false);

            modelBuilder.Entity<DeleteUser>()
                .Property(e => e.Users_Name)
                .IsUnicode(false);

            modelBuilder.Entity<DeleteUser>()
                .Property(e => e.Users_Login)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.FilmName)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.AgeRestriction)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.FilmDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.Repertuar)
                .IsUnicode(false);

            modelBuilder.Entity<Podpiska>()
                .Property(e => e.NamePodpiska)
                .IsUnicode(false);

            modelBuilder.Entity<Podpiska>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<UserPodpiska>()
                .Property(e => e.SrokDeistvia)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserLogin)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Zhanr>()
                .Property(e => e.ZhanrName)
                .IsUnicode(false);

            modelBuilder.Entity<UsersView>()
                .Property(e => e.Название_фильма)
                .IsUnicode(false);

            modelBuilder.Entity<UsersView>()
                .Property(e => e.Фамилия)
                .IsUnicode(false);

            modelBuilder.Entity<UsersView>()
                .Property(e => e.Имя)
                .IsUnicode(false);

            modelBuilder.Entity<UsersView>()
                .Property(e => e.Логин)
                .IsUnicode(false);
        }
    }
}

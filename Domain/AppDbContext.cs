using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;

namespace WebApp.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { set; get; }

        public DbSet<ServiceItem> ServiceItems { set; get; }
        public DbSet<Processor> Processors { set; get; }
        public DbSet<Motherboard> Motherboards { set; get; }
        public DbSet<Component> Components { set; get; }
        public DbSet<Videoadapter> Videoadapters { set; get; }
        public DbSet<StorageDevice> StorageDevices { set; get; }
        public DbSet<SoundCard> SoundCards { set; get; }
        public DbSet<PowerUnit> PowerUnits { set; get; }

        public IQueryable<ServiceItem> ServiceItem { get; internal set; }

        public IQueryable<Processor> Processor { get; internal set; }

        public IQueryable<Motherboard> Motherboard { get; internal set; }

        public IQueryable<Component> Component { get; internal set; }
        public IQueryable<Videoadapter> Videoadapter { get; internal set; }
        public IQueryable<StorageDevice> StorageDevice { get; internal set; }
        public IQueryable<SoundCard> SoundCard { get; internal set; }
        public IQueryable<PowerUnit> PowerUnit { get; internal set; }

        public object Response { get; internal set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Создание новой роли
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "ca761232-ed42-11ce-bacd-00aa0057b223",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            // Создание нового пользователя
            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "ca761232-ed42-11ce-bacd-00aa0057b223",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "bloody@yandex.ru",
                NormalizedEmail = "BLOODY@YANDEX.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "supperpassword"),
                SecurityStamp = string.Empty
            });

            // Связь пользователь-роль
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "ca761232-ed42-11ce-bacd-00aa0057b223",
                UserId = "ca761232-ed42-11ce-bacd-00aa0057b223"
            });

            // Создание текстового поля
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("3C345AF4-2678-4A3A-A170-4433E0CAA87C"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            // Создание текстового поля
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("5A315AF2-D467-4B53-AD25-043EFE4CBDD7"),
                CodeWord = "PageServices",
                Title = "Услуги"
            });

            // Создание текстового поля
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("419B11CA-1CFE-4789-B86A-BE0C4F19F98C"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
        }
    }
}

using BNState.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BNState.Domain.Data
{
    public class ApplicationDbContext : IdentityDbContext<Profile, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Image> PropertyImages { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<LocalGoverment> LocalGoverments { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<OgAppointment> OgAppointments { get; set; }
        public DbSet<OgLevel1> OgLevel1s { get; set; }
        public DbSet<OgLevel2> OgLevel2s { get; set; }
        public DbSet<OgLevel3> OgLevel3s { get; set; }
        public DbSet<OgLevel4> OgLevel4s { get; set; }
        public DbSet<OgLevel5> OgLevel5s { get; set; }
        public DbSet<OgLevel6> OgLevel6s { get; set; }
        public DbSet<OgLevel7> OgLevel7s { get; set; }
        public DbSet<OgLevel8> OgLevel8s { get; set; }
        public DbSet<OgLevel9> OgLevel9s { get; set; }
        public DbSet<CategoryAppointment> CategoryAppointments { get; set; }
        public DbSet<Category1> Category1s { get; set; }
        public DbSet<Category2> Category2s { get; set; }
        public DbSet<Category3> Category3s { get; set; }
        public DbSet<Category4> Category4s { get; set; }
        public DbSet<Category5> Category5s { get; set; }
        public DbSet<Category6> Category6s { get; set; }
        public DbSet<Category7> Category7s { get; set; }
        public DbSet<Category8> Category8s { get; set; }
        public DbSet<Category9> Category9s { get; set; }
    }
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=SQL5110.site4now.net;Database=db_a6fbb5_bn;User Id=db_a6fbb5_bn_admin;Password=Admin@123;MultipleActiveResultSets=true");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
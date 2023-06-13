using Microsoft.EntityFrameworkCore;
using DragonxTeamBackend.Models;


namespace DragonxTeamBackend.Db {
    public class ServerContext : DbContext {

        public ServerContext(DbContextOptions options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
            modelBuilder.Entity<UserClientModel>()
                .HasKey(user => user.id_user);

            modelBuilder.Entity<UserExtraInfoModel>()
                .HasKey(user_info => user_info.id_user_info);

            modelBuilder.Entity<UserExtraInfoModel>()
                .HasOne(user => user.Forkey_User).WithOne(user => user.Forkey_User_Info)
                .HasForeignKey<UserExtraInfoModel>(user => user.id_user);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=.;Initial Catalog=gameserver1;Integrated Security=True; Encrypt=False;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<UserClientModel> DbUserClient {get; set;}
        public DbSet<UserExtraInfoModel> DbUserInfo {get; set;}

    }
}

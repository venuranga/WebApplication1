using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace CarAuction
{

    public class AuctionContext : DbContext
    {
        public AuctionContext(DbContextOptions<AuctionContext> options) : base(options) { }



        // DbSet properties for each entity
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public DbSet<Address> Address { get; set; }

        public AuctionContext()
        {

        }




        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the one-to-many relationship between User and Bid
            modelBuilder.Entity<User>()
                .HasMany(u => u.Bids)
                .WithOne(b => b.User)
                .HasForeignKey(b => b.UserId);

            // Configure the one-to-many relationship between Car and Bid
            modelBuilder.Entity<Car>()
                .HasMany(c => c.Bids)
                .WithOne(b => b.Car)
                .HasForeignKey(b => b.CarId);

            // Configure the one-to-one relationship between Auction and Payment
            modelBuilder.Entity<Auction>()
                .HasOne(a => a.Payment)
                .WithOne(p => p.Auction)
                .HasForeignKey<Payment>(p => p.AuctionId);

            // Configure the many-to-one relationship between User and Address
            modelBuilder.Entity<User>()
            .HasOne(u => u.Address)
            .WithMany()
                .HasForeignKey(u => u.AddressId);
        }
        */

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings

            String ConStr = "Server=127.0.0.1;Database=CarAuctionDb;password=iamleVenu98#;uid=root";


    
            options.UseMySql(ConStr, ServerVersion.AutoDetect(ConStr));
        }
    }

}


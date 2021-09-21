using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;

#nullable disable

namespace ShopWebData
{
    public partial class ShopWebContext : IdentityDbContext<User>, IDataProtectionKeyContext
    {
        public ShopWebContext()
        {
        }

        public ShopWebContext(DbContextOptions<ShopWebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adress> Adresses { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<MenuItem> Menu { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Image> Images { get; set; }        
        public virtual DbSet<DeliveryTime> DeliveryTimes { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<ShopsAdresses> ShopsAdresses { get; set; }
        public virtual DbSet<Gift> Gifts { get; set; }
        public virtual DbSet<Statistics> Statistics { get; set; }
        public virtual DbSet<ProductCollection> ProductCollections { get; set; }
        public virtual DbSet<ProductInCollection> ProductsInCollection { get; set; }
        public virtual DbSet<DeliveryPriceTag> DeliveryPriceTags { get; set; }
        public virtual DbSet<DataProtectionKey> DataProtectionKeys { get; set; }


        public static string ConnectionString = "";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.EnableSensitiveDataLogging();           

            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDbFunction(() => StringExtensions.Translate(default, default, default)); // define sql built-in function

            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");
            modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products);

                entity.HasMany(product => product.Images)                
                    .WithOne(image => image.Product)
                    .HasForeignKey(image => image.ProductId)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.Cascade);
            });


            modelBuilder.Entity<ProductCollection>(entity =>
            {
                entity.HasMany(d => d.Products);
            });

            modelBuilder.Entity<ProductInCollection>(entity =>
            {
                entity.HasOne(d => d.Product);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasMany(p => p.Images)
                    .WithOne(p => p.Category)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasMany(c => c.CartItems)
                      .WithOne(e => e.Cart);

                entity.Property(c => c.Status)
                      .HasConversion<int>();
            });


            modelBuilder.Entity<User>()
                .HasMany(u => u.Adresses)
                .WithOne(adress => adress.User);

            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.Property(c => c.Type)
                    .HasConversion<int>();

                entity.HasMany(p => p.Images)
                    .WithOne(p => p.MenuItem)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(p => p.Parent);
            });

            modelBuilder.Entity<Gift>(entity =>
            {
                entity.HasOne(gift => gift.Cart).WithMany(cart => cart.Gifts);
                entity.HasOne(gift => gift.Product);
            });

            modelBuilder.Entity<Shop>()
                .HasMany(p => p.Adresses)
                .WithMany(p => p.Shops)
                .UsingEntity<ShopsAdresses>(
                    j => j
                        .HasOne(pt => pt.Adress)
                        .WithMany(t => t.ShopAdresses)
                        .HasForeignKey(pt => pt.AdressId),
                    j => j
                        .HasOne(pt => pt.Shop)
                        .WithMany(p => p.ShopsAdresses)
                        .HasForeignKey(pt => pt.ShopId),
                    j =>
                    {
                        j.Property(pt => pt.SequentialNumber);
                        j.HasKey(t => new { t.ShopId, t.AdressId });
                    });
            OnModelCreatingPartial(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

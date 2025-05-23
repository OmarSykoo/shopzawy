using Microsoft.EntityFrameworkCore;
using Modules.Common.Infrastructure;
using Modules.Orders.Domain.Entities;
using Modules.Orders.Infrastructure.EntityConfig;
using Modules.Orders.Infrastructure.EntityConfig.TranslationEntityConfig;

namespace Modules.Orders.Infrastructure.Data;

public class OrdersDbContext(DbContextOptions<OrdersDbContext> Options) :
    DbContext(Options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductTranslation> ProductTranslations { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<BrandTranslation> BrandTranslations { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Banner> banners { get; set; }
    public DbSet<ProductItem> ProductItems { get; set; }
    public DbSet<ProductItemOptions> ProductItemOptions { get; set; }
    public DbSet<Specification> Specifications { get; set; }
    public DbSet<SpecificationTranslation> SpecificationTranslations { get; set; }
    public DbSet<SpecificationOption> SpecificationOptions { get; set; }
    public DbSet<CategorySpec> CategorySpecs { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(Schemas.Orders);
        modelBuilder.ApplyConfiguration<ProductItemOptions>(new ProductItemOptionsConfig());
        modelBuilder.ApplyConfiguration<ProductItem>(new ProductItemConfig());
        modelBuilder.ApplyConfiguration<SpecificationOption>(new SpecOptionConfig());
        modelBuilder.ApplyConfiguration<Banner>(new BannerConfig());
        modelBuilder.ApplyConfiguration<Brand>(new BrandConfig());
        modelBuilder.ApplyConfiguration<BrandTranslation>(new BrandTranslationConfig());
        modelBuilder.ApplyConfiguration<Category>(new CategoryConfig());
        modelBuilder.ApplyConfiguration<CategoryTranslation>(new CategoryTranslationConfig());
        modelBuilder.ApplyConfiguration<Specification>(new SpecConfig());
        modelBuilder.ApplyConfiguration<SpecificationTranslation>(new SpecificationTranslationConfig());
        modelBuilder.ApplyConfiguration<Product>(new ProductConfig());
        modelBuilder.ApplyConfiguration<ProductTranslation>(new ProductTranslationConfig());
        modelBuilder.ApplyConfiguration<Vendor>(new VendorConfig());
        modelBuilder.ApplyConfiguration<Color>(new ColorConfig());
        modelBuilder.ApplyConfiguration<CategorySpec>(new CategorySpecConfig());
    }
}

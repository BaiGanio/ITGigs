using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DBContectConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var services = new ServiceCollection();
                services.AddDbContext<BillingContext>(options => options.UseSqlServer(
                     //"Server=.;Database=Billing; User ID=fourhundred;Password=qheGm6;"
                     "Data Source=LK\\SQLEXPRESS;Initial Catalog=Billing;Persist Security Info=True;User ID=fourhundred;Password=qheGm6;",
                    builder =>
                {
                    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
                })); //Persist Security Info=True;User ID=fourhundred;Password=qheGm6; MultipleActiveResultSets=true;

                var serviceProvider = services.BuildServiceProvider();
                var _appDbContext = serviceProvider.GetService<BillingContext>();

                var somth = _appDbContext.BillType.ToList();
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(somth, Newtonsoft.Json.Formatting.Indented);
                Console.WriteLine(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }

    public class BillingContext : DbContext
    {
        public BillingContext(DbContextOptions<BillingContext> options)
            : base(options) { }

        public DbSet<BillType> BillType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public class BillType 
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }}
    }

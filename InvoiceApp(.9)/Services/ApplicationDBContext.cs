using InvoiceApp_._9_.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApp_._9_.Services
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationDBContext()
        {
        }

        public DbSet<Invoice> invoices { get; set; } = null!;

    }
}

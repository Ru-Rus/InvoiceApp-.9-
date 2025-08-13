using InvoiceApp_._9_.Models;
using InvoiceApp_._9_.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvoiceApp_._9_.Pages.invoices
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext Content;
        public List<Invoice> invoiceList = new();

        public IndexModel(ApplicationDBContext context)
        {
            this.Content = context;

        }

        public void OnGet()
        {
            invoiceList = Content.invoices.OrderByDescending(i => i.ID).ToList();
        }
    }
}

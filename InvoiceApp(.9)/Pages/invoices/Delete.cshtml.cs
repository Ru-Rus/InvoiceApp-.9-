using InvoiceApp_._9_.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvoiceApp_._9_.Pages.invoices
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDBContext context;

        public DeleteModel(ApplicationDBContext context)
        {
            this.context = context;
        }

        public IActionResult OnGet( int id)
        {
            var invoice = context.invoices.Find(id);
            if(invoice != null)
            {
                context.invoices.Remove(invoice);
                context.SaveChanges();
            }

            return RedirectToPage("/invoices/Index");

        }
    }
}

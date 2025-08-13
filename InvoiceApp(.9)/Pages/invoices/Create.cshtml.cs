using InvoiceApp_._9_.Models;
using InvoiceApp_._9_.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvoiceApp_._9_.Pages.invoices
{
    public class CreateModel : PageModel
    {
        private ApplicationDBContext context;

        [BindProperty]
        public InvoicesDto InvoicesDto { get; set; } = new();

        public CreateModel(ApplicationDBContext context)
        {
            this.context = context;
        }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); 
            }
            //else if (ModelState.IsValid)
            //{
            //    RedirectToPage("Index");
            //}

            var invoice = new Invoice
            {
                number = InvoicesDto.number,
                status = InvoicesDto.status,
                issueDate = InvoicesDto.issueDate,
                dueDate = InvoicesDto.dueDate,

                service = InvoicesDto.service,
                unitPrice = InvoicesDto.unitPrice,
                quantity = InvoicesDto.quantity,

                clientName = InvoicesDto.clientName,
                email = InvoicesDto.email,
                phone = InvoicesDto.phone,
                address = InvoicesDto.address
            };

            context.invoices.Add(invoice);
            context.SaveChanges();

            return RedirectToPage("/invoices/Index");
        }
    }
}

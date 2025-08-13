using InvoiceApp_._9_.Models;
using InvoiceApp_._9_.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvoiceApp_._9_.Pages.invoices
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public InvoicesDto InvoicesDto { get; set; } = new();

        [BindProperty]
        public Invoice Invoice { get; set; } = new();


        private readonly ApplicationDBContext context;
        public EditModel(ApplicationDBContext context)
        {
            this.context = context; 
        }



        public IActionResult OnGet(int id)
        {
            var invoice = context.invoices.Find(id);
            if(invoice == null)
            {
                return RedirectToPage("/invoices/Index");
            }
            else
            {
                Invoice = invoice;
                InvoicesDto.number = invoice.number;
                InvoicesDto.status = invoice.status;
                InvoicesDto.issueDate = invoice.issueDate;
                InvoicesDto.dueDate = invoice.dueDate;

                InvoicesDto.service = invoice.service;
                InvoicesDto.unitPrice = invoice.unitPrice;
                InvoicesDto.quantity = invoice.quantity;

                InvoicesDto.clientName = invoice.clientName;
                InvoicesDto.email = invoice.email;
                InvoicesDto.phone = invoice.phone;
                InvoicesDto.address = invoice.address;

                return Page();
            }
        }

        public IActionResult OnPost(int id)
        {
            var invoice = context.invoices.Find(id);
            if(invoice == null)
            {
                return RedirectToPage("/invoice/Index");
            }
            Invoice = invoice;

            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                invoice.number = InvoicesDto.number;
                invoice.status = InvoicesDto.status;
                invoice.issueDate = InvoicesDto.issueDate;
                invoice.dueDate = InvoicesDto.dueDate;

                invoice.service = InvoicesDto.service;
                invoice.unitPrice = InvoicesDto.unitPrice;
                invoice.quantity = InvoicesDto.quantity;

                invoice.clientName = InvoicesDto.clientName;
                invoice.email = InvoicesDto.email;
                invoice.phone = InvoicesDto.phone;
                invoice.address = InvoicesDto.address;

                context.SaveChanges();

                successMsg = "Invoice Update Successfully";

                return Page();

            }
        }
        public string successMsg = "";

    }
}

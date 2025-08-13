using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace InvoiceApp_._9_.Models
{
    public class InvoicesDto
    {
        [Required]
        public string number { get; set; } = "";
        [Required]
        public string status { get; set; } = ""; //Paid or Pending 
        public DateOnly? issueDate { get; set; }
        public DateOnly? dueDate { get; set; }

        //Service
        [Required]
        public string service { get; set; } = "";
        [Range(1,9999999, ErrorMessage ="Invalid Unit Price")]
        public decimal unitPrice { get; set; }
        [Range (1,99)]
        public int quantity { get; set; }

        //client details
        [Required(ErrorMessage ="Client Name is Required")]
        public string clientName { get; set; } = "";
        [Required, EmailAddress]
        public string email { get; set; } = "";
        [Phone]
        public string phone { get; set; } = "";
        public string address { get; set; } = "";
    }
}

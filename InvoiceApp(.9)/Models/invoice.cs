using Microsoft.EntityFrameworkCore;

namespace InvoiceApp_._9_.Models
{
    public class Invoice
    {
        public int ID { get; set; }
        public string number { get; set; } = "";
        public string status { get; set; } = ""; //Paid or Pending 
        public DateOnly? issueDate { get; set; }
        public DateOnly? dueDate { get; set; }

        //Service
        public string service { get; set; } = "";
        [Precision(16,2)]
        public decimal unitPrice { get; set; }
        public int quantity { get; set; }

        //client details
        public string clientName { get; set; } = "";
        public string email { get; set; } = "";
        public string phone { get; set; } = "";
        public string address { get; set; } = "";
    }
}

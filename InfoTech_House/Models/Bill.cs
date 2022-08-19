using System.ComponentModel.DataAnnotations;

namespace InfoTech_House.Models
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime? BillDate { get; set; }
        public decimal BillAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public DateTime? PaidDate { get; set; }
        public Customer Customer { get; set; }
    }
}

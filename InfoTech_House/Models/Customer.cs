using System.ComponentModel.DataAnnotations;

namespace InfoTech_House.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Bill> Bills { get; set; }
    }
}


using InfoTech_House.Models;

namespace InfoTech_House
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bill> lists = new List<Bill>
            {
               new Bill{Id = 2, BillAmount = 3000,PaidAmount = 2000, BillDate = DateTime.Parse("2020-07-01"), CustomerId = 2},
               new Bill{Id = 3, BillAmount = 2000,PaidAmount = 0, BillDate = DateTime.Parse("2020-08-01"), CustomerId = 3},
               new Bill{Id = 4, BillAmount = 1000,PaidAmount = 0, BillDate = DateTime.Parse("2020-08-01"), CustomerId = 4},
               new Bill{Id = 5, BillAmount = 5000,PaidAmount = 4000, BillDate = DateTime.Parse("2020-08-01"), CustomerId = 5},
               new Bill{Id = 6, BillAmount = 1000,PaidAmount = 0, BillDate = DateTime.Parse("2020-08-01"), CustomerId = 6}
            };
            decimal amountToMatch = 1000;
            var resultIds = GetPossibleCustomerIdsForOutstandingAmount(lists, amountToMatch);
            string customerIds = string.Empty;
            foreach (var result in resultIds)
            {
                customerIds = customerIds + $"{result.ToString()}\n";
            }
            Console.WriteLine($"{customerIds}");
        }

        static IEnumerable<int> GetPossibleCustomerIdsForOutstandingAmount(List<Bill> outstandingBills, decimal amountToMatch)
        {
            List<Bill> bills = new List<Bill>();

            bills = outstandingBills.Where(x => (x.BillAmount == amountToMatch || (x.BillAmount - x.PaidAmount) == amountToMatch) && x.PaidDate == null).ToList();

            List<int> possibleCustomerIds = new List<int>();
            foreach (var item in bills)
            {
                possibleCustomerIds.Add(item.Id);
            }
            return possibleCustomerIds;
        }

    }


}
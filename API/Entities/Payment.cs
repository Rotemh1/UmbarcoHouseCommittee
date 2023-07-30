
namespace API.Entities
{
    public class Payment
    {
         public int Id { get; set; }
        public int AptNum { get; set; }
        public string ResName { get; set; }
        public Month PayMonth { get; set; }
        public int Amount { get; set; }
        public PayMethod PayedWith { get; set; }
    }
    public enum Month{
        Jan = 1,
        Feb = 2,
        Mar = 3,
        Apr = 4,
        May = 5,
        Jun = 6,
        Jul = 7,
        Aug = 8,
        Sep = 9,
        Oct = 10,
        Nov = 11,
        Dec = 12
    }
    public enum PayMethod{
        CreditCard = 1,
        Cash = 2,
        Transfer = 3,
        checkPayment = 4
    }
}
namespace Domain.Entities
{
    public class Employee_Shop
    {
        public int IdEmployee { get; set; }
        public int IdShop { get; set; }
        public DateTime Date { get; set; }
        public bool IsSupervisor { get; set; }

    }
}

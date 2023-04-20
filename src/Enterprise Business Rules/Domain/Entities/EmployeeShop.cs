namespace Domain.Entities
{
    public class EmployeeShop
    {
        public int IdEmployee { get; set; }
        public int IdShop { get; set; }
        public DateTime Date { get; set; }
        public bool IsSupervisor { get; set; }

    }
}

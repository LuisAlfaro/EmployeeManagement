using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class EmployeeShopDTO
    {
        public int IdEmployee { get; set; }
        public int IdShop { get; set; }
        public DateTime Date { get; set; }
        public bool IsSupervisor { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CreateEmployeeDTO
    {
        public string Name { get; init; }
        public int Type { get; init; }
        public string Telephone { get; init; }
        public string Address { get; init; }
        public DateTime EmploymentDate { get; init; }
    }
}

using Application.DTOs;
using Application.UseCases.EmployeeUseCases.GeAllEmployees;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.EmployeeShopUseCases.AssignEmployeeShop
{
    public class AssignEmployeeShopInteractor : IAssignEmployeeShopInputPort
    {
        readonly IEmployeeShopRepository EmployeeShopRepository;
        readonly IUnitOfWork UnitOfWork;
        readonly IAssignEmployeeShopOutputPort OutputPort;

        public AssignEmployeeShopInteractor(IEmployeeShopRepository employeeShopRepository,
            IUnitOfWork unitOfWork,
            IAssignEmployeeShopOutputPort outputPort) =>
            (EmployeeShopRepository, UnitOfWork, OutputPort) = (employeeShopRepository, unitOfWork, outputPort);

        public async Task Handle(AssignEmployeeShopDTO assignEmployeeShopDTO)
        {

            EmployeeShop newEmployeeShop = new EmployeeShop
            {
                IdEmployee = assignEmployeeShopDTO.IdEmployee,
                IdShop = assignEmployeeShopDTO.IdShop,
                Date = assignEmployeeShopDTO.Date,
                IsSupervisor = assignEmployeeShopDTO.IsSupervisor,
            };

            EmployeeShopRepository.CreateEmployeeShop(newEmployeeShop);
            await UnitOfWork.SaveChanges();
            await OutputPort.Handle(
                new EmployeeShopDTO
                {
                    IdEmployee = newEmployeeShop.IdEmployee,
                    IdShop = newEmployeeShop.IdShop,
                    Date = newEmployeeShop.Date,
                    IsSupervisor = newEmployeeShop.IsSupervisor,
                }
                );

        }
    }
}

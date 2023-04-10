using Application.DTOs;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;

namespace Application.UseCases.EmployeeUseCases.DeleteEmployee
{
    public class DeleteEmployeeInteractor : IDeleteEmployeeInputPort
    {
        readonly IEmployeeRepository EmployeeRepository;
        readonly IUnitOfWork UnitOfWork;
        readonly IDeleteEmployeeOutputPort OutputPort;

        public DeleteEmployeeInteractor(IEmployeeRepository employeeRepository,
            IUnitOfWork unitOfWork,
            IDeleteEmployeeOutputPort outputPort) =>
            (EmployeeRepository, UnitOfWork, OutputPort) =
            (employeeRepository, unitOfWork, outputPort);

        public async Task Handle(int id)
        {
            
            EmployeeRepository.DeleteEmployee(id);
            await UnitOfWork.SaveChanges();
            await OutputPort.Handle();
        }
    }
}

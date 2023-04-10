using Application.DTOs;
using Application.UseCases.EmployeeUseCases.CreateEmployee;
using Microsoft.AspNetCore.Mvc;
using Presenters;

namespace Controllers.Employee
{
    [Route("api/employee")]
    [ApiController]
    public class CreateEmployeeController
    {
        readonly ICreateEmployeeInputPort InputPort;
        readonly ICreateEmployeeOutputPort OutputPort;

        public CreateEmployeeController(ICreateEmployeeInputPort inputPort,
         ICreateEmployeeOutputPort outputPort) =>
            (InputPort, OutputPort) = (inputPort, outputPort);


        [HttpPost]
        public async Task<EmployeeDTO> CreateEmployee(CreateEmployeeDTO employee)
        {
            await InputPort.Handle(employee);
            return ((IPresenter<EmployeeDTO>)OutputPort).Content;
        }

    }
}

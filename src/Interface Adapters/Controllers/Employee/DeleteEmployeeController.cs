using Application.DTOs;
using Application.UseCases.EmployeeUseCases.CreateEmployee;
using Application.UseCases.EmployeeUseCases.DeleteEmployee;
using Microsoft.AspNetCore.Mvc;
using Presenters;

namespace Controllers.Employee
{
    [Route("api/employee/{id}")]
    [ApiController]
    public class DeleteEmployeeController
    {
        readonly IDeleteEmployeeInputPort InputPort;
        readonly IDeleteEmployeeOutputPort OutputPort;

        public DeleteEmployeeController(IDeleteEmployeeInputPort inputPort,
         IDeleteEmployeeOutputPort outputPort) =>
            (InputPort, OutputPort) = (inputPort, outputPort);


        [HttpDelete]
        public async Task CreateEmployee(int id)
        {
            await InputPort.Handle(id);            
        }

    }
}

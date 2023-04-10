using Application.DTOs;
using Application.UseCases.EmployeeUseCases.CreateEmployee;
using Application.UseCases.EmployeeUseCases.UpdateEmployee;
using Microsoft.AspNetCore.Mvc;
using Presenters;

namespace Controllers.Employee
{
    [Route("api/employee/{id}")]
    [ApiController]
    public class UpdateEmployeeController
    {
        readonly IUpdateEmployeeInputPort InputPort;
        readonly IUpdateEmployeeOutputPort OutputPort;

        public UpdateEmployeeController(IUpdateEmployeeInputPort inputPort,
         IUpdateEmployeeOutputPort outputPort) =>
            (InputPort, OutputPort) = (inputPort, outputPort);


        [HttpPut]
        public async Task<EmployeeDTO> UpdateEmployee(int id, EmployeeDTO employee)
        {
            await InputPort.Handle(employee);
            return ((IPresenter<EmployeeDTO>)OutputPort).Content;
        }

    }
}

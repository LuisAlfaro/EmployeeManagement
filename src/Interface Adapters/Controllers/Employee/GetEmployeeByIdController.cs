using Application.DTOs;
using Application.UseCases.EmployeeUseCases.GeAllEmployees;
using Application.UseCases.EmployeeUseCases.GetEmployeeById;
using Microsoft.AspNetCore.Mvc;
using Presenters;

namespace Controllers.Employee
{
    [Route("api/employee/{id}")]
    [ApiController]
    public class GetEmployeeByIdController
    {
        readonly IGetEmployeeByIdInputPort InputPort;
        readonly IGetEmployeeByIdOutputPort OutputPort;

        public GetEmployeeByIdController(IGetEmployeeByIdInputPort inputPort,
         IGetEmployeeByIdOutputPort outputPort) =>
            (InputPort, OutputPort) = (inputPort, outputPort);


        [HttpGet]
        public async Task<EmployeeDTO> GetEmployeeById(int id)
        {
            await InputPort.Handle(id);
            return ((IPresenter<EmployeeDTO>)OutputPort).Content;
        }
    }
}

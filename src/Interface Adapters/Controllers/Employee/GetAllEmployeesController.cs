using Application.DTOs;
using Application.UseCases.EmployeeTypeUseCases.GeAllEmployeeTypes;
using Application.UseCases.EmployeeUseCases.GeAllEmployees;
using Microsoft.AspNetCore.Mvc;
using Presenters;

namespace Controllers.Employee
{
    [Route("api/employee/")]
    [ApiController]    
    public class GetAllEmployeesController
    {
        readonly IGetAllEmployeesInputPort InputPort;
        readonly IGetAllEmployeesOutputPort OutputPort;

        public GetAllEmployeesController(IGetAllEmployeesInputPort inputPort,
         IGetAllEmployeesOutputPort outputPort) =>
            (InputPort, OutputPort) = (inputPort, outputPort);


        [HttpGet]
        public async Task<IEnumerable<EmployeeDTO>> GetAllEmployees()
        {
            await InputPort.Handle();
            return ((IPresenter<IEnumerable<EmployeeDTO>>)OutputPort).Content;
        }
    }
}

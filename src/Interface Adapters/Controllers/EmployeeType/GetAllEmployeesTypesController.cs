using Application.DTOs;
using Application.UseCases.EmployeeTypeUseCases.GeAllEmployeeTypes;
using Microsoft.AspNetCore.Mvc;
using Presenters;

namespace Controllers.Employee
{
    [Route("api/employeetype/")]
    [ApiController]    
    public class GetAllEmployeesTypesController
    {
        readonly IGetAllEmployeeTypesInputPort InputPort;
        readonly IGetAllEmployeeTypesOutputPort OutputPort;

        public GetAllEmployeesTypesController(IGetAllEmployeeTypesInputPort inputPort,
         IGetAllEmployeeTypesOutputPort outputPort) =>
            (InputPort, OutputPort) = (inputPort, outputPort);


        [HttpGet]
        public async Task<IEnumerable<EmployeeTypeDTO>> GetAllEmployeeTypes()
        {
            await InputPort.Handle();
            return ((IPresenter<IEnumerable<EmployeeTypeDTO>>)OutputPort).Content;
        }
    }
}

using Application.DTOs;
using Application.UseCases.EmployeeShopUseCases.AssignEmployeeShop;
using Application.UseCases.EmployeeUseCases.CreateEmployee;
using Microsoft.AspNetCore.Mvc;
using Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.EmployeeShop
{
    [Route("api/employeeshop/")]
    [ApiController]
    public class AssingEmployeeShopController
    {
        readonly IAssignEmployeeShopInputPort InputPort;
        readonly IAssignEmployeeShopOutputPort OutputPort;

        public AssingEmployeeShopController(IAssignEmployeeShopInputPort inputPort,
         IAssignEmployeeShopOutputPort outputPort) =>
            (InputPort, OutputPort) = (inputPort, outputPort);


        [HttpPost]
        public async Task<EmployeeShopDTO> AssingEmployeeShop(AssignEmployeeShopDTO assignEmployeeShopDTO)
        {
            await InputPort.Handle(assignEmployeeShopDTO);
            return ((IPresenter<EmployeeShopDTO>)OutputPort).Content;
        }
    }
}

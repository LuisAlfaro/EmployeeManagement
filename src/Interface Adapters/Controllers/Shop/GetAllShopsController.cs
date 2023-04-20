using Application.DTOs;
using Application.UseCases.ShopUseCases.GeAllShops;
using Microsoft.AspNetCore.Mvc;
using Presenters;

namespace Controllers.Employee
{
    [Route("api/shop/")]
    [ApiController]    
    public class GetAllShopsController
    {
        readonly IGeAllShopsInputPort InputPort;
        readonly IGeAllShopsOutputPort OutputPort;

        public GetAllShopsController(IGeAllShopsInputPort inputPort,
         IGeAllShopsOutputPort outputPort) =>
            (InputPort, OutputPort) = (inputPort, outputPort);


        [HttpGet]
        public async Task<IEnumerable<ShopDTO>> GetAllShops()
        {
            await InputPort.Handle();
            return ((IPresenter<IEnumerable<ShopDTO>>)OutputPort).Content;
        }
    }
}

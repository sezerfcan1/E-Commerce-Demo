using ECommerceDemo.Application.Abstractions;
using ECommerceDemo.Application.Repositories;
using ECommerceDemo.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;



        public ProductsController(
            IProductWriteRepository productWriteRepository, 
            IProductReadRepository productReadRepository,
            IOrderWriteRepository orderWriteRepository,
            ICustomerWriteRepository customerWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;


        }

        [HttpGet]
        public async Task Get()
        {
            var product  = _productReadRepository.GetAll().First();
            product.Stock--;
            _productWriteRepository.Update(product);

            await _productWriteRepository.SaveAsync();
        }

    }
}

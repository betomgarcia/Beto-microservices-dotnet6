using GeekShopping.ProductApi.Data.ValueObjects;
using GeekShopping.ProductApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeekShopping.ProductApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProductRepository _repository;

        public ProdutoController(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductVO>>> FindAll()
        {
            var produtos = await _repository.FindAll();

            if (produtos == null) return NotFound();

            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVO>> FindById(long id)
        {
            var produto = await _repository.FindById(id);

            if(produto == null) return NotFound();

            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult<ProductVO>> Create(ProductVO vo)
        {            
            if (vo == null) return BadRequest();

            var produto = await _repository.Create(vo);

            return Ok(produto);
        }

        [HttpPut]
        public async Task<ActionResult<ProductVO>> Update(ProductVO vo)
        {
            if (vo == null) return BadRequest();

            var produto = await _repository.Update(vo);

            return Ok(produto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var retorno = await _repository.Delete(id);
            if(!retorno) return BadRequest();

            return Ok(retorno);
        }
    }
}

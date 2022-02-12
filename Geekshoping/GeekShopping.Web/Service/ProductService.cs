﻿using GeekShopping.Web.Models;
using GeekShopping.Web.Service.IServices;
using GeekShopping.Web.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace GeekShopping.Web.Service
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        public const string BasePath = $"api/v1/Produto";

        public ProductService(HttpClient client)
        {
            _client = client ?? throw new ArgumentException(nameof(client));
        }
        public async Task<IEnumerable<ProductModel>> FindAllProducts()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<ProductModel>>();
        }

        public async Task<ProductModel> FindProductById(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<ProductModel>();
        }

        public async Task<ProductModel> CreateProduct(ProductModel model)
        {
            var response = await _client.PostAsJson(BasePath, model);

            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ProductModel>();
            else throw new Exception("Algo de errado ao chamar API");
        }

        public async Task<ProductModel> UpdateProduct(ProductModel model)
        {
            var response = await _client.PutAsJson(BasePath, model);

            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ProductModel>();
            else throw new Exception("Algo de errado ao chamar API");
        }

        public async Task<bool> DeleteProductById(long id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");

            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<bool>();
            else throw new Exception("Algo de errado ao chamar API");
        }
    }
}
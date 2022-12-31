﻿using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySqlContext _context;
        private IMapper _mapper;

        public ProductRepository(MySqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductVO>> FindAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> FindById(long id)
        {
            Product products = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<ProductVO>(products);
        }

        public async Task<ProductVO> Create(ProductVO vo)
        {
            Product products = _mapper.Map<Product>(vo);
            _context.Products.Add(products);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProductVO>(products);
        }

        public async Task<ProductVO> Update(ProductVO vo)
        {
            Product products = _mapper.Map<Product>(vo);
            _context.Products.Add(products);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProductVO>(products);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Product products = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();

                if (products == null)
                    return false;

                _context.Products.Remove(products);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}

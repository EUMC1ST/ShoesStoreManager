﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityTier;
using CommonTier;

namespace DataTier
{
    public class ProductData
    {
        private DataProductsEntities  _context = new DataProductsEntities ();
        public List<ProductEntity> GetProducts()
        {
            var products = _context.eumc1_getProducts().ToList();
            return Assist.Convert<List<eumc1_getProducts_Result>, List<ProductEntity>>(products); 
        }
        public List<ProductEntity> GetProductByIdOrName(int? id, string name)
        {

            var productObject = _context.eumc1_getProductByIdOrName(id, name).ToList();
            return Assist.Convert<List<eumc1_getProductByIdOrName_Result>, List<ProductEntity>>(productObject);
        }

        public Int32 EditProduct(ProductEntity product)
        {
            var isProductEdited = _context.eumc1_editProduct(
                product.Id,
                product.IdType,
                product.IdColor,
                product.IdBrand,
                product.IdProvider,
                product.IdCatalog,
                product.Nombre,
                product.Title,
                product.Description,
                product.Observations,
                product.PriceDistributor,
                product.PriceClient,
                product.PriceMember,
                product.IsEnabled,
                product.Keywords,
                product.DateUpdate
                );
            return isProductEdited;
        }

        public int DeleteProduct(int productId)
        {
            var isProductDeleted = _context.eumc1_deleteProductById(productId);
            return isProductDeleted;
        }


        public List<CatColors> GetProductColors()
        {
            var productColor = _context.eumc1_getProductColors().ToList();
            return Assist.Convert<List<eumc1_getProductColors_Result>, List<CatColors>>(productColor);
        }

        public int CreateProduct(Product product)
        {

            return 1;
        }

    }
}

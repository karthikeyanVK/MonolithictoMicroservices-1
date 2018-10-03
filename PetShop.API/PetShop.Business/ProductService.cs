#region Copyright PETShop
// All rights are reserved. Reproduction or transmission in whole or in part, in
// any form or by any means, electronic, mechanical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
#endregion

using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using PetShop.DBAccess;
using PetShop.Model;
using Order = PetShop.DBAccess.Order;
using Product = PetShop.Model.Product;

namespace PetShop.Business
{
    public class ProductService 
    {
        public IList<Product> GetData()
        {
            using (var context = new PetShopContext())
            {
                var query = from product in context.Products
                            select
                                new Model.Product
                                {
                                    ProductId =  product.ProductId,
                                    ProductName = product.ProductName,
                                    AvailableQuantity = product.Quantity
                                };
                return query.ToList();
            }
        }

        public bool AddProduct(Product product)
        {
            var dbProduct = new DBAccess.Product
            {
 
                ProductId = product.ProductId == Guid.Empty ? Guid.NewGuid() : product.ProductId,
                ProductName = product.ProductName,
                Quantity = product.AvailableQuantity
            };

            using (var context = new PetShopContext())
            {
                context.Products.AddOrUpdate(dbProduct);
                context.SaveChanges();
            }

            return true;
        }

    }
}
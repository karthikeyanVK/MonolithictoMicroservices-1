#region Copyright PETShop
// All rights are reserved. Reproduction or transmission in whole or in part, in
// any form or by any means, electronic, mechanical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
#endregion

using System.Collections.Generic;
using System.Linq;
using PetShop.DBAccess;
using PetShop.Model;

namespace PetShop.Business
{
    public class SearchService 
    {
        public IList<SearchResult> GetData()
        {
            using (var context = new PetShopContext())
            {
                var query = from product in context.Products
                    select
                        new SearchResult
                        {
                            ProductId = product.ProductId,
                            ProductName = product.ProductName,
                            AvailableQuantity = product.Quantity
                        };
                return query.ToList();
            }
        }

        
    }
}
#region Copyright PETShop
// All rights are reserved. Reproduction or transmission in whole or in part, in
// any form or by any means, electronic, mechanical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
#endregion

using System;
using System.Data.Entity.Migrations;
using PetShop.DBAccess;
using Order = PetShop.DBAccess.Order;

namespace PetShop.Business
{
    public class OrderService 
    {


        public bool SaveData(Model.Order order)
        {
            var orderData = new Order
            {
                OrderId = Guid.NewGuid(),
                ProductId = order.ProductId,
                CustomerId = PetShopDBConfiguration.DefaultCustomerID,
                Quantity = order.Quantity
            };

            using (var context = new PetShopContext())
            {
                context.Orders.AddOrUpdate(orderData);
                context.SaveChanges();
            }

            return true;
        }
    }
}
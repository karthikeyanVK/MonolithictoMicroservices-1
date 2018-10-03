#region Copyright CADS
// All rights are reserved. Reproduction or transmission in whole or in part, in
// any form or by any means, electronic, mechanical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
#endregion

using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace PetShop.DBAccess
{
    public class PetShopDBConfiguration : DbMigrationsConfiguration<PetShopContext>
    {
        public static Guid DefaultCustomerID = Guid.Parse("17EDCACA-C902-431A-B935-A1FCF05CA52A");
        protected override void Seed(PetShopContext context)
        {
            var customer = new List<Customer>
            {
                new Customer
                {
                    CustomerId = DefaultCustomerID,
                    CustomerAddress = "Chennai",
                    CustomerName = "Meetup User"
                }
            };
            customer.ForEach(c=>context.Customers.AddOrUpdate(c));
        }
    }
 
}
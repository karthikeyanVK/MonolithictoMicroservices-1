#region Copyright CADS
// All rights are reserved. Reproduction or transmission in whole or in part, in
// any form or by any means, electronic, mechanical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
#endregion

using System;

namespace PetShop.Model
{
    public class Product
    {
        public string ProductName { get; set; }
        public Guid ProductId { get; set; }
        
        public int AvailableQuantity { get; set; }
    }
}
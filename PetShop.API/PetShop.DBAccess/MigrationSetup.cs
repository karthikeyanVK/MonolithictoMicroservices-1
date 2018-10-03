#region Copyright CADS
// All rights are reserved. Reproduction or transmission in whole or in part, in
// any form or by any means, electronic, mechanical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
#endregion

using System.Data.Entity;

namespace PetShop.DBAccess
{
    public class MigrationSetup
    {
        public static void EnableMigrations()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<PetShopContext, PetShopDBConfiguration>(useSuppliedContext: true));
        }
    }
}
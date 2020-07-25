using System;
using System.Collections.Generic;
using MessageCentral.UI.Bll;

namespace MessageCentral.UI.Data
{
    public class TenantData
    {
        private static List<Tenant> tenantList;
        private static string[] sampleLastNames = { "Smith", "Grant", "Folys", "Flynn", "Anny", "Bonker", "Dongle", "Char", "Ford", "Landers", "Mallard", "Laker", "Taner", "Golis", "Sanders", "Warren", "Buffer"};
        private static string[] sampleFirstNames = { "Bill", "Gil", "Ann", "Frank", "Gio", "Krishan", "Alex", "Rado", "Scott" };

        public TenantData()
        {
        }

        public static List<Tenant> GetTenantList()
        {
            string lastName = string.Empty;
            var rand = new Random();

            if(tenantList == null)
            {
                tenantList = new List<Tenant>();
                for (int i=0;i<100; i++)
                {
                    tenantList.Add(new Tenant()
                    {
                        FirstName = sampleFirstNames[rand.Next(0, 17)],
                        LastName = sampleLastNames[rand.Next(0, 8)],
                        ContactNumber = "810" + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString()
                    }); ;
                }

            }
            return tenantList;
        }
    }
}

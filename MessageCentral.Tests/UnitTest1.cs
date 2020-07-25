using System;
using System.Collections.Generic;
using Xunit;
using MessageCentral.UI.Bll;

namespace MessageCentral.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            MessageService msgService = new MessageService();
            List<Tenant> tenants = msgService.GetTenantsByCriteria("A-F", string.Empty);

            Assert.True(tenants.Count > 0, "Should return more than zero. Returned Count: " + tenants.Count);

        }
    }
}

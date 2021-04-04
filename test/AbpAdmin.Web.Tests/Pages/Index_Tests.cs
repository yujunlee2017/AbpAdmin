using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpAdmin.Pages
{
    public class Index_Tests : AbpAdminWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}

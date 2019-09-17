using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace AbpPermissionCacheTest.Web.Pages
{
    public class IndexModel : AbpPermissionCacheTestPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}
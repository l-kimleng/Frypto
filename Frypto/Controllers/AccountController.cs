using System.Linq;
using System.Net.Http;
using Frypto.BindingModels;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using System.Web.Http;
using Frypto.Core.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using Frypto.Utils;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;

namespace Frypto.Controllers
{
    [Authorize]
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        private ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get => _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            private set => _userManager = value;
        }

        // POST api/Account/Register
        [HttpPost]
        [Route("Register")]
        [Authorize(Roles = RoleName.CanManageUser)]
        public async Task<IHttpActionResult> Register(RegisterBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new ApplicationUser() { UserName = model.Email, Email = model.Email };

            var result = await UserManager.CreateAsync(user, model.Password);

            //if(result.Succeeded)
            //{
            //    var roleStore = new RoleStore<IdentityRole>(new Frypto.Core.Persistences.FryptoDbContext());
            //    var roleManager = new RoleManager<IdentityRole>(roleStore);
            //    await roleManager.CreateAsync(new IdentityRole("CanManageUser"));
            //    await UserManager.AddToRoleAsync(user.Id, "CanManageUser");
            //}

            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }

            return Ok();
        }

        // POST api/Account/Logout
        [AllowAnonymous]
        [HttpPost]
        [Route("Logout")]
        public IHttpActionResult Logout()
        {
            Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
            return Ok(new { message = "Logout successful!"});
        }

        private IAuthenticationManager Authentication => Request.GetOwinContext().Authentication;

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }
                
                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }
    }
}

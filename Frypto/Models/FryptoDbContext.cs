using Microsoft.AspNet.Identity.EntityFramework;

namespace Frypto.Models
{
    public class FryptoDbContext : IdentityDbContext<ApplicationUser>
    {
        public FryptoDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static FryptoDbContext Create()
        {
            return new FryptoDbContext();
        }
    }
}
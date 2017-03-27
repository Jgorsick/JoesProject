using Microsoft.AspNet.Identity.EntityFramework;

namespace JoesProject.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        
        internal string School;
        internal string StreetAddress;
        internal string City;
        internal string ZipCode;
        internal string MobilePhone;
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
            
        }
       
    }
}
using Abp.Authorization;
using SmartShop.Authorization.Roles;
using SmartShop.Authorization.Users;

namespace SmartShop.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

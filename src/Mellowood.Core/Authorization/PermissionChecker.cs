using Abp.Authorization;
using Mellowood.Authorization.Roles;
using Mellowood.Authorization.Users;

namespace Mellowood.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

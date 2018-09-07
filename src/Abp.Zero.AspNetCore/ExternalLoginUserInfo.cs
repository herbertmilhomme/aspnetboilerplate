using Abp.Extensions;
using Microsoft.AspNet.Identity;

namespace Abp.Zero.AspNetCore
{
    public class ExternalLoginUserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public UserLoginInfo LoginInfo { get; set; }

        public bool HasAllNonEmpty()
        {
            return !FirstName.IsNullOrEmpty() &&
                   !LastName.IsNullOrEmpty() &&
                   !EmailAddress.IsNullOrEmpty();
        }
    }
}
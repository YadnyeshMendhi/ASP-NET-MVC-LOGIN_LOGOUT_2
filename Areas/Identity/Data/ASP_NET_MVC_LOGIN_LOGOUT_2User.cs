using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ASP_NET_MVC_LOGIN_LOGOUT_2.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ASP_NET_MVC_LOGIN_LOGOUT_2User class
public class ASP_NET_MVC_LOGIN_LOGOUT_2User : IdentityUser
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
}


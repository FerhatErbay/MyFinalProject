using System;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper
    {
       public static SecurityKey CreateSecurityKey(string securityKey)
        {
            //SecurityKey secrtyKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
            //return secrtyKey;

            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}

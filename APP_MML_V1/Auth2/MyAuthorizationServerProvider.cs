using APP_MML_V1.Models;
using APP_MML_V1.Utilities;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace APP_MML_V1.Auth2
{
    public class MyAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated(); // 
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);

            if (context.UserName == "web_o_android" && context.Password == "web_o_android")
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, "web_o_android"));
                identity.AddClaim(new Claim("username", "web_o_android"));
                identity.AddClaim(new Claim(ClaimTypes.Name, "web_o_android"));
                context.Validated(identity);
            }
            else
            {                           
                String condigo = context.UserName;
                string pass = Hashing.toAscii(context.Password);
                List<USUARIO> usua = new List<USUARIO>();
                using (AuthRepository authRepo = new AuthRepository())
                {
                    try
                    {
                        usua = authRepo.FindUser(condigo);
                    }
                    catch (Exception error)
                    {
                        context.SetError("QueryError", "Error al hacer la consulta : " + error);
                        return;
                    }
                }
                if ((usua == null) || (usua.Count == 0))
                {
                    context.SetError("QueryError", "Error en las credenciales 404 ");
                    return;
                }
                var aa = usua.First();
                string password = aa.PASSWO;
                string role = Util.noNullString(aa.CARGO);
                string name = Util.noNullString(aa.NOMBRE);
                string codigo = aa.CODIGO;
                password = Hashing.toAsciiFromInter(password);
                if (pass == password)
                {
                    identity.AddClaim(new Claim(ClaimTypes.Role, role));
                    identity.AddClaim(new Claim("username", codigo));
                    identity.AddClaim(new Claim(ClaimTypes.Name, codigo));
                    context.Validated(identity);
                }
                else
                {
                    context.SetError("invalid_grant", "Provided username and password Error ");
                    return;
                }
            }
        }
    }
}
using APP_MML_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace APP_MML_V1.Controllers
{
    public class InfoClientController : ApiController
    {
        private SisacEntities db = new SisacEntities();
        // GET: api/InfoClient
        [Authorize]
        public IEnumerable<USUARIO> Get()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var roles = identity.Claims
                        .Where(c => c.Type == ClaimTypes.Role)
                        .Select(c => c.Value);
            var consulta = db.Database.SqlQuery<USUARIO>(@"SELECT * FROM USUARIO WHERE CODIGO='" + identity.Name + "'").ToList();
            return consulta;
        }

    }
}

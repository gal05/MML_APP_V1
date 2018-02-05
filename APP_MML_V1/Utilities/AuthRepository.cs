using APP_MML_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APP_MML_V1.Utilities
{
    public class AuthRepository : IDisposable
    {
        private SisacEntities usuariosLocalEntities = new SisacEntities();

        public List<USUARIO> FindUser(string userName)
        {
            //password = Hashing.toAscii(password);

            List<USUARIO> usua = new List<USUARIO>();
            usua = usuariosLocalEntities.USUARIO.SqlQuery("SELECT * FROM USUARIO WHERE CODIGO='" + userName + "'").ToList();


            //var usuario= usua.First();

            return usua;


        }

        public void Dispose()
        {
            usuariosLocalEntities.Dispose();
        }
    }
}
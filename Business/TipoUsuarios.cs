using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TipoUsuarios
    {
        #region classificação de usuários
        const int programador = 0;
        const int administrador = 1;
        const int supervisor = 2;
        const int colaborador = 3;
        #endregion
         public static void PermissoesUsuarios(string usertipo)
        {
            var Usuario = new object();
            while (Usuario is "0" or "1" or "2" or "3") {
                if (Usuario.Equals("0"))
                {
                }
                if (Usuario.Equals("1"))
                {
                }
                if (Usuario.Equals("2"))
                {
                }
                if (Usuario.Equals("3"))
                {
                }
                else { } }
        }
    }
}

using Database;
using System.Data;

namespace Business
{
    public class UserLogins
    {
       
        public static DataTable LoginUserBusiness(string text)
        {
            System.IO.StreamReader stream = null;
            DataTable dt = new DataTable();
            var l_user = new Database.Arquivos();
            l_user.LocalArquvios(text);
            return dt;
        }

    }

}
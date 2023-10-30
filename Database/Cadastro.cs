using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System.Data;
using System.IO;
using System.Linq.Expressions;

namespace Database
{
    public class BaseDados
    {
        public string files { get; set; }
        public string lines { get; set; }
        public string text { get; set; }

        #region Database_ParaAjustar
        public void LoginUsers()
        {
               
        var searchfile = System.IO.Path.GetFileName(@"C:\Users\WDAGUtilityAccount\Desktop\Projeto app\BaseDados\\Usuarios");

            while (searchfile != null)
            {

                if (searchfile != null)
                {
                    System.IO.File.ReadAllText(@"C:\Users\WDAGUtilityAccount\Desktop\Projeto app\BaseDados\\Usuarios");
                    Console.WriteLine(searchfile);
                    return;
                }

                string[] lines = { "login,", "senha" };
                System.IO.File.WriteAllLines(@"C:\Users\WDAGUtilityAccount\Desktop\Projeto app\BaseDados\\Usuarios", lines);
                string text = "login" + "senha";
                System.IO.File.WriteAllText(@"C:\Users\WDAGUtilityAccount\Desktop\Projeto app\BaseDados\\Usuarios", text);

                using (System.IO.StreamWriter file =
                       new System.IO.StreamWriter(@"C:\Users\WDAGUtilityAccount\Desktop\Projeto app\BaseDados\\Usuarios"))
                {

                    foreach (string line in lines)
                    {
                        if (!line.Contains("Second"))
                        {
                            file.WriteLine(line);
                        }

                    }


                }

            }

        }
        #endregion
    }
}






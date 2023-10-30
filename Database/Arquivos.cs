using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Database
{
    public class Arquivos
    {

        #region Usuarios
        public void LocalArquvios(string text)
        {
            string pasta = (@"C:\Users\WDAGUtilityAccount\Desktop\Projeto app\BaseDados");
            string arquivo = (@"C:\Users\WDAGUtilityAccount\Desktop\Projeto app\BaseDados\Usuarios");
            bool pastaExiste = Directory.Exists(pasta);
            bool arquivoExiste = File.Exists(arquivo);
            string arquive = File.ReadAllText(arquivo);

           
            if (pastaExiste && arquivoExiste)
            {
                if (arquive == "")
                {
                    string dadosconta = "login " + ";" + " senha";
                    var contacriada = new List<string>();
                    contacriada.Add(dadosconta + "\n");
                    contacriada.Add(text + "\n");
                    System.IO.File.WriteAllLines(@"C:\Users\WDAGUtilityAccount\Desktop\Projeto app\BaseDados\Usuarios", contacriada);
                    return;
                }
                

                if (arquivo != null)
                {//precisa ler e escrever aonde não tiver anotações
                    string dadosconta = "login " + ";" + " senha";
                    var contacriada = new List<string>();
                    contacriada.Add(dadosconta + "\n");
                    contacriada.Add(text + "\n");
                    var abrirarquivo = File.ReadAllLines(arquivo);

                    #region contagem de informações txt
                    var arq = new StreamReader(@"C:\Users\WDAGUtilityAccount\Desktop\Projeto app\BaseDados\Usuarios")
                        .ReadToEnd();
                    var txt = arq.Split(new char[] { '\n' });
                    var contagem = txt.Count();
                    #endregion

                    if (contagem > 0)
                    {
                        var escrever = new StreamWriter(@"C:\Users\WDAGUtilityAccount\Desktop\Projeto app\BaseDados\Usuarios").Encoding.
                    }
                    //System.IO.File.WriteAllLines(@"C:\Users\WDAGUtilityAccount\Desktop\Projeto app\BaseDados\Usuarios", contacriada);
                }
            }
            else
            {
                string[] lines = { "login" + " ; " + "senha\n" };
                System.IO.File.WriteAllLines(@"C:\Users\WDAGUtilityAccount\Desktop\Projeto app\BaseDados\\Usuarios", lines);
                //string texto = "login" + "senha";
                //System.IO.File.WriteAllText(@"C:\Users\WDAGUtilityAccount\Desktop\Projeto app\BaseDados\\Usuarios", texto);
                using (System.IO.StreamWriter arquivo2 =
                       new System.IO.StreamWriter(@"C:\Users\WDAGUtilityAccount\Desktop\Projeto app\BaseDados\\Usuarios"))
                {
                    foreach (string line in lines)
                    {
                        if (!line.Contains("Second"))
                        {
                            arquivo2.WriteLine(line);
                        }
                    }
                }

                //File.AppendAllText(arquivo, text);

            }
        }

        #endregion



    }
}





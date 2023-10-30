using Business;
using Database;
using System.Data;
using System.Runtime.CompilerServices;
using User;

namespace ToolsProject
{
    public partial class Login : Form
    {
        // Aplicativo aplicativo;

        public Login(/*Aplicativo fApp*/)//"Aplicativo fApp" manipular o forms declarado
        {
            InitializeComponent();
            LayoutPaginaLogin();
            //aplicativo = fApp;
        }
        #region layout
        public void LayoutPaginaLogin()
        {
            FormBorderStyle = FormBorderStyle.None;
        }
        #endregion

        DataTable dt = new DataTable();

        #region Tipo de Usuario
        /* private void data()
         {

             UserLogins.PermissoesUsuarios();

         }*/
        #endregion

        private void btEntrar_Click_1(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            //if (!string.IsNullOrEmpty(login)) { Text = login; }
            string senha = tbSenha.Text;
            //if (!string.IsNullOrEmpty(senha) ) { Text = senha; }

            if (login == "" || senha == "")
            {
                string incorrect = "Senha ou Login invalido!";
                var loginSenha = MessageBox.Show(incorrect);
                tbLogin.Focus();
                return;
            }
            string text = /*"SELECT * FROM tbLogin WHERE TBLOGIN='"+*/ login + ";" /*"'AND TBSENHAUSUARIO='" */ + senha /*+ "'"*/;
            dt = UserLogins.LoginUserBusiness(text);
            if (dt.Rows.Count == 1)
            {
            }
            else
            {
            }
        }
        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
namespace ToolsProject
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbLogin = new TextBox();
            tbSenha = new TextBox();
            label2 = new Label();
            btEntrar = new Button();
            btSair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Login:";
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(12, 27);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(174, 23);
            tbLogin.TabIndex = 1;
            // 
            // tbSenha
            // 
            tbSenha.Location = new Point(12, 77);
            tbSenha.Name = "tbSenha";
            tbSenha.PasswordChar = '*';
            tbSenha.Size = new Size(174, 23);
            tbSenha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // btEntrar
            // 
            btEntrar.Location = new Point(12, 113);
            btEntrar.Name = "btEntrar";
            btEntrar.Size = new Size(75, 23);
            btEntrar.TabIndex = 4;
            btEntrar.Text = "Entrar";
            btEntrar.UseVisualStyleBackColor = true;
            btEntrar.Click += btEntrar_Click_1;
            // 
            // btSair
            // 
            btSair.Location = new Point(111, 113);
            btSair.Name = "btSair";
            btSair.Size = new Size(75, 23);
            btSair.TabIndex = 5;
            btSair.Text = "Sair";
            btSair.UseVisualStyleBackColor = true;
            btSair.Click += btSair_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(198, 158);
            Controls.Add(btSair);
            Controls.Add(btEntrar);
            Controls.Add(tbSenha);
            Controls.Add(label2);
            Controls.Add(tbLogin);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbLogin;
        private TextBox tbSenha;
        private Label label2;
        private Button btEntrar;
        private Button btSair;
    }
}
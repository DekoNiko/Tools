using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.Design;

namespace Tools
{
	public partial class fHome : Form
	{
		public fHome()
		{
			InitializeComponent();
			Execuções();

		}
		private void Execuções()
		{
			FormBorderStyle = FormBorderStyle.None;
			Regras();
			InputformatoDados();

		}

		private void cbxFerramenta_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btSair_Click_1(object sender, EventArgs e)
		{
			Close();
		}

		public void Regras()
		{
			List<string> fillinput = new List<string>();
			fillinput.Add("");
			fillinput.Add("BOLETOS");
			fillinput.Add("MONITORAMENTO");
			cbxFerramenta.DataSource = fillinput;
			cbxFerramenta.SelectedIndex = 0;
		}


		public void InputformatoDados()
		{
			List<string> fillinput = new List<string>();
			fillinput.Add("");
			fillinput.Add("SQL");
			fillinput.Add("EXCEL");
			cbxInputSelect.DataSource = fillinput;
			cbxInputSelect.SelectedIndex = 0;
		}

		private void btIniciar_Click(object sender, EventArgs e)
		{
			if (cbxFerramenta.Text == "Boletos")
			{
				panel1.Controls.Clear();
				panel1.Controls.Add(new UserControl1());
			}
			if (cbxFerramenta.Text == "Monitoramento")
			{
				panel1.Controls.Clear();

			}
		}

	}
}



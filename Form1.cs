namespace WinForms_Sandbox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(inputTextBox.Text) && !outputList.Items.Contains(inputTextBox.Text))
			{
				outputList.Items.Add(inputTextBox.Text);
			}
		}


		private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.Enter) {
				buttonAdd.PerformClick();
			}
		}

	}
}

namespace WinForms_Sandbox
{
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void buttonAdd_Click(object sender, EventArgs e) {
			if (!string.IsNullOrWhiteSpace(inputTextBox.Text)&&!outputList.Items.Contains(inputTextBox.Text)) {
				outputList.Items.Add(inputTextBox.Text);
			}
		}


		private void inputTextBox_KeyDown(object sender, KeyEventArgs e) {

			if (e.KeyCode==Keys.Enter) {
				buttonAdd.PerformClick();
			}
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e) {
			Graphics graphics = e.Graphics;

			Pen penMediumTurqoise = new(Brushes.MediumTurquoise, 3);
			int posX = 0;
			int posY = 0;
			int width = 200;
			int height = 200;

			e.Graphics.DrawRectangle(penMediumTurqoise, posX, posY, width, height);
		}
	}
}

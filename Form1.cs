using System.Drawing;

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

			string hexColor = hexInput.Text;

			if (!string.IsNullOrWhiteSpace(hexColor)) {
				Color inputColor = ColorTranslator.FromHtml("#" + hexColor);

				SolidBrush inputBrush = new SolidBrush(inputColor);
				int posX = 0;
				int posY = 0;
				int width = pictureBox1.Width;
				int height = pictureBox1.Height;

				e.Graphics.FillRectangle(inputBrush, posX, posY, width, height);
			}
		}

		private void buttonPaint_Click(object sender, EventArgs e) {
			pictureBox1.Refresh();
		}
	}
}

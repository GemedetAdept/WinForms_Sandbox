namespace WinForms_Sandbox
{
	partial class Form1
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
		private void InitializeComponent() {
			outputList=new ListBox();
			sandboxLabel=new Label();
			inputTextBox=new TextBox();
			buttonAdd=new Button();
			pictureBox1=new PictureBox();
			buttonPaint=new Button();
			hexInput=new TextBox();
			hexPrefix=new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// outputList
			// 
			outputList.FormattingEnabled=true;
			outputList.ItemHeight=15;
			outputList.Location=new Point(8, 23);
			outputList.Name="outputList";
			outputList.Size=new Size(120, 94);
			outputList.TabIndex=1;
			// 
			// sandboxLabel
			// 
			sandboxLabel.AutoSize=true;
			sandboxLabel.Location=new Point(12, 5);
			sandboxLabel.Name="sandboxLabel";
			sandboxLabel.Size=new Size(83, 15);
			sandboxLabel.TabIndex=2;
			sandboxLabel.Text="Sandbox Input";
			// 
			// inputTextBox
			// 
			inputTextBox.Location=new Point(134, 23);
			inputTextBox.Name="inputTextBox";
			inputTextBox.Size=new Size(100, 23);
			inputTextBox.TabIndex=3;
			inputTextBox.KeyDown+=inputTextBox_KeyDown;
			// 
			// buttonAdd
			// 
			buttonAdd.Location=new Point(148, 52);
			buttonAdd.Name="buttonAdd";
			buttonAdd.Size=new Size(75, 23);
			buttonAdd.TabIndex=4;
			buttonAdd.Text="Add";
			buttonAdd.UseVisualStyleBackColor=true;
			buttonAdd.Click+=buttonAdd_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Location=new Point(8, 123);
			pictureBox1.MaximumSize=new Size(256, 256);
			pictureBox1.MinimumSize=new Size(256, 256);
			pictureBox1.Name="pictureBox1";
			pictureBox1.Size=new Size(256, 256);
			pictureBox1.TabIndex=5;
			pictureBox1.TabStop=false;
			pictureBox1.Paint+=pictureBox1_Paint;
			// 
			// buttonPaint
			// 
			buttonPaint.Location=new Point(284, 152);
			buttonPaint.Name="buttonPaint";
			buttonPaint.Size=new Size(100, 23);
			buttonPaint.TabIndex=6;
			buttonPaint.Text="Paint";
			buttonPaint.UseVisualStyleBackColor=true;
			buttonPaint.Click+=buttonPaint_Click;
			// 
			// hexInput
			// 
			hexInput.Location=new Point(284, 123);
			hexInput.MaxLength=6;
			hexInput.Name="hexInput";
			hexInput.Size=new Size(100, 23);
			hexInput.TabIndex=7;
			// 
			// hexPrefix
			// 
			hexPrefix.AutoSize=true;
			hexPrefix.Font=new Font("Segoe UI", 11F);
			hexPrefix.Location=new Point(270, 126);
			hexPrefix.Name="hexPrefix";
			hexPrefix.Size=new Size(18, 20);
			hexPrefix.TabIndex=8;
			hexPrefix.Text="#";
			// 
			// Form1
			// 
			AutoScaleDimensions=new SizeF(96F, 96F);
			AutoScaleMode=AutoScaleMode.Dpi;
			ClientSize=new Size(1008, 561);
			Controls.Add(hexPrefix);
			Controls.Add(hexInput);
			Controls.Add(buttonPaint);
			Controls.Add(pictureBox1);
			Controls.Add(buttonAdd);
			Controls.Add(inputTextBox);
			Controls.Add(sandboxLabel);
			Controls.Add(outputList);
			Margin=new Padding(2);
			Name="Form1";
			Text="WinForms Sandbox";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ListBox outputList;
		private Label sandboxLabel;
		private TextBox inputTextBox;
		private Button buttonAdd;
		private PictureBox pictureBox1;
		private Button buttonPaint;
		private TextBox hexInput;
		private Label hexPrefix;
	}
}

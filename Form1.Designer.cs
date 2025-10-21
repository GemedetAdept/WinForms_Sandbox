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
        private void InitializeComponent()
        {
            outputList = new ListBox();
            sandboxLabel = new Label();
            inputTextBox = new TextBox();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // outputList
            // 
            outputList.FormattingEnabled = true;
            outputList.ItemHeight = 15;
            outputList.Location = new Point(8, 23);
            outputList.Name = "outputList";
            outputList.Size = new Size(120, 94);
            outputList.TabIndex = 1;
            // 
            // sandboxLabel
            // 
            sandboxLabel.AutoSize = true;
            sandboxLabel.Location = new Point(12, 5);
            sandboxLabel.Name = "sandboxLabel";
            sandboxLabel.Size = new Size(83, 15);
            sandboxLabel.TabIndex = 2;
            sandboxLabel.Text = "Sandbox Input";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(134, 23);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(100, 23);
            inputTextBox.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(148, 52);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(buttonAdd);
            Controls.Add(inputTextBox);
            Controls.Add(sandboxLabel);
            Controls.Add(outputList);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "WinForms Sandbox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox outputList;
        private Label sandboxLabel;
        private TextBox inputTextBox;
        private Button buttonAdd;
    }
}

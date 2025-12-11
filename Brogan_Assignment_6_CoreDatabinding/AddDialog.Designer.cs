namespace Brogan_Assignment_6_CoreDatabinding
{
    partial class AddDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cancelButton = new Button();
            addButton = new Button();
            nameTextBox = new TextBox();
            ageTextBox = new TextBox();
            nameLabel = new Label();
            ageLabel = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(122, 195);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 34);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "&Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addButton
            // 
            addButton.DialogResult = DialogResult.OK;
            addButton.Location = new Point(335, 195);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 34);
            addButton.TabIndex = 5;
            addButton.Text = "&Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(100, 119);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 31);
            nameTextBox.TabIndex = 1;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(311, 119);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(150, 31);
            ageTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(145, 91);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "&Name";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(362, 91);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(44, 25);
            ageLabel.TabIndex = 2;
            ageLabel.Text = "A&ge";
            // 
            // AddDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 288);
            Controls.Add(ageLabel);
            Controls.Add(nameLabel);
            Controls.Add(ageTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(addButton);
            Controls.Add(cancelButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddDialog";
            Text = "AddDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button addButton;
        private TextBox nameTextBox;
        private TextBox ageTextBox;
        private Label nameLabel;
        private Label ageLabel;
    }
}
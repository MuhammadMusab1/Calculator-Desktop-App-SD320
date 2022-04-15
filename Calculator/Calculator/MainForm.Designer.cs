namespace Calculator
{
    partial class MainForm
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
            this.DisplayNumberTextBox = new System.Windows.Forms.TextBox();
            this.DisplayNumberLabel = new System.Windows.Forms.Label();
            this.OperationLabel = new System.Windows.Forms.Label();
            this.Operation = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.LocationalButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.BinaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayNumberTextBox
            // 
            this.DisplayNumberTextBox.Location = new System.Drawing.Point(35, 75);
            this.DisplayNumberTextBox.Name = "DisplayNumberTextBox";
            this.DisplayNumberTextBox.Size = new System.Drawing.Size(179, 23);
            this.DisplayNumberTextBox.TabIndex = 0;
            // 
            // DisplayNumberLabel
            // 
            this.DisplayNumberLabel.AutoSize = true;
            this.DisplayNumberLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayNumberLabel.Location = new System.Drawing.Point(48, 37);
            this.DisplayNumberLabel.Name = "DisplayNumberLabel";
            this.DisplayNumberLabel.Size = new System.Drawing.Size(140, 25);
            this.DisplayNumberLabel.TabIndex = 1;
            this.DisplayNumberLabel.Text = "Display Number";
            // 
            // OperationLabel
            // 
            this.OperationLabel.AutoSize = true;
            this.OperationLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OperationLabel.Location = new System.Drawing.Point(278, 37);
            this.OperationLabel.Name = "OperationLabel";
            this.OperationLabel.Size = new System.Drawing.Size(92, 25);
            this.OperationLabel.TabIndex = 2;
            this.OperationLabel.Text = "Operation";
            // 
            // Operation
            // 
            this.Operation.AutoSize = true;
            this.Operation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Operation.Location = new System.Drawing.Point(287, 75);
            this.Operation.Name = "Operation";
            this.Operation.Padding = new System.Windows.Forms.Padding(0, 6, 60, 0);
            this.Operation.Size = new System.Drawing.Size(62, 23);
            this.Operation.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(441, 75);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(441, 104);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(75, 24);
            this.SubtractButton.TabIndex = 5;
            this.SubtractButton.Text = "Subtract";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(441, 134);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(75, 23);
            this.DivideButton.TabIndex = 6;
            this.DivideButton.Text = "Divide";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(441, 163);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(75, 23);
            this.MultiplyButton.TabIndex = 7;
            this.MultiplyButton.Text = "Multiply";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // LocationalButton
            // 
            this.LocationalButton.Location = new System.Drawing.Point(595, 159);
            this.LocationalButton.Name = "LocationalButton";
            this.LocationalButton.Size = new System.Drawing.Size(75, 23);
            this.LocationalButton.TabIndex = 8;
            this.LocationalButton.Text = "LOC";
            this.LocationalButton.UseVisualStyleBackColor = true;
            this.LocationalButton.Click += new System.EventHandler(this.LocationalButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Location = new System.Drawing.Point(595, 114);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(75, 23);
            this.DecimalButton.TabIndex = 9;
            this.DecimalButton.Text = "DEC";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // BinaryButton
            // 
            this.BinaryButton.Location = new System.Drawing.Point(595, 75);
            this.BinaryButton.Name = "BinaryButton";
            this.BinaryButton.Size = new System.Drawing.Size(75, 23);
            this.BinaryButton.TabIndex = 10;
            this.BinaryButton.Text = "BIN";
            this.BinaryButton.UseVisualStyleBackColor = true;
            this.BinaryButton.Click += new System.EventHandler(this.BinaryButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BinaryButton);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.LocationalButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.OperationLabel);
            this.Controls.Add(this.DisplayNumberLabel);
            this.Controls.Add(this.DisplayNumberTextBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox DisplayNumberTextBox;
        private Label DisplayNumberLabel;
        private Label OperationLabel;
        private Label Operation;
        private Button AddButton;
        private Button SubtractButton;
        private Button DivideButton;
        private Button MultiplyButton;
        private Button LocationalButton;
        private Button DecimalButton;
        private Button BinaryButton;
    }
}
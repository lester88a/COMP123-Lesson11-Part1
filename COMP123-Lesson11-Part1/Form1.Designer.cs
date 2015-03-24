namespace COMP123_Lesson11_Part1
{
    partial class InputForm
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.YouTypedTextBox = new System.Windows.Forms.TextBox();
            this.OutputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(13, 13);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(101, 24);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(120, 10);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(150, 29);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(13, 48);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(99, 24);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(120, 45);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(150, 29);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(17, 95);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(77, 32);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Controls.Add(this.YouTypedTextBox);
            this.OutputGroupBox.Controls.Add(this.label1);
            this.OutputGroupBox.Location = new System.Drawing.Point(17, 193);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(455, 257);
            this.OutputGroupBox.TabIndex = 5;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "You Typed:";
            // 
            // YouTypedTextBox
            // 
            this.YouTypedTextBox.Location = new System.Drawing.Point(137, 120);
            this.YouTypedTextBox.Name = "YouTypedTextBox";
            this.YouTypedTextBox.Size = new System.Drawing.Size(211, 20);
            this.YouTypedTextBox.TabIndex = 1;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Form";
            this.OutputGroupBox.ResumeLayout(false);
            this.OutputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YouTypedTextBox;
    }
}


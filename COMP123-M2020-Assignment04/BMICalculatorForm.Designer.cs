namespace COMP123_M2020_Assignment04
{
    partial class BMICalculatorForm
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
            this.bmiLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.CalculatorButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bmiLabel
            // 
            this.bmiLabel.AutoSize = true;
            this.bmiLabel.Location = new System.Drawing.Point(70, 41);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(192, 31);
            this.bmiLabel.TabIndex = 0;
            this.bmiLabel.Text = "BMI Calculator";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(32, 111);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(98, 31);
            this.weightLabel.TabIndex = 1;
            this.weightLabel.Text = "Weight";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(32, 172);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(93, 31);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(145, 111);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(117, 38);
            this.weightTextBox.TabIndex = 2;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(145, 165);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(117, 38);
            this.heightTextBox.TabIndex = 2;
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.Location = new System.Drawing.Point(76, 232);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(152, 45);
            this.CalculatorButton.TabIndex = 3;
            this.CalculatorButton.Text = "Calculate";
            this.CalculatorButton.UseVisualStyleBackColor = true;
            this.CalculatorButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(104, 327);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(92, 31);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "Result";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.CalculatorButton);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.bmiLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bmiLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Button CalculatorButton;
        private System.Windows.Forms.Label resultLabel;
    }
}


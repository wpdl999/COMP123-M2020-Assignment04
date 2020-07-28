namespace COMP123_M2020_Assignment04
{
    partial class Imperial
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
            this.imperialLabel = new System.Windows.Forms.Label();
            this.heightILabel = new System.Windows.Forms.Label();
            this.weightILabel = new System.Windows.Forms.Label();
            this.heightITextBox = new System.Windows.Forms.TextBox();
            this.weightITextBox = new System.Windows.Forms.TextBox();
            this.imperialButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.resultILabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imperialLabel
            // 
            this.imperialLabel.AutoSize = true;
            this.imperialLabel.Location = new System.Drawing.Point(87, 43);
            this.imperialLabel.Name = "imperialLabel";
            this.imperialLabel.Size = new System.Drawing.Size(110, 31);
            this.imperialLabel.TabIndex = 0;
            this.imperialLabel.Text = "Imperial";
            // 
            // heightILabel
            // 
            this.heightILabel.AutoSize = true;
            this.heightILabel.Location = new System.Drawing.Point(26, 115);
            this.heightILabel.Name = "heightILabel";
            this.heightILabel.Size = new System.Drawing.Size(136, 31);
            this.heightILabel.TabIndex = 1;
            this.heightILabel.Text = "My Height";
            // 
            // weightILabel
            // 
            this.weightILabel.AutoSize = true;
            this.weightILabel.Location = new System.Drawing.Point(26, 183);
            this.weightILabel.Name = "weightILabel";
            this.weightILabel.Size = new System.Drawing.Size(141, 31);
            this.weightILabel.TabIndex = 2;
            this.weightILabel.Text = "My Weight";
            // 
            // heightITextBox
            // 
            this.heightITextBox.Location = new System.Drawing.Point(194, 115);
            this.heightITextBox.Name = "heightITextBox";
            this.heightITextBox.Size = new System.Drawing.Size(88, 38);
            this.heightITextBox.TabIndex = 3;
            // 
            // weightITextBox
            // 
            this.weightITextBox.Location = new System.Drawing.Point(194, 183);
            this.weightITextBox.Name = "weightITextBox";
            this.weightITextBox.Size = new System.Drawing.Size(88, 38);
            this.weightITextBox.TabIndex = 3;
            // 
            // imperialButton
            // 
            this.imperialButton.Location = new System.Drawing.Point(71, 245);
            this.imperialButton.Name = "imperialButton";
            this.imperialButton.Size = new System.Drawing.Size(152, 41);
            this.imperialButton.TabIndex = 4;
            this.imperialButton.Text = "Calculate";
            this.imperialButton.UseVisualStyleBackColor = true;
            this.imperialButton.Click += new System.EventHandler(this.imperialButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultILabel
            // 
            this.resultILabel.AutoSize = true;
            this.resultILabel.Location = new System.Drawing.Point(99, 300);
            this.resultILabel.Name = "resultILabel";
            this.resultILabel.Size = new System.Drawing.Size(92, 31);
            this.resultILabel.TabIndex = 6;
            this.resultILabel.Text = "Result";
            // 
            // Imperial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.resultILabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imperialButton);
            this.Controls.Add(this.weightITextBox);
            this.Controls.Add(this.heightITextBox);
            this.Controls.Add(this.weightILabel);
            this.Controls.Add(this.heightILabel);
            this.Controls.Add(this.imperialLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MinimizeBox = false;
            this.Name = "Imperial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imperial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Imperial_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imperialLabel;
        private System.Windows.Forms.Label heightILabel;
        private System.Windows.Forms.Label weightILabel;
        private System.Windows.Forms.TextBox heightITextBox;
        private System.Windows.Forms.TextBox weightITextBox;
        private System.Windows.Forms.Button imperialButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultILabel;
    }
}
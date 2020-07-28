namespace COMP123_M2020_Assignment04
{
    partial class Metric_Units
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
            this.weightMLabel = new System.Windows.Forms.Label();
            this.MetricUnitsLabel = new System.Windows.Forms.Label();
            this.weightMTextBox = new System.Windows.Forms.TextBox();
            this.heightMLabel = new System.Windows.Forms.Label();
            this.heightMTextBox = new System.Windows.Forms.TextBox();
            this.mertricButton = new System.Windows.Forms.Button();
            this.resultMLabel = new System.Windows.Forms.Label();
            this.BackMButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weightMLabel
            // 
            this.weightMLabel.AutoSize = true;
            this.weightMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.weightMLabel.Location = new System.Drawing.Point(16, 112);
            this.weightMLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.weightMLabel.Name = "weightMLabel";
            this.weightMLabel.Size = new System.Drawing.Size(141, 31);
            this.weightMLabel.TabIndex = 0;
            this.weightMLabel.Text = "My Weight";
            // 
            // MetricUnitsLabel
            // 
            this.MetricUnitsLabel.AutoSize = true;
            this.MetricUnitsLabel.Location = new System.Drawing.Point(72, 37);
            this.MetricUnitsLabel.Name = "MetricUnitsLabel";
            this.MetricUnitsLabel.Size = new System.Drawing.Size(167, 31);
            this.MetricUnitsLabel.TabIndex = 1;
            this.MetricUnitsLabel.Text = "Mertric Units";
            // 
            // weightMTextBox
            // 
            this.weightMTextBox.Location = new System.Drawing.Point(220, 112);
            this.weightMTextBox.Name = "weightMTextBox";
            this.weightMTextBox.Size = new System.Drawing.Size(72, 38);
            this.weightMTextBox.TabIndex = 2;
            // 
            // heightMLabel
            // 
            this.heightMLabel.AutoSize = true;
            this.heightMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.heightMLabel.Location = new System.Drawing.Point(21, 172);
            this.heightMLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.heightMLabel.Name = "heightMLabel";
            this.heightMLabel.Size = new System.Drawing.Size(136, 31);
            this.heightMLabel.TabIndex = 0;
            this.heightMLabel.Text = "My Height";
            // 
            // heightMTextBox
            // 
            this.heightMTextBox.Location = new System.Drawing.Point(220, 172);
            this.heightMTextBox.Name = "heightMTextBox";
            this.heightMTextBox.Size = new System.Drawing.Size(72, 38);
            this.heightMTextBox.TabIndex = 2;
            // 
            // mertricButton
            // 
            this.mertricButton.Location = new System.Drawing.Point(78, 233);
            this.mertricButton.Name = "mertricButton";
            this.mertricButton.Size = new System.Drawing.Size(152, 45);
            this.mertricButton.TabIndex = 3;
            this.mertricButton.Text = "Calculate";
            this.mertricButton.UseVisualStyleBackColor = true;
            this.mertricButton.Click += new System.EventHandler(this.mertricButton_Click);
            // 
            // resultMLabel
            // 
            this.resultMLabel.AutoSize = true;
            this.resultMLabel.Location = new System.Drawing.Point(110, 303);
            this.resultMLabel.Name = "resultMLabel";
            this.resultMLabel.Size = new System.Drawing.Size(81, 31);
            this.resultMLabel.TabIndex = 4;
            this.resultMLabel.Text = "result";
            // 
            // BackMButton
            // 
            this.BackMButton.Location = new System.Drawing.Point(12, 392);
            this.BackMButton.Name = "BackMButton";
            this.BackMButton.Size = new System.Drawing.Size(85, 37);
            this.BackMButton.TabIndex = 5;
            this.BackMButton.Text = "Back";
            this.BackMButton.UseVisualStyleBackColor = true;
            this.BackMButton.Click += new System.EventHandler(this.BackMButton_Click);
            // 
            // Metric_Units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BackMButton);
            this.Controls.Add(this.resultMLabel);
            this.Controls.Add(this.mertricButton);
            this.Controls.Add(this.heightMTextBox);
            this.Controls.Add(this.weightMTextBox);
            this.Controls.Add(this.MetricUnitsLabel);
            this.Controls.Add(this.heightMLabel);
            this.Controls.Add(this.weightMLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.Name = "Metric_Units";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metric_Units";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightMLabel;
        private System.Windows.Forms.Label MetricUnitsLabel;
        private System.Windows.Forms.TextBox weightMTextBox;
        private System.Windows.Forms.Label heightMLabel;
        private System.Windows.Forms.TextBox heightMTextBox;
        private System.Windows.Forms.Button mertricButton;
        private System.Windows.Forms.Label resultMLabel;
        private System.Windows.Forms.Button BackMButton;
    }
}
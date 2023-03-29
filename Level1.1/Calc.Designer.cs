namespace Level1._1
{
    partial class Form1
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
            this.leftRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sumButton = new System.Windows.Forms.Button();
            this.rightRichTextBox = new System.Windows.Forms.RichTextBox();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // leftRichTextBox
            // 
            this.leftRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftRichTextBox.Location = new System.Drawing.Point(32, 30);
            this.leftRichTextBox.Name = "leftRichTextBox";
            this.leftRichTextBox.Size = new System.Drawing.Size(136, 50);
            this.leftRichTextBox.TabIndex = 0;
            this.leftRichTextBox.Text = "";
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(101, 95);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(152, 39);
            this.sumButton.TabIndex = 3;
            this.sumButton.Text = "Сложить";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // rightRichTextBox
            // 
            this.rightRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightRichTextBox.Location = new System.Drawing.Point(187, 30);
            this.rightRichTextBox.Name = "rightRichTextBox";
            this.rightRichTextBox.Size = new System.Drawing.Size(136, 50);
            this.rightRichTextBox.TabIndex = 4;
            this.rightRichTextBox.Text = "";
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultRichTextBox.Location = new System.Drawing.Point(101, 149);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.ReadOnly = true;
            this.resultRichTextBox.Size = new System.Drawing.Size(152, 50);
            this.resultRichTextBox.TabIndex = 5;
            this.resultRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 223);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.rightRichTextBox);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.leftRichTextBox);
            this.Name = "Form1";
            this.Text = "Calc";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox leftRichTextBox;
        private System.Windows.Forms.RichTextBox rightRichTextBox;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.Button sumButton;

        #endregion
    }
}
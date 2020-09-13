namespace CardGame
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
            this.pullCardButton = new System.Windows.Forms.Button();
            this.shuffleDeckButton = new System.Windows.Forms.Button();
            this.sortDeckButton = new System.Windows.Forms.Button();
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // pullCardButton
            // 
            this.pullCardButton.Location = new System.Drawing.Point(649, 12);
            this.pullCardButton.Name = "pullCardButton";
            this.pullCardButton.Size = new System.Drawing.Size(139, 23);
            this.pullCardButton.TabIndex = 0;
            this.pullCardButton.Text = "Pull Card";
            this.pullCardButton.UseVisualStyleBackColor = true;
            this.pullCardButton.Click += new System.EventHandler(this.PullCardButton_Click);
            // 
            // shuffleDeckButton
            // 
            this.shuffleDeckButton.Location = new System.Drawing.Point(649, 41);
            this.shuffleDeckButton.Name = "shuffleDeckButton";
            this.shuffleDeckButton.Size = new System.Drawing.Size(139, 23);
            this.shuffleDeckButton.TabIndex = 1;
            this.shuffleDeckButton.Text = "Shuffle Deck";
            this.shuffleDeckButton.UseVisualStyleBackColor = true;
            this.shuffleDeckButton.Click += new System.EventHandler(this.ShuffleDeckButton_Click);
            // 
            // sortDeckButton
            // 
            this.sortDeckButton.Location = new System.Drawing.Point(649, 70);
            this.sortDeckButton.Name = "sortDeckButton";
            this.sortDeckButton.Size = new System.Drawing.Size(139, 23);
            this.sortDeckButton.TabIndex = 2;
            this.sortDeckButton.Text = "Sort Deck";
            this.sortDeckButton.UseVisualStyleBackColor = true;
            this.sortDeckButton.Click += new System.EventHandler(this.SortDeckButton_Click);
            // 
            // mainTextBox
            // 
            this.mainTextBox.Location = new System.Drawing.Point(12, 12);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(631, 417);
            this.mainTextBox.TabIndex = 3;
            this.mainTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.sortDeckButton);
            this.Controls.Add(this.shuffleDeckButton);
            this.Controls.Add(this.pullCardButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pullCardButton;
        private System.Windows.Forms.Button shuffleDeckButton;
        private System.Windows.Forms.Button sortDeckButton;
        private System.Windows.Forms.RichTextBox mainTextBox;
    }
}


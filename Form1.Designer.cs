namespace Handbags
{
    partial class Handbags
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDrawBags = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelHandbagRows = new System.Windows.Forms.Label();
            this.textBoxHandbagRows = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 310);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDrawBags
            // 
            this.buttonDrawBags.Location = new System.Drawing.Point(137, 408);
            this.buttonDrawBags.Name = "buttonDrawBags";
            this.buttonDrawBags.Size = new System.Drawing.Size(74, 53);
            this.buttonDrawBags.TabIndex = 1;
            this.buttonDrawBags.Text = "Draw Handbags";
            this.buttonDrawBags.UseVisualStyleBackColor = true;
            this.buttonDrawBags.Click += new System.EventHandler(this.buttonDrawBags_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(83, 467);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(189, 467);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // labelHandbagRows
            // 
            this.labelHandbagRows.AutoSize = true;
            this.labelHandbagRows.Location = new System.Drawing.Point(67, 368);
            this.labelHandbagRows.Name = "labelHandbagRows";
            this.labelHandbagRows.Size = new System.Drawing.Size(91, 13);
            this.labelHandbagRows.TabIndex = 4;
            this.labelHandbagRows.Text = "Number Of Rows:";
            // 
            // textBoxHandbagRows
            // 
            this.textBoxHandbagRows.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHandbagRows.Location = new System.Drawing.Point(164, 366);
            this.textBoxHandbagRows.Name = "textBoxHandbagRows";
            this.textBoxHandbagRows.Size = new System.Drawing.Size(100, 20);
            this.textBoxHandbagRows.TabIndex = 5;
            this.textBoxHandbagRows.Text = "10";
            // 
            // Handbags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 552);
            this.Controls.Add(this.textBoxHandbagRows);
            this.Controls.Add(this.labelHandbagRows);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDrawBags);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Handbags";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handbags";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDrawBags;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelHandbagRows;
        private System.Windows.Forms.TextBox textBoxHandbagRows;
    }
}


namespace WindowsFormsApp1
{
    partial class Search
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
            this.Stext = new System.Windows.Forms.TextBox();
            this.Sbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Stext
            // 
            this.Stext.Location = new System.Drawing.Point(180, 159);
            this.Stext.Name = "Stext";
            this.Stext.Size = new System.Drawing.Size(412, 22);
            this.Stext.TabIndex = 0;
            this.Stext.TextChanged += new System.EventHandler(this.Stext_TextChanged);
            // 
            // Sbutton
            // 
            this.Sbutton.Location = new System.Drawing.Point(345, 219);
            this.Sbutton.Name = "Sbutton";
            this.Sbutton.Size = new System.Drawing.Size(75, 23);
            this.Sbutton.TabIndex = 1;
            this.Sbutton.Text = "Search";
            this.Sbutton.UseVisualStyleBackColor = true;
            this.Sbutton.Click += new System.EventHandler(this.Sbutton_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sbutton);
            this.Controls.Add(this.Stext);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Stext;
        private System.Windows.Forms.Button Sbutton;
    }
}
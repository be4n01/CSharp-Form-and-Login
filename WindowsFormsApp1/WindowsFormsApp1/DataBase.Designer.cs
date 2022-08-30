namespace WindowsFormsApp1
{
    partial class DataBase
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
            this.btnCon = new System.Windows.Forms.Button();
            this.InsBtn = new System.Windows.Forms.Button();
            this.DisBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(272, 188);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 0;
            this.btnCon.Text = "Connect";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // InsBtn
            // 
            this.InsBtn.Location = new System.Drawing.Point(379, 188);
            this.InsBtn.Name = "InsBtn";
            this.InsBtn.Size = new System.Drawing.Size(75, 23);
            this.InsBtn.TabIndex = 1;
            this.InsBtn.Text = "Insert";
            this.InsBtn.UseVisualStyleBackColor = true;
            this.InsBtn.Click += new System.EventHandler(this.InsBtn_Click);
            // 
            // DisBtn
            // 
            this.DisBtn.Location = new System.Drawing.Point(483, 188);
            this.DisBtn.Name = "DisBtn";
            this.DisBtn.Size = new System.Drawing.Size(75, 23);
            this.DisBtn.TabIndex = 2;
            this.DisBtn.Text = "Display";
            this.DisBtn.UseVisualStyleBackColor = true;
            this.DisBtn.Click += new System.EventHandler(this.DisBtn_Click);
            // 
            // DataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisBtn);
            this.Controls.Add(this.InsBtn);
            this.Controls.Add(this.btnCon);
            this.Name = "DataBase";
            this.Text = "DataBase";
            this.Load += new System.EventHandler(this.DataBase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button InsBtn;
        private System.Windows.Forms.Button DisBtn;
    }
}
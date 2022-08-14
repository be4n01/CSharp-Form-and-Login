namespace WindowsFormsApp1
{
    partial class ProductCardTemplate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prodName = new System.Windows.Forms.Label();
            this.prodItem = new System.Windows.Forms.Label();
            this.prodPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prodName
            // 
            this.prodName.AutoSize = true;
            this.prodName.Location = new System.Drawing.Point(41, 36);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(69, 16);
            this.prodName.TabIndex = 0;
            this.prodName.Text = "prodname";
            // 
            // prodItem
            // 
            this.prodItem.AutoSize = true;
            this.prodItem.Location = new System.Drawing.Point(41, 66);
            this.prodItem.Name = "prodItem";
            this.prodItem.Size = new System.Drawing.Size(60, 16);
            this.prodItem.TabIndex = 1;
            this.prodItem.Text = "prodItem";
            // 
            // prodPrice
            // 
            this.prodPrice.AutoSize = true;
            this.prodPrice.Location = new System.Drawing.Point(41, 96);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(67, 16);
            this.prodPrice.TabIndex = 2;
            this.prodPrice.Text = "ProdPrice";
            this.prodPrice.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "$";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ProductCardTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prodPrice);
            this.Controls.Add(this.prodItem);
            this.Controls.Add(this.prodName);
            this.Name = "ProductCardTemplate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prodName;
        private System.Windows.Forms.Label prodItem;
        private System.Windows.Forms.Label prodPrice;
        private System.Windows.Forms.Label label4;
    }
}

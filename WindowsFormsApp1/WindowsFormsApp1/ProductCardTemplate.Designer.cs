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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CardId = new System.Windows.Forms.Label();
            this.CardDate = new System.Windows.Forms.Label();
            this.CardInv = new System.Windows.Forms.Label();
            this.CardObj = new System.Windows.Forms.Label();
            this.CardCount = new System.Windows.Forms.Label();
            this.CardPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Object";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // CardId
            // 
            this.CardId.AutoSize = true;
            this.CardId.Location = new System.Drawing.Point(178, 37);
            this.CardId.Name = "CardId";
            this.CardId.Size = new System.Drawing.Size(44, 16);
            this.CardId.TabIndex = 6;
            this.CardId.Text = "label7";
            // 
            // CardDate
            // 
            this.CardDate.AutoSize = true;
            this.CardDate.Location = new System.Drawing.Point(178, 83);
            this.CardDate.Name = "CardDate";
            this.CardDate.Size = new System.Drawing.Size(44, 16);
            this.CardDate.TabIndex = 7;
            this.CardDate.Text = "label8";
            // 
            // CardInv
            // 
            this.CardInv.AutoSize = true;
            this.CardInv.Location = new System.Drawing.Point(178, 129);
            this.CardInv.Name = "CardInv";
            this.CardInv.Size = new System.Drawing.Size(44, 16);
            this.CardInv.TabIndex = 8;
            this.CardInv.Text = "label9";
            // 
            // CardObj
            // 
            this.CardObj.AutoSize = true;
            this.CardObj.Location = new System.Drawing.Point(178, 172);
            this.CardObj.Name = "CardObj";
            this.CardObj.Size = new System.Drawing.Size(51, 16);
            this.CardObj.TabIndex = 9;
            this.CardObj.Text = "label10";
            // 
            // CardCount
            // 
            this.CardCount.AutoSize = true;
            this.CardCount.Location = new System.Drawing.Point(178, 211);
            this.CardCount.Name = "CardCount";
            this.CardCount.Size = new System.Drawing.Size(51, 16);
            this.CardCount.TabIndex = 10;
            this.CardCount.Text = "label11";
            // 
            // CardPrice
            // 
            this.CardPrice.AutoSize = true;
            this.CardPrice.Location = new System.Drawing.Point(178, 255);
            this.CardPrice.Name = "CardPrice";
            this.CardPrice.Size = new System.Drawing.Size(51, 16);
            this.CardPrice.TabIndex = 11;
            this.CardPrice.Text = "label12";
            // 
            // ProductCardTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CardPrice);
            this.Controls.Add(this.CardCount);
            this.Controls.Add(this.CardObj);
            this.Controls.Add(this.CardInv);
            this.Controls.Add(this.CardDate);
            this.Controls.Add(this.CardId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductCardTemplate";
            this.Size = new System.Drawing.Size(466, 387);
            this.Load += new System.EventHandler(this.ProductCardTemplate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CardId;
        private System.Windows.Forms.Label CardDate;
        private System.Windows.Forms.Label CardInv;
        private System.Windows.Forms.Label CardObj;
        private System.Windows.Forms.Label CardCount;
        private System.Windows.Forms.Label CardPrice;
    }
}

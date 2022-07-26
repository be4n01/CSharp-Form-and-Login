namespace Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Fid = new System.Windows.Forms.Label();
            this.Finvnum = new System.Windows.Forms.Label();
            this.Fdate = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Fobjname = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Fcount = new System.Windows.Forms.Label();
            this.Fprice = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(184, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(563, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(2, 225);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowTemplate.Height = 24;
            this.Grid.Size = new System.Drawing.Size(874, 217);
            this.Grid.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Fid
            // 
            this.Fid.AutoSize = true;
            this.Fid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fid.Location = new System.Drawing.Point(33, 32);
            this.Fid.Name = "Fid";
            this.Fid.Size = new System.Drawing.Size(24, 20);
            this.Fid.TabIndex = 4;
            this.Fid.Text = "Id";
            this.Fid.Click += new System.EventHandler(this.label1_Click);
            // 
            // Finvnum
            // 
            this.Finvnum.AutoSize = true;
            this.Finvnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finvnum.Location = new System.Drawing.Point(559, 32);
            this.Finvnum.Name = "Finvnum";
            this.Finvnum.Size = new System.Drawing.Size(71, 20);
            this.Finvnum.TabIndex = 5;
            this.Finvnum.Text = "InvNum";
            // 
            // Fdate
            // 
            this.Fdate.AutoSize = true;
            this.Fdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fdate.Location = new System.Drawing.Point(301, 32);
            this.Fdate.Name = "Fdate";
            this.Fdate.Size = new System.Drawing.Size(49, 20);
            this.Fdate.TabIndex = 6;
            this.Fdate.Text = "Date";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(356, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(636, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 22);
            this.textBox3.TabIndex = 8;
            // 
            // Fobjname
            // 
            this.Fobjname.AutoSize = true;
            this.Fobjname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fobjname.Location = new System.Drawing.Point(33, 94);
            this.Fobjname.Name = "Fobjname";
            this.Fobjname.Size = new System.Drawing.Size(86, 20);
            this.Fobjname.TabIndex = 9;
            this.Fobjname.Text = "ObjName";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(125, 92);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(505, 22);
            this.textBox4.TabIndex = 10;
            // 
            // Fcount
            // 
            this.Fcount.AutoSize = true;
            this.Fcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fcount.Location = new System.Drawing.Point(33, 161);
            this.Fcount.Name = "Fcount";
            this.Fcount.Size = new System.Drawing.Size(58, 20);
            this.Fcount.TabIndex = 11;
            this.Fcount.Text = "Count";
            // 
            // Fprice
            // 
            this.Fprice.AutoSize = true;
            this.Fprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fprice.Location = new System.Drawing.Point(292, 161);
            this.Fprice.Name = "Fprice";
            this.Fprice.Size = new System.Drawing.Size(53, 20);
            this.Fprice.TabIndex = 12;
            this.Fprice.Text = "Price";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(97, 159);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(171, 22);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(351, 159);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(171, 22);
            this.textBox6.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 499);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Fprice);
            this.Controls.Add(this.Fcount);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Fobjname);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Fdate);
            this.Controls.Add(this.Finvnum);
            this.Controls.Add(this.Fid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Fid;
        private System.Windows.Forms.Label Finvnum;
        private System.Windows.Forms.Label Fdate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Fobjname;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Fcount;
        private System.Windows.Forms.Label Fprice;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}


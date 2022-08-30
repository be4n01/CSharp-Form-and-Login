namespace WindowsFormsApp1
{
    partial class Form2
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
            this.Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Datainvent = new System.Windows.Forms.TextBox();
            this.Datacount = new System.Windows.Forms.TextBox();
            this.Dataobj = new System.Windows.Forms.TextBox();
            this.Dataprice = new System.Windows.Forms.TextBox();
            this.Dataid = new System.Windows.Forms.TextBox();
            this.DataDel = new System.Windows.Forms.Button();
            this.DataUpd = new System.Windows.Forms.Button();
            this.DataAdd = new System.Windows.Forms.Button();
            this.DataDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(37, 28);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(24, 20);
            this.Label.TabIndex = 1;
            this.Label.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Inventory";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(37, 174);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 20);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Object";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(37, 224);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(58, 20);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Price";
            // 
            // Datainvent
            // 
            this.Datainvent.Location = new System.Drawing.Point(146, 125);
            this.Datainvent.Name = "Datainvent";
            this.Datainvent.Size = new System.Drawing.Size(100, 22);
            this.Datainvent.TabIndex = 17;
            // 
            // Datacount
            // 
            this.Datacount.Location = new System.Drawing.Point(146, 224);
            this.Datacount.Name = "Datacount";
            this.Datacount.Size = new System.Drawing.Size(100, 22);
            this.Datacount.TabIndex = 16;
            // 
            // Dataobj
            // 
            this.Dataobj.Location = new System.Drawing.Point(146, 172);
            this.Dataobj.Name = "Dataobj";
            this.Dataobj.Size = new System.Drawing.Size(560, 22);
            this.Dataobj.TabIndex = 15;
            // 
            // Dataprice
            // 
            this.Dataprice.Location = new System.Drawing.Point(146, 269);
            this.Dataprice.Name = "Dataprice";
            this.Dataprice.Size = new System.Drawing.Size(100, 22);
            this.Dataprice.TabIndex = 14;
            // 
            // Dataid
            // 
            this.Dataid.Location = new System.Drawing.Point(146, 26);
            this.Dataid.Name = "Dataid";
            this.Dataid.Size = new System.Drawing.Size(100, 22);
            this.Dataid.TabIndex = 13;
            // 
            // DataDel
            // 
            this.DataDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataDel.Location = new System.Drawing.Point(567, 352);
            this.DataDel.Name = "DataDel";
            this.DataDel.Size = new System.Drawing.Size(101, 41);
            this.DataDel.TabIndex = 19;
            this.DataDel.Text = "Delete";
            this.DataDel.UseVisualStyleBackColor = true;
            this.DataDel.Click += new System.EventHandler(this.DataDel_Click);
            // 
            // DataUpd
            // 
            this.DataUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataUpd.Location = new System.Drawing.Point(306, 352);
            this.DataUpd.Name = "DataUpd";
            this.DataUpd.Size = new System.Drawing.Size(101, 41);
            this.DataUpd.TabIndex = 20;
            this.DataUpd.Text = "Update";
            this.DataUpd.UseVisualStyleBackColor = true;
            this.DataUpd.Click += new System.EventHandler(this.DataUpd_Click);
            // 
            // DataAdd
            // 
            this.DataAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataAdd.Location = new System.Drawing.Point(41, 352);
            this.DataAdd.Name = "DataAdd";
            this.DataAdd.Size = new System.Drawing.Size(101, 41);
            this.DataAdd.TabIndex = 21;
            this.DataAdd.Text = "Add";
            this.DataAdd.UseVisualStyleBackColor = true;
            this.DataAdd.Click += new System.EventHandler(this.DataAdd_Click);
            // 
            // DataDate
            // 
            this.DataDate.Location = new System.Drawing.Point(146, 74);
            this.DataDate.Name = "DataDate";
            this.DataDate.Size = new System.Drawing.Size(100, 22);
            this.DataDate.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataDate);
            this.Controls.Add(this.DataAdd);
            this.Controls.Add(this.DataUpd);
            this.Controls.Add(this.DataDel);
            this.Controls.Add(this.Datainvent);
            this.Controls.Add(this.Datacount);
            this.Controls.Add(this.Dataobj);
            this.Controls.Add(this.Dataprice);
            this.Controls.Add(this.Dataid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Datainvent;
        private System.Windows.Forms.TextBox Datacount;
        private System.Windows.Forms.TextBox Dataobj;
        private System.Windows.Forms.TextBox Dataprice;
        private System.Windows.Forms.TextBox Dataid;
        private System.Windows.Forms.Button DataDel;
        private System.Windows.Forms.Button DataUpd;
        private System.Windows.Forms.Button DataAdd;
        private System.Windows.Forms.TextBox DataDate;
    }
}
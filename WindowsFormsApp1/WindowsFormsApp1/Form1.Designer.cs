namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Fid = new System.Windows.Forms.TextBox();
            this.Fprice = new System.Windows.Forms.TextBox();
            this.Fobj = new System.Windows.Forms.TextBox();
            this.Fcount = new System.Windows.Forms.TextBox();
            this.Finvent = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.lent = new System.Windows.Forms.Label();
            this.Fcheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(12, 40);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(24, 20);
            this.Label.TabIndex = 0;
            this.Label.Text = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Price";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(18, 181);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(58, 20);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "Count";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(12, 108);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 20);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Object";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(591, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // Fid
            // 
            this.Fid.Location = new System.Drawing.Point(42, 38);
            this.Fid.Name = "Fid";
            this.Fid.Size = new System.Drawing.Size(100, 22);
            this.Fid.TabIndex = 6;
            // 
            // Fprice
            // 
            this.Fprice.Location = new System.Drawing.Point(350, 181);
            this.Fprice.Name = "Fprice";
            this.Fprice.Size = new System.Drawing.Size(100, 22);
            this.Fprice.TabIndex = 8;
            // 
            // Fobj
            // 
            this.Fobj.Location = new System.Drawing.Point(82, 108);
            this.Fobj.Name = "Fobj";
            this.Fobj.Size = new System.Drawing.Size(560, 22);
            this.Fobj.TabIndex = 9;
            // 
            // Fcount
            // 
            this.Fcount.Location = new System.Drawing.Point(82, 179);
            this.Fcount.Name = "Fcount";
            this.Fcount.Size = new System.Drawing.Size(100, 22);
            this.Fcount.TabIndex = 10;
            // 
            // Finvent
            // 
            this.Finvent.Location = new System.Drawing.Point(692, 34);
            this.Finvent.Name = "Finvent";
            this.Finvent.Size = new System.Drawing.Size(100, 22);
            this.Finvent.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(348, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(146, 396);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(101, 41);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(481, 396);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(104, 41);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 223);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowTemplate.Height = 24;
            this.Grid.Size = new System.Drawing.Size(776, 167);
            this.Grid.TabIndex = 15;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // lent
            // 
            this.lent.AutoSize = true;
            this.lent.Location = new System.Drawing.Point(1, 1);
            this.lent.Name = "lent";
            this.lent.Size = new System.Drawing.Size(44, 16);
            this.lent.TabIndex = 16;
            this.lent.Text = "label1";
            this.lent.Click += new System.EventHandler(this.lent_Click);
            // 
            // Fcheck
            // 
            this.Fcheck.AutoSize = true;
            this.Fcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fcheck.Location = new System.Drawing.Point(586, 177);
            this.Fcheck.Name = "Fcheck";
            this.Fcheck.Size = new System.Drawing.Size(122, 24);
            this.Fcheck.TabIndex = 18;
            this.Fcheck.Text = "checkBox1";
            this.Fcheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.Fcheck);
            this.Controls.Add(this.lent);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Finvent);
            this.Controls.Add(this.Fcount);
            this.Controls.Add(this.Fobj);
            this.Controls.Add(this.Fprice);
            this.Controls.Add(this.Fid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fid;
        private System.Windows.Forms.TextBox Fprice;
        private System.Windows.Forms.TextBox Fobj;
        private System.Windows.Forms.TextBox Fcount;
        private System.Windows.Forms.TextBox Finvent;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Label lent;
        private System.Windows.Forms.CheckBox Fcheck;
    }
}


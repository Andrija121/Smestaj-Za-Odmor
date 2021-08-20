namespace ZadatakOdmor
{
    partial class UserForm
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbAvailableAccommodations = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbConutry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tbMinPrice = new System.Windows.Forms.TextBox();
            this.tbMaxPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(562, 409);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(88, 52);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(348, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 26);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbAvailableAccommodations
            // 
            this.lbAvailableAccommodations.FormattingEnabled = true;
            this.lbAvailableAccommodations.ItemHeight = 20;
            this.lbAvailableAccommodations.Location = new System.Drawing.Point(12, 40);
            this.lbAvailableAccommodations.Name = "lbAvailableAccommodations";
            this.lbAvailableAccommodations.Size = new System.Drawing.Size(318, 424);
            this.lbAvailableAccommodations.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select Avaiable Accommodation to Reserve";
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(561, 188);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(88, 217);
            this.btnReserve.TabIndex = 21;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Start Date ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbMaxPrice);
            this.panel1.Controls.Add(this.tbMinPrice);
            this.panel1.Controls.Add(this.btnShowAll);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbConutry);
            this.panel1.Location = new System.Drawing.Point(336, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 276);
            this.panel1.TabIndex = 23;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(44, 231);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(116, 42);
            this.btnShowAll.TabIndex = 27;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(4, 180);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(205, 37);
            this.btnFilter.TabIndex = 31;
            this.btnFilter.Text = "Filter Price";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Price Per Night";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Country";
            // 
            // cbConutry
            // 
            this.cbConutry.FormattingEnabled = true;
            this.cbConutry.Location = new System.Drawing.Point(44, 35);
            this.cbConutry.Name = "cbConutry";
            this.cbConutry.Size = new System.Drawing.Size(116, 28);
            this.cbConutry.TabIndex = 25;
            this.cbConutry.SelectedIndexChanged += new System.EventHandler(this.cbConutry_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Filters";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "End Date ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(346, 108);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(292, 26);
            this.dateTimePicker2.TabIndex = 25;
            // 
            // tbMinPrice
            // 
            this.tbMinPrice.Location = new System.Drawing.Point(4, 148);
            this.tbMinPrice.Name = "tbMinPrice";
            this.tbMinPrice.Size = new System.Drawing.Size(82, 26);
            this.tbMinPrice.TabIndex = 32;
            // 
            // tbMaxPrice
            // 
            this.tbMaxPrice.Location = new System.Drawing.Point(127, 148);
            this.tbMaxPrice.Name = "tbMaxPrice";
            this.tbMaxPrice.Size = new System.Drawing.Size(82, 26);
            this.tbMaxPrice.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Min Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Max Price";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 475);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAvailableAccommodations);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnLogOut);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox lbAvailableAccommodations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbConutry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox tbMaxPrice;
        private System.Windows.Forms.TextBox tbMinPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
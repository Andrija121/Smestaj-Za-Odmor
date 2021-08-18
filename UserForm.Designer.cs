﻿namespace ZadatakOdmor
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
            this.rb100plus = new System.Windows.Forms.RadioButton();
            this.rbLess100more50 = new System.Windows.Forms.RadioButton();
            this.rbLess50 = new System.Windows.Forms.RadioButton();
            this.cbConutry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(375, 266);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(59, 22);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 26);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // lbAvailableAccommodations
            // 
            this.lbAvailableAccommodations.FormattingEnabled = true;
            this.lbAvailableAccommodations.Location = new System.Drawing.Point(8, 26);
            this.lbAvailableAccommodations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbAvailableAccommodations.Name = "lbAvailableAccommodations";
            this.lbAvailableAccommodations.Size = new System.Drawing.Size(213, 264);
            this.lbAvailableAccommodations.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select Avaiable Accommodation to Reserve";
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(374, 122);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(59, 141);
            this.btnReserve.TabIndex = 21;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Start Date ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowAll);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rb100plus);
            this.panel1.Controls.Add(this.rbLess100more50);
            this.panel1.Controls.Add(this.rbLess50);
            this.panel1.Controls.Add(this.cbConutry);
            this.panel1.Location = new System.Drawing.Point(224, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 167);
            this.panel1.TabIndex = 23;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(73, 138);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(67, 27);
            this.btnShowAll.TabIndex = 27;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(2, 138);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(67, 27);
            this.btnFilter.TabIndex = 31;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
          //  this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Price Per Night";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Country";
            // 
            // rb100plus
            // 
            this.rb100plus.AutoSize = true;
            this.rb100plus.Location = new System.Drawing.Point(29, 102);
            this.rb100plus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb100plus.Name = "rb100plus";
            this.rb100plus.Size = new System.Drawing.Size(52, 17);
            this.rb100plus.TabIndex = 28;
            this.rb100plus.TabStop = true;
            this.rb100plus.Text = "100 +";
            this.rb100plus.UseVisualStyleBackColor = true;
            this.rb100plus.CheckedChanged += new System.EventHandler(this.rb100plus_CheckedChanged);
            // 
            // rbLess100more50
            // 
            this.rbLess100more50.AutoSize = true;
            this.rbLess100more50.Location = new System.Drawing.Point(29, 83);
            this.rbLess100more50.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbLess100more50.Name = "rbLess100more50";
            this.rbLess100more50.Size = new System.Drawing.Size(64, 17);
            this.rbLess100more50.TabIndex = 27;
            this.rbLess100more50.TabStop = true;
            this.rbLess100more50.Text = "50 - 100";
            this.rbLess100more50.UseVisualStyleBackColor = true;
            this.rbLess100more50.CheckedChanged += new System.EventHandler(this.rbLess100more50_CheckedChanged);
            // 
            // rbLess50
            // 
            this.rbLess50.AutoSize = true;
            this.rbLess50.Location = new System.Drawing.Point(29, 63);
            this.rbLess50.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbLess50.Name = "rbLess50";
            this.rbLess50.Size = new System.Drawing.Size(46, 17);
            this.rbLess50.TabIndex = 26;
            this.rbLess50.TabStop = true;
            this.rbLess50.Text = "< 50";
            this.rbLess50.UseVisualStyleBackColor = true;
            this.rbLess50.CheckedChanged += new System.EventHandler(this.rbLess50_CheckedChanged);
            // 
            // cbConutry
            // 
            this.cbConutry.FormattingEnabled = true;
            this.cbConutry.Location = new System.Drawing.Point(29, 16);
            this.cbConutry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbConutry.Name = "cbConutry";
            this.cbConutry.Size = new System.Drawing.Size(79, 21);
            this.cbConutry.TabIndex = 25;
            this.cbConutry.SelectedIndexChanged += new System.EventHandler(this.cbConutry_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Filters";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "End Date ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(231, 70);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker2.TabIndex = 25;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 292);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.RadioButton rb100plus;
        private System.Windows.Forms.RadioButton rbLess100more50;
        private System.Windows.Forms.RadioButton rbLess50;
        private System.Windows.Forms.ComboBox cbConutry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnShowAll;
    }
}
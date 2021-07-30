namespace ZadatakOdmor
{
    partial class AdminForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveAccomodation = new System.Windows.Forms.Button();
            this.listBoxAccommodation = new System.Windows.Forms.ListBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.btnAddNewAccomodation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTown = new System.Windows.Forms.TextBox();
            this.tbPPN = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(711, 413);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(88, 34);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Remove Accomodation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Create New Accomodation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(316, -17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 484);
            this.panel1.TabIndex = 27;
            // 
            // btnRemoveAccomodation
            // 
            this.btnRemoveAccomodation.Location = new System.Drawing.Point(535, 349);
            this.btnRemoveAccomodation.Name = "btnRemoveAccomodation";
            this.btnRemoveAccomodation.Size = new System.Drawing.Size(120, 54);
            this.btnRemoveAccomodation.TabIndex = 26;
            this.btnRemoveAccomodation.Text = "Remove";
            this.btnRemoveAccomodation.UseVisualStyleBackColor = true;
            this.btnRemoveAccomodation.Click += new System.EventHandler(this.btnRemoveAccomodation_Click);
            // 
            // listBoxAccommodation
            // 
            this.listBoxAccommodation.FormattingEnabled = true;
            this.listBoxAccommodation.ItemHeight = 20;
            this.listBoxAccommodation.Location = new System.Drawing.Point(384, 60);
            this.listBoxAccommodation.Name = "listBoxAccommodation";
            this.listBoxAccommodation.Size = new System.Drawing.Size(615, 264);
            this.listBoxAccommodation.TabIndex = 25;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(151, 258);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(159, 28);
            this.cbCountry.TabIndex = 24;
            // 
            // btnAddNewAccomodation
            // 
            this.btnAddNewAccomodation.Location = new System.Drawing.Point(90, 330);
            this.btnAddNewAccomodation.Name = "btnAddNewAccomodation";
            this.btnAddNewAccomodation.Size = new System.Drawing.Size(121, 73);
            this.btnAddNewAccomodation.TabIndex = 23;
            this.btnAddNewAccomodation.Text = "Add New Accomodation";
            this.btnAddNewAccomodation.UseVisualStyleBackColor = true;
            this.btnAddNewAccomodation.Click += new System.EventHandler(this.btnAddNewAccomodation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Town";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Price Per Night";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // tbTown
            // 
            this.tbTown.Location = new System.Drawing.Point(151, 185);
            this.tbTown.Name = "tbTown";
            this.tbTown.Size = new System.Drawing.Size(100, 26);
            this.tbTown.TabIndex = 18;
            // 
            // tbPPN
            // 
            this.tbPPN.Location = new System.Drawing.Point(151, 128);
            this.tbPPN.Name = "tbPPN";
            this.tbPPN.Size = new System.Drawing.Size(100, 26);
            this.tbPPN.TabIndex = 17;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(151, 76);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 26);
            this.tbName.TabIndex = 16;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemoveAccomodation);
            this.Controls.Add(this.listBoxAccommodation);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.btnAddNewAccomodation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTown);
            this.Controls.Add(this.tbPPN);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnLogOut);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemoveAccomodation;
        private System.Windows.Forms.ListBox listBoxAccommodation;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Button btnAddNewAccomodation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTown;
        private System.Windows.Forms.TextBox tbPPN;
        private System.Windows.Forms.TextBox tbName;
    }
}
namespace CarApp.UserControls
{
    partial class SP_ViewRequests
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
            lbRequests = new ListBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            tbEmail = new TextBox();
            tbFullName = new TextBox();
            groupBox2 = new GroupBox();
            tbMileage = new TextBox();
            label8 = new Label();
            tbYear = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tbMake = new TextBox();
            tbModel = new TextBox();
            label1 = new Label();
            btnAccept = new Button();
            btnDeny = new Button();
            btnSelect = new Button();
            groupBox4 = new GroupBox();
            cbInspection = new CheckBox();
            cbWax = new CheckBox();
            cbCoolant = new CheckBox();
            cbTyres = new CheckBox();
            cbLightBulb = new CheckBox();
            cbFilter = new CheckBox();
            cbOil = new CheckBox();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // lbRequests
            // 
            lbRequests.FormattingEnabled = true;
            lbRequests.ItemHeight = 20;
            lbRequests.Location = new Point(15, 37);
            lbRequests.Name = "lbRequests";
            lbRequests.Size = new Size(399, 444);
            lbRequests.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(tbFullName);
            groupBox1.Location = new Point(430, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 104);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 65);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 6;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 5;
            label2.Text = "Full name:";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.Location = new Point(96, 62);
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(209, 28);
            tbEmail.TabIndex = 4;
            // 
            // tbFullName
            // 
            tbFullName.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbFullName.Location = new Point(96, 23);
            tbFullName.Name = "tbFullName";
            tbFullName.ReadOnly = true;
            tbFullName.Size = new Size(209, 28);
            tbFullName.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbMileage);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tbYear);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbMake);
            groupBox2.Controls.Add(tbModel);
            groupBox2.Location = new Point(430, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(376, 180);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Car information";
            // 
            // tbMileage
            // 
            tbMileage.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbMileage.Location = new Point(96, 136);
            tbMileage.Name = "tbMileage";
            tbMileage.ReadOnly = true;
            tbMileage.Size = new Size(158, 28);
            tbMileage.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(21, 139);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 9;
            label8.Text = "Mileage:";
            // 
            // tbYear
            // 
            tbYear.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbYear.Location = new Point(167, 102);
            tbYear.Name = "tbYear";
            tbYear.ReadOnly = true;
            tbYear.Size = new Size(125, 28);
            tbYear.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(16, 105);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 3;
            label6.Text = "Year of production:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 71);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 8;
            label5.Text = "Model:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 37);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Make:";
            // 
            // tbMake
            // 
            tbMake.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbMake.Location = new Point(81, 34);
            tbMake.Name = "tbMake";
            tbMake.ReadOnly = true;
            tbMake.Size = new Size(211, 28);
            tbMake.TabIndex = 5;
            // 
            // tbModel
            // 
            tbModel.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbModel.Location = new Point(81, 68);
            tbModel.Name = "tbModel";
            tbModel.ReadOnly = true;
            tbModel.Size = new Size(211, 28);
            tbModel.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 2;
            label1.Text = "Repair requests:";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(835, 399);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(166, 38);
            btnAccept.TabIndex = 3;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnDeny
            // 
            btnDeny.Location = new Point(835, 443);
            btnDeny.Name = "btnDeny";
            btnDeny.Size = new Size(166, 38);
            btnDeny.TabIndex = 4;
            btnDeny.Text = "Deny";
            btnDeny.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(15, 500);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(399, 29);
            btnSelect.TabIndex = 5;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbInspection);
            groupBox4.Controls.Add(cbWax);
            groupBox4.Controls.Add(cbCoolant);
            groupBox4.Controls.Add(cbTyres);
            groupBox4.Controls.Add(cbLightBulb);
            groupBox4.Controls.Add(cbFilter);
            groupBox4.Controls.Add(cbOil);
            groupBox4.Location = new Point(812, 48);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(171, 269);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Options selected";
            // 
            // cbInspection
            // 
            cbInspection.AutoSize = true;
            cbInspection.Enabled = false;
            cbInspection.Location = new Point(6, 216);
            cbInspection.Name = "cbInspection";
            cbInspection.Size = new Size(154, 24);
            cbInspection.TabIndex = 9;
            cbInspection.Text = "General inspection";
            cbInspection.UseVisualStyleBackColor = true;
            // 
            // cbWax
            // 
            cbWax.AutoSize = true;
            cbWax.Enabled = false;
            cbWax.Location = new Point(6, 186);
            cbWax.Name = "cbWax";
            cbWax.Size = new Size(59, 24);
            cbWax.TabIndex = 8;
            cbWax.Text = "Wax";
            cbWax.UseVisualStyleBackColor = true;
            // 
            // cbCoolant
            // 
            cbCoolant.AutoSize = true;
            cbCoolant.Enabled = false;
            cbCoolant.Location = new Point(6, 156);
            cbCoolant.Name = "cbCoolant";
            cbCoolant.Size = new Size(135, 24);
            cbCoolant.TabIndex = 7;
            cbCoolant.Text = "Coolant change";
            cbCoolant.UseVisualStyleBackColor = true;
            // 
            // cbTyres
            // 
            cbTyres.AutoSize = true;
            cbTyres.Enabled = false;
            cbTyres.Location = new Point(6, 126);
            cbTyres.Name = "cbTyres";
            cbTyres.Size = new Size(110, 24);
            cbTyres.TabIndex = 6;
            cbTyres.Text = "Tyre change";
            cbTyres.UseVisualStyleBackColor = true;
            // 
            // cbLightBulb
            // 
            cbLightBulb.AutoSize = true;
            cbLightBulb.Enabled = false;
            cbLightBulb.Location = new Point(6, 96);
            cbLightBulb.Name = "cbLightBulb";
            cbLightBulb.Size = new Size(150, 24);
            cbLightBulb.TabIndex = 5;
            cbLightBulb.Text = "Light bulb change";
            cbLightBulb.UseVisualStyleBackColor = true;
            // 
            // cbFilter
            // 
            cbFilter.AutoSize = true;
            cbFilter.Enabled = false;
            cbFilter.Location = new Point(6, 66);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(137, 24);
            cbFilter.TabIndex = 4;
            cbFilter.Text = "Air filter change";
            cbFilter.UseVisualStyleBackColor = true;
            // 
            // cbOil
            // 
            cbOil.AutoSize = true;
            cbOil.Enabled = false;
            cbOil.Location = new Point(6, 36);
            cbOil.Name = "cbOil";
            cbOil.Size = new Size(102, 24);
            cbOil.TabIndex = 3;
            cbOil.Text = "Oil change";
            cbOil.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(430, 343);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(399, 196);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(430, 320);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 8;
            label7.Text = "Message:";
            // 
            // SP_ViewRequests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(richTextBox1);
            Controls.Add(groupBox4);
            Controls.Add(btnSelect);
            Controls.Add(btnDeny);
            Controls.Add(btnAccept);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lbRequests);
            Name = "SP_ViewRequests";
            Size = new Size(1010, 558);
            Load += SP_ViewRequests_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbRequests;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox tbEmail;
        private TextBox tbFullName;
        private GroupBox groupBox2;
        private TextBox tbYear;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tbMake;
        private TextBox tbModel;
        private Label label1;
        private Button btnAccept;
        private Button btnDeny;
        private Button btnSelect;
        private TextBox tbMileage;
        private Label label8;
        private GroupBox groupBox4;
        private CheckBox cbInspection;
        private CheckBox cbWax;
        private CheckBox cbCoolant;
        private CheckBox cbTyres;
        private CheckBox cbLightBulb;
        private CheckBox cbFilter;
        private CheckBox cbOil;
        private RichTextBox richTextBox1;
        private Label label7;
    }
}

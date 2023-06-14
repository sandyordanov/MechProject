namespace CarApp.UserControls
{
    partial class SP_ManageMechanics
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
            lbDisplay = new ListBox();
            label1 = new Label();
            btnShowInfo = new Button();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            label5 = new Label();
            tbSearch = new TextBox();
            label6 = new Label();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            tbShowSpecialisation = new RichTextBox();
            label14 = new Label();
            tbShowPhone = new TextBox();
            btnIamSure = new Button();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbShowLastName = new TextBox();
            tbShowFirstName = new TextBox();
            btnFire = new Button();
            btnPromote = new Button();
            btnAddNew = new Button();
            tbAddName = new TextBox();
            tbAddLastName = new TextBox();
            tbAddPhone = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            lblPassword = new Label();
            tbPassword = new TextBox();
            tbSpecialisation = new RichTextBox();
            label13 = new Label();
            groupBox2 = new GroupBox();
            nUpNDownLevel = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUpNDownLevel).BeginInit();
            SuspendLayout();
            // 
            // lbDisplay
            // 
            lbDisplay.FormattingEnabled = true;
            lbDisplay.ItemHeight = 20;
            lbDisplay.Location = new Point(20, 75);
            lbDisplay.Name = "lbDisplay";
            lbDisplay.Size = new Size(321, 424);
            lbDisplay.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 52);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 1;
            label1.Text = "Mechanics:";
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(20, 505);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(321, 42);
            btnShowInfo.TabIndex = 4;
            btnShowInfo.Text = "View information";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mechanic;
            pictureBox1.Location = new Point(6, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 136);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(216, 204);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(347, 29);
            progressBar1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(216, 181);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 13;
            label5.Text = "Apprentice";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(75, 17);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(165, 27);
            tbSearch.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 20);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 15;
            label6.Text = "Search:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(246, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbShowSpecialisation);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(tbShowPhone);
            groupBox1.Controls.Add(btnIamSure);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbShowLastName);
            groupBox1.Controls.Add(tbShowFirstName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnFire);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(btnPromote);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(369, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(624, 272);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // tbShowSpecialisation
            // 
            tbShowSpecialisation.Location = new Point(419, 25);
            tbShowSpecialisation.Name = "tbShowSpecialisation";
            tbShowSpecialisation.Size = new Size(187, 120);
            tbShowSpecialisation.TabIndex = 28;
            tbShowSpecialisation.Text = "";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(156, 94);
            label14.Name = "label14";
            label14.Size = new Size(53, 20);
            label14.TabIndex = 24;
            label14.Text = "Phone:";
            // 
            // tbShowPhone
            // 
            tbShowPhone.Location = new Point(241, 91);
            tbShowPhone.Name = "tbShowPhone";
            tbShowPhone.ReadOnly = true;
            tbShowPhone.Size = new Size(169, 27);
            tbShowPhone.TabIndex = 23;
            // 
            // btnIamSure
            // 
            btnIamSure.Location = new Point(20, 239);
            btnIamSure.Name = "btnIamSure";
            btnIamSure.Size = new Size(94, 29);
            btnIamSure.TabIndex = 22;
            btnIamSure.Text = "Cofirm";
            btnIamSure.UseVisualStyleBackColor = true;
            btnIamSure.Visible = false;
            btnIamSure.Click += btnIamSure_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(509, 181);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 19;
            label8.Text = "Master";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(371, 181);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 18;
            label7.Text = "Regular";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 61);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 19;
            label3.Text = "Last name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 28);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 18;
            label2.Text = "First name:";
            // 
            // tbShowLastName
            // 
            tbShowLastName.Location = new Point(241, 58);
            tbShowLastName.Name = "tbShowLastName";
            tbShowLastName.ReadOnly = true;
            tbShowLastName.Size = new Size(169, 27);
            tbShowLastName.TabIndex = 16;
            // 
            // tbShowFirstName
            // 
            tbShowFirstName.Location = new Point(242, 25);
            tbShowFirstName.Name = "tbShowFirstName";
            tbShowFirstName.ReadOnly = true;
            tbShowFirstName.Size = new Size(169, 27);
            tbShowFirstName.TabIndex = 15;
            // 
            // btnFire
            // 
            btnFire.Location = new Point(20, 204);
            btnFire.Name = "btnFire";
            btnFire.Size = new Size(94, 29);
            btnFire.TabIndex = 14;
            btnFire.Text = "Fire";
            btnFire.UseVisualStyleBackColor = true;
            btnFire.Click += btnFire_Click;
            // 
            // btnPromote
            // 
            btnPromote.Location = new Point(20, 168);
            btnPromote.Name = "btnPromote";
            btnPromote.Size = new Size(94, 29);
            btnPromote.TabIndex = 13;
            btnPromote.Text = "Promote";
            btnPromote.UseVisualStyleBackColor = true;
            btnPromote.Click += btnPromote_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(326, 174);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(154, 42);
            btnAddNew.TabIndex = 18;
            btnAddNew.Text = "Add new mechanic";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // tbAddName
            // 
            tbAddName.Location = new Point(131, 45);
            tbAddName.Name = "tbAddName";
            tbAddName.Size = new Size(125, 27);
            tbAddName.TabIndex = 19;
            // 
            // tbAddLastName
            // 
            tbAddLastName.Location = new Point(131, 86);
            tbAddLastName.Name = "tbAddLastName";
            tbAddLastName.Size = new Size(125, 27);
            tbAddLastName.TabIndex = 20;
            // 
            // tbAddPhone
            // 
            tbAddPhone.Location = new Point(131, 124);
            tbAddPhone.Name = "tbAddPhone";
            tbAddPhone.Size = new Size(125, 27);
            tbAddPhone.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 48);
            label10.Name = "label10";
            label10.Size = new Size(79, 20);
            label10.TabIndex = 22;
            label10.Text = "FirstName:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 89);
            label11.Name = "label11";
            label11.Size = new Size(78, 20);
            label11.TabIndex = 23;
            label11.Text = "LastName:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 127);
            label12.Name = "label12";
            label12.Size = new Size(108, 20);
            label12.TabIndex = 24;
            label12.Text = "Phone number:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(22, 166);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 25;
            lblPassword.Text = "Password:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(131, 163);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(125, 27);
            tbPassword.TabIndex = 26;
            // 
            // tbSpecialisation
            // 
            tbSpecialisation.Location = new Point(315, 48);
            tbSpecialisation.Name = "tbSpecialisation";
            tbSpecialisation.Size = new Size(187, 120);
            tbSpecialisation.TabIndex = 27;
            tbSpecialisation.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(285, 25);
            label13.Name = "label13";
            label13.Size = new Size(207, 20);
            label13.TabIndex = 22;
            label13.Text = "Add mechanic specialisations:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nUpNDownLevel);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbAddLastName);
            groupBox2.Controls.Add(btnAddNew);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(tbAddName);
            groupBox2.Controls.Add(tbSpecialisation);
            groupBox2.Controls.Add(tbAddPhone);
            groupBox2.Controls.Add(tbPassword);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(lblPassword);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(400, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(545, 252);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add new mechanic";
            // 
            // nUpNDownLevel
            // 
            nUpNDownLevel.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            nUpNDownLevel.Location = new Point(131, 206);
            nUpNDownLevel.Name = "nUpNDownLevel";
            nUpNDownLevel.Size = new Size(125, 27);
            nUpNDownLevel.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 208);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 28;
            label4.Text = "MechLevel";
            // 
            // SP_ManageMechanics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnSearch);
            Controls.Add(btnShowInfo);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(lbDisplay);
            Controls.Add(tbSearch);
            Name = "SP_ManageMechanics";
            Size = new Size(1005, 560);
            Load += SP_ManageMechanics_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUpNDownLevel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbDisplay;
        private Label label1;
        private Button btnShowInfo;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Label label5;
        private TextBox tbSearch;
        private Label label6;
        private Button btnSearch;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label2;
        private TextBox tbShowLastName;
        private TextBox tbShowFirstName;
        private Button btnFire;
        private Button btnPromote;
        private Button btnAddNew;
        private TextBox tbAddName;
        private TextBox tbAddLastName;
        private TextBox tbAddPhone;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label lblPassword;
        private TextBox tbPassword;
        private RichTextBox tbSpecialisation;
        private Label label13;
        private GroupBox groupBox2;
        private Button btnIamSure;
        private Label label14;
        private TextBox tbShowPhone;
        private RichTextBox tbShowSpecialisation;
        private NumericUpDown nUpNDownLevel;
        private Label label4;
    }
}

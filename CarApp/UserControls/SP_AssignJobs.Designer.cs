namespace CarApp.UserControls
{
    partial class SP_AssignJobs
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
            lbMechanics = new ListBox();
            btnAssign = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbKeywordsRequest = new RichTextBox();
            tbKeywordsMechanic = new RichTextBox();
            btnFindMatch = new Button();
            SuspendLayout();
            // 
            // lbRequests
            // 
            lbRequests.FormattingEnabled = true;
            lbRequests.ItemHeight = 20;
            lbRequests.Location = new Point(20, 142);
            lbRequests.Name = "lbRequests";
            lbRequests.Size = new Size(470, 224);
            lbRequests.TabIndex = 0;
            lbRequests.SelectedIndexChanged += lbRequests_SelectedIndexChanged;
            // 
            // lbMechanics
            // 
            lbMechanics.FormattingEnabled = true;
            lbMechanics.ItemHeight = 20;
            lbMechanics.Location = new Point(519, 142);
            lbMechanics.Name = "lbMechanics";
            lbMechanics.Size = new Size(470, 224);
            lbMechanics.TabIndex = 1;
            lbMechanics.SelectedIndexChanged += lbMechanics_SelectedIndexChanged;
            // 
            // btnAssign
            // 
            btnAssign.Location = new Point(394, 462);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(215, 52);
            btnAssign.TabIndex = 2;
            btnAssign.Text = "Assign job";
            btnAssign.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 113);
            label1.Name = "label1";
            label1.Size = new Size(254, 26);
            label1.TabIndex = 3;
            label1.Text = "Approved repair requests:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(519, 113);
            label2.Name = "label2";
            label2.Size = new Size(116, 26);
            label2.TabIndex = 4;
            label2.Text = "Mechanics:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 388);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(366, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(613, 388);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(376, 27);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(323, 17);
            label3.Name = "label3";
            label3.Size = new Size(363, 34);
            label3.TabIndex = 7;
            label3.Text = "Job Assignment Management";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 418);
            label4.Name = "label4";
            label4.Size = new Size(166, 20);
            label4.TabIndex = 8;
            label4.Text = "*selected repair request";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(852, 418);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 9;
            label5.Text = "*selected mechanic";
            // 
            // tbKeywordsRequest
            // 
            tbKeywordsRequest.Location = new Point(192, 421);
            tbKeywordsRequest.Name = "tbKeywordsRequest";
            tbKeywordsRequest.Size = new Size(185, 104);
            tbKeywordsRequest.TabIndex = 10;
            tbKeywordsRequest.Text = "";
            // 
            // tbKeywordsMechanic
            // 
            tbKeywordsMechanic.Location = new Point(625, 421);
            tbKeywordsMechanic.Name = "tbKeywordsMechanic";
            tbKeywordsMechanic.Size = new Size(185, 104);
            tbKeywordsMechanic.TabIndex = 11;
            tbKeywordsMechanic.Text = "";
            // 
            // btnFindMatch
            // 
            btnFindMatch.Location = new Point(421, 386);
            btnFindMatch.Name = "btnFindMatch";
            btnFindMatch.Size = new Size(165, 52);
            btnFindMatch.TabIndex = 12;
            btnFindMatch.Text = "Find a match";
            btnFindMatch.UseVisualStyleBackColor = true;
            btnFindMatch.Click += btnFindMatch_Click;
            // 
            // SP_AssignJobs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnFindMatch);
            Controls.Add(tbKeywordsMechanic);
            Controls.Add(tbKeywordsRequest);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAssign);
            Controls.Add(lbMechanics);
            Controls.Add(lbRequests);
            Name = "SP_AssignJobs";
            Size = new Size(1010, 558);
            Load += SP_AssignJobs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbRequests;
        private ListBox lbMechanics;
        private Button btnAssign;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox tbKeywordsRequest;
        private RichTextBox tbKeywordsMechanic;
        private Button btnFindMatch;
    }
}

namespace CarApp.Forms
{
    partial class ServicePoint_Form
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
            panel1 = new Panel();
            btnReviewAppointments = new Button();
            btnAssignJobs = new Button();
            btnEvaluatePrice = new Button();
            btnManageMechanics = new Button();
            btnLogOut = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(121, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 560);
            panel1.TabIndex = 1;
            // 
            // btnReviewAppointments
            // 
            btnReviewAppointments.Location = new Point(0, 126);
            btnReviewAppointments.Name = "btnReviewAppointments";
            btnReviewAppointments.Size = new Size(120, 69);
            btnReviewAppointments.TabIndex = 5;
            btnReviewAppointments.Text = "Repair Requests";
            btnReviewAppointments.UseVisualStyleBackColor = true;
            btnReviewAppointments.Click += btnReviewAppointments_Click;
            // 
            // btnAssignJobs
            // 
            btnAssignJobs.Location = new Point(0, 201);
            btnAssignJobs.Name = "btnAssignJobs";
            btnAssignJobs.Size = new Size(120, 69);
            btnAssignJobs.TabIndex = 6;
            btnAssignJobs.Text = "Assign jobs";
            btnAssignJobs.UseVisualStyleBackColor = true;
            btnAssignJobs.Click += btnAssignJobs_Click;
            // 
            // btnEvaluatePrice
            // 
            btnEvaluatePrice.Location = new Point(0, 276);
            btnEvaluatePrice.Name = "btnEvaluatePrice";
            btnEvaluatePrice.Size = new Size(120, 69);
            btnEvaluatePrice.TabIndex = 7;
            btnEvaluatePrice.Text = "Evaluate price";
            btnEvaluatePrice.UseVisualStyleBackColor = true;
            btnEvaluatePrice.Click += btnEvaluatePrice_Click;
            // 
            // btnManageMechanics
            // 
            btnManageMechanics.Location = new Point(0, 351);
            btnManageMechanics.Name = "btnManageMechanics";
            btnManageMechanics.Size = new Size(120, 69);
            btnManageMechanics.TabIndex = 8;
            btnManageMechanics.Text = "Manage mechanics";
            btnManageMechanics.UseVisualStyleBackColor = true;
            btnManageMechanics.Click += btnManageMechanics_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(0, 480);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(120, 69);
            btnLogOut.TabIndex = 9;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_1001386094_612x612;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // ServicePoint_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 561);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogOut);
            Controls.Add(btnManageMechanics);
            Controls.Add(btnEvaluatePrice);
            Controls.Add(btnAssignJobs);
            Controls.Add(btnReviewAppointments);
            Controls.Add(panel1);
            Name = "ServicePoint_Form";
            Text = "ServicePoint_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnReviewAppointments;
        private Button btnAssignJobs;
        private Button btnEvaluatePrice;
        private Button btnManageMechanics;
        private Button btnLogOut;
        private PictureBox pictureBox1;
    }
}
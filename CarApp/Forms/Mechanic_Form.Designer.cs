namespace CarApp.Forms
{
    partial class Mechanic_Form
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
            btnViewAssigned = new Button();
            panel1 = new Panel();
            btnRepair = new Button();
            btnInspect = new Button();
            button4 = new Button();
            btnSeeInfo = new Button();
            btnLogOut = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnViewAssigned
            // 
            btnViewAssigned.Location = new Point(-1, 126);
            btnViewAssigned.Name = "btnViewAssigned";
            btnViewAssigned.Size = new Size(120, 69);
            btnViewAssigned.TabIndex = 0;
            btnViewAssigned.Text = "View Assigned";
            btnViewAssigned.UseVisualStyleBackColor = true;
            btnViewAssigned.Click += btnViewAssigned_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(119, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 558);
            panel1.TabIndex = 1;
            // 
            // btnRepair
            // 
            btnRepair.Location = new Point(-1, 276);
            btnRepair.Name = "btnRepair";
            btnRepair.Size = new Size(120, 69);
            btnRepair.TabIndex = 2;
            btnRepair.Text = "Repair";
            btnRepair.UseVisualStyleBackColor = true;
            // 
            // btnInspect
            // 
            btnInspect.Location = new Point(-1, 201);
            btnInspect.Name = "btnInspect";
            btnInspect.Size = new Size(120, 69);
            btnInspect.TabIndex = 3;
            btnInspect.Text = "Inspect";
            btnInspect.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(-1, 351);
            button4.Name = "button4";
            button4.Size = new Size(120, 69);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            // 
            // btnSeeInfo
            // 
            btnSeeInfo.Location = new Point(-1, 426);
            btnSeeInfo.Name = "btnSeeInfo";
            btnSeeInfo.Size = new Size(120, 69);
            btnSeeInfo.TabIndex = 5;
            btnSeeInfo.Text = "Account";
            btnSeeInfo.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(-1, 501);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(120, 69);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_1001386094_612x612;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Mechanic_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 561);
            Controls.Add(btnSeeInfo);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogOut);
            Controls.Add(button4);
            Controls.Add(btnInspect);
            Controls.Add(btnRepair);
            Controls.Add(panel1);
            Controls.Add(btnViewAssigned);
            Name = "Mechanic_Form";
            Text = "Mechanic_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewAssigned;
        private Panel panel1;
        private Button btnRepair;
        private Button btnInspect;
        private Button button4;
        private Button btnSeeInfo;
        private Button btnLogOut;
        private PictureBox pictureBox1;
    }
}
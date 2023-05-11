namespace CarApp.UserControls
{
    partial class Mechanic_ViewJobs
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
            lbAssignedCars = new ListBox();
            btnSelect = new Button();
            SuspendLayout();
            // 
            // lbAssignedCars
            // 
            lbAssignedCars.FormattingEnabled = true;
            lbAssignedCars.ItemHeight = 20;
            lbAssignedCars.Location = new Point(3, 3);
            lbAssignedCars.Name = "lbAssignedCars";
            lbAssignedCars.Size = new Size(621, 264);
            lbAssignedCars.TabIndex = 0;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(3, 273);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // Mechanic_ViewJobs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSelect);
            Controls.Add(lbAssignedCars);
            Name = "Mechanic_ViewJobs";
            Size = new Size(1010, 558);
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbAssignedCars;
        private Button btnSelect;
    }
}

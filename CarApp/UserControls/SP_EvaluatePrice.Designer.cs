namespace CarApp.UserControls
{
    partial class SP_EvaluatePrice
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
            groupBox3 = new GroupBox();
            cbInspection = new CheckBox();
            cbWax = new CheckBox();
            cbCoolant = new CheckBox();
            cbTyres = new CheckBox();
            cbLightBulb = new CheckBox();
            cbFilter = new CheckBox();
            cbOil = new CheckBox();
            btnCalculateOptions = new Button();
            lbOwner = new Label();
            lbCar = new Label();
            groupBox1 = new GroupBox();
            lbRepairsDone = new ListBox();
            btnSelect = new Button();
            tbInformation = new RichTextBox();
            label1 = new Label();
            upDownPrice = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            upDownOptions = new NumericUpDown();
            label4 = new Label();
            upDownTotal = new NumericUpDown();
            btnEvaluationDone = new Button();
            button1 = new Button();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)upDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownOptions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownTotal).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnCalculateOptions);
            groupBox3.Controls.Add(cbInspection);
            groupBox3.Controls.Add(cbWax);
            groupBox3.Controls.Add(cbCoolant);
            groupBox3.Controls.Add(cbTyres);
            groupBox3.Controls.Add(cbLightBulb);
            groupBox3.Controls.Add(cbFilter);
            groupBox3.Controls.Add(cbOil);
            groupBox3.Location = new Point(826, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(171, 303);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Options selected";
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
            // btnCalculateOptions
            // 
            btnCalculateOptions.Location = new Point(38, 258);
            btnCalculateOptions.Name = "btnCalculateOptions";
            btnCalculateOptions.Size = new Size(94, 29);
            btnCalculateOptions.TabIndex = 10;
            btnCalculateOptions.Text = "Calculate";
            btnCalculateOptions.UseVisualStyleBackColor = true;
            // 
            // lbOwner
            // 
            lbOwner.AutoSize = true;
            lbOwner.Location = new Point(6, 30);
            lbOwner.Name = "lbOwner";
            lbOwner.Size = new Size(134, 28);
            lbOwner.TabIndex = 2;
            lbOwner.Text = "Owner name:";
            // 
            // lbCar
            // 
            lbCar.AutoSize = true;
            lbCar.Location = new Point(6, 60);
            lbCar.Name = "lbCar";
            lbCar.Size = new Size(47, 28);
            lbCar.TabIndex = 3;
            lbCar.Text = "Car:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbOwner);
            groupBox1.Controls.Add(lbCar);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 120);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // lbRepairsDone
            // 
            lbRepairsDone.FormattingEnabled = true;
            lbRepairsDone.ItemHeight = 20;
            lbRepairsDone.Location = new Point(417, 35);
            lbRepairsDone.Name = "lbRepairsDone";
            lbRepairsDone.Size = new Size(388, 104);
            lbRepairsDone.TabIndex = 5;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(711, 145);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 6;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // tbInformation
            // 
            tbInformation.Location = new Point(18, 172);
            tbInformation.Name = "tbInformation";
            tbInformation.Size = new Size(362, 167);
            tbInformation.TabIndex = 7;
            tbInformation.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 149);
            label1.Name = "label1";
            label1.Size = new Size(235, 20);
            label1.TabIndex = 8;
            label1.Text = "Information about selected repair:";
            // 
            // upDownPrice
            // 
            upDownPrice.Location = new Point(187, 349);
            upDownPrice.Name = "upDownPrice";
            upDownPrice.Size = new Size(150, 27);
            upDownPrice.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 351);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 10;
            label2.Text = "Evaluate price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 379);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 12;
            label3.Text = "Estimated options cost:\r\n";
            // 
            // upDownOptions
            // 
            upDownOptions.Location = new Point(187, 377);
            upDownOptions.Name = "upDownOptions";
            upDownOptions.ReadOnly = true;
            upDownOptions.Size = new Size(150, 27);
            upDownOptions.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 407);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 14;
            label4.Text = "Total:";
            // 
            // upDownTotal
            // 
            upDownTotal.Location = new Point(187, 405);
            upDownTotal.Name = "upDownTotal";
            upDownTotal.ReadOnly = true;
            upDownTotal.Size = new Size(150, 27);
            upDownTotal.TabIndex = 13;
            // 
            // btnEvaluationDone
            // 
            btnEvaluationDone.Location = new Point(93, 447);
            btnEvaluationDone.Name = "btnEvaluationDone";
            btnEvaluationDone.Size = new Size(133, 53);
            btnEvaluationDone.TabIndex = 15;
            btnEvaluationDone.Text = "Evaluation done";
            btnEvaluationDone.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(842, 337);
            button1.Name = "button1";
            button1.Size = new Size(144, 48);
            button1.TabIndex = 16;
            button1.Text = "Change service costs";
            button1.UseVisualStyleBackColor = true;
            // 
            // SP_EvaluatePrice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(btnEvaluationDone);
            Controls.Add(label4);
            Controls.Add(upDownTotal);
            Controls.Add(label3);
            Controls.Add(upDownOptions);
            Controls.Add(label2);
            Controls.Add(upDownPrice);
            Controls.Add(label1);
            Controls.Add(tbInformation);
            Controls.Add(btnSelect);
            Controls.Add(lbRepairsDone);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "SP_EvaluatePrice";
            Size = new Size(1010, 558);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)upDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownOptions).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private Button btnCalculateOptions;
        private CheckBox cbInspection;
        private CheckBox cbWax;
        private CheckBox cbCoolant;
        private CheckBox cbTyres;
        private CheckBox cbLightBulb;
        private CheckBox cbFilter;
        private CheckBox cbOil;
        private Label lbOwner;
        private Label lbCar;
        private GroupBox groupBox1;
        private ListBox lbRepairsDone;
        private Button btnSelect;
        private RichTextBox tbInformation;
        private Label label1;
        private NumericUpDown upDownPrice;
        private Label label2;
        private Label label3;
        private NumericUpDown upDownOptions;
        private Label label4;
        private NumericUpDown upDownTotal;
        private Button btnEvaluationDone;
        private Button button1;
    }
}

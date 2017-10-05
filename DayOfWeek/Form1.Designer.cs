namespace DayOfWeek
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.gboxRadioButton = new System.Windows.Forms.GroupBox();
            this.rbnSunday = new System.Windows.Forms.RadioButton();
            this.rbnSaturday = new System.Windows.Forms.RadioButton();
            this.rbnFriday = new System.Windows.Forms.RadioButton();
            this.rbnThursday = new System.Windows.Forms.RadioButton();
            this.rbnWednesday = new System.Windows.Forms.RadioButton();
            this.rbnTuesday = new System.Windows.Forms.RadioButton();
            this.rbnMonday = new System.Windows.Forms.RadioButton();
            this.lblErrors = new System.Windows.Forms.Label();
            this.lblSolution = new System.Windows.Forms.Label();
            this.btnCalculateClasses = new System.Windows.Forms.Button();
            this.gboxRadioButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Insert your name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 98);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(77, 13);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Insert yout age";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(12, 65);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(362, 20);
            this.tbxName.TabIndex = 2;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(12, 124);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(362, 20);
            this.tbxAge.TabIndex = 3;
            this.tbxAge.TextChanged += new System.EventHandler(this.tbxAge_TextChanged);
            // 
            // gboxRadioButton
            // 
            this.gboxRadioButton.Controls.Add(this.rbnSunday);
            this.gboxRadioButton.Controls.Add(this.rbnSaturday);
            this.gboxRadioButton.Controls.Add(this.rbnFriday);
            this.gboxRadioButton.Controls.Add(this.rbnThursday);
            this.gboxRadioButton.Controls.Add(this.rbnWednesday);
            this.gboxRadioButton.Controls.Add(this.rbnTuesday);
            this.gboxRadioButton.Controls.Add(this.rbnMonday);
            this.gboxRadioButton.Location = new System.Drawing.Point(12, 164);
            this.gboxRadioButton.Name = "gboxRadioButton";
            this.gboxRadioButton.Size = new System.Drawing.Size(362, 48);
            this.gboxRadioButton.TabIndex = 4;
            this.gboxRadioButton.TabStop = false;
            this.gboxRadioButton.Text = "Select a day of week";
            // 
            // rbnSunday
            // 
            this.rbnSunday.AutoSize = true;
            this.rbnSunday.Location = new System.Drawing.Point(233, 20);
            this.rbnSunday.Name = "rbnSunday";
            this.rbnSunday.Size = new System.Drawing.Size(31, 17);
            this.rbnSunday.TabIndex = 6;
            this.rbnSunday.TabStop = true;
            this.rbnSunday.Text = "7";
            this.rbnSunday.UseVisualStyleBackColor = true;
            this.rbnSunday.CheckedChanged += new System.EventHandler(this.rbnSunday_CheckedChanged);
            // 
            // rbnSaturday
            // 
            this.rbnSaturday.AutoSize = true;
            this.rbnSaturday.Location = new System.Drawing.Point(195, 20);
            this.rbnSaturday.Name = "rbnSaturday";
            this.rbnSaturday.Size = new System.Drawing.Size(31, 17);
            this.rbnSaturday.TabIndex = 5;
            this.rbnSaturday.TabStop = true;
            this.rbnSaturday.Text = "6";
            this.rbnSaturday.UseVisualStyleBackColor = true;
            this.rbnSaturday.CheckedChanged += new System.EventHandler(this.rbnSaturday_CheckedChanged);
            // 
            // rbnFriday
            // 
            this.rbnFriday.AutoSize = true;
            this.rbnFriday.Location = new System.Drawing.Point(157, 20);
            this.rbnFriday.Name = "rbnFriday";
            this.rbnFriday.Size = new System.Drawing.Size(31, 17);
            this.rbnFriday.TabIndex = 4;
            this.rbnFriday.TabStop = true;
            this.rbnFriday.Text = "5";
            this.rbnFriday.UseVisualStyleBackColor = true;
            this.rbnFriday.CheckedChanged += new System.EventHandler(this.rbnFriday_CheckedChanged);
            // 
            // rbnThursday
            // 
            this.rbnThursday.AutoSize = true;
            this.rbnThursday.Location = new System.Drawing.Point(119, 20);
            this.rbnThursday.Name = "rbnThursday";
            this.rbnThursday.Size = new System.Drawing.Size(31, 17);
            this.rbnThursday.TabIndex = 3;
            this.rbnThursday.TabStop = true;
            this.rbnThursday.Text = "4";
            this.rbnThursday.UseVisualStyleBackColor = true;
            this.rbnThursday.CheckedChanged += new System.EventHandler(this.rbnThursday_CheckedChanged);
            // 
            // rbnWednesday
            // 
            this.rbnWednesday.AutoSize = true;
            this.rbnWednesday.Location = new System.Drawing.Point(81, 19);
            this.rbnWednesday.Name = "rbnWednesday";
            this.rbnWednesday.Size = new System.Drawing.Size(31, 17);
            this.rbnWednesday.TabIndex = 2;
            this.rbnWednesday.TabStop = true;
            this.rbnWednesday.Text = "3";
            this.rbnWednesday.UseVisualStyleBackColor = true;
            this.rbnWednesday.CheckedChanged += new System.EventHandler(this.rbnWednesday_CheckedChanged);
            // 
            // rbnTuesday
            // 
            this.rbnTuesday.AutoSize = true;
            this.rbnTuesday.Location = new System.Drawing.Point(43, 19);
            this.rbnTuesday.Name = "rbnTuesday";
            this.rbnTuesday.Size = new System.Drawing.Size(31, 17);
            this.rbnTuesday.TabIndex = 1;
            this.rbnTuesday.TabStop = true;
            this.rbnTuesday.Text = "2";
            this.rbnTuesday.UseVisualStyleBackColor = true;
            this.rbnTuesday.CheckedChanged += new System.EventHandler(this.rbnTuesday_CheckedChanged);
            // 
            // rbnMonday
            // 
            this.rbnMonday.AutoSize = true;
            this.rbnMonday.Location = new System.Drawing.Point(6, 19);
            this.rbnMonday.Name = "rbnMonday";
            this.rbnMonday.Size = new System.Drawing.Size(31, 17);
            this.rbnMonday.TabIndex = 0;
            this.rbnMonday.TabStop = true;
            this.rbnMonday.Text = "1";
            this.rbnMonday.UseVisualStyleBackColor = true;
            this.rbnMonday.CheckedChanged += new System.EventHandler(this.ChooseDay);
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Location = new System.Drawing.Point(15, 240);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(11, 13);
            this.lblErrors.TabIndex = 5;
            this.lblErrors.Text = "*";
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(18, 325);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(11, 13);
            this.lblSolution.TabIndex = 6;
            this.lblSolution.Text = "*";
            // 
            // btnCalculateClasses
            // 
            this.btnCalculateClasses.Enabled = false;
            this.btnCalculateClasses.Location = new System.Drawing.Point(12, 275);
            this.btnCalculateClasses.Name = "btnCalculateClasses";
            this.btnCalculateClasses.Size = new System.Drawing.Size(213, 23);
            this.btnCalculateClasses.TabIndex = 7;
            this.btnCalculateClasses.Text = "¿Have Clases?";
            this.btnCalculateClasses.UseVisualStyleBackColor = true;
            this.btnCalculateClasses.Click += new System.EventHandler(this.btnCalculateClasses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 411);
            this.Controls.Add(this.btnCalculateClasses);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.gboxRadioButton);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxRadioButton.ResumeLayout(false);
            this.gboxRadioButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.GroupBox gboxRadioButton;
        private System.Windows.Forms.RadioButton rbnSunday;
        private System.Windows.Forms.RadioButton rbnSaturday;
        private System.Windows.Forms.RadioButton rbnFriday;
        private System.Windows.Forms.RadioButton rbnThursday;
        private System.Windows.Forms.RadioButton rbnWednesday;
        private System.Windows.Forms.RadioButton rbnTuesday;
        private System.Windows.Forms.RadioButton rbnMonday;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.Button btnCalculateClasses;
    }
}


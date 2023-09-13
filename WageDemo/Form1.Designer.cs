namespace WageDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumHoursWorked = new Label();
            lblHourWage = new Label();
            txtNumHoursWorked = new TextBox();
            txtHourWage = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblNumHoursWorked
            // 
            lblNumHoursWorked.AutoSize = true;
            lblNumHoursWorked.Location = new Point(12, 31);
            lblNumHoursWorked.Name = "lblNumHoursWorked";
            lblNumHoursWorked.Size = new Size(144, 15);
            lblNumHoursWorked.TabIndex = 0;
            lblNumHoursWorked.Text = "Number of Hours Worked";
            lblNumHoursWorked.Click += lblNumHoursWorked_Click;
            // 
            // lblHourWage
            // 
            lblHourWage.AutoSize = true;
            lblHourWage.Location = new Point(65, 65);
            lblHourWage.Name = "lblHourWage";
            lblHourWage.Size = new Size(76, 15);
            lblHourWage.TabIndex = 1;
            lblHourWage.Text = "Hourly Wage";
            // 
            // txtNumHoursWorked
            // 
            txtNumHoursWorked.Location = new Point(171, 28);
            txtNumHoursWorked.Name = "txtNumHoursWorked";
            txtNumHoursWorked.Size = new Size(187, 23);
            txtNumHoursWorked.TabIndex = 2;
            // 
            // txtHourWage
            // 
            txtHourWage.Location = new Point(171, 57);
            txtHourWage.Name = "txtHourWage";
            txtHourWage.Size = new Size(187, 23);
            txtHourWage.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(171, 92);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(80, 31);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(273, 92);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(85, 31);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 144);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtHourWage);
            Controls.Add(txtNumHoursWorked);
            Controls.Add(lblHourWage);
            Controls.Add(lblNumHoursWorked);
            Name = "Form1";
            Text = "Wage Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumHoursWorked;
        private Label lblHourWage;
        private TextBox txtNumHoursWorked;
        private TextBox txtHourWage;
        private Button btnCalculate;
        private Button btnExit;
    }
}
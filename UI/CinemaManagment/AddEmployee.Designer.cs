
namespace CinemaManagment
{
    partial class AddEmployee
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
            this.labelAddEmployee = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelShift = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.comboBoxFunction = new System.Windows.Forms.ComboBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.numericUpDownShift = new System.Windows.Forms.NumericUpDown();
            this.roundedButtonAdd = new CustomControls.RJControls.RoundedButton();
            this.numericUpDownNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownNum)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddEmployee
            // 
            this.labelAddEmployee.AutoSize = true;
            this.labelAddEmployee.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelAddEmployee.ForeColor = System.Drawing.Color.White;
            this.labelAddEmployee.Location = new System.Drawing.Point(12, 9);
            this.labelAddEmployee.Name = "labelAddEmployee";
            this.labelAddEmployee.Size = new System.Drawing.Size(222, 41);
            this.labelAddEmployee.TabIndex = 4;
            this.labelAddEmployee.Text = "Add Employee";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(12, 141);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(66, 28);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(17, 172);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(269, 22);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelNum.ForeColor = System.Drawing.Color.White;
            this.labelNum.Location = new System.Drawing.Point(12, 68);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(182, 28);
            this.labelNum.TabIndex = 7;
            this.labelNum.Text = "Employee Number";
            // 
            // labelShift
            // 
            this.labelShift.AutoSize = true;
            this.labelShift.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelShift.ForeColor = System.Drawing.Color.White;
            this.labelShift.Location = new System.Drawing.Point(12, 283);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(54, 28);
            this.labelShift.TabIndex = 9;
            this.labelShift.Text = "Shift";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(12, 356);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(91, 28);
            this.labelRole.TabIndex = 11;
            this.labelRole.Text = "Function";
            // 
            // comboBoxFunction
            // 
            this.comboBoxFunction.FormattingEnabled = true;
            this.comboBoxFunction.Location = new System.Drawing.Point(17, 387);
            this.comboBoxFunction.Name = "comboBoxFunction";
            this.comboBoxFunction.Size = new System.Drawing.Size(269, 24);
            this.comboBoxFunction.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(17, 243);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(269, 22);
            this.textBoxEmail.TabIndex = 20;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(12, 212);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(60, 28);
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "Email";
            // 
            // numericUpDownShift
            // 
            this.numericUpDownShift.Location = new System.Drawing.Point(17, 314);
            this.numericUpDownShift.Name = "numericUpDownShift";
            this.numericUpDownShift.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownShift.TabIndex = 21;
            // 
            // roundedButtonAdd
            // 
            this.roundedButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButtonAdd.BackColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonAdd.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButtonAdd.BorderRadius = 20;
            this.roundedButtonAdd.BorderSize = 0;
            this.roundedButtonAdd.FlatAppearance.BorderSize = 0;
            this.roundedButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.roundedButtonAdd.ForeColor = System.Drawing.Color.White;
            this.roundedButtonAdd.Location = new System.Drawing.Point(552, 447);
            this.roundedButtonAdd.Name = "roundedButtonAdd";
            this.roundedButtonAdd.Size = new System.Drawing.Size(100, 47);
            this.roundedButtonAdd.TabIndex = 17;
            this.roundedButtonAdd.Text = "Add";
            this.roundedButtonAdd.TextColor = System.Drawing.Color.White;
            this.roundedButtonAdd.UseVisualStyleBackColor = false;
            this.roundedButtonAdd.Click += new System.EventHandler(this.roundedButtonAdd_Click);
            // 
            // numericUpDownNum
            // 
            this.numericUpDownNum.Location = new System.Drawing.Point(17, 99);
            this.numericUpDownNum.Name = "numericUpDownNum";
            this.numericUpDownNum.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownNum.TabIndex = 22;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (21)))), ((int) (((byte) (32)))));
            this.ClientSize = new System.Drawing.Size(664, 506);
            this.Controls.Add(this.numericUpDownNum);
            this.Controls.Add(this.numericUpDownShift);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.roundedButtonAdd);
            this.Controls.Add(this.comboBoxFunction);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelShift);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAddEmployee);
            this.MinimumSize = new System.Drawing.Size(682, 553);
            this.Name = "AddEmployee";
            this.Text = "Add Employee";
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelAddEmployee;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelShift;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ComboBox comboBoxFunction;
        private CustomControls.RJControls.RoundedButton roundedButtonAdd;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.NumericUpDown numericUpDownShift;
        private System.Windows.Forms.NumericUpDown numericUpDownNum;
    }
}
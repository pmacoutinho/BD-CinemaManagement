
namespace CinemaManagment
{
    partial class Login
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.numericUpDownEmployee = new System.Windows.Forms.NumericUpDown();
            this.roundedButtonLogin = new CustomControls.RJControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(12, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(97, 41);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Login";
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.ForeColor = System.Drawing.Color.White;
            this.labelEmployee.Location = new System.Drawing.Point(14, 74);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(138, 28);
            this.labelEmployee.TabIndex = 14;
            this.labelEmployee.Text = "Employee ID: ";
            // 
            // numericUpDownEmployee
            // 
            this.numericUpDownEmployee.Location = new System.Drawing.Point(158, 74);
            this.numericUpDownEmployee.Name = "numericUpDownEmployee";
            this.numericUpDownEmployee.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownEmployee.TabIndex = 17;
            // 
            // roundedButtonLogin
            // 
            this.roundedButtonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButtonLogin.BackColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonLogin.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButtonLogin.BorderRadius = 20;
            this.roundedButtonLogin.BorderSize = 0;
            this.roundedButtonLogin.FlatAppearance.BorderSize = 0;
            this.roundedButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonLogin.ForeColor = System.Drawing.Color.White;
            this.roundedButtonLogin.Location = new System.Drawing.Point(330, 162);
            this.roundedButtonLogin.MinimumSize = new System.Drawing.Size(108, 40);
            this.roundedButtonLogin.Name = "roundedButtonLogin";
            this.roundedButtonLogin.Size = new System.Drawing.Size(108, 40);
            this.roundedButtonLogin.TabIndex = 16;
            this.roundedButtonLogin.Text = "Login";
            this.roundedButtonLogin.TextColor = System.Drawing.Color.White;
            this.roundedButtonLogin.UseVisualStyleBackColor = false;
            this.roundedButtonLogin.Click += new System.EventHandler(this.roundedButtonLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(450, 214);
            this.Controls.Add(this.numericUpDownEmployee);
            this.Controls.Add(this.roundedButtonLogin);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.labelLogin);
            this.MinimumSize = new System.Drawing.Size(468, 261);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelEmployee;
        private CustomControls.RJControls.RoundedButton roundedButtonLogin;
        private System.Windows.Forms.NumericUpDown numericUpDownEmployee;
    }
}

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
            this.labelCinema = new System.Windows.Forms.Label();
            this.comboBoxCinema = new System.Windows.Forms.ComboBox();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.numericUpDownEmployee = new System.Windows.Forms.NumericUpDown();
            this.roundedButtonLogin = new CustomControls.RJControls.RoundedButton();
            this.buttonManager = new System.Windows.Forms.Button();
            this.buttonSeller = new System.Windows.Forms.Button();
            this.buttonCleaner = new System.Windows.Forms.Button();
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
            // labelCinema
            // 
            this.labelCinema.AutoSize = true;
            this.labelCinema.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCinema.ForeColor = System.Drawing.Color.White;
            this.labelCinema.Location = new System.Drawing.Point(14, 107);
            this.labelCinema.Name = "labelCinema";
            this.labelCinema.Size = new System.Drawing.Size(91, 28);
            this.labelCinema.TabIndex = 12;
            this.labelCinema.Text = "Cinema: ";
            // 
            // comboBoxCinema
            // 
            this.comboBoxCinema.FormattingEnabled = true;
            this.comboBoxCinema.Location = new System.Drawing.Point(158, 111);
            this.comboBoxCinema.Name = "comboBoxCinema";
            this.comboBoxCinema.Size = new System.Drawing.Size(232, 24);
            this.comboBoxCinema.TabIndex = 13;
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.ForeColor = System.Drawing.Color.White;
            this.labelEmployee.Location = new System.Drawing.Point(14, 166);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(138, 28);
            this.labelEmployee.TabIndex = 14;
            this.labelEmployee.Text = "Employee ID: ";
            // 
            // numericUpDownEmployee
            // 
            this.numericUpDownEmployee.Location = new System.Drawing.Point(158, 172);
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
            this.roundedButtonLogin.Location = new System.Drawing.Point(544, 285);
            this.roundedButtonLogin.Name = "roundedButtonLogin";
            this.roundedButtonLogin.Size = new System.Drawing.Size(108, 40);
            this.roundedButtonLogin.TabIndex = 16;
            this.roundedButtonLogin.Text = "Login";
            this.roundedButtonLogin.TextColor = System.Drawing.Color.White;
            this.roundedButtonLogin.UseVisualStyleBackColor = false;
            this.roundedButtonLogin.Click += new System.EventHandler(this.roundedButtonLogin_Click);
            // 
            // buttonManager
            // 
            this.buttonManager.Location = new System.Drawing.Point(12, 285);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(93, 40);
            this.buttonManager.TabIndex = 18;
            this.buttonManager.Text = "Manager";
            this.buttonManager.UseVisualStyleBackColor = true;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // buttonSeller
            // 
            this.buttonSeller.Location = new System.Drawing.Point(111, 285);
            this.buttonSeller.Name = "buttonSeller";
            this.buttonSeller.Size = new System.Drawing.Size(93, 40);
            this.buttonSeller.TabIndex = 19;
            this.buttonSeller.Text = "Seller";
            this.buttonSeller.UseVisualStyleBackColor = true;
            this.buttonSeller.Click += new System.EventHandler(this.buttonSeller_Click);
            // 
            // buttonCleaner
            // 
            this.buttonCleaner.Location = new System.Drawing.Point(210, 285);
            this.buttonCleaner.Name = "buttonCleaner";
            this.buttonCleaner.Size = new System.Drawing.Size(93, 40);
            this.buttonCleaner.TabIndex = 20;
            this.buttonCleaner.Text = "Cleaner";
            this.buttonCleaner.UseVisualStyleBackColor = true;
            this.buttonCleaner.Click += new System.EventHandler(this.buttonCleaner_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(664, 337);
            this.Controls.Add(this.buttonCleaner);
            this.Controls.Add(this.buttonSeller);
            this.Controls.Add(this.buttonManager);
            this.Controls.Add(this.numericUpDownEmployee);
            this.Controls.Add(this.roundedButtonLogin);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.comboBoxCinema);
            this.Controls.Add(this.labelCinema);
            this.Controls.Add(this.labelLogin);
            this.MinimumSize = new System.Drawing.Size(682, 384);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelCinema;
        private System.Windows.Forms.ComboBox comboBoxCinema;
        private System.Windows.Forms.Label labelEmployee;
        private CustomControls.RJControls.RoundedButton roundedButtonLogin;
        private System.Windows.Forms.NumericUpDown numericUpDownEmployee;
        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Button buttonSeller;
        private System.Windows.Forms.Button buttonCleaner;
    }
}
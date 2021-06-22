
namespace CinemaManagment
{
    partial class AddClient
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
            this.labelAddClient = new System.Windows.Forms.Label();
            this.labelMovieId = new System.Windows.Forms.Label();
            this.textBoxMovieTitle = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.roundedButtonAdd = new CustomControls.RJControls.RoundedButton();
            this.SuspendLayout();
            // 
            // labelAddClient
            // 
            this.labelAddClient.AutoSize = true;
            this.labelAddClient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddClient.ForeColor = System.Drawing.Color.White;
            this.labelAddClient.Location = new System.Drawing.Point(12, 9);
            this.labelAddClient.Name = "labelAddClient";
            this.labelAddClient.Size = new System.Drawing.Size(168, 41);
            this.labelAddClient.TabIndex = 6;
            this.labelAddClient.Text = "Add Client";
            // 
            // labelMovieId
            // 
            this.labelMovieId.AutoSize = true;
            this.labelMovieId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovieId.ForeColor = System.Drawing.Color.White;
            this.labelMovieId.Location = new System.Drawing.Point(12, 69);
            this.labelMovieId.Name = "labelMovieId";
            this.labelMovieId.Size = new System.Drawing.Size(145, 28);
            this.labelMovieId.TabIndex = 9;
            this.labelMovieId.Text = "Client Number";
            // 
            // textBoxMovieTitle
            // 
            this.textBoxMovieTitle.Location = new System.Drawing.Point(17, 100);
            this.textBoxMovieTitle.Name = "textBoxMovieTitle";
            this.textBoxMovieTitle.Size = new System.Drawing.Size(269, 22);
            this.textBoxMovieTitle.TabIndex = 10;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(14, 145);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(66, 28);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(19, 176);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(269, 22);
            this.textBoxName.TabIndex = 12;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(19, 257);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.labelDateOfBirth.Location = new System.Drawing.Point(14, 220);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(129, 28);
            this.labelDateOfBirth.TabIndex = 14;
            this.labelDateOfBirth.Text = "Date of Birth";
            this.labelDateOfBirth.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundedButtonAdd
            // 
            this.roundedButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButtonAdd.BackColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonAdd.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButtonAdd.BorderRadius = 20;
            this.roundedButtonAdd.BorderSize = 0;
            this.roundedButtonAdd.FlatAppearance.BorderSize = 0;
            this.roundedButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonAdd.ForeColor = System.Drawing.Color.White;
            this.roundedButtonAdd.Location = new System.Drawing.Point(552, 447);
            this.roundedButtonAdd.Name = "roundedButtonAdd";
            this.roundedButtonAdd.Size = new System.Drawing.Size(100, 47);
            this.roundedButtonAdd.TabIndex = 19;
            this.roundedButtonAdd.Text = "Add";
            this.roundedButtonAdd.TextColor = System.Drawing.Color.White;
            this.roundedButtonAdd.UseVisualStyleBackColor = false;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(664, 506);
            this.Controls.Add(this.roundedButtonAdd);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxMovieTitle);
            this.Controls.Add(this.labelMovieId);
            this.Controls.Add(this.labelAddClient);
            this.Name = "AddClient";
            this.Text = "Add Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddClient;
        private System.Windows.Forms.Label labelMovieId;
        private System.Windows.Forms.TextBox textBoxMovieTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelDateOfBirth;
        private CustomControls.RJControls.RoundedButton roundedButtonAdd;
    }
}
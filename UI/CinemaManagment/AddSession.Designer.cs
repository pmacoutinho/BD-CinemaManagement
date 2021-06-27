
namespace CinemaManagment
{
    partial class AddSession
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
            this.labelAddSession = new System.Windows.Forms.Label();
            this.labelFilmImdb = new System.Windows.Forms.Label();
            this.labelNoWeeks = new System.Windows.Forms.Label();
            this.labelPremiere = new System.Windows.Forms.Label();
            this.roundedButtonAdd = new CustomControls.RJControls.RoundedButton();
            this.numericUpDownNoWeeks = new System.Windows.Forms.NumericUpDown();
            this.monthCalendarPremiere = new System.Windows.Forms.MonthCalendar();
            this.comboBoxImdb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoWeeks)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddSession
            // 
            this.labelAddSession.AutoSize = true;
            this.labelAddSession.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddSession.ForeColor = System.Drawing.Color.White;
            this.labelAddSession.Location = new System.Drawing.Point(12, 9);
            this.labelAddSession.Name = "labelAddSession";
            this.labelAddSession.Size = new System.Drawing.Size(189, 41);
            this.labelAddSession.TabIndex = 6;
            this.labelAddSession.Text = "Add Session";
            // 
            // labelFilmImdb
            // 
            this.labelFilmImdb.AutoSize = true;
            this.labelFilmImdb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilmImdb.ForeColor = System.Drawing.Color.White;
            this.labelFilmImdb.Location = new System.Drawing.Point(12, 68);
            this.labelFilmImdb.Name = "labelFilmImdb";
            this.labelFilmImdb.Size = new System.Drawing.Size(145, 28);
            this.labelFilmImdb.TabIndex = 9;
            this.labelFilmImdb.Text = "Film IMDb Key";
            // 
            // labelNoWeeks
            // 
            this.labelNoWeeks.AutoSize = true;
            this.labelNoWeeks.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoWeeks.ForeColor = System.Drawing.Color.White;
            this.labelNoWeeks.Location = new System.Drawing.Point(12, 141);
            this.labelNoWeeks.Name = "labelNoWeeks";
            this.labelNoWeeks.Size = new System.Drawing.Size(201, 28);
            this.labelNoWeeks.TabIndex = 11;
            this.labelNoWeeks.Text = "No Weeks Screening";
            // 
            // labelPremiere
            // 
            this.labelPremiere.AutoSize = true;
            this.labelPremiere.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPremiere.ForeColor = System.Drawing.Color.White;
            this.labelPremiere.Location = new System.Drawing.Point(12, 216);
            this.labelPremiere.Name = "labelPremiere";
            this.labelPremiere.Size = new System.Drawing.Size(94, 28);
            this.labelPremiere.TabIndex = 21;
            this.labelPremiere.Text = "Premiere";
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
            this.roundedButtonAdd.TabIndex = 27;
            this.roundedButtonAdd.Text = "Add";
            this.roundedButtonAdd.TextColor = System.Drawing.Color.White;
            this.roundedButtonAdd.UseVisualStyleBackColor = false;
            this.roundedButtonAdd.Click += new System.EventHandler(this.roundedButtonAdd_Click);
            // 
            // numericUpDownNoWeeks
            // 
            this.numericUpDownNoWeeks.Location = new System.Drawing.Point(19, 173);
            this.numericUpDownNoWeeks.Name = "numericUpDownNoWeeks";
            this.numericUpDownNoWeeks.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownNoWeeks.TabIndex = 29;
            // 
            // monthCalendarPremiere
            // 
            this.monthCalendarPremiere.Location = new System.Drawing.Point(17, 253);
            this.monthCalendarPremiere.Name = "monthCalendarPremiere";
            this.monthCalendarPremiere.TabIndex = 30;
            // 
            // comboBoxImdb
            // 
            this.comboBoxImdb.FormattingEnabled = true;
            this.comboBoxImdb.Location = new System.Drawing.Point(17, 99);
            this.comboBoxImdb.Name = "comboBoxImdb";
            this.comboBoxImdb.Size = new System.Drawing.Size(267, 24);
            this.comboBoxImdb.TabIndex = 31;
            // 
            // AddSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(664, 506);
            this.Controls.Add(this.comboBoxImdb);
            this.Controls.Add(this.monthCalendarPremiere);
            this.Controls.Add(this.numericUpDownNoWeeks);
            this.Controls.Add(this.roundedButtonAdd);
            this.Controls.Add(this.labelPremiere);
            this.Controls.Add(this.labelNoWeeks);
            this.Controls.Add(this.labelFilmImdb);
            this.Controls.Add(this.labelAddSession);
            this.MinimumSize = new System.Drawing.Size(682, 553);
            this.Name = "AddSession";
            this.Text = "AddSession";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoWeeks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddSession;
        private System.Windows.Forms.Label labelFilmImdb;
        private System.Windows.Forms.Label labelNoWeeks;
        private System.Windows.Forms.Label labelPremiere;
        private CustomControls.RJControls.RoundedButton roundedButtonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownNoWeeks;
        private System.Windows.Forms.MonthCalendar monthCalendarPremiere;
        private System.Windows.Forms.ComboBox comboBoxImdb;
    }
}
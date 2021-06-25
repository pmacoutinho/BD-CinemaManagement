
namespace CinemaManagment
{
    partial class AddCleaningRecord
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
            this.labelAddCleaningRecord = new System.Windows.Forms.Label();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelCleaner = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.monthCalendarDate = new System.Windows.Forms.MonthCalendar();
            this.roundedButtonAdd = new CustomControls.RJControls.RoundedButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numericUpDownRoom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCleaner = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCleaner)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddCleaningRecord
            // 
            this.labelAddCleaningRecord.AutoSize = true;
            this.labelAddCleaningRecord.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddCleaningRecord.ForeColor = System.Drawing.Color.White;
            this.labelAddCleaningRecord.Location = new System.Drawing.Point(12, 9);
            this.labelAddCleaningRecord.Name = "labelAddCleaningRecord";
            this.labelAddCleaningRecord.Size = new System.Drawing.Size(315, 41);
            this.labelAddCleaningRecord.TabIndex = 6;
            this.labelAddCleaningRecord.Text = "Add Cleaning Record";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoom.ForeColor = System.Drawing.Color.White;
            this.labelRoom.Location = new System.Drawing.Point(12, 68);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(65, 28);
            this.labelRoom.TabIndex = 9;
            this.labelRoom.Text = "Room";
            // 
            // labelCleaner
            // 
            this.labelCleaner.AutoSize = true;
            this.labelCleaner.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCleaner.ForeColor = System.Drawing.Color.White;
            this.labelCleaner.Location = new System.Drawing.Point(12, 141);
            this.labelCleaner.Name = "labelCleaner";
            this.labelCleaner.Size = new System.Drawing.Size(80, 28);
            this.labelCleaner.TabIndex = 21;
            this.labelCleaner.Text = "Cleaner";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.ForeColor = System.Drawing.Color.White;
            this.labelHour.Location = new System.Drawing.Point(12, 216);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(58, 28);
            this.labelHour.TabIndex = 23;
            this.labelHour.Text = "Hour";
            // 
            // textBoxHour
            // 
            this.textBoxHour.Location = new System.Drawing.Point(19, 247);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(269, 22);
            this.textBoxHour.TabIndex = 24;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(327, 68);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(54, 28);
            this.Date.TabIndex = 25;
            this.Date.Text = "Date";
            // 
            // monthCalendarDate
            // 
            this.monthCalendarDate.Location = new System.Drawing.Point(332, 99);
            this.monthCalendarDate.Name = "monthCalendarDate";
            this.monthCalendarDate.TabIndex = 26;
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
            // numericUpDownRoom
            // 
            this.numericUpDownRoom.Location = new System.Drawing.Point(19, 99);
            this.numericUpDownRoom.Name = "numericUpDownRoom";
            this.numericUpDownRoom.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRoom.TabIndex = 28;
            // 
            // numericUpDownCleaner
            // 
            this.numericUpDownCleaner.Location = new System.Drawing.Point(19, 172);
            this.numericUpDownCleaner.Name = "numericUpDownCleaner";
            this.numericUpDownCleaner.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCleaner.TabIndex = 29;
            // 
            // AddCleaningRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(664, 506);
            this.Controls.Add(this.numericUpDownCleaner);
            this.Controls.Add(this.numericUpDownRoom);
            this.Controls.Add(this.roundedButtonAdd);
            this.Controls.Add(this.monthCalendarDate);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.textBoxHour);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelCleaner);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.labelAddCleaningRecord);
            this.MaximumSize = new System.Drawing.Size(682, 553);
            this.Name = "AddCleaningRecord";
            this.Text = "AddCleaningRecord";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCleaner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddCleaningRecord;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Label labelCleaner;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.MonthCalendar monthCalendarDate;
        private CustomControls.RJControls.RoundedButton roundedButtonAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown numericUpDownRoom;
        private System.Windows.Forms.NumericUpDown numericUpDownCleaner;
    }
}
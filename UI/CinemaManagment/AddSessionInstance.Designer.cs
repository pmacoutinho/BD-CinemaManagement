
namespace CinemaManagment
{
    partial class AddSessionInstance
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
            this.labelAddSessionInstance = new System.Windows.Forms.Label();
            this.labelSessionID = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.labelColumn = new System.Windows.Forms.Label();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSessionId = new System.Windows.Forms.ComboBox();
            this.roundedButtonAdd = new CustomControls.RJControls.RoundedButton();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddSessionInstance
            // 
            this.labelAddSessionInstance.AutoSize = true;
            this.labelAddSessionInstance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddSessionInstance.ForeColor = System.Drawing.Color.White;
            this.labelAddSessionInstance.Location = new System.Drawing.Point(12, 9);
            this.labelAddSessionInstance.Name = "labelAddSessionInstance";
            this.labelAddSessionInstance.Size = new System.Drawing.Size(314, 41);
            this.labelAddSessionInstance.TabIndex = 29;
            this.labelAddSessionInstance.Text = "Add Session Instance";
            // 
            // labelSessionID
            // 
            this.labelSessionID.AutoSize = true;
            this.labelSessionID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionID.ForeColor = System.Drawing.Color.White;
            this.labelSessionID.Location = new System.Drawing.Point(12, 68);
            this.labelSessionID.Name = "labelSessionID";
            this.labelSessionID.Size = new System.Drawing.Size(107, 28);
            this.labelSessionID.TabIndex = 30;
            this.labelSessionID.Text = "Session ID";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.ForeColor = System.Drawing.Color.White;
            this.labelStartTime.Location = new System.Drawing.Point(12, 141);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(105, 28);
            this.labelStartTime.TabIndex = 32;
            this.labelStartTime.Text = "Start Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "Room";
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(17, 172);
            this.numericUpDownHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(51, 22);
            this.numericUpDownHour.TabIndex = 36;
            // 
            // labelColumn
            // 
            this.labelColumn.AutoSize = true;
            this.labelColumn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumn.ForeColor = System.Drawing.Color.White;
            this.labelColumn.Location = new System.Drawing.Point(74, 166);
            this.labelColumn.Name = "labelColumn";
            this.labelColumn.Size = new System.Drawing.Size(17, 28);
            this.labelColumn.TabIndex = 37;
            this.labelColumn.Text = ":";
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Location = new System.Drawing.Point(97, 172);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(51, 22);
            this.numericUpDownMinutes.TabIndex = 38;
            // 
            // comboBoxSessionId
            // 
            this.comboBoxSessionId.FormattingEnabled = true;
            this.comboBoxSessionId.Location = new System.Drawing.Point(17, 99);
            this.comboBoxSessionId.Name = "comboBoxSessionId";
            this.comboBoxSessionId.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSessionId.TabIndex = 39;
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
            this.roundedButtonAdd.TabIndex = 28;
            this.roundedButtonAdd.Text = "Add";
            this.roundedButtonAdd.TextColor = System.Drawing.Color.White;
            this.roundedButtonAdd.UseVisualStyleBackColor = false;
            this.roundedButtonAdd.Click += new System.EventHandler(this.roundedButtonAdd_Click);
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(17, 247);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRoom.TabIndex = 40;
            // 
            // AddSessionInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(664, 506);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.comboBoxSessionId);
            this.Controls.Add(this.numericUpDownMinutes);
            this.Controls.Add(this.labelColumn);
            this.Controls.Add(this.numericUpDownHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.labelSessionID);
            this.Controls.Add(this.labelAddSessionInstance);
            this.Controls.Add(this.roundedButtonAdd);
            this.MinimumSize = new System.Drawing.Size(682, 553);
            this.Name = "AddSessionInstance";
            this.Text = "AddSessionInstance";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RoundedButton roundedButtonAdd;
        private System.Windows.Forms.Label labelAddSessionInstance;
        private System.Windows.Forms.Label labelSessionID;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.Label labelColumn;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.ComboBox comboBoxSessionId;
        private System.Windows.Forms.ComboBox comboBoxRoom;
    }
}
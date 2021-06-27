
namespace CinemaManagment
{
    partial class AddRoom
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
            this.labelAddRoom = new System.Windows.Forms.Label();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.roundedButtonAdd = new CustomControls.RJControls.RoundedButton();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            this.rBtn_update = new CustomControls.RJControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddRoom
            // 
            this.labelAddRoom.AutoSize = true;
            this.labelAddRoom.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddRoom.ForeColor = System.Drawing.Color.White;
            this.labelAddRoom.Location = new System.Drawing.Point(12, 9);
            this.labelAddRoom.Name = "labelAddRoom";
            this.labelAddRoom.Size = new System.Drawing.Size(167, 41);
            this.labelAddRoom.TabIndex = 7;
            this.labelAddRoom.Text = "Add Room";
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomNumber.ForeColor = System.Drawing.Color.White;
            this.labelRoomNumber.Location = new System.Drawing.Point(12, 64);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(146, 28);
            this.labelRoomNumber.TabIndex = 10;
            this.labelRoomNumber.Text = "Room Number";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacity.ForeColor = System.Drawing.Color.White;
            this.labelCapacity.Location = new System.Drawing.Point(12, 137);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(87, 28);
            this.labelCapacity.TabIndex = 12;
            this.labelCapacity.Text = "Capacity";
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
            this.roundedButtonAdd.TabIndex = 20;
            this.roundedButtonAdd.Text = "Add";
            this.roundedButtonAdd.TextColor = System.Drawing.Color.White;
            this.roundedButtonAdd.UseVisualStyleBackColor = false;
            this.roundedButtonAdd.Click += new System.EventHandler(this.roundedButtonAdd_Click);
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Location = new System.Drawing.Point(17, 95);
            this.numericUpDownNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownNumber.TabIndex = 21;
            // 
            // numericUpDownCapacity
            // 
            this.numericUpDownCapacity.Location = new System.Drawing.Point(17, 168);
            this.numericUpDownCapacity.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownCapacity.Name = "numericUpDownCapacity";
            this.numericUpDownCapacity.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCapacity.TabIndex = 22;
            // 
            // rBtn_update
            // 
            this.rBtn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rBtn_update.BackColor = System.Drawing.Color.SlateBlue;
            this.rBtn_update.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.rBtn_update.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rBtn_update.BorderRadius = 20;
            this.rBtn_update.BorderSize = 0;
            this.rBtn_update.FlatAppearance.BorderSize = 0;
            this.rBtn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtn_update.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_update.ForeColor = System.Drawing.Color.White;
            this.rBtn_update.Location = new System.Drawing.Point(552, 447);
            this.rBtn_update.Name = "rBtn_update";
            this.rBtn_update.Size = new System.Drawing.Size(100, 47);
            this.rBtn_update.TabIndex = 23;
            this.rBtn_update.Text = "Update";
            this.rBtn_update.TextColor = System.Drawing.Color.White;
            this.rBtn_update.UseVisualStyleBackColor = false;
            this.rBtn_update.Visible = false;
            this.rBtn_update.Click += new System.EventHandler(this.rBtn_update_Click);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(664, 506);
            this.Controls.Add(this.rBtn_update);
            this.Controls.Add(this.numericUpDownCapacity);
            this.Controls.Add(this.numericUpDownNumber);
            this.Controls.Add(this.roundedButtonAdd);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelRoomNumber);
            this.Controls.Add(this.labelAddRoom);
            this.Name = "AddRoom";
            this.Text = "Add Room";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private CustomControls.RJControls.RoundedButton rBtn_update;

        private CustomControls.RJControls.RoundedButton roundedButton1;

        #endregion

        private System.Windows.Forms.Label labelAddRoom;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label labelCapacity;
        private CustomControls.RJControls.RoundedButton roundedButtonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
    }
}
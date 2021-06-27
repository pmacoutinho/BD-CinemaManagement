namespace CinemaManagment
{
    partial class AddTicket
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
            this.labelAddTicket = new System.Windows.Forms.Label();
            this.labelSeller = new System.Windows.Forms.Label();
            this.comboBoxSeller = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelSessionInstance = new System.Windows.Forms.Label();
            this.comboBoxSession = new System.Windows.Forms.ComboBox();
            this.labelSeats = new System.Windows.Forms.Label();
            this.comboBoxSeat = new System.Windows.Forms.ComboBox();
            this.roundedButtonAdd = new CustomControls.RJControls.RoundedButton();
            this.SuspendLayout();
            // 
            // labelAddTicket
            // 
            this.labelAddTicket.AutoSize = true;
            this.labelAddTicket.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelAddTicket.ForeColor = System.Drawing.Color.White;
            this.labelAddTicket.Location = new System.Drawing.Point(12, 9);
            this.labelAddTicket.Name = "labelAddTicket";
            this.labelAddTicket.Size = new System.Drawing.Size(171, 41);
            this.labelAddTicket.TabIndex = 7;
            this.labelAddTicket.Text = "Add Ticket";
            // 
            // labelSeller
            // 
            this.labelSeller.AutoSize = true;
            this.labelSeller.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelSeller.ForeColor = System.Drawing.Color.White;
            this.labelSeller.Location = new System.Drawing.Point(12, 68);
            this.labelSeller.Name = "labelSeller";
            this.labelSeller.Size = new System.Drawing.Size(62, 28);
            this.labelSeller.TabIndex = 10;
            this.labelSeller.Text = "Seller";
            // 
            // comboBoxSeller
            // 
            this.comboBoxSeller.FormattingEnabled = true;
            this.comboBoxSeller.Location = new System.Drawing.Point(17, 99);
            this.comboBoxSeller.Name = "comboBoxSeller";
            this.comboBoxSeller.Size = new System.Drawing.Size(229, 24);
            this.comboBoxSeller.TabIndex = 11;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelClient.ForeColor = System.Drawing.Color.White;
            this.labelClient.Location = new System.Drawing.Point(12, 141);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(64, 28);
            this.labelClient.TabIndex = 12;
            this.labelClient.Text = "Client";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(17, 172);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(229, 24);
            this.comboBoxClient.TabIndex = 13;
            // 
            // labelSessionInstance
            // 
            this.labelSessionInstance.AutoSize = true;
            this.labelSessionInstance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelSessionInstance.ForeColor = System.Drawing.Color.White;
            this.labelSessionInstance.Location = new System.Drawing.Point(12, 216);
            this.labelSessionInstance.Name = "labelSessionInstance";
            this.labelSessionInstance.Size = new System.Drawing.Size(163, 28);
            this.labelSessionInstance.TabIndex = 14;
            this.labelSessionInstance.Text = "Session Instance";
            // 
            // comboBoxSession
            // 
            this.comboBoxSession.FormattingEnabled = true;
            this.comboBoxSession.Location = new System.Drawing.Point(17, 247);
            this.comboBoxSession.Name = "comboBoxSession";
            this.comboBoxSession.Size = new System.Drawing.Size(229, 24);
            this.comboBoxSession.TabIndex = 15;
            this.comboBoxSession.SelectedIndexChanged += new System.EventHandler(this.comboBoxSession_SelectedIndexChanged);
            // 
            // labelSeats
            // 
            this.labelSeats.AutoSize = true;
            this.labelSeats.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelSeats.ForeColor = System.Drawing.Color.White;
            this.labelSeats.Location = new System.Drawing.Point(12, 293);
            this.labelSeats.Name = "labelSeats";
            this.labelSeats.Size = new System.Drawing.Size(147, 28);
            this.labelSeats.TabIndex = 16;
            this.labelSeats.Text = "Available Seats";
            // 
            // comboBoxSeat
            // 
            this.comboBoxSeat.FormattingEnabled = true;
            this.comboBoxSeat.Location = new System.Drawing.Point(17, 324);
            this.comboBoxSeat.Name = "comboBoxSeat";
            this.comboBoxSeat.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSeat.TabIndex = 17;
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
            this.roundedButtonAdd.TabIndex = 28;
            this.roundedButtonAdd.Text = "Add";
            this.roundedButtonAdd.TextColor = System.Drawing.Color.White;
            this.roundedButtonAdd.UseVisualStyleBackColor = false;
            this.roundedButtonAdd.Click += new System.EventHandler(this.roundedButtonAdd_Click);
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (21)))), ((int) (((byte) (32)))));
            this.ClientSize = new System.Drawing.Size(664, 506);
            this.Controls.Add(this.roundedButtonAdd);
            this.Controls.Add(this.comboBoxSeat);
            this.Controls.Add(this.labelSeats);
            this.Controls.Add(this.comboBoxSession);
            this.Controls.Add(this.labelSessionInstance);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.comboBoxSeller);
            this.Controls.Add(this.labelSeller);
            this.Controls.Add(this.labelAddTicket);
            this.MinimumSize = new System.Drawing.Size(682, 553);
            this.Name = "AddTicket";
            this.Text = "AddTicket";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelAddTicket;
        private System.Windows.Forms.Label labelSeller;
        private System.Windows.Forms.ComboBox comboBoxSeller;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelSessionInstance;
        private System.Windows.Forms.ComboBox comboBoxSession;
        private System.Windows.Forms.Label labelSeats;
        private System.Windows.Forms.ComboBox comboBoxSeat;
        private CustomControls.RJControls.RoundedButton roundedButtonAdd;
    }
}
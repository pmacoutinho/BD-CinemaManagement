
namespace CinemaManagment.SellerComps
{
    partial class NewTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstBox_sessions = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_box_client = new System.Windows.Forms.ListBox();
            this.lst_box_seats = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roundedButtonEdit = new CustomControls.RJControls.RoundedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstBox_sessions
            // 
            this.lstBox_sessions.FormattingEnabled = true;
            this.lstBox_sessions.ItemHeight = 16;
            this.lstBox_sessions.Location = new System.Drawing.Point(302, 41);
            this.lstBox_sessions.Name = "lstBox_sessions";
            this.lstBox_sessions.Size = new System.Drawing.Size(261, 340);
            this.lstBox_sessions.TabIndex = 1;
            this.lstBox_sessions.SelectedIndexChanged += new System.EventHandler(this.lstBox_sessions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(299, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sessions";
            // 
            // lst_box_client
            // 
            this.lst_box_client.FormattingEnabled = true;
            this.lst_box_client.ItemHeight = 16;
            this.lst_box_client.Location = new System.Drawing.Point(12, 41);
            this.lst_box_client.Name = "lst_box_client";
            this.lst_box_client.Size = new System.Drawing.Size(261, 340);
            this.lst_box_client.TabIndex = 1;
            this.lst_box_client.SelectedIndexChanged += new System.EventHandler(this.lst_box_client_SelectedIndexChanged);
            // 
            // lst_box_seats
            // 
            this.lst_box_seats.FormattingEnabled = true;
            this.lst_box_seats.ItemHeight = 16;
            this.lst_box_seats.Location = new System.Drawing.Point(588, 41);
            this.lst_box_seats.Name = "lst_box_seats";
            this.lst_box_seats.Size = new System.Drawing.Size(185, 340);
            this.lst_box_seats.TabIndex = 1;
            this.lst_box_seats.SelectedIndexChanged += new System.EventHandler(this.lst_box_seats_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(585, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Available Seats";
            // 
            // roundedButtonEdit
            // 
            this.roundedButtonEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.roundedButtonEdit.BackColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonEdit.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButtonEdit.BorderRadius = 20;
            this.roundedButtonEdit.BorderSize = 0;
            this.roundedButtonEdit.FlatAppearance.BorderSize = 0;
            this.roundedButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonEdit.ForeColor = System.Drawing.Color.White;
            this.roundedButtonEdit.Location = new System.Drawing.Point(350, 398);
            this.roundedButtonEdit.Name = "roundedButtonEdit";
            this.roundedButtonEdit.Size = new System.Drawing.Size(98, 40);
            this.roundedButtonEdit.TabIndex = 8;
            this.roundedButtonEdit.Text = "OK";
            this.roundedButtonEdit.TextColor = System.Drawing.Color.White;
            this.roundedButtonEdit.UseVisualStyleBackColor = false;
            this.roundedButtonEdit.Click += new System.EventHandler(this.roundedButtonEdit_Click);
            // 
            // NewTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundedButtonEdit);
            this.Controls.Add(this.lst_box_client);
            this.Controls.Add(this.lst_box_seats);
            this.Controls.Add(this.lstBox_sessions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewTicket";
            this.Text = "NewTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBox_sessions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_box_client;
        private System.Windows.Forms.ListBox lst_box_seats;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RoundedButton roundedButtonEdit;
    }
}
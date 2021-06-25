
namespace CinemaManagment
{
    partial class AddFilm
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
            this.labelAddFilm = new System.Windows.Forms.Label();
            this.labelImdb = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelDirector = new System.Windows.Forms.Label();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.labelRuntime = new System.Windows.Forms.Label();
            this.roundedButtonAdd = new CustomControls.RJControls.RoundedButton();
            this.textBoxRuntime = new System.Windows.Forms.TextBox();
            this.textBoxImdb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAddFilm
            // 
            this.labelAddFilm.AutoSize = true;
            this.labelAddFilm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddFilm.ForeColor = System.Drawing.Color.White;
            this.labelAddFilm.Location = new System.Drawing.Point(12, 9);
            this.labelAddFilm.Name = "labelAddFilm";
            this.labelAddFilm.Size = new System.Drawing.Size(146, 41);
            this.labelAddFilm.TabIndex = 5;
            this.labelAddFilm.Text = "Add Film";
            // 
            // labelImdb
            // 
            this.labelImdb.AutoSize = true;
            this.labelImdb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImdb.ForeColor = System.Drawing.Color.White;
            this.labelImdb.Location = new System.Drawing.Point(12, 68);
            this.labelImdb.Name = "labelImdb";
            this.labelImdb.Size = new System.Drawing.Size(101, 28);
            this.labelImdb.TabIndex = 8;
            this.labelImdb.Text = "IMDb Key";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(14, 141);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(51, 28);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(17, 172);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(269, 22);
            this.textBoxTitle.TabIndex = 11;
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirector.ForeColor = System.Drawing.Color.White;
            this.labelDirector.Location = new System.Drawing.Point(12, 289);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(84, 28);
            this.labelDirector.TabIndex = 12;
            this.labelDirector.Text = "Director";
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(17, 320);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(269, 22);
            this.textBoxDirector.TabIndex = 13;
            // 
            // labelRuntime
            // 
            this.labelRuntime.AutoSize = true;
            this.labelRuntime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRuntime.ForeColor = System.Drawing.Color.White;
            this.labelRuntime.Location = new System.Drawing.Point(12, 216);
            this.labelRuntime.Name = "labelRuntime";
            this.labelRuntime.Size = new System.Drawing.Size(89, 28);
            this.labelRuntime.TabIndex = 19;
            this.labelRuntime.Text = "Runtime";
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
            this.roundedButtonAdd.TabIndex = 18;
            this.roundedButtonAdd.Text = "Add";
            this.roundedButtonAdd.TextColor = System.Drawing.Color.White;
            this.roundedButtonAdd.UseVisualStyleBackColor = false;
            this.roundedButtonAdd.Click += new System.EventHandler(this.roundedButtonAdd_Click);
            // 
            // textBoxRuntime
            // 
            this.textBoxRuntime.Location = new System.Drawing.Point(17, 247);
            this.textBoxRuntime.Name = "textBoxRuntime";
            this.textBoxRuntime.Size = new System.Drawing.Size(269, 22);
            this.textBoxRuntime.TabIndex = 20;
            // 
            // textBoxImdb
            // 
            this.textBoxImdb.Location = new System.Drawing.Point(17, 99);
            this.textBoxImdb.Name = "textBoxImdb";
            this.textBoxImdb.Size = new System.Drawing.Size(269, 22);
            this.textBoxImdb.TabIndex = 9;
            // 
            // AddFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(664, 506);
            this.Controls.Add(this.textBoxRuntime);
            this.Controls.Add(this.labelRuntime);
            this.Controls.Add(this.roundedButtonAdd);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxImdb);
            this.Controls.Add(this.labelImdb);
            this.Controls.Add(this.labelAddFilm);
            this.MaximumSize = new System.Drawing.Size(682, 553);
            this.Name = "AddFilm";
            this.Text = "Add Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddFilm;
        private System.Windows.Forms.Label labelImdb;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.TextBox textBoxDirector;
        private CustomControls.RJControls.RoundedButton roundedButtonAdd;
        private System.Windows.Forms.Label labelRuntime;
        private System.Windows.Forms.TextBox textBoxRuntime;
        private System.Windows.Forms.TextBox textBoxImdb;
    }
}
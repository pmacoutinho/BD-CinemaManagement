
namespace CinemaManagment
{
    partial class ListSession
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelSessionList = new System.Windows.Forms.Label();
            this.roundedButtonAdd = new CustomControls.RJControls.RoundedButton();
            this.roundedButtonEdit = new CustomControls.RJControls.RoundedButton();
            this.dataGridViewSession = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSessionList
            // 
            this.labelSessionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSessionList.AutoSize = true;
            this.labelSessionList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionList.ForeColor = System.Drawing.Color.White;
            this.labelSessionList.Location = new System.Drawing.Point(12, 9);
            this.labelSessionList.Name = "labelSessionList";
            this.labelSessionList.Size = new System.Drawing.Size(179, 41);
            this.labelSessionList.TabIndex = 5;
            this.labelSessionList.Text = "Session List";
            // 
            // roundedButtonAdd
            // 
            this.roundedButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButtonAdd.BackColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonAdd.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButtonAdd.BorderRadius = 20;
            this.roundedButtonAdd.BorderSize = 0;
            this.roundedButtonAdd.FlatAppearance.BorderSize = 0;
            this.roundedButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonAdd.ForeColor = System.Drawing.Color.White;
            this.roundedButtonAdd.Location = new System.Drawing.Point(572, 12);
            this.roundedButtonAdd.Name = "roundedButtonAdd";
            this.roundedButtonAdd.Size = new System.Drawing.Size(98, 40);
            this.roundedButtonAdd.TabIndex = 6;
            this.roundedButtonAdd.Text = "Add";
            this.roundedButtonAdd.TextColor = System.Drawing.Color.White;
            this.roundedButtonAdd.UseVisualStyleBackColor = false;
            this.roundedButtonAdd.Click += new System.EventHandler(this.roundedButtonAdd_Click);
            // 
            // roundedButtonEdit
            // 
            this.roundedButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButtonEdit.BackColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonEdit.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButtonEdit.BorderRadius = 20;
            this.roundedButtonEdit.BorderSize = 0;
            this.roundedButtonEdit.FlatAppearance.BorderSize = 0;
            this.roundedButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonEdit.ForeColor = System.Drawing.Color.White;
            this.roundedButtonEdit.Location = new System.Drawing.Point(468, 12);
            this.roundedButtonEdit.Name = "roundedButtonEdit";
            this.roundedButtonEdit.Size = new System.Drawing.Size(98, 40);
            this.roundedButtonEdit.TabIndex = 7;
            this.roundedButtonEdit.Text = "Edit";
            this.roundedButtonEdit.TextColor = System.Drawing.Color.White;
            this.roundedButtonEdit.UseVisualStyleBackColor = false;
            this.roundedButtonEdit.Click += new System.EventHandler(this.roundedButtonEdit_Click);
            // 
            // dataGridViewSession
            // 
            this.dataGridViewSession.AllowUserToAddRows = false;
            this.dataGridViewSession.AllowUserToDeleteRows = false;
            this.dataGridViewSession.AllowUserToResizeColumns = false;
            this.dataGridViewSession.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridViewSession.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSession.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSession.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dataGridViewSession.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSession.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSession.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSession.ColumnHeadersHeight = 35;
            this.dataGridViewSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSession.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSession.Location = new System.Drawing.Point(12, 76);
            this.dataGridViewSession.MultiSelect = false;
            this.dataGridViewSession.Name = "dataGridViewSession";
            this.dataGridViewSession.ReadOnly = true;
            this.dataGridViewSession.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSession.RowHeadersVisible = false;
            this.dataGridViewSession.RowHeadersWidth = 51;
            this.dataGridViewSession.RowTemplate.Height = 40;
            this.dataGridViewSession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSession.Size = new System.Drawing.Size(658, 465);
            this.dataGridViewSession.TabIndex = 9;
            // 
            // ListSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.dataGridViewSession);
            this.Controls.Add(this.roundedButtonEdit);
            this.Controls.Add(this.roundedButtonAdd);
            this.Controls.Add(this.labelSessionList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(682, 553);
            this.Name = "ListSession";
            this.Text = "ListSession";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSessionList;
        private CustomControls.RJControls.RoundedButton roundedButtonAdd;
        private CustomControls.RJControls.RoundedButton roundedButtonEdit;
        private System.Windows.Forms.DataGridView dataGridViewSession;
    }
}

namespace CinemaManagment
{
    partial class ListCleaner
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelCleanerList = new System.Windows.Forms.Label();
            this.dataGridViewCleaners = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundedButtonDetails = new CustomControls.RJControls.RoundedButton();
            this.roundedButtonEdit = new CustomControls.RJControls.RoundedButton();
            this.roundedButtonAdd = new CustomControls.RJControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCleaners)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCleanerList
            // 
            this.labelCleanerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCleanerList.AutoSize = true;
            this.labelCleanerList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCleanerList.ForeColor = System.Drawing.Color.White;
            this.labelCleanerList.Location = new System.Drawing.Point(12, 9);
            this.labelCleanerList.Name = "labelCleanerList";
            this.labelCleanerList.Size = new System.Drawing.Size(181, 41);
            this.labelCleanerList.TabIndex = 4;
            this.labelCleanerList.Text = "Cleaner List";
            // 
            // dataGridViewCleaners
            // 
            this.dataGridViewCleaners.AllowUserToAddRows = false;
            this.dataGridViewCleaners.AllowUserToDeleteRows = false;
            this.dataGridViewCleaners.AllowUserToResizeColumns = false;
            this.dataGridViewCleaners.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridViewCleaners.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCleaners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCleaners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCleaners.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCleaners.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dataGridViewCleaners.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewCleaners.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCleaners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCleaners.ColumnHeadersHeight = 35;
            this.dataGridViewCleaners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCleaners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.EmployeeName,
            this.Shift,
            this.Supervisor});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCleaners.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCleaners.Location = new System.Drawing.Point(12, 76);
            this.dataGridViewCleaners.Name = "dataGridViewCleaners";
            this.dataGridViewCleaners.ReadOnly = true;
            this.dataGridViewCleaners.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCleaners.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCleaners.RowHeadersVisible = false;
            this.dataGridViewCleaners.RowHeadersWidth = 51;
            this.dataGridViewCleaners.RowTemplate.Height = 40;
            this.dataGridViewCleaners.Size = new System.Drawing.Size(658, 465);
            this.dataGridViewCleaners.TabIndex = 8;
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.MinimumWidth = 6;
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Name";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // Shift
            // 
            this.Shift.HeaderText = "Shift";
            this.Shift.MinimumWidth = 6;
            this.Shift.Name = "Shift";
            this.Shift.ReadOnly = true;
            // 
            // Supervisor
            // 
            this.Supervisor.HeaderText = "Supervisor";
            this.Supervisor.MinimumWidth = 6;
            this.Supervisor.Name = "Supervisor";
            this.Supervisor.ReadOnly = true;
            // 
            // roundedButtonDetails
            // 
            this.roundedButtonDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButtonDetails.BackColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonDetails.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonDetails.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButtonDetails.BorderRadius = 20;
            this.roundedButtonDetails.BorderSize = 0;
            this.roundedButtonDetails.FlatAppearance.BorderSize = 0;
            this.roundedButtonDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonDetails.ForeColor = System.Drawing.Color.White;
            this.roundedButtonDetails.Location = new System.Drawing.Point(364, 12);
            this.roundedButtonDetails.Name = "roundedButtonDetails";
            this.roundedButtonDetails.Size = new System.Drawing.Size(98, 40);
            this.roundedButtonDetails.TabIndex = 7;
            this.roundedButtonDetails.Text = "Details";
            this.roundedButtonDetails.TextColor = System.Drawing.Color.White;
            this.roundedButtonDetails.UseVisualStyleBackColor = false;
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
            this.roundedButtonEdit.TabIndex = 6;
            this.roundedButtonEdit.Text = "Edit";
            this.roundedButtonEdit.TextColor = System.Drawing.Color.White;
            this.roundedButtonEdit.UseVisualStyleBackColor = false;
            this.roundedButtonEdit.Click += new System.EventHandler(this.roundedButtonEdit_Click);
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
            this.roundedButtonAdd.TabIndex = 5;
            this.roundedButtonAdd.Text = "Add";
            this.roundedButtonAdd.TextColor = System.Drawing.Color.White;
            this.roundedButtonAdd.UseVisualStyleBackColor = false;
            this.roundedButtonAdd.Click += new System.EventHandler(this.roundedButtonAdd_Click);
            // 
            // ListCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.dataGridViewCleaners);
            this.Controls.Add(this.roundedButtonDetails);
            this.Controls.Add(this.roundedButtonEdit);
            this.Controls.Add(this.roundedButtonAdd);
            this.Controls.Add(this.labelCleanerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(682, 553);
            this.Name = "ListCleaner";
            this.Text = "CleanerList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCleaners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCleanerList;
        private CustomControls.RJControls.RoundedButton roundedButtonAdd;
        private CustomControls.RJControls.RoundedButton roundedButtonEdit;
        private CustomControls.RJControls.RoundedButton roundedButtonDetails;
        private System.Windows.Forms.DataGridView dataGridViewCleaners;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supervisor;
    }
}
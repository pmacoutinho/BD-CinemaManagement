
namespace CinemaManagment
{
    partial class ListVendor
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
            this.dataGridViewVendors = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelVendorList = new System.Windows.Forms.Label();
            this.roundedButtonDetails = new CustomControls.RJControls.RoundedButton();
            this.roundedButtonAdd = new CustomControls.RJControls.RoundedButton();
            this.roundedButtonEdit = new CustomControls.RJControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVendors
            // 
            this.dataGridViewVendors.AllowUserToAddRows = false;
            this.dataGridViewVendors.AllowUserToDeleteRows = false;
            this.dataGridViewVendors.AllowUserToResizeColumns = false;
            this.dataGridViewVendors.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridViewVendors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVendors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVendors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVendors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewVendors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dataGridViewVendors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewVendors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVendors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVendors.ColumnHeadersHeight = 35;
            this.dataGridViewVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewVendors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewVendors.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewVendors.Location = new System.Drawing.Point(12, 76);
            this.dataGridViewVendors.Name = "dataGridViewVendors";
            this.dataGridViewVendors.ReadOnly = true;
            this.dataGridViewVendors.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewVendors.RowHeadersVisible = false;
            this.dataGridViewVendors.RowHeadersWidth = 51;
            this.dataGridViewVendors.RowTemplate.Height = 40;
            this.dataGridViewVendors.Size = new System.Drawing.Size(658, 465);
            this.dataGridViewVendors.TabIndex = 0;
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
            // labelVendorList
            // 
            this.labelVendorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVendorList.AutoSize = true;
            this.labelVendorList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendorList.ForeColor = System.Drawing.Color.White;
            this.labelVendorList.Location = new System.Drawing.Point(12, 9);
            this.labelVendorList.Name = "labelVendorList";
            this.labelVendorList.Size = new System.Drawing.Size(176, 41);
            this.labelVendorList.TabIndex = 3;
            this.labelVendorList.Text = "Vendor List";
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
            this.roundedButtonDetails.TabIndex = 4;
            this.roundedButtonDetails.Text = "Details";
            this.roundedButtonDetails.TextColor = System.Drawing.Color.White;
            this.roundedButtonDetails.UseVisualStyleBackColor = false;
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
            this.roundedButtonAdd.TabIndex = 2;
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
            this.roundedButtonEdit.TabIndex = 1;
            this.roundedButtonEdit.Text = "Edit";
            this.roundedButtonEdit.TextColor = System.Drawing.Color.White;
            this.roundedButtonEdit.UseVisualStyleBackColor = false;
            this.roundedButtonEdit.Click += new System.EventHandler(this.roundedButtonEdit_Click);
            // 
            // ListVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.roundedButtonDetails);
            this.Controls.Add(this.labelVendorList);
            this.Controls.Add(this.roundedButtonAdd);
            this.Controls.Add(this.roundedButtonEdit);
            this.Controls.Add(this.dataGridViewVendors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(682, 553);
            this.Name = "ListVendor";
            this.Text = "Vendor List";
            this.Shown += new System.EventHandler(this.Form2_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVendors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supervisor;
        private CustomControls.RJControls.RoundedButton roundedButtonEdit;
        private CustomControls.RJControls.RoundedButton roundedButtonAdd;
        private System.Windows.Forms.Label labelVendorList;
        private CustomControls.RJControls.RoundedButton roundedButtonDetails;
    }
}
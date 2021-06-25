
namespace CinemaManagment
{
    partial class ListManager
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
            this.labelManagerList = new System.Windows.Forms.Label();
            this.roundedButtonAdd = new CustomControls.RJControls.RoundedButton();
            this.roundedButtonEdit = new CustomControls.RJControls.RoundedButton();
            this.roundedButtonDetails = new CustomControls.RJControls.RoundedButton();
            this.dataGridViewManager = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManager)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManagerList
            // 
            this.labelManagerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelManagerList.AutoSize = true;
            this.labelManagerList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagerList.ForeColor = System.Drawing.Color.White;
            this.labelManagerList.Location = new System.Drawing.Point(12, 9);
            this.labelManagerList.Name = "labelManagerList";
            this.labelManagerList.Size = new System.Drawing.Size(201, 41);
            this.labelManagerList.TabIndex = 4;
            this.labelManagerList.Text = "Manager List";
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
            // dataGridViewManager
            // 
            this.dataGridViewManager.AllowUserToAddRows = false;
            this.dataGridViewManager.AllowUserToDeleteRows = false;
            this.dataGridViewManager.AllowUserToResizeColumns = false;
            this.dataGridViewManager.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridViewManager.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewManager.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewManager.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dataGridViewManager.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewManager.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewManager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewManager.ColumnHeadersHeight = 35;
            this.dataGridViewManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewManager.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewManager.Location = new System.Drawing.Point(12, 76);
            this.dataGridViewManager.MultiSelect = false;
            this.dataGridViewManager.Name = "dataGridViewManager";
            this.dataGridViewManager.ReadOnly = true;
            this.dataGridViewManager.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewManager.RowHeadersVisible = false;
            this.dataGridViewManager.RowHeadersWidth = 51;
            this.dataGridViewManager.RowTemplate.Height = 40;
            this.dataGridViewManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewManager.Size = new System.Drawing.Size(658, 465);
            this.dataGridViewManager.TabIndex = 8;
            // 
            // ListManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.dataGridViewManager);
            this.Controls.Add(this.roundedButtonDetails);
            this.Controls.Add(this.roundedButtonEdit);
            this.Controls.Add(this.roundedButtonAdd);
            this.Controls.Add(this.labelManagerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(682, 553);
            this.Name = "ListManager";
            this.Text = "ListManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManagerList;
        private CustomControls.RJControls.RoundedButton roundedButtonAdd;
        private CustomControls.RJControls.RoundedButton roundedButtonEdit;
        private CustomControls.RJControls.RoundedButton roundedButtonDetails;
        private System.Windows.Forms.DataGridView dataGridViewManager;
    }
}
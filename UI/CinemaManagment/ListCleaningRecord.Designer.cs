
namespace CinemaManagment
{
    partial class ListCleaningRecord
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
            this.labelCleaningRecord = new System.Windows.Forms.Label();
            this.roundedButtonAdd = new CustomControls.RJControls.RoundedButton();
            this.dataGridViewCleaningRecords = new System.Windows.Forms.DataGridView();
            this.rBtn_seeAll = new CustomControls.RJControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewCleaningRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCleaningRecord
            // 
            this.labelCleaningRecord.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCleaningRecord.AutoSize = true;
            this.labelCleaningRecord.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelCleaningRecord.ForeColor = System.Drawing.Color.White;
            this.labelCleaningRecord.Location = new System.Drawing.Point(12, 9);
            this.labelCleaningRecord.Name = "labelCleaningRecord";
            this.labelCleaningRecord.Size = new System.Drawing.Size(248, 41);
            this.labelCleaningRecord.TabIndex = 6;
            this.labelCleaningRecord.Text = "Cleaning Record";
            // 
            // roundedButtonAdd
            // 
            this.roundedButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButtonAdd.BackColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonAdd.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButtonAdd.BorderRadius = 20;
            this.roundedButtonAdd.BorderSize = 0;
            this.roundedButtonAdd.FlatAppearance.BorderSize = 0;
            this.roundedButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.roundedButtonAdd.ForeColor = System.Drawing.Color.White;
            this.roundedButtonAdd.Location = new System.Drawing.Point(572, 12);
            this.roundedButtonAdd.Name = "roundedButtonAdd";
            this.roundedButtonAdd.Size = new System.Drawing.Size(98, 40);
            this.roundedButtonAdd.TabIndex = 7;
            this.roundedButtonAdd.Text = "Add";
            this.roundedButtonAdd.TextColor = System.Drawing.Color.White;
            this.roundedButtonAdd.UseVisualStyleBackColor = false;
            this.roundedButtonAdd.Click += new System.EventHandler(this.roundedButtonAdd_Click);
            // 
            // dataGridViewCleaningRecords
            // 
            this.dataGridViewCleaningRecords.AllowUserToAddRows = false;
            this.dataGridViewCleaningRecords.AllowUserToDeleteRows = false;
            this.dataGridViewCleaningRecords.AllowUserToResizeColumns = false;
            this.dataGridViewCleaningRecords.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (35)))), ((int) (((byte) (32)))), ((int) (((byte) (39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridViewCleaningRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCleaningRecords.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCleaningRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCleaningRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCleaningRecords.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (21)))), ((int) (((byte) (32)))));
            this.dataGridViewCleaningRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewCleaningRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCleaningRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCleaningRecords.ColumnHeadersHeight = 35;
            this.dataGridViewCleaningRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (21)))), ((int) (((byte) (32)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (77)))), ((int) (((byte) (70)))), ((int) (((byte) (85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCleaningRecords.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCleaningRecords.Location = new System.Drawing.Point(12, 76);
            this.dataGridViewCleaningRecords.MultiSelect = false;
            this.dataGridViewCleaningRecords.Name = "dataGridViewCleaningRecords";
            this.dataGridViewCleaningRecords.ReadOnly = true;
            this.dataGridViewCleaningRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewCleaningRecords.RowHeadersVisible = false;
            this.dataGridViewCleaningRecords.RowHeadersWidth = 51;
            this.dataGridViewCleaningRecords.RowTemplate.Height = 40;
            this.dataGridViewCleaningRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCleaningRecords.Size = new System.Drawing.Size(658, 465);
            this.dataGridViewCleaningRecords.TabIndex = 10;
            // 
            // rBtn_seeAll
            // 
            this.rBtn_seeAll.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rBtn_seeAll.BackColor = System.Drawing.Color.SlateBlue;
            this.rBtn_seeAll.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.rBtn_seeAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rBtn_seeAll.BorderRadius = 20;
            this.rBtn_seeAll.BorderSize = 0;
            this.rBtn_seeAll.FlatAppearance.BorderSize = 0;
            this.rBtn_seeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtn_seeAll.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rBtn_seeAll.ForeColor = System.Drawing.Color.White;
            this.rBtn_seeAll.Location = new System.Drawing.Point(468, 12);
            this.rBtn_seeAll.Name = "rBtn_seeAll";
            this.rBtn_seeAll.Size = new System.Drawing.Size(98, 40);
            this.rBtn_seeAll.TabIndex = 11;
            this.rBtn_seeAll.Text = "See All";
            this.rBtn_seeAll.TextColor = System.Drawing.Color.White;
            this.rBtn_seeAll.UseVisualStyleBackColor = false;
            this.rBtn_seeAll.Click += new System.EventHandler(this.rBtn_seeAll_Click);
            // 
            // ListCleaningRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (21)))), ((int) (((byte) (32)))));
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.rBtn_seeAll);
            this.Controls.Add(this.dataGridViewCleaningRecords);
            this.Controls.Add(this.roundedButtonAdd);
            this.Controls.Add(this.labelCleaningRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(682, 553);
            this.Name = "ListCleaningRecord";
            this.Text = "ListCleaningRecord";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewCleaningRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private CustomControls.RJControls.RoundedButton rBtn_seeAll;

        private CustomControls.RJControls.RoundedButton rBtn_;

        #endregion

        private System.Windows.Forms.Label labelCleaningRecord;
        private CustomControls.RJControls.RoundedButton roundedButtonAdd;
        private System.Windows.Forms.DataGridView dataGridViewCleaningRecords;
    }
}

namespace CinemaManagment
{
    partial class ListRoom
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
            this.labelRoomList = new System.Windows.Forms.Label();
            this.roundedButtonAdd = new CustomControls.RJControls.RoundedButton();
            this.roundedButtonEdit = new CustomControls.RJControls.RoundedButton();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.rBtn_delete = new CustomControls.RJControls.RoundedButton();
            this.rBtn_refresh = new CustomControls.RJControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRoomList
            // 
            this.labelRoomList.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRoomList.AutoSize = true;
            this.labelRoomList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelRoomList.ForeColor = System.Drawing.Color.White;
            this.labelRoomList.Location = new System.Drawing.Point(12, 9);
            this.labelRoomList.Name = "labelRoomList";
            this.labelRoomList.Size = new System.Drawing.Size(157, 41);
            this.labelRoomList.TabIndex = 4;
            this.labelRoomList.Text = "Room List";
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
            this.roundedButtonAdd.Location = new System.Drawing.Point(364, 12);
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
            this.roundedButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButtonEdit.BackColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonEdit.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButtonEdit.BorderRadius = 20;
            this.roundedButtonEdit.BorderSize = 0;
            this.roundedButtonEdit.FlatAppearance.BorderSize = 0;
            this.roundedButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.AllowUserToDeleteRows = false;
            this.dataGridViewRooms.AllowUserToResizeColumns = false;
            this.dataGridViewRooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (35)))), ((int) (((byte) (32)))), ((int) (((byte) (39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridViewRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRooms.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (21)))), ((int) (((byte) (32)))));
            this.dataGridViewRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRooms.ColumnHeadersHeight = 35;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (21)))), ((int) (((byte) (32)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (77)))), ((int) (((byte) (70)))), ((int) (((byte) (85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRooms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRooms.Location = new System.Drawing.Point(12, 76);
            this.dataGridViewRooms.MultiSelect = false;
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewRooms.RowHeadersVisible = false;
            this.dataGridViewRooms.RowHeadersWidth = 51;
            this.dataGridViewRooms.RowTemplate.Height = 40;
            this.dataGridViewRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRooms.Size = new System.Drawing.Size(658, 465);
            this.dataGridViewRooms.TabIndex = 8;
            // 
            // rBtn_delete
            // 
            this.rBtn_delete.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rBtn_delete.BackColor = System.Drawing.Color.SlateBlue;
            this.rBtn_delete.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.rBtn_delete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rBtn_delete.BorderRadius = 20;
            this.rBtn_delete.BorderSize = 0;
            this.rBtn_delete.FlatAppearance.BorderSize = 0;
            this.rBtn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtn_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rBtn_delete.ForeColor = System.Drawing.Color.White;
            this.rBtn_delete.Location = new System.Drawing.Point(572, 12);
            this.rBtn_delete.Name = "rBtn_delete";
            this.rBtn_delete.Size = new System.Drawing.Size(98, 40);
            this.rBtn_delete.TabIndex = 5;
            this.rBtn_delete.Text = "Delete";
            this.rBtn_delete.TextColor = System.Drawing.Color.White;
            this.rBtn_delete.UseVisualStyleBackColor = false;
            this.rBtn_delete.Click += new System.EventHandler(this.rBtn_delete_Click);
            // 
            // rBtn_refresh
            // 
            this.rBtn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rBtn_refresh.BackColor = System.Drawing.Color.SlateBlue;
            this.rBtn_refresh.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.rBtn_refresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rBtn_refresh.BorderRadius = 20;
            this.rBtn_refresh.BorderSize = 0;
            this.rBtn_refresh.FlatAppearance.BorderSize = 0;
            this.rBtn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtn_refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rBtn_refresh.ForeColor = System.Drawing.Color.White;
            this.rBtn_refresh.Location = new System.Drawing.Point(260, 12);
            this.rBtn_refresh.Name = "rBtn_refresh";
            this.rBtn_refresh.Size = new System.Drawing.Size(98, 40);
            this.rBtn_refresh.TabIndex = 5;
            this.rBtn_refresh.Text = "Refresh";
            this.rBtn_refresh.TextColor = System.Drawing.Color.White;
            this.rBtn_refresh.UseVisualStyleBackColor = false;
            this.rBtn_refresh.Click += new System.EventHandler(this.rBtn_refresh_Click_1);
            // 
            // ListRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (23)))), ((int) (((byte) (21)))), ((int) (((byte) (32)))));
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.dataGridViewRooms);
            this.Controls.Add(this.roundedButtonEdit);
            this.Controls.Add(this.rBtn_refresh);
            this.Controls.Add(this.rBtn_delete);
            this.Controls.Add(this.roundedButtonAdd);
            this.Controls.Add(this.labelRoomList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(682, 553);
            this.Name = "ListRoom";
            this.Text = "RoomList";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private CustomControls.RJControls.RoundedButton rBtn_delete;
        private CustomControls.RJControls.RoundedButton rBtn_refresh;

        #endregion

        private System.Windows.Forms.Label labelRoomList;
        private CustomControls.RJControls.RoundedButton roundedButtonAdd;
        private CustomControls.RJControls.RoundedButton roundedButtonEdit;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
    }
}
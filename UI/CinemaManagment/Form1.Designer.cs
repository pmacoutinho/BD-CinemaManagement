
namespace CinemaManagment
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonEmpregados = new System.Windows.Forms.Button();
            this.panelEmpregadosSubmenu = new System.Windows.Forms.Panel();
            this.buttonVendedores = new System.Windows.Forms.Button();
            this.buttonLimpezas = new System.Windows.Forms.Button();
            this.buttonSalas = new System.Windows.Forms.Button();
            this.panelSalasSubmenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonFilmes = new System.Windows.Forms.Button();
            this.panelFilmesSubmenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.panelClientesSubmenu = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelEmpregadosSubmenu.SuspendLayout();
            this.panelSalasSubmenu.SuspendLayout();
            this.panelFilmesSubmenu.SuspendLayout();
            this.panelClientesSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.panelClientesSubmenu);
            this.panelSideMenu.Controls.Add(this.buttonClientes);
            this.panelSideMenu.Controls.Add(this.panelFilmesSubmenu);
            this.panelSideMenu.Controls.Add(this.buttonFilmes);
            this.panelSideMenu.Controls.Add(this.panelSalasSubmenu);
            this.panelSideMenu.Controls.Add(this.buttonSalas);
            this.panelSideMenu.Controls.Add(this.panelEmpregadosSubmenu);
            this.panelSideMenu.Controls.Add(this.buttonEmpregados);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 553);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(229, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonEmpregados
            // 
            this.buttonEmpregados.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmpregados.FlatAppearance.BorderSize = 0;
            this.buttonEmpregados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpregados.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEmpregados.Location = new System.Drawing.Point(0, 100);
            this.buttonEmpregados.Name = "buttonEmpregados";
            this.buttonEmpregados.Size = new System.Drawing.Size(229, 45);
            this.buttonEmpregados.TabIndex = 1;
            this.buttonEmpregados.Text = "Gerir Empregados";
            this.buttonEmpregados.UseVisualStyleBackColor = true;
            this.buttonEmpregados.Click += new System.EventHandler(this.buttonEmpregados_Click);
            // 
            // panelEmpregadosSubmenu
            // 
            this.panelEmpregadosSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelEmpregadosSubmenu.Controls.Add(this.buttonLimpezas);
            this.panelEmpregadosSubmenu.Controls.Add(this.buttonVendedores);
            this.panelEmpregadosSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmpregadosSubmenu.Location = new System.Drawing.Point(0, 145);
            this.panelEmpregadosSubmenu.Name = "panelEmpregadosSubmenu";
            this.panelEmpregadosSubmenu.Size = new System.Drawing.Size(229, 86);
            this.panelEmpregadosSubmenu.TabIndex = 2;
            // 
            // buttonVendedores
            // 
            this.buttonVendedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVendedores.FlatAppearance.BorderSize = 0;
            this.buttonVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVendedores.ForeColor = System.Drawing.Color.LightGray;
            this.buttonVendedores.Location = new System.Drawing.Point(0, 0);
            this.buttonVendedores.Name = "buttonVendedores";
            this.buttonVendedores.Size = new System.Drawing.Size(229, 40);
            this.buttonVendedores.TabIndex = 0;
            this.buttonVendedores.Text = "Vendedores";
            this.buttonVendedores.UseVisualStyleBackColor = true;
            this.buttonVendedores.Click += new System.EventHandler(this.buttonVendedores_Click);
            // 
            // buttonLimpezas
            // 
            this.buttonLimpezas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLimpezas.FlatAppearance.BorderSize = 0;
            this.buttonLimpezas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpezas.ForeColor = System.Drawing.Color.LightGray;
            this.buttonLimpezas.Location = new System.Drawing.Point(0, 40);
            this.buttonLimpezas.Name = "buttonLimpezas";
            this.buttonLimpezas.Size = new System.Drawing.Size(229, 40);
            this.buttonLimpezas.TabIndex = 1;
            this.buttonLimpezas.Text = "Limpezas";
            this.buttonLimpezas.UseVisualStyleBackColor = true;
            // 
            // buttonSalas
            // 
            this.buttonSalas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSalas.FlatAppearance.BorderSize = 0;
            this.buttonSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalas.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSalas.Location = new System.Drawing.Point(0, 231);
            this.buttonSalas.Name = "buttonSalas";
            this.buttonSalas.Size = new System.Drawing.Size(229, 45);
            this.buttonSalas.TabIndex = 3;
            this.buttonSalas.Text = "Gerir Salas";
            this.buttonSalas.UseVisualStyleBackColor = true;
            this.buttonSalas.Click += new System.EventHandler(this.buttonSalas_Click);
            // 
            // panelSalasSubmenu
            // 
            this.panelSalasSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSalasSubmenu.Controls.Add(this.button2);
            this.panelSalasSubmenu.Controls.Add(this.button3);
            this.panelSalasSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSalasSubmenu.Location = new System.Drawing.Point(0, 276);
            this.panelSalasSubmenu.Name = "panelSalasSubmenu";
            this.panelSalasSubmenu.Size = new System.Drawing.Size(229, 86);
            this.panelSalasSubmenu.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(0, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Limpezas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "Vendedores";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonFilmes
            // 
            this.buttonFilmes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFilmes.FlatAppearance.BorderSize = 0;
            this.buttonFilmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilmes.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonFilmes.Location = new System.Drawing.Point(0, 362);
            this.buttonFilmes.Name = "buttonFilmes";
            this.buttonFilmes.Size = new System.Drawing.Size(229, 45);
            this.buttonFilmes.TabIndex = 5;
            this.buttonFilmes.Text = "Gerir Biblioteca de Filmes";
            this.buttonFilmes.UseVisualStyleBackColor = true;
            this.buttonFilmes.Click += new System.EventHandler(this.buttonFilmes_Click);
            // 
            // panelFilmesSubmenu
            // 
            this.panelFilmesSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelFilmesSubmenu.Controls.Add(this.button5);
            this.panelFilmesSubmenu.Controls.Add(this.button6);
            this.panelFilmesSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilmesSubmenu.Location = new System.Drawing.Point(0, 407);
            this.panelFilmesSubmenu.Name = "panelFilmesSubmenu";
            this.panelFilmesSubmenu.Size = new System.Drawing.Size(229, 86);
            this.panelFilmesSubmenu.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(0, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(229, 40);
            this.button5.TabIndex = 1;
            this.button5.Text = "Limpezas";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.LightGray;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(229, 40);
            this.button6.TabIndex = 0;
            this.button6.Text = "Vendedores";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // buttonClientes
            // 
            this.buttonClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClientes.FlatAppearance.BorderSize = 0;
            this.buttonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonClientes.Location = new System.Drawing.Point(0, 493);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(229, 45);
            this.buttonClientes.TabIndex = 7;
            this.buttonClientes.Text = "Gerir Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // panelClientesSubmenu
            // 
            this.panelClientesSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelClientesSubmenu.Controls.Add(this.button8);
            this.panelClientesSubmenu.Controls.Add(this.button9);
            this.panelClientesSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientesSubmenu.Location = new System.Drawing.Point(0, 538);
            this.panelClientesSubmenu.Name = "panelClientesSubmenu";
            this.panelClientesSubmenu.Size = new System.Drawing.Size(229, 86);
            this.panelClientesSubmenu.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.LightGray;
            this.button8.Location = new System.Drawing.Point(0, 40);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(229, 40);
            this.button8.TabIndex = 1;
            this.button8.Text = "Limpezas";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.LightGray;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(229, 40);
            this.button9.TabIndex = 0;
            this.button9.Text = "Vendedores";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(682, 553);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CinemaManagment.Properties.Resources.cinema_manager;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelEmpregadosSubmenu.ResumeLayout(false);
            this.panelSalasSubmenu.ResumeLayout(false);
            this.panelFilmesSubmenu.ResumeLayout(false);
            this.panelClientesSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelEmpregadosSubmenu;
        private System.Windows.Forms.Button buttonLimpezas;
        private System.Windows.Forms.Button buttonVendedores;
        private System.Windows.Forms.Button buttonEmpregados;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelClientesSubmenu;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Panel panelFilmesSubmenu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonFilmes;
        private System.Windows.Forms.Panel panelSalasSubmenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSalas;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


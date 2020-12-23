
namespace ToDoList
{
    partial class ToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSport = new FontAwesome.Sharp.IconButton();
            this.btnHousework = new FontAwesome.Sharp.IconButton();
            this.btnLife = new FontAwesome.Sharp.IconButton();
            this.btnUniversity = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnMain = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMain)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnSport);
            this.panelMenu.Controls.Add(this.btnHousework);
            this.panelMenu.Controls.Add(this.btnLife);
            this.panelMenu.Controls.Add(this.btnUniversity);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 600);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSport
            // 
            this.btnSport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSport.FlatAppearance.BorderSize = 0;
            this.btnSport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSport.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSport.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.btnSport.IconColor = System.Drawing.SystemColors.Control;
            this.btnSport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSport.IconSize = 32;
            this.btnSport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSport.Location = new System.Drawing.Point(0, 320);
            this.btnSport.Name = "btnSport";
            this.btnSport.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSport.Size = new System.Drawing.Size(200, 60);
            this.btnSport.TabIndex = 7;
            this.btnSport.Text = "Sport";
            this.btnSport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSport.UseVisualStyleBackColor = true;
            this.btnSport.Click += new System.EventHandler(this.btnSport_Click);
            // 
            // btnHousework
            // 
            this.btnHousework.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHousework.FlatAppearance.BorderSize = 0;
            this.btnHousework.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHousework.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHousework.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHousework.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHousework.IconColor = System.Drawing.SystemColors.Control;
            this.btnHousework.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHousework.IconSize = 32;
            this.btnHousework.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHousework.Location = new System.Drawing.Point(0, 260);
            this.btnHousework.Name = "btnHousework";
            this.btnHousework.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHousework.Size = new System.Drawing.Size(200, 60);
            this.btnHousework.TabIndex = 6;
            this.btnHousework.Text = "Housework";
            this.btnHousework.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHousework.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHousework.UseVisualStyleBackColor = true;
            this.btnHousework.Click += new System.EventHandler(this.btnHousework_Click);
            // 
            // btnLife
            // 
            this.btnLife.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLife.FlatAppearance.BorderSize = 0;
            this.btnLife.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLife.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLife.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLife.IconChar = FontAwesome.Sharp.IconChar.BezierCurve;
            this.btnLife.IconColor = System.Drawing.SystemColors.Control;
            this.btnLife.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLife.IconSize = 32;
            this.btnLife.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLife.Location = new System.Drawing.Point(0, 200);
            this.btnLife.Name = "btnLife";
            this.btnLife.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLife.Size = new System.Drawing.Size(200, 60);
            this.btnLife.TabIndex = 5;
            this.btnLife.Text = "Life";
            this.btnLife.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLife.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLife.UseVisualStyleBackColor = true;
            this.btnLife.Click += new System.EventHandler(this.btnLife_Click);
            // 
            // btnUniversity
            // 
            this.btnUniversity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUniversity.FlatAppearance.BorderSize = 0;
            this.btnUniversity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUniversity.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUniversity.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUniversity.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.btnUniversity.IconColor = System.Drawing.SystemColors.Control;
            this.btnUniversity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUniversity.IconSize = 32;
            this.btnUniversity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUniversity.Location = new System.Drawing.Point(0, 140);
            this.btnUniversity.Name = "btnUniversity";
            this.btnUniversity.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUniversity.Size = new System.Drawing.Size(200, 60);
            this.btnUniversity.TabIndex = 4;
            this.btnUniversity.Text = "University";
            this.btnUniversity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUniversity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUniversity.UseVisualStyleBackColor = true;
            this.btnUniversity.Click += new System.EventHandler(this.btnUniversity_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelLogo.Controls.Add(this.btnMain);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10);
            this.panelLogo.Size = new System.Drawing.Size(200, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnMain
            // 
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnMain.Image")));
            this.btnMain.Location = new System.Drawing.Point(10, 10);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(180, 120);
            this.btnMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMain.TabIndex = 9;
            this.btnMain.TabStop = false;
            this.btnMain.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblTitleChildForm);
            this.panel1.Controls.Add(this.iconCurrentChildForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(711, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 43);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(757, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 43);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(39, 12);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(40, 17);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconCurrentChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(0, 0);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 43);
            this.iconCurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 43);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(800, 557);
            this.panelDesktop.TabIndex = 2;
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoList";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnUniversity;
        private FontAwesome.Sharp.IconButton btnSport;
        private FontAwesome.Sharp.IconButton btnHousework;
        private FontAwesome.Sharp.IconButton btnLife;
        private System.Windows.Forms.PictureBox btnMain;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel panelDesktop;
    }
}


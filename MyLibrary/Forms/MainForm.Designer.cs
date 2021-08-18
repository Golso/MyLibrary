
namespace MyLibrary
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnWanted = new System.Windows.Forms.Button();
            this.btnBorrowed = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.userPanel = new System.Windows.Forms.Panel();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlNavigation.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.Navy;
            this.pnlNavigation.Controls.Add(this.btnSettings);
            this.pnlNavigation.Controls.Add(this.btnWanted);
            this.pnlNavigation.Controls.Add(this.btnBorrowed);
            this.pnlNavigation.Controls.Add(this.btnMain);
            this.pnlNavigation.Controls.Add(this.userPanel);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(186, 577);
            this.pnlNavigation.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSettings.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSettings.Location = new System.Drawing.Point(0, 517);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(186, 60);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Ustawienia";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnWanted
            // 
            this.btnWanted.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWanted.FlatAppearance.BorderSize = 0;
            this.btnWanted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWanted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWanted.ForeColor = System.Drawing.Color.DarkRed;
            this.btnWanted.Location = new System.Drawing.Point(0, 234);
            this.btnWanted.Name = "btnWanted";
            this.btnWanted.Size = new System.Drawing.Size(186, 60);
            this.btnWanted.TabIndex = 4;
            this.btnWanted.Text = "Do kupienia";
            this.btnWanted.UseVisualStyleBackColor = true;
            this.btnWanted.Click += new System.EventHandler(this.BtnWanted_Click);
            // 
            // btnBorrowed
            // 
            this.btnBorrowed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrowed.FlatAppearance.BorderSize = 0;
            this.btnBorrowed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBorrowed.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBorrowed.Location = new System.Drawing.Point(0, 174);
            this.btnBorrowed.Name = "btnBorrowed";
            this.btnBorrowed.Size = new System.Drawing.Size(186, 60);
            this.btnBorrowed.TabIndex = 3;
            this.btnBorrowed.Text = "Pożyczone";
            this.btnBorrowed.UseVisualStyleBackColor = true;
            this.btnBorrowed.Click += new System.EventHandler(this.BtnBorrowed_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Navy;
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMain.ForeColor = System.Drawing.Color.DarkRed;
            this.btnMain.Location = new System.Drawing.Point(0, 114);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(186, 60);
            this.btnMain.TabIndex = 2;
            this.btnMain.Text = "Moje książki";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.BtnMain_Click);
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.userPanel.Controls.Add(this.logoutLabel);
            this.userPanel.Controls.Add(this.userNameLabel);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.Location = new System.Drawing.Point(0, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(186, 114);
            this.userPanel.TabIndex = 1;
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logoutLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.logoutLabel.Location = new System.Drawing.Point(53, 65);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(75, 20);
            this.logoutLabel.TabIndex = 2;
            this.logoutLabel.Text = "Wyloguj";
            this.logoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userNameLabel.Location = new System.Drawing.Point(39, 17);
            this.userNameLabel.MinimumSize = new System.Drawing.Size(103, 20);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(103, 20);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "User Name";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(914, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.BackColor = System.Drawing.Color.MediumBlue;
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLoader.Location = new System.Drawing.Point(186, 114);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(765, 463);
            this.pnlFormLoader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(449, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Moje książki";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlNavigation.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnWanted;
        private System.Windows.Forms.Button btnBorrowed;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label logoutLabel;
    }
}

